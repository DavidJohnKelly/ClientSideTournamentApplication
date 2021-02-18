Public Class SignupORDrawSheets


    Private Sub BtnSignup_Click(sender As Object, e As EventArgs) Handles BtnSignup.Click
        TournamentViewer.ShowDialog()
    End Sub

    Private Sub BtnViewDrawSheets_Click(sender As Object, e As EventArgs) Handles BtnViewDrawSheets.Click
        ViewEditableDrawsheets.ShowDialog()
    End Sub

End Class