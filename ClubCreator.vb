Imports System.IO
Imports System.Net

Public Class ClubCreator
    Dim assistantlist As New List(Of String) ' Houses the names of the instructors
    Dim FreeInstructors As New List(Of String)

    Private Sub ClubCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SldrCapacity.Minimum = 5 ' Sets the minimum value of the capacity to 5 club members
        SldrCapacity.Maximum = 100 ' Sets the max value of the capacity to 100 club members
        SldrCapacity.TickFrequency = 95 ' Ensures that each movement of the slider increments the value by one

        Dim AssistantNames As FtpWebRequest = DirectCast(WebRequest.Create(ftphost & "/Users Info/"), FtpWebRequest)
        AssistantNames.Method = WebRequestMethods.Ftp.ListDirectory ' Lists file names in Users Info
        AssistantNames.Credentials = New NetworkCredential("FTPUser", "P@ssw0rd")

        Dim response As FtpWebResponse = DirectCast(AssistantNames.GetResponse(), FtpWebResponse)
        Dim responseStream As Stream = response.GetResponseStream
        ' Reads the tournament names from the directories
        Using reader As New StreamReader(responseStream)
            'Runs until the end of the directories
            Do While reader.Peek <> -1
                ' Adds tournament name to the list
                assistantlist.Add(reader.ReadLine)
            Loop
        End Using
        response.Close()
        Dim x As Integer = 0
        'Runs until each instructor has been accounted for
        Do While x < assistantlist.Count
            Try ' Checked if user CSV file already exits in local directory
                'Downloads instructor info file locally
                My.Computer.Network.DownloadFile(ftphost & "/Users Info/" + assistantlist(x), "C:\UserCSV\" + assistantlist(x), "FTPUser", "P@ssw0rd")
            Catch
            End Try
            FileOpen(1, "C:\UserCSV\" + assistantlist(x), OpenMode.Input)
            Dim fullline As String = ""
            Dim infoitems() As String
            'Reads the cell data
            fullline = LineInput(1)
            infoitems = Split(fullline, ",")
            'Checks if user is not assigned to a club
            If (infoitems(5) = "None") Then
                'Adds the instructor to data grid, getting their name from file name and username
                If Not assistantlist(x).Replace(".csv", "") = ActiveUser Then
                    FreeInstructors.Add(assistantlist(x).Replace(".csv", ""))
                    If assistantlist(x).Contains(Search.Text) Then
                        GridAssistantInstructors.Rows.Add(RegexFunctions.getNamefromusername(assistantlist(x).Replace(".csv", "")))
                    End If
                End If
            End If

            FileClose(1)
            'Only deletes fie if file isn't current user file
            If Not ("C:\UserCSV\" + assistantlist(x) = "C:\UserCSV\" + ActiveUser + ".csv") Then
                File.Delete("C:\UserCSV\" + assistantlist(x))
            End If
            x += 1 ' Iterates through the loop

        Loop
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim valid As Boolean = False
        ' Checks that the club name doesnt contain name, that the location doesnt contain symbols, and that the text inputs are not set to their default values
        If Not TxtClubName.Text.Contains("Name") And Not RegexFunctions.ContainsSymbols(TxtLocation.Text) = False And TxtLocation.Text <> "Club Location" And SlctMaxBelt.Text <> "Maximum Belt" And SlctMinBelt.Text <> "Minimum Belt" And LblCapacity.Text <> "Capacity" Then
            valid = True
        End If

        'Creates the Club info file
        If valid = True Then
            Try
                Dim ClubInfo As FileStream = File.Create("C:\UserCSV\" + TxtClubName.Text + "Info.csv")
                ClubInfo.Close()
                'Writes the club data
                Dim ClubInfoCSV As StreamWriter = New StreamWriter("C:\UserCSV\" + TxtClubName.Text + "Info.csv")
                ClubInfoCSV.Write(TxtLocation.Text & ",")
                ClubInfoCSV.Write(SlctMinBelt.Text & ",")
                ClubInfoCSV.Write(SlctMaxBelt.Text & ",")
                ClubInfoCSV.Write(LblCapacity.Text & ",")
                ClubInfoCSV.Close()
                'Creates club directories
                FTPFunctions.CreateDirectory(ftphost + "/Clubs/" + TxtClubName.Text)
                'Stores students
                FTPFunctions.CreateDirectory(ftphost + "/Clubs/" + TxtClubName.Text + "\Students")
                'Stores instructors
                FTPFunctions.CreateDirectory(ftphost + "/Clubs/" + TxtClubName.Text + "\Instructors")
                'Uploads the CSV file
                FTPFunctions.Upload(ftphost + "/Clubs/" + TxtClubName.Text + "/" + TxtClubName.Text + "Info.CSV", "C:\UserCSV\" + TxtClubName.Text + "Info.csv", True)
                Dim x As Integer = 0
                'Iterates through the data grid
                For Each row As DataGridViewRow In GridAssistantInstructors.Rows
                    'Runs in checkbox for assistant instructor is checked
                    If row.Cells("Buttons").Value = True Then
                        Dim i As Integer = 0
                        'Iterates through the assistant list
                        Do Until i = assistantlist.Count
                            'Runs if the list item matches checked instructor
                            If assistantlist(i).Contains(GridAssistantInstructors.Item(0, x).Value.ToString().Replace(" ", "")) Then
                                'Stops errors resulting from duplicate file downloads
                                Try
                                    My.Computer.Network.DownloadFile(ftphost + "/Users Info/" + assistantlist(i), "C:\UserCSV\" + assistantlist(i), "FTPUser", "P@ssw0rd")
                                Catch
                                    File.Delete("C:\UserCSV\" + assistantlist(i))
                                End Try
                                'Reads the downloaded file to check that they aren't assigned to a club already
                                Dim fileread As StreamReader = New StreamReader("C:\UserCSV\" + assistantlist(i))
                                Dim line As String = fileread.ReadLine()
                                fileread.Close()
                                'Deletes file if already assigned
                                If Not (line.Contains("None")) Then
                                    File.Delete("C:\UserCSV\" + assistantlist(i))
                                End If
                                'Uploads the file, ensuring file isn't deleted if it belongs to the active user 
                                If "C:\UserCSV\" + assistantlist(i) = "C:\UserCSV\" + ActiveUser + ".csv" Then
                                    FTPFunctions.Upload(ftphost + "/Clubs/" + TxtClubName.Text + "/Instructors/" + assistantlist(i), "C:\UserCSV\" + assistantlist(i), False)
                                Else
                                    FTPFunctions.Upload(ftphost + "/Clubs/" + TxtClubName.Text + "/Instructors/" + assistantlist(i), "C:\UserCSV\" + assistantlist(i), True)

                                End If

                            End If
                            i += 1
                        Loop

                    End If
                    x += 1
                Next
                'Uploads active user CSV file
                FTPFunctions.Upload(ftphost + "/Clubs/" + TxtClubName.Text + "/Instructors/" + ActiveUser + ".csv", "C:\UserCSV\" + ActiveUser + ".csv", False)
                MsgBox("Club Created Successfully") ' Notifies the user of successful club creation
            Catch
                MsgBox("Error! Club already exists")
            End Try
        Else
            MsgBox("Error! Ensure inputs are correct")
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles SldrCapacity.Scroll
        LblCapacity.Text = SldrCapacity.Value.ToString
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Not (String.IsNullOrEmpty(Search.Text)) Then
            LblSearch.Visible = False
        End If
    End Sub

    Private Sub Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search.KeyPress
        'Runs if enter key is pressed
        If e.KeyChar = Chr(13) Then
            'Clears the data grid so that entries can be added without duplication
            GridAssistantInstructors.Rows.Clear()
            Dim x As Integer = 0
            Do Until x = FreeInstructors.Count
                'Checks if the instructor contains the search text
                If FreeInstructors(x).Contains(Search.Text) Then
                    'Adds them to the datagrid if they do
                    GridAssistantInstructors.Rows.Add(RegexFunctions.getNamefromusername(FreeInstructors(x)))
                End If
                x += 1
            Loop
        End If
    End Sub
End Class