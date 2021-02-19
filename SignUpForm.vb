Imports System.ComponentModel
Imports System.IO
Imports System.Text.RegularExpressions

Public Class SignUp
    Dim fullname As String
    Dim username As String
    Dim fsname() As String
    Dim beltlevel As New Dictionary(Of String, Integer)
    Dim userbeltlevel As Integer

    Private Sub clubfill()

        'Gets the club names
        Dim clubnames As String() = Directory.GetDirectories("C:\UserCSV\Clubs\")
        Dim i As Integer = 0
        'Loops through amount of times there are clubs
        Do Until i = clubnames.Count
            'Opens the club information file
            FileOpen(1, clubnames(i) + "\" + clubnames(i).Replace("C:\UserCSV\Clubs\", "") + "Info.csv", OpenMode.Input)
            'Defines each individual data item in the CSV
            Dim infoitems As String() = Split(LineInput(1), ",")
            Dim capacity As Integer = infoitems(3)
            'Gets the club min and max belt values
            Dim minbelt As String = infoitems(1)
            Dim maxbelt As String = infoitems(2)
            'Counts how many students are in student directory in club
            Dim students As Integer = Directory.GetFiles(clubnames(i) + "\Students\").Count


            'Provides the boolean to determine if data is added to combobox
            Dim valid As Boolean = True
            'Checks if number of files in the club students folder is less than capacity
            If students < capacity Then
                Try
                    Try
                        If SlctBelt.Text.Contains("Black") Then
                            'Sets their level to 5
                            userbeltlevel = 5
                        Else
                            userbeltlevel = beltlevel(SlctBelt.Text)
                        End If
                    Catch ex As Exception
                        userbeltlevel = 0
                    End Try

                    'Checks if the user is a lower or higher belt than the club min or max
                    If userbeltlevel < CInt(beltlevel(minbelt)) Or userbeltlevel > CInt(beltlevel(maxbelt)) Then
                        valid = False
                    Else
                        valid = True
                    End If
                Catch ex As Exception
                    MsgBox("Error!")
                End Try
            Else
                valid = False
            End If
            'If checks were successful, adds club to combobox
            If valid = True Then
                SlctClub.Items.Add(clubnames(i).Replace("C:\UserCSV\Clubs\", ""))
            End If
            i += 1
            FileClose(1)
        Loop
    End Sub
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' Runs When the form loads
        'Adds the belt levels and the corresponding integer values
        beltlevel.Add("White", 0)
        beltlevel.Add("Yellow Tag", 1)
        beltlevel.Add("Yellow", 1)
        beltlevel.Add("Green Tag", 2)
        beltlevel.Add("Green", 2)
        beltlevel.Add("Blue Tag", 3)
        beltlevel.Add("Blue", 3)
        beltlevel.Add("Red Tag", 4)
        beltlevel.Add("Red", 4)
        beltlevel.Add("Black Tag", 4)
        beltlevel.Add("Black", 5)
        If Directory.Exists("C:\UserCSV") Then ' Checks if UserCSV directory has already been generated
            LoginForm.ShowDialog() ' Opens the login form
        Else
            My.Computer.FileSystem.CreateDirectory("C:\UserCSV") ' Creates a directory in the C drive called UserCSV
            FTPFunctions.SynchroniseDirectory("C:\UserCSV\Clubs\", "/Clubs", "Download") ' Downloads the Clubs directory from the FTP server
            clubfill()
            RBtnStudent.Checked = True ' Checks the student radio button to make it the default value

            SldrHeight.Minimum = 90 ' Sets the minimum value of the height slider to 90cm
            SldrHeight.Maximum = 250 ' Sets the max value of the height slider to 250cm
            SldrHeight.TickFrequency = 160 ' Ensures that each movement of the slider increments the value by one

            SldrWeight.Minimum = 30 ' Sets the minimum value of the weight slider to 30kg
            SldrWeight.Maximum = 150 ' Sets the maximum value of the weight slider to 150kg
            SldrWeight.TickFrequency = 120 ' Ensures that each movement of the slider increments the value by one
        End If
    End Sub

    Private Sub TxtName_Click(sender As Object, e As EventArgs) Handles TxtName.Click ' Runs when a user clicks on the name text box
        If TxtName.Text = "Name" Then
            TxtName.Text = "" ' Clears the text box
        End If
    End Sub

    Private Sub TxtName_Leave(sender As Object, e As EventArgs) Handles TxtName.Leave ' Runs when the user interacts with elements other than the name text box
        If String.IsNullOrEmpty(TxtName.Text) Then
            TxtName.Text = "Name" ' If text box is empty, fills in Name again
        End If
    End Sub

    Private Sub TxtEmail_Click(sender As Object, e As EventArgs) Handles TxtEmail.Click ' Runs when the user clicks on the email text box
        If TxtEmail.Text = "Email Address" Then
            TxtEmail.Text = "" ' Clears the text box
        End If
    End Sub

    Private Sub TxtEmail_Leave(sender As Object, e As EventArgs) Handles TxtEmail.Leave ' Runs when the user interacts with elements other than the email text box
        If String.IsNullOrEmpty(TxtEmail.Text) Then
            TxtEmail.Text = "Email Address" ' If text box is empty, fills in Email again
        End If
    End Sub

    Private Sub SldrHeight_Scroll(sender As Object, e As EventArgs) Handles SldrHeight.Scroll ' Runs when the height slider is interacted with
        LblHeight.Text = SldrHeight.Value.ToString + "cm" ' Updates the value of the lblHeight text to show exactly what value the user has selected
    End Sub

    Private Sub SldrWeight_Scroll(sender As Object, e As EventArgs) Handles SldrWeight.Scroll ' Runs when the weight slider is interacted with
        LblWeight.Text = SldrWeight.Value.ToString + "kg" ' Updates the value of the lblWeight text to show exactly what value the user has selected
    End Sub

    'The following section prevents the user from manually editing the values in the selection box
    Dim currentClubSelection As String ' Creates a variable to store the current value of the club selection box
    Private Sub SlctClub_Click(sender As Object, e As EventArgs) Handles SlctClub.Click ' Runs when the club selection box is clicked
        currentClubSelection = SlctClub.Text ' Assigns the current text in the club selection box to the currentclubselection variable
    End Sub

    Dim currentBeltSelection As String ' Creates a variable to store the current value of the belt selection box
    Private Sub SlctBelt_Click(sender As Object, e As EventArgs) Handles SlctBelt.Click ' Runs when the belt selection box is clicked
        currentBeltSelection = SlctBelt.Text ' Assigns the current text in the belt selection box to the currentbeltselection variable
    End Sub

    Dim currentGenderSelection As String ' Creates a variable to store the current value of the gender selection box
    Private Sub SlctGender_Click(sender As Object, e As EventArgs) Handles SlctGender.Click ' Runs when the gender selection box is clicked
        currentGenderSelection = SlctGender.Text ' Assigns the current text in the gender selection box to the currentgenderselection variable
    End Sub

    Private Sub SlctClub_Leave(sender As Object, e As EventArgs) Handles SlctClub.Leave ' Runs when the user interacts with any object other than the club selection box
        SlctClub.Text = currentClubSelection ' Reverts whatever is in the club selection box back to the initial value it held, if it has been edited manually
    End Sub

    Private Sub SlctBelt_Leave(sender As Object, e As EventArgs) Handles SlctBelt.Leave ' Runs when the user interacts with any object other than the belt selection box
        SlctBelt.Text = currentBeltSelection ' Reverts whatever is in the belt selection box back to the initial value it held, if it has been edited manually
    End Sub

    Private Sub SlctGender_Leave(sender As Object, e As EventArgs) Handles SlctGender.Leave ' Runs when the user interacts with any object other than the gender selection box
        SlctGender.Text = currentGenderSelection ' Reverts whatever is in the gender selection box back to the initial value it held, if it has been edited manually
    End Sub

    Private Sub SlctBelt_SelectedValueChanged(sender As Object, e As EventArgs) Handles SlctBelt.SelectedValueChanged ' Runs when a value in the belt select menu is chosen
        currentBeltSelection = SlctBelt.Text ' Assigns the selected value to currentbeltselection
    End Sub

    Private Sub SlctClub_SelectedValueChanged(sender As Object, e As EventArgs) Handles SlctClub.SelectedValueChanged ' Runs when a value in the club select menu is chosen
        currentClubSelection = SlctClub.Text ' Assigns the selected value to currentclubselection
    End Sub

    Private Sub SlctGender_SelectedValueChanged(sender As Object, e As EventArgs) Handles SlctGender.SelectedValueChanged ' Runs when a value in the gender select menu is chosen
        currentGenderSelection = SlctGender.Text ' Assigns the selected value to currentgenderselection
    End Sub

    Private Function generate_username(ByVal ParamArray args() As String) ' Creates the function that generates a username
        Dim random As New Random(Rnd() + Date.Now.Millisecond) ' Generates a new random, using Rnd and the current millisecond
        'Sets the max value to 99 and the min value to 10
        Dim number As String = random.Next(10, 99) ' Generates the random number
        username = "" + args(0).ToString + "" + args(1).ToString + "" + number + "" ' Generates the username
        Return username ' Allows other subs to use the username
    End Function

    Dim valid As Boolean = True
    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click ' Runs when the submit button is clicked

        If Not (RegexFunctions.ContainsNumbers(TxtName.Text)) = True Then ' Checks for the presence of numbers in the name text box
            MsgBox("Error! Your name cannot contain numbers") ' Presents a message box to the user, telling them that their name cannot contain numbers
            valid = False
        End If
        If Not (RegexFunctions.IsValidEmail(TxtEmail.Text)) = True Then ' Checks that the entered email is in the correct form
            MsgBox("Error! Invalid Email") ' If the email is not correct, a message box is shown to the user, saying that their email is not valid
            valid = False
        End If
        If LblHeight.Text = "cm" Then ' Checks whether the user has interacted with the height slider
            valid = False
            MsgBox("Error! Please enter a height") ' If the user hasn't interacted with the height slider, a message box is shown, telling them to enter a height
        End If
        If TxtName.Text = "Name" Then
            valid = False
            MsgBox("Error! Please enter a name")
        End If
        If LblWeight.Text = "kg" Then ' Checks whether the user has interacted with the weight slider
            valid = False
            MsgBox("Error! Please enter a weight") ' If the user hasn't interacted with the weight slider, a message box is shown, telling them to enter a weight
        End If
        If RBtnInstructor.Checked = True And DateDOB.Value.Date > ("31,12,2003") Then ' Checks if the user is too young to be an instructor
            valid = False
            MsgBox("Error! You are too young to be an instructor") ' A message box is shown telling them that they are too young to be an instructor
        End If
        If SlctGender.Text = "Gender" Then ' Checks whether the user has selected a gender value
            valid = False
            MsgBox("Error! Please select a gender") ' A message box is shown, telling them to select a gender
        End If
        If SlctClub.Text = "Club" Then ' Checks whether the user has selected a club
            valid = False
            MsgBox("Error! Please select a club") ' A message box is shown, telling them to select a club
        End If
        If SlctBelt.Text = "Belt" Then ' Checks whether the user has selected a belt
            valid = False
            MsgBox("Error! Please select a belt") ' A message box is shown, telling them to select a belt
        End If

        If valid = True Then ' Runs only if the validation checks were successful

            'Replaces more than two spaces in the name section with a single space. Then splits the first name and second name, putting them in a list
            fsname = Regex.Replace(TxtName.Text, "[ ]{2,", " ", RegexOptions.None).Split(" ")
            Dim CSVpath As String = ""
            Dim loopend As Boolean = False
            Do Until loopend = True ' Runs until a unique username is generated
                username = generate_username(fsname(0), fsname(1)) ' Calls on the generate_username function to generate the username
                CSVpath = "C:\UserCSV\" + username + ".csv" ' Collects the directory and filename together with the csv identifier
                If System.IO.File.Exists(CSVpath) Then ' Checks if CSV file already exists
                    loopend = False ' If it does, loops again
                Else
                    loopend = True ' If it doesn't, exits the loop
                End If
            Loop

            Dim height As String = Replace(LblHeight.Text, "cm", "") ' Removes the cm text from the height before saving it
            Dim weight As String = Replace(LblWeight.Text, "kg", "") ' Removes the kg text from the weight before saving it
            Dim DOB As String = Replace(DateDOB.Value.Date.ToString, " 00:00:00", "") ' Retrieves the date from the date time picker and removes the generic time associated with it
            'Removes any spaces between the user's first and last name and then appends 'values' to this, creating the file name
            Dim filename As String = New String(TxtName.Text.Where(Function(y) Not Char.IsWhiteSpace(y)).ToArray).ToString + "Values"
            Dim UserCSV As FileStream = File.Create(CSVpath) ' Creates the CSV file
            UserCSV.Close() ' Closes the CSV file

            Dim CSV As StreamWriter = New StreamWriter(CSVpath) ' Reopens the file in write mode
            'This section writes the user's data to their CSV file
            Try
                CSV.Write(fsname(0) & ",")
                CSV.Write(fsname(1) & ",")
            Catch ex As Exception ' Runs when only one name is entered
                MsgBox("Error! Enter your forename and surname") ' Tells the user to enter their first and last names
                CSV.Close() ' Closes the CSV file
                Exit Sub ' Exits the submit button subroutine
            End Try
            CSV.Write(TxtEmail.Text & ",")
            CSV.Write(height & ",")
            CSV.Write(weight & ",")
            CSV.Write(DOB & ",") ' Obtains only the date portion of the date time picker
            CSV.Write(SlctGender.Text & ",")
            CSV.Write(SlctClub.Text & ",")
            CSV.Write(SlctBelt.Text & ",")
            'Saves either instructor or student depending on which is selected
            If RBtnInstructor.Checked = True Then
                CSV.Write("Instructor" & ",")
            Else
                CSV.Write("Student" & ",")
            End If

            CSV.Close()
            ActiveUser = username
            FTPFunctions.Upload(ftphost & "/Users Info/" & username & ".csv", CSVpath, False)
            'Runs if user has selected a club
            If SlctClub.Text <> "None" Then
                'Copies to the Instructors folder
                If RBtnInstructor.Checked = True Then
                    File.Copy(CSVpath, "C:\UserCSV\Clubs\" + SlctClub.Text + "\Instructors\" + username + ".csv")
                End If
                'Copies to the students folder
                If RBtnStudent.Checked = True Then
                    File.Copy(CSVpath, "C:\UserCSV\Clubs\" + SlctClub.Text + "\Students\" + username + ".csv")
                End If
                FTPFunctions.SynchroniseDirectory("C:\UserCSV\Clubs\", "/Clubs", "Upload") ' Uploads the Clubs directory to the FTP server
            End If
            'Deletes the local club directory
            Directory.Delete("C:\UserCSV\Clubs\", True)
            PasswordForm.ShowDialog()

        End If
    End Sub

    Private Sub SlctBelt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SlctBelt.SelectedIndexChanged
        SlctClub.Items.Clear()
        SlctClub.Items.Add("None")
        clubfill()
    End Sub

    Private Sub SignUp_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Directory.Delete("C:\UserCSV\Clubs\", True)
    End Sub
End Class