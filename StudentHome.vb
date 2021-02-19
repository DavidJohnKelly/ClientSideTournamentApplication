Public Class StudentHome
    Private Sub BtnTournamentsignup_Click(sender As Object, e As EventArgs) Handles BtnTournamentsignup.Click
        TournamentViewer.ShowDialog()
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

    Private Sub StudentHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginForm.Visible = False
    End Sub

    Private Sub BtnRunningOrder_Click(sender As Object, e As EventArgs) Handles BtnRunningOrder.Click
        ViewRunningOrders.ShowDialog()
    End Sub

    Private Sub BtnDrawSheets_Click(sender As Object, e As EventArgs) Handles BtnDrawSheets.Click
        ViewDrawSheets.ShowDialog()
    End Sub
End Class