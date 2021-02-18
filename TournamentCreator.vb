Imports System.IO
Imports System.Net

Public Class TournamentCreator
    Private Sub TournamentCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ihome.Visible = False
        SldrCapacity.Minimum = 20 ' Sets the minimum value of the capacity to 20
        SldrCapacity.Maximum = 1000 ' Sets the max value of the capacity to 1000
        SldrCapacity.TickFrequency = 980 ' Ensures that each movement of the slider increments the value by one
        SldrRings.Minimum = 1 ' Sets the minimum number of rings to 20
        SldrRings.Maximum = 6 ' Sets the maximum number of rings to 20
        SldrRings.TickFrequency = 5 ' Ensures that each movement of the slider increments the value by one
    End Sub

    Private Sub TournamentCreator_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ihome.Visible = True
    End Sub

    Private Sub createCSV(ByVal localCSVPath As String, ByVal FTPCSVPath As String)
        Dim csv As FileStream = File.Create(localCSVPath) ' Creates the file
        csv.Close() ' Closes the file
        'Defines the location of the file to be uploaded
        FTPFunctions.Upload(FTPCSVPath, localCSVPath, True)
        File.Delete(localCSVPath)
    End Sub

    Private Sub Tournament_FileCreation(ByVal TournamentEvent As String, ByVal location As String, ByVal gender As String)
        'Creates the event files, calling the event name, the FTP location and the gender (if required) as parameters
        createCSV("C:/UserCSV/" + TournamentEvent + "(Children(8-10)).csv", location + "" + TournamentEvent + "/Children(8-10).csv")
        createCSV("C:/UserCSV/" + TournamentEvent + "(Children(11-14" + gender + ")).csv", location + "" + TournamentEvent + "/Children(11-14" + gender + ").csv")
        createCSV("C:/UserCSV/" + TournamentEvent + "(Junior(14-16" + gender + ")).csv", location + "" + TournamentEvent + "/Junior(14-16" + gender + ").csv")
        createCSV("C:/UserCSV/" + TournamentEvent + "(Junior(17-19" + gender + ")).csv", location + "" + TournamentEvent + "/Junior(17-19" + gender + ").csv")
        createCSV("C:/UserCSV/" + TournamentEvent + "(Adult(20-40" + gender + ")).csv", location + "" + TournamentEvent + "/Adult(20-40" + gender + ").csv")
        createCSV("C:/UserCSV/" + TournamentEvent + "(Veteran(40+" + gender + ")).csv", location + "" + TournamentEvent + "/Veteran(40+" + gender + ").csv")
    End Sub


    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim valid As Boolean = True
        'Checks that the location doesn't contain symbols
        If (RegexFunctions.ContainsSymbols(TxtLocation.Text)) = True Then
            MsgBox("Error! Enter a valid location")
            valid = False
        End If
        'Checks that the tournament name doesn't contain symbols
        If Not (RegexFunctions.ContainsSymbols(TxtTournamentName.Text)) = True Then
            MsgBox("Error! Enter a valid name")
            valid = False
        End If

        Dim checknum As Integer = 0
        For Each ctrl As Control In Me.Controls ' Cycles through each object on the form
            ' Checks if object is a check-box and whether it is checked
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                checknum += 1
            End If
        Next
        If checknum = 0 Then ' Runs if no check-boxes were checked
            MsgBox("Error! Please select an event")
            valid = False
        End If
        If TxtLocation.Text = "Location" Then
            'Runs if no location was entered
            MsgBox("Error! Please enter a location")
            valid = False
        End If
        If TxtTournamentName.Text = "Tournament Name" Then
            'Runs if no tournament name was entered
            MsgBox("Error! Please enter a tournament name")
            valid = False
        End If
        If LblCapacity.Text = "" Then
            'Runs if no capacity was selected
            MsgBox("Error! Please select a capacity")
            valid = False
        End If
        If SlctMinBelt.Text = "Minimum Belt" Then
            'Runs if no minimum belt was selected
            MsgBox("Error! Please select a minimum belt")
            valid = False
        End If
        If DteClosing.Value < DteOpening.Value Then
            'Runs if application closing was set to end before application opening
            MsgBox("Error! Select a valid closing date")
            valid = False
        End If
        If DteOpening.Value < Date.Now.AddDays(-1) Then
            'Runs if opening date set to before current date
            MsgBox("Error! Select a valid opening date")
            valid = False
        End If
        'Runs if no ring selection has been made
        If LblRings.Text = "" Then
            MsgBox("Error! Select an amount of rings!")
            valid = False
        End If

        'Runs if validation checks were successful
        If valid = True Then
            'Defines tournament folder location
            Dim tournament_location As String = ftphost + "/Tournaments/" + TxtTournamentName.Text + "/"
            Try
                'Attempts to create directory
                FTPFunctions.CreateDirectory(tournament_location)
                MsgBox("Tournament Creation Successful") ' Notifies the user when the tournament was created successfully
            Catch ex As Exception
                'Runs if directory already existed
                valid = False
                MsgBox("Error! Tournament already exists")
                Exit Sub
            End Try

            'Creates and uploads the tournament entrant file
            Dim entrantcreation As FileStream = File.Create("C:\UserCSV\" + TxtTournamentName.Text + " Entrants.csv")
            entrantcreation.Close()
            FTPFunctions.Upload(ftphost + "/Tournaments/" + TxtTournamentName.Text + "/" + TxtTournamentName.Text + " Entrants.csv", "C:\UserCSV\" + TxtTournamentName.Text + " Entrants.csv", True)

            If ChckPatterns.Checked = True Then
                'Creates the Patterns folder
                FTPFunctions.CreateDirectory(tournament_location + "Patterns/")
                'Creates the Patterns entrant files
                Tournament_FileCreation("Patterns", tournament_location, "")

            End If

            If ChckSparring.Checked = True Then
                'Creates the sparring folder
                FTPFunctions.CreateDirectory(tournament_location + "Sparring/")
                'Creates the sparring entrant files
                Tournament_FileCreation("Sparring", tournament_location, " M")
                Tournament_FileCreation("Sparring", tournament_location, " F")
            End If

            If ChckSelfDefence.Checked = True Then
                'creates the self defence folder
                FTPFunctions.CreateDirectory(tournament_location + "Self Defence/")
                'Creates the self defence entrant files
                Tournament_FileCreation("Self Defence", tournament_location, "")
            End If
            If ChckSpecialTechnique.Checked = True Then
                'Creates the Special Technique folder
                FTPFunctions.CreateDirectory(tournament_location + "Special Technique/")
                'Creates the special technique entrant files
                Tournament_FileCreation("Special Technique", tournament_location, "")
            End If

            'Creates tournament information file
            Dim tournamentCSV As FileStream = File.Create("C:/UserCSV/" + TxtTournamentName.Text + " Information.CSV")
            tournamentCSV.Close()
            'Reopens the information file in write mode
            Dim tournamentcsvEdit As StreamWriter = New StreamWriter("C:/UserCSV/" + TxtTournamentName.Text + " Information.CSV", False, System.Text.Encoding.UTF8)
            'Writes the tournament data to the file
            tournamentcsvEdit.Write(TxtTournamentName.Text & ",")
            tournamentcsvEdit.Write(TxtLocation.Text & ",")
            tournamentcsvEdit.Write(SlctMinBelt.Text & ",")
            If ChckDynamicCategories.Checked = True Then
                tournamentcsvEdit.Write("Dynamic Categories,")
            Else
                tournamentcsvEdit.Write("No Dynamic Categories,")
            End If
            tournamentcsvEdit.Write(DteOpening.Value.ToString & ",")
            tournamentcsvEdit.Write(DteClosing.Value.ToString & ",")
            tournamentcsvEdit.Write(LblCapacity.Text & ",")
            If ChckPatterns.Checked = True Then
                tournamentcsvEdit.Write("Patterns,")
            End If
            If ChckSparring.Checked = True Then
                tournamentcsvEdit.Write("Sparring,")
            End If
            If ChckSelfDefence.Checked = True Then
                tournamentcsvEdit.Write("Self Defence,")
            End If
            If ChckSpecialTechnique.Checked = True Then
                tournamentcsvEdit.Write("Special Technique,")
            End If

            tournamentcsvEdit.Write(TimeOpening.Value.TimeOfDay.ToString + "/" + TimeClosing.Value.TimeOfDay.ToString + ",")
            tournamentcsvEdit.Write(LblRings.Text.ToString + ",")
            tournamentcsvEdit.Close()
            'Uploads the tournament information file
            FTPFunctions.Upload(ftphost + "/Tournaments/" + TxtTournamentName.Text + "/" + TxtTournamentName.Text + "" + " Information.CSV", "C:/UserCSV/" + TxtTournamentName.Text + " Information.CSV", True)

        End If
    End Sub


    Private Sub SldrCapacity_Scroll(sender As Object, e As EventArgs) Handles SldrCapacity.Scroll
        LblCapacity.Text = SldrCapacity.Value.ToString ' Provides visual representation of the slider data.
    End Sub

    Private Sub TxtTournamentName_Click(sender As Object, e As EventArgs) Handles TxtTournamentName.Click
        'Clears if default text is present
        If TxtTournamentName.Text = "Tournament Name" Then
            TxtTournamentName.Text = ""
        End If
    End Sub

    Private Sub TxtTournamentName_Leave(sender As Object, e As EventArgs) Handles TxtTournamentName.Leave
        'Inserts default text is no text changed
        If String.IsNullOrEmpty(TxtTournamentName.Text) Then
            TxtTournamentName.Text = "Tournament Name"
        End If
    End Sub

    Private Sub TxtLocation_Click(sender As Object, e As EventArgs) Handles TxtLocation.Click
        'Clears if default text is present
        If TxtLocation.Text = "Location" Then
            TxtLocation.Text = ""
        End If
    End Sub

    Private Sub TxtLocation_Leave(sender As Object, e As EventArgs) Handles TxtLocation.Leave
        'Inserts default text is no text changed
        If String.IsNullOrEmpty(TxtLocation.Text) Then
            TxtLocation.Text = "Location"
        End If
    End Sub

    Dim currentbeltselection As String
    Private Sub SlctMinBelt_Click(sender As Object, e As EventArgs) Handles SlctMinBelt.Click
        currentbeltselection = SlctMinBelt.Text
    End Sub

    Private Sub SlctMinBelt_Leave(sender As Object, e As EventArgs) Handles SlctMinBelt.Leave
        SlctMinBelt.Text = currentbeltselection
    End Sub

    Private Sub SlctMinBelt_SelectedValueChanged(sender As Object, e As EventArgs) Handles SlctMinBelt.SelectedValueChanged
        currentbeltselection = SlctMinBelt.Text
    End Sub

    Private Sub SldrRings_Scroll(sender As Object, e As EventArgs) Handles SldrRings.Scroll
        LblRings.Text = SldrRings.Value.ToString
    End Sub
End Class