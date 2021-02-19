Imports System.IO
Imports System.Security.Cryptography

Public Class LoginForm

    ' Runs when the Forgot Password link is clicked
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        PasswordForm.ShowDialog() ' Shows the password form
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        ActiveUser = TxtUsername.Text
        Dim LoginCSVpath As String = "C:\UserCSV\" + TxtUsername.Text + "Login.csv" ' Defines the file path
        'Defines the location of the file to be downloaded
        Dim LocalLoginLocation As String = ftphost + "/Logins/" + TxtUsername.Text + "Login.csv"
        Dim sTargetFileName = Path.GetFileName(LocalLoginLocation)
        sTargetFileName = sTargetFileName.Replace("/", "\")
        'Downloads the file
        Try ' Checks the user exists on FTP server
            My.Computer.Network.DownloadFile(LocalLoginLocation, LoginCSVpath, "FTPUser", "P@ssw0rd")
        Catch ' Otherwise, username incorrect and subroutine must exit
            MsgBox("Error! Invalid Username or Password")
            Exit Sub
        End Try

        Dim csv As StreamReader = New StreamReader(LoginCSVpath) ' Opens the file in write mode
        Dim line As String = csv.ReadLine ' Reads the line of the csv
        csv.Close() ' Closes the login file
        File.Delete(LoginCSVpath) ' Deletes the login file
        Using md5hash As MD5 = md5hash.Create() ' Creates a new instance of MD5
            'Calls upon the getMd5Hash function to hash the confirm password text
            Dim PasswordHash As String = HelperFunctions.GetMd5Hash(md5hash, TxtPassword.Text)
            If line.Contains(PasswordHash) Then ' Checks if the csv contains the hashed password
                'Checks whether the specified UserCSV file exists. If not, downloads copy from FTP Server
                If Not File.Exists("C:\UserCSV\" + TxtUsername.Text + ".csv") Then
                    My.Computer.Network.DownloadFile(ftphost + "/Users Info/" + TxtUsername.Text + ".csv", "C:\UserCSV\" + TxtUsername.Text + ".csv", "FTPUser", "P@ssw0rd")
                End If
                ' Opens UserCSV file to check if user is an instructor or a student
                FileOpen(1, "C:\UserCSV\" + TxtUsername.Text + ".csv", OpenMode.Input)
                Dim Privileges As String = LineInput(1)
                FileClose(1)
                If Privileges.Contains("Instructor") Then ' Checks if user is an instructor
                    InstructorHome.ShowDialog() ' Opens the instructor home form
                ElseIf Privileges.Contains("Student") Then ' Checks if user is a student
                    'Opens the student home form
                    StudentHome.ShowDialog()
                End If
            Else ' Otherwise, incorrect credentials
                MsgBox("Error! Invalid Username or Password")
            End If
        End Using

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class