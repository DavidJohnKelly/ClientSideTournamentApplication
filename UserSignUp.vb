Imports System.ComponentModel
Imports System.IO
Imports System.Net.Mail

Public Class UserSignUp

    Dim UserCSVFullLine As String = ""
    Private Sub UserSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fullLine As String = ""
        FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Input)
        UserCSVFullLine = LineInput(1)

        Dim UserCSVItems() As String = Split(UserCSVFullLine, ",")
        If UserCSVItems(7) = "Instructor" Then
            ChckUmpire.Visible = True
        Else
            ChckUmpire.Visible = False
        End If
        FileClose(1)
        TxtName.Text = GlobalFunctions.RegexFunctions.getNamefromusername(ActiveUser)
        TxtBelt.Text = UserCSVItems(6)
        TxtDOB.Text = UserCSVItems(3)
        TxtHeight.Text = UserCSVItems(1) + "cm"
        TxtWeight.Text = UserCSVItems(2) + "kg"
        TxtClub.Text = UserCSVItems(5)
        TxtGender.Text = UserCSVItems(4)
        TxtEmail.Text = UserCSVItems(0)

        LblTournament.Text = TournamentApplication
        Dim localpath As String = "C:\UserCSV\" + TournamentApplication + " Information.csv"
        'Downloads the tournament information file
        My.Computer.Network.DownloadFile(ftphost + "/Tournaments/" + TournamentApplication + "/" + TournamentApplication + " Information.csv", localpath, "FTPUser", "P@ssw0rd")
        FileOpen(1, localpath, OpenMode.Input)
        ' Reads the file
        fullLine = LineInput(1)
        Dim items() As String = Split(fullLine, ",")
        FileClose(1)

        ' This section checks what events are being run
        If items.Contains("Patterns") Then
            ChckPatterns.Visible = True
        End If

        If items.Contains("Sparring") Then
            ChckSparring.Visible = True
        End If

        If items.Contains("Self Defence") Then
            ChckSelfDefence.Visible = True
        End If

        If items.Contains("Special Technique") Then
            ChckSpecialTechnique.Visible = True
        End If

        My.Computer.FileSystem.DeleteFile(localpath)
    End Sub

    Private Sub UserSignUp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Re hides the event buttons
        ChckPatterns.Visible = False
        ChckSparring.Visible = False
        ChckSelfDefence.Visible = False
        ChckSpecialTechnique.Visible = False
    End Sub

    Private Sub Apply(ByVal TournamentEvent As String, ByVal age As Integer, ByVal gender As String)

        'Removes cm from the height
        Dim height As String = TxtHeight.Text.Replace("cm", "")
        'Removes kg from the weight
        Dim weight As String = TxtWeight.Text.Replace("kg", "")
        'Joins al the strings into a full line
        Dim newUserCSVFullLine As String = TxtEmail.Text + "," + height + "," + weight + "," + TxtDOB.Text + "," + TxtGender.Text + "," + TxtClub.Text + "," + TxtBelt.Text + ","
        'Checks if user is a student or instructor
        If UserCSVFullLine.Contains("Instructor") Then
            newUserCSVFullLine = newUserCSVFullLine & "Instructor"
        Else
            newUserCSVFullLine = newUserCSVFullLine & "Student"
        End If
        'Checks if the generated full line is different from the read full line
        If Not (newUserCSVFullLine = UserCSVFullLine) Then
            'If it is, deletes the original
            System.IO.File.Delete("C:\UserCSV\" + ActiveUser + ".csv")
            'Creates new user csv file in its place
            Dim fis As FileStream = File.Create("C:\UserCSV\" + ActiveUser + ".csv")
            fis.Close()
            'Writes the new user csv data
            Dim siw As StreamWriter = File.AppendText("C:\UserCSV\" + ActiveUser + ".csv")
            siw.Write(newUserCSVFullLine)
            siw.Close()
            'Sets the variable of the usercsvfullline to the new user csv fullline
            UserCSVFullLine = newUserCSVFullLine
        End If
        Try

            'Generates the location on the FTP server
            Dim FTPLocation As String = ftphost + "/Tournaments/" + TournamentApplication + "/" + TournamentEvent + "/" + HelperFunctions.GroupCalculator(age, gender) + ".csv"
            'Generates the location on the local disk
            Dim OriginalFileLocation As String = "C:\UserCSV\Sparring" + HelperFunctions.GroupCalculator(age, gender) + "Original.csv"
            'Downloads the file
            My.Computer.Network.DownloadFile(FTPLocation, OriginalFileLocation, "FTPUser", "P@ssw0rd")
            Dim LocalLocation As String = "C:\UserCSV\Sparring" + HelperFunctions.GroupCalculator(age, gender) + ".csv"
            'Creates the edited file
            Dim fs As FileStream = File.Create(LocalLocation)
            fs.Close()
            'Writes tournament event information to UserCSV file if user is an instructor
            If UserCSVFullLine.Contains("Instructor") Then
                FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Append)
                'Writes tournament name, event and user group to file
                WriteLine(1, TournamentApplication + "," + TournamentEvent + "," + HelperFunctions.GroupCalculator(age, gender))
                FileClose(1)
            End If

            Dim tournamentcsv As StreamReader = New StreamReader(OriginalFileLocation)
            Dim NewTournamentsw As StreamWriter = File.AppendText(LocalLocation)
            Dim tournamentitems() As String
            'String full to ensure that the do loop runs
            Dim line As String = "LINE"
            'Runs until EOF
            Do Until tournamentcsv.Peek = -1
                line = tournamentcsv.ReadLine
                tournamentitems = Split(line, ",")
                'Checks if username already in file
                If tournamentitems(0) = ActiveUser Then

                Else
                    NewTournamentsw.WriteLine(line)
                End If
            Loop
            tournamentcsv.Close()
            NewTournamentsw.Close()
            'Initializes the streamwriter to append to the file
            Dim sw As StreamWriter = File.AppendText(LocalLocation)
            If ChckUmpire.Checked = True Then
                'Appends the data in the user CSV file and Umpire
                sw.WriteLine(ActiveUser.ToString & "," & UserCSVFullLine & ",Umpire")
            Else
                'Appends the data in the user CSV file
                sw.WriteLine(ActiveUser.ToString & "," & UserCSVFullLine)
            End If
            sw.Close()
            'Deletes the original file on the FTP server
            FTPFunctions.Delete(FTPLocation)
            'Uploads the file to the FTP server
            FTPFunctions.Upload(FTPLocation, LocalLocation, True)
            File.Delete(OriginalFileLocation)
            MsgBox("Application Successful")

            Try
                'Uses google's SMTP client, hence the Gmail account
                Dim EmailTransfer As New SmtpClient("smtp.gmail.com") With {
                    .Credentials = New Net.NetworkCredential("TournamentManagerBot@gmail.com", "TournamentManager1234"), 'Allows VB to access the gmail account
                    .EnableSsl = True, 'Enables SSL and assigns port number
                    .Port = 587
                }

                Dim SuccessEmail As New MailMessage With {'Initialises the email capabilities of VB
                    .From = New MailAddress("TournamentManagerBot@gmail.com"), 'Assigns email sender
                    .Subject = ("Tournament Signup Success"), 'Assigns the email header and contents
                    .Body = ("Signup to " + LblTournament.Text + " was successful.")
                }
                'Sends email to email saved on form
                SuccessEmail.To.Add(TxtEmail.Text)
                'Sends the email
                EmailTransfer.Send(SuccessEmail)
                'Clears the email from memory
                EmailTransfer.Dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Catch
                MsgBox("Application Failed")
        End Try
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

        Dim symbols As Integer = 0
        For Each ctrl As Control In Me.Controls ' Cycles through each object on the form
            ' Checks if object is a text box
            If TypeOf ctrl Is TextBox Then
                'Ignores Date of birth and email as they are meant to have symbols
                If Not (ctrl.Name = "TxtDOB" Or ctrl.Name = "TxtEmail") Then
                    'Removes spaces from the strings and checks for the presence of symbols
                    If RegexFunctions.ContainsSymbols((ctrl.Text).Replace(" ", "")) Then
                        symbols += 1
                    End If
                End If
            End If
        Next
        'Runs if no symbols have been detected
        If symbols <> 0 Then
            MsgBox("Error! Text inputs cannot contain symbols")
            Exit Sub
        End If

        'Handles initial age generation
        Dim age As Integer = Today.Year - DateTime.Parse(TxtDOB.Text).Year
        'Checks if age is too big for current date
        If DateTime.Parse(TxtDOB.Text).AddYears(age) > Today.Date Then
            'If it is, user must be a year younger so subtracts one
            age -= 1
        End If
        If age < 16 And ChckUmpire.Checked = True Then
            MsgBox("Error! You are too young to be an umpire")
            Exit Sub
        End If
        'Downloads tournament entrant fie
        My.Computer.Network.DownloadFile(ftphost + "/Tournaments/" + LblTournament.Text + "/" + LblTournament.Text + " Entrants.csv", "C:\UserCSV\" + LblTournament.Text + " Entrants.csv", "FTPUser", "P@ssw0rd")
        FileOpen(1, "C:\UserCSV\" + LblTournament.Text + " Entrants.csv", OpenMode.Input)
        'Retrieves the current number of entrants
        Dim entrants As New Integer
        Try
            entrants = CInt(LineInput(1).Replace(",", ""))
        Catch
            entrants = 0
        End Try
        FileClose(1)
        'Creates updated entrant file
        Dim filestream As FileStream = File.Create("C:\UserCSV\" + LblTournament.Text + " EntrantsNew.csv")
        filestream.Close()
        'Writes new number of entrants
        Dim newentrants As StreamWriter = New StreamWriter("C:\UserCSV\" + LblTournament.Text + " EntrantsNew.csv")
        Try
            newentrants.Write((entrants + 1).ToString)
            'Runs if tournament has zero entrants as entrants will be null
        Catch
            newentrants.Write("1")
        End Try
        newentrants.Close()
        'Uploads to CSV server
        FTPFunctions.Upload(ftphost + "/Tournaments/" + LblTournament.Text + "/" + LblTournament.Text + " Entrants.csv", "C:\UserCSV\" + LblTournament.Text + " EntrantsNew.csv", True)
        File.Delete("C:\UserCSV\" + LblTournament.Text + " Entrants.csv")


        'Handles applications for each event
        If ChckSparring.Checked = True Then
            If TxtGender.Text = "Male" Then
                Apply("Sparring", age, " M")

            ElseIf TxtGender.Text = "Female" Then
                Apply("Sparring", age, " F")
            Else
                MsgBox("Error! Gender invalid")
                Exit Sub
            End If

        End If

        If ChckPatterns.Checked = True Then
            Apply("Patterns", age, "")
        End If

        If ChckSelfDefence.Checked = True Then
            Apply("Self Defence", age, "")
        End If
        If ChckSpecialTechnique.Checked = True Then
            Apply("Special Technique", age, "")
        End If

    End Sub
End Class