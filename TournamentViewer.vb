Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class TournamentViewer

    Private Sub datagridfill()
        GridTournaments.Columns(0).DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Dim TournamentList As New List(Of String)
        TournamentList = FTPFunctions.ListDirectoryNames("/Tournaments/") ' Houses the tournament names

        ' Opens the user CSV file
        FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Input)
        Dim fullinfo As String = ""
        Dim infoitems() As String
        'Reads the file
        fullinfo = LineInput(1)
        infoitems = Split(fullinfo, ",")

        If infoitems(7) = "Student" Then
            LblAddTournament.Visible = False
        End If
        'Gets the user belt
        Dim userbelt As String = infoitems(6)
        Dim userlevel As Integer = 0
        FileClose(1)
        'Converts belt into number level
        If userbelt = "White" Or userbelt = "Yellow Tag" Then
            userlevel = 0
        ElseIf userbelt = "Yellow" Or userbelt = "Green Tag" Then
            userlevel = 1
        ElseIf userbelt = "Green" Or userbelt = "Blue Tag" Then
            userlevel = 2
        ElseIf userbelt = "Blue" Or userbelt = "Red Tag" Then
            userlevel = 3
        ElseIf userbelt = "Red" Or userbelt = "Black Tag" Then
            userlevel = 4
        Else
            userlevel = 5
        End If
        Dim x As Integer = 0
        'Loops through the tournament list
        Do Until x = TournamentList.Count
            'Assigns the FTP file location and the local download path
            Dim FTPLocation As String = ftphost + "/Tournaments/" + TournamentList(x) + "/" + TournamentList(x) + " Information.csv"
            Dim Locallocation As String = "C:\UserCSV\" + TournamentList(x) + " Information.csv"
            'Downloads the file
            My.Computer.Network.DownloadFile(FTPLocation, Locallocation, "FTPUser", "P@ssw0rd")

            Dim fullLine As String = ""
            'Opens the CSV file
            FileOpen(1, Locallocation, OpenMode.Input)
            'Splits each item into a list
            Dim item() As String
            Do Until EOF(1)
                fullLine = LineInput(1)
                item = Split(fullLine, ",")
            Loop
            FileClose(1)
            'Calculates the date from the tournament opening date
            Dim tournamentopening As Date = Date.Parse(item(4))
            Dim tournamentclosing As Date = Date.Parse(item(5))
            Dim validDate As Boolean
            'Retrieves tournament capacity
            Dim tournamentcapacity As Integer = CInt(item(6))
            'Downloads tournament entrant file

            My.Computer.Network.DownloadFile(ftphost + "/Tournaments/" + TournamentList(x) + "/" + TournamentList(x) + " Entrants.csv", "C:\UserCSV\" + TournamentList(x) + " Entrants.csv", "FTPUser", "P@ssw0rd")
            Dim validcapacity As Boolean
            'Retrieves number of current entrants
            FileOpen(1, "C:\UserCSV\" + TournamentList(x) + " Entrants.csv", OpenMode.Input)
            Dim entrantnum As Integer
            Try
                entrantnum = CInt(LineInput(1).Replace(",", ""))
            Catch
                entrantnum = 0
            End Try
            FileClose(1)

            'Sets valid to true only if number of entrants is less than capacity
            If entrantnum < tournamentcapacity Then
                validcapacity = True
            Else
                validcapacity = False
            End If
            File.Delete("C:\UserCSV\" + TournamentList(x) + " Entrants.csv")
            'Checks if the opening date is later than the current date
            If tournamentopening > Date.Now Then
                validDate = False
            Else
                validDate = True
            End If

            'Checks if closing date is before current date
            If tournamentclosing < Date.Now Then
                validDate = False
            Else
                validDate = True
            End If
            'Converts the tournament min belt into number level
            Dim tournamentlevel As Integer = 0
            If item(2) = "White" Then
                tournamentlevel = 0
            ElseIf item(2) = "Yellow" Then
                tournamentlevel = 1
            ElseIf item(2) = "Green" Then
                tournamentlevel = 2
            ElseIf item(2) = "Blue" Then
                tournamentlevel = 3
            ElseIf item(2) = "Red" Then
                tournamentlevel = 4
            ElseIf item(2) = "Black" Then
                tournamentlevel = 5
            End If
            'Runs only if opening date has already passed and closing date hasn't
            If validDate = True Then
                'Runs only if tournament has available space
                If validcapacity = True Then
                    'Runs only if User is great enough belt
                    If userlevel = tournamentlevel Or userlevel > tournamentlevel Then
                        'Builds a new multi-line string
                        Dim datastring As String = ""
                        datastring = datastring & item(0) + "   -   " + item(1) & vbNewLine

                        If fullLine.Contains("Patterns") Then
                            datastring = datastring & "Patterns" & vbNewLine
                        End If
                        If fullLine.Contains("Sparring") Then
                            datastring = datastring & "Sparring" & vbNewLine

                        End If
                        If fullLine.Contains("Self Defence") Then
                            datastring = datastring & "Self Defence" & vbNewLine

                        End If
                        If fullLine.Contains("Special Technique") Then
                            datastring = datastring & "Special Technique" & vbNewLine

                        End If
                        'Runs if data string doesn't match search text
                        If Not datastring.ToLower.Contains(Search.Text.ToLower) Then
                            datastring = "" ' Sets the datastring to be void
                        End If
                        FileClose(1)
                        'Adds the data in rows to the data grid if datastring not void
                        If Not datastring = "" Then
                            GridTournaments.Rows.Add(datastring.ToString)
                        End If
                        System.IO.File.Delete(Locallocation)

                    End If
                End If
            Else
                File.Delete(Locallocation)
            End If
            File.Delete(Locallocation)
            x += 1
        Loop

    End Sub
    Private Sub TournamentViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datagridfill()
    End Sub

    Private Sub TournamentViewer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        GridTournaments.Rows.Clear() ' Clears the data grid
        'ihome.Visible = True ' Reopens the instructor home screen
    End Sub

    Private Sub GridTournaments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTournaments.CellContentClick
        'Try
        'Runs if an apply button was clicked
        If TypeOf GridTournaments.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then

            Dim rowindex As Integer = CInt(e.RowIndex)  ' Retrieves the row the button was clicked on
            Dim row As DataGridViewRow = GridTournaments.Rows(rowindex)
            'Gets the text in column 0 of the selected row
            Dim tournamentname As String = GridTournaments.Rows(rowindex).Cells(0).Value.ToString
            'Removes all text from after the tournament name
            Dim pos As Integer = tournamentname.IndexOf("   -")
            tournamentname = tournamentname.Substring(0, pos)
            'Ensures that the application form knows which tournament the user is applying to
            TournamentApplication = tournamentname
            If ClubViewer.Bulkapply = "False" Then
                selfsignup.ShowDialog()

            Else
                BulkSignup.Show()
            End If
        End If
        'Catch
        'MsgBox("ERROR")
        'End Try
    End Sub

    Private Sub Search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Search.KeyPress
        If e.KeyChar = Chr(13) Then
            GridTournaments.Rows.Clear()
            datagridfill()
        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        If Not (String.IsNullOrEmpty(Search.Text)) Then
            LblSearch.Visible = False
        End If
    End Sub

    Private Sub LblAddTournament_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblAddTournament.LinkClicked
        TournamentCreator.ShowDialog()
    End Sub
End Class