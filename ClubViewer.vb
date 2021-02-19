Imports System.IO
Imports System.Net
Public Class ClubViewer
    Public Bulkapply As Boolean = False
    Dim userclub As String
    Private Sub ClubViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridStudents.Rows.Clear()
        'Reads user club
        FileOpen(1, "C:\UserCSV\" + ActiveUser + ".csv", OpenMode.Input)
        Dim infoitems() As String = Split(LineInput(1), ",")
        FileClose(1)
        userclub = infoitems(5)
        'Sets the userclub label to found user club
        LblClub.Text = userclub
        'Gets student usernames
        Dim studentlist As List(Of String) = FTPFunctions.ListDirectoryNames("/Clubs/" + userclub + "/Students/")
        Dim x As Integer = 0
        Do Until x = studentlist.Count
            'Adds students to data grid
            GridStudents.Rows.Add(studentlist(x).Replace(".csv", ""))
            x += 1
        Loop
    End Sub

    Private Sub GridStudents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridStudents.CellContentClick
        'Runs if the cross image in the image column is clicked
        If TypeOf GridStudents.Columns(e.ColumnIndex) Is DataGridViewImageColumn Then
            Dim rowindex As Integer = CInt(e.RowIndex)  ' Retrieves the row the button was clicked on
            Dim row As DataGridViewRow = GridStudents.Rows(rowindex)
            'Gets the student username in column 0 of the selected row
            Dim studentname As String = GridStudents.Rows(rowindex).Cells(0).Value.ToString
            'Deletes the student file from the club folder
            FTPFunctions.Delete(ftphost + "/Clubs/" + LblClub.Text + "/Students/" + studentname + ".csv")
            'Removes the student from the data grid
            GridStudents.Rows.RemoveAt(rowindex)
        End If
    End Sub

    Private Sub LblBulkApplication_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LblBulkApplication.LinkClicked
        'Sets bulk apply to true and opens the tournament viewer form
        Bulkapply = True
        TournamentViewer.ShowDialog()
    End Sub


    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        'Runs if the enter key was pressed
        If e.KeyChar = Chr(13) Then
            'Clears the data grid
            GridStudents.Rows.Clear()
            'Rereads student usernames
            Dim studentlist As List(Of String) = FTPFunctions.ListDirectoryNames("/Clubs/" + userclub + "/Students/")
            Dim x As Integer = 0
            Do Until x = studentlist.Count
                'Adds students to data grid if username contains search input
                If studentlist(x).Contains(TxtSearch.Text) Then
                    GridStudents.Rows.Add(studentlist(x).Replace(".csv", ""))
                End If
                x += 1
            Loop
        End If
    End Sub
End Class