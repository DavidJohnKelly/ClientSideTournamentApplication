Imports System.ComponentModel

Public Class InstructorHome
    Private Sub InstructorHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formlogin.Visible = False
    End Sub

    Private Sub BtnTournamentCreator_Click(sender As Object, e As EventArgs) Handles BtnTournamentCreator.Click
        tournamentcreation.ShowDialog()
    End Sub

    Private Sub BtnTournamentsignup_Click(sender As Object, e As EventArgs) Handles BtnTournamentsignup.Click
        SignupORDrawSheets.ShowDialog()

    End Sub

    Private Sub BtnClubManagement_Click(sender As Object, e As EventArgs) Handles BtnClubManagement.Click
        'Opens user csv for current user
        FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Input)
        'Splits items
        Dim infoitems() As String = Split(LineInput(1), ",")
        FileClose(1)
        If infoitems(5) = "None" Then
            'Shows club creator if user not affiliated with a club
            clubcreation.ShowDialog()
        Else
            'Shows club viewer if user already affiliated with a club.
            ClubViewer.ShowDialog()
        End If
    End Sub


    Private Sub InstructorHome_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub

    Private Sub TxtResults_Click(sender As Object, e As EventArgs) Handles TxtResults.Click
        'Checks if user has a results file, if not, they haven't attended a tournament yet
        Try
            My.Computer.Network.DownloadFile(ftphost + "/Results/" + ActiveUser + "Results.csv", "C:\UserCSV\" + ActiveUser + "Results.csv", "FTPUser", "P@ssw0rd")
            ResultsForm.ShowDialog()
        Catch
            MsgBox("Error! You haven't attended any tournaments yet!")
        End Try
    End Sub

    Private Sub BtnRunningOrder_Click(sender As Object, e As EventArgs) Handles BtnRunningOrder.Click
        ViewRunningOrders.ShowDialog()
    End Sub

    Private Sub BtnDrawSheets_Click(sender As Object, e As EventArgs) Handles BtnDrawSheets.Click
        ViewDrawSheets.ShowDialog()
    End Sub
End Class