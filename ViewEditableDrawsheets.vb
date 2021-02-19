Imports System.IO
Public Class ViewEditableDrawsheets
    Private Sub ViewEditableDrawsheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SignupORDrawSheets.Visible = False
        'Opens the UserCSV file
        Dim tournamentreader As New StreamReader("C:\UserCSV\" + ActiveUser + ".csv")
        'Defines a list to store the tournament information
        Dim items As New List(Of String)
        'Reads each line of UserCSV
        Do While tournamentreader.Peek <> -1
            Dim fullline As String = tournamentreader.ReadLine
            'Avoids copying user information relating to system signup
            Try
                If Not fullline.Contains("@") Then
                    items.Add(fullline.Replace(Chr(34), ""))
                End If
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try
        Loop
        Dim datagridcounter As Integer = 0
        'Adds each bit of tournament information to the data grid
        Do Until datagridcounter = items.Count
            DrawSheetGrid.Rows.Add()
            DrawSheetGrid.Rows(datagridcounter).Cells(0).Value = items(datagridcounter).Split(",")(0)
            DrawSheetGrid.Rows(datagridcounter).Cells(1).Value = items(datagridcounter).Split(",")(1)
            DrawSheetGrid.Rows(datagridcounter).Cells(2).Value = items(datagridcounter).Split(",")(2)
            datagridcounter += 1
        Loop
    End Sub
    Private Sub DrawSheetGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DrawSheetGrid.CellContentClick
        'Checks that the button for viewing draw sheets was clicked
        If e.ColumnIndex = 3 Then
            'Collects the tournament name, event information and category information
            tournamentFullLine = DrawSheetGrid.Rows(e.RowIndex).Cells(0).Value + "/" + DrawSheetGrid.Rows(e.RowIndex).Cells(1).Value + "/" + DrawSheetGrid.Rows(e.RowIndex).Cells(2).Value
            'Loads the draw sheet
            DrawSheet.ShowDialog()
        End If
    End Sub
End Class