Imports System.IO

Public Class BulkSignup
    Private Sub BulkSignup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Retrieves tournament name
        LblTournamentName.Text = TournamentApplication
        'Reads user CSV file
        FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Input)
        Dim infoitems() As String = Split(LineInput(1), ",")
        FileClose(1)
        Dim studentlist As New List(Of String)
        Dim userclub As String = infoitems(5)
        'Gets student usernames
        studentlist = FTPFunctions.ListDirectoryNames("/Clubs/" + userclub + "/Students/")
        Dim x As Integer = 0
        Do Until x = studentlist.Count
            'Adds students to data grid

            GridStudents.Rows.Add(studentlist(x).Replace(".csv", ""))
            x += 1
        Loop
        'Gets the list of events in tournament folder
        Dim eventlist As List(Of String) = FTPFunctions.ListDirectoryNames("/Tournaments/" + LblTournamentName.Text)
        'Sets each checkbox to visible or not depending on presence in list
        If eventlist.Contains("Patterns") Then
            ChckPatterns.Visible = True
        End If
        If eventlist.Contains("Self Defence") Then
            ChckSelfDefence.Visible = True
        End If
        If eventlist.Contains("Sparring") Then
            ChckSparring.Visible = True
        End If
        If eventlist.Contains("Special Technique") Then
            ChckSpecialTechnique.Visible = True
        End If
    End Sub

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        Dim checknum As Integer = 0
        For Each ctrl As Control In Me.Controls ' Cycles through each object on the form
            ' Checks if object is a checkbox and whether it is checked
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                checknum += 1
            End If
        Next
        'Runs if user hasn't selected any events
        If checknum = 0 Then
            MsgBox("Error! Select an event")
            'Exits the application process
            Exit Sub
        End If
        If ChckSparring.Checked = True Then
            'Applies students to special technique
            Apply("Sparring")
        End If

        If ChckPatterns.Checked = True Then
            'Applies students to special technique
            Apply("Patterns")
        End If

        If ChckSelfDefence.Checked = True Then
            'Applies students to special technique
            Apply("Self Defence")
        End If
        If ChckSpecialTechnique.Checked = True Then
            'Applies students to special technique
            Apply("Special Technique")
        End If

    End Sub
    Private Sub Apply(ByVal TournamentEvent As String)
        Dim i As Integer = 0
        Do Until i = GridStudents.RowCount
            'Checks if student is selected
            If GridStudents.Rows(i).Cells(1).Value = True Then

                Dim username As String = GridStudents.Rows(i).Cells(0).Value.ToString
                'Downloads and reads user CSV file
                My.Computer.Network.DownloadFile(ftphost + "/Users Info/" + username + ".csv", "C:\UserCSV\" + username + ".csv", "FTPUser", "P@ssw0rd")

                FileOpen(1, "C:/UserCSV/" + username + ".csv", OpenMode.Input)
                Dim fullline As String = LineInput(1)
                Dim infoitems() As String = Split(fullline, ",")
                FileClose(1)
                'Deletes downloaded file
                File.Delete("C:\UserCSV\" + username + ".csv")

                Dim email As String = infoitems(0)
                MsgBox(email)
                Dim age As Integer = Today.Year - DateTime.Parse(infoitems(3)).Year
                'Checks if age is too big for current date
                If DateTime.Parse(infoitems(3)).AddYears(age) > Today.Date Then
                    'If it is, user must be a year younger so subtracts one
                    age -= 1
                End If
                Dim gender As String
                If TournamentEvent = "Sparring" Then
                    gender = " " + infoitems(4).Replace("ale", "").Replace("em", "")
                Else
                    gender = ""
                End If

                Dim usergroup As String = HelperFunctions.GroupCalculator(age.ToString, gender)
                Try
                    'Generates the location on the FTP server
                    Dim FTPLocation As String = ftphost + "/Tournaments/" + TournamentApplication + "/" + TournamentEvent + "/" + usergroup + ".csv"
                    'Generates the location on the local disk
                    Dim OriginalFileLocation As String = "C:\UserCSV\" + TournamentEvent + "" + usergroup + "Original.csv"
                    'Downloads the file
                    My.Computer.Network.DownloadFile(FTPLocation, OriginalFileLocation, "FTPUser", "P@ssw0rd")
                    Dim LocalLocation As String = "C:\UserCSV\" + TournamentEvent + "" + usergroup + ".csv"
                    'Creates the edited file
                    Dim fs As FileStream = File.Create(LocalLocation)
                    fs.Close()
                    Dim tournamentcsv As StreamReader = New StreamReader(OriginalFileLocation)
                    Dim NewTournamentsw As StreamWriter = File.AppendText(LocalLocation)
                    'String full to ensure that the do loop runs
                    Dim line As String = "LINE"
                    'Runs until EOF
                    Do Until tournamentcsv.Peek = -1
                        Dim tournamentitems() As String
                        line = tournamentcsv.ReadLine
                        tournamentitems = Split(line, ",")
                        'Checks if user email already in file
                        If tournamentitems(1) = email Then
                        Else
                            NewTournamentsw.WriteLine(line)
                        End If
                    Loop
                    tournamentcsv.Close()
                    NewTournamentsw.Close()
                    'Initializes the streamwriter to append to the file
                    Dim sw As StreamWriter = File.AppendText(LocalLocation)
                    sw.WriteLine(username.ToString + "," + fullline)
                    sw.Close()
                    'Deletes the original file on the FTP server
                    FTPFunctions.Delete(FTPLocation)
                    'Uploads the file to the FTP server
                    FTPFunctions.Upload(FTPLocation, LocalLocation, True)
                    File.Delete(OriginalFileLocation)
                    MsgBox("Application Successful")
                Catch
                    MsgBox("Application Failed")
                    End Try
                End If
                i += 1
        Loop
    End Sub
End Class