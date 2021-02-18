Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text

Public Class PasswordForm

    Dim passwordhash As String
    Dim username As String

    Public Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' Runs when the form loads
        Try
            Dim file As String() = Directory.GetFiles("C:\UserCSV\") ' Retrieves the name of the CSV file
            username = Replace(file(0), "C:\UserCSV\", "") ' Removes the directory from the name
            username = Replace(username, ".csv", "") ' Removes .csv from the file name
            LblUsername.Text = "Your username is: " & username ' Outputs the username
            signform.Dispose()
        Catch
            username = ActiveUser
            LblUsername.Text = "Your username is " & username
        End Try
    End Sub


    'Runs when the confirm button is clicked
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        If TxtCreatePassword.Text = TxtConfirmPassword.Text And ' Checks if the two provided passwords are equal
            CheckNumbers.CheckState = CheckState.Checked And CheckSymbols.CheckState = CheckState.Checked And ' Checks that all checkboxes are checked
            CheckLength.CheckState = CheckState.Checked Then
            Using md5hash As MD5 = md5hash.Create() ' Creates a new instance of MD5
                'Calls upon the getMd5Hash function to hash the confirm password text
                passwordhash = HelperFunctions.GetMd5Hash(md5hash, TxtConfirmPassword.Text)
            End Using

            Dim LoginCSVpath As String = "C:\UserCSV\" + username + "Login.csv" ' Defines the file path
            Dim LoginCSV As FileStream = File.Create(LoginCSVpath) ' Creates user login file
            LoginCSV.Close() ' Closes the file
            Dim csv As StreamWriter = New StreamWriter(LoginCSVpath) ' Reopens the file in write mode
            csv.Write(username & ",") ' Writes the user's generated username
            csv.Write(passwordhash & ",") ' Writes the user's hashed password
            csv.Close() ' Closes the file

            'Defines the location of the file to be uploaded
            Dim location As String = "" + ftphost + "/Logins/" + username + "Login.csv"
            FTPFunctions.Upload(location, LoginCSVpath, True)
            MsgBox("Account creation successful. Please relaunch application")
        ElseIf TxtCreatePassword.Text <> TxtConfirmPassword.Text Then ' Checks the passwords are equal
            MsgBox("Error! Passwords do not match") ' Tells the user that they aren't equal
        Else
            MsgBox("Error! Password is invalid")
        End If

    End Sub

    Private Sub TxtCreatePassword_TextChanged(sender As Object, e As EventArgs) Handles TxtCreatePassword.TextChanged ' Runs when the create password text is changed
        If Not (RegexFunctions.ContainsNumbers(TxtCreatePassword.Text)) = True Then ' Checks if string contains numbers
            CheckNumbers.Checked = True ' Checks the number checkbox
        Else ' Checks if password doesn't contain numbers
            CheckNumbers.Checked = False
        End If
        If TxtCreatePassword.Text.Length <= 20 And TxtCreatePassword.Text.Length >= 8 Then ' Checks if string is between 8 and 20 characters
            CheckLength.Checked = True ' Checks the length checkbox
        Else ' Checks if password is too long or too short
            CheckLength.Checked = False
        End If
        If RegexFunctions.ContainsSymbols(TxtCreatePassword.Text) = True Then ' Checks if string contains symbols
            CheckSymbols.Checked = True ' Checks the symbols checkbox
        Else ' Checks if password doesn't contain symbols
            CheckSymbols.Checked = False
        End If

    End Sub
End Class