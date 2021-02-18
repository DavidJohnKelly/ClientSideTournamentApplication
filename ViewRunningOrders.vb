Public Class ViewRunningOrders
    Private Sub ViewRunningOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the UserCSV file in csv mode
        Dim CSVRead As New FileIO.TextFieldParser("C:\UserCSV\" + ActiveUser + ".csv") With {
                    .Delimiters = New String() {","},
                    .TextFieldType = FileIO.FieldType.Delimited
                }
        'Runs until the end of the file is reached
        While CSVRead.EndOfData = False
            'Gets cell values on the current line
            Dim fullLine As String = CSVRead.ReadLine
            'Only adds tournament entry data, not user data
            If Not fullLine.Contains("@") Then
                'Separates the CSV data
                Dim TournamentInfo As List(Of String) = fullLine.Split(",").ToList
                'Only adds tournament if tournament is not already in grid, to avoid events creating multiple instances
                If CheckForDuplicate(TournamentInfo(0).Replace(Chr(34), "")) = False Then
                    'Adds the tournament to the grid if it isn't already there
                    GridTournaments.Rows.Add(TournamentInfo(0).Replace(Chr(34), ""))
                End If
            End If
        End While
        CSVRead.Close()

    End Sub

    'Returns false if grid doesn't already contain item, true if it does
    Private Function CheckForDuplicate(ByVal TournamentName As String)
        Dim Duplicate As Boolean = False
        'Cycles through each row in the datagrid
        For Each Row As DataGridViewRow In GridTournaments.Rows
            'Checks if the grid contains the item
            If Row.Cells(0).Value.contains(TournamentName) Then
                'Sets duplicate to true if it does.
                Duplicate = True
            End If
        Next
        Return Duplicate
    End Function

    Private Sub GridTournaments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTournaments.CellContentClick
        If TypeOf GridTournaments.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim RowIndex As Integer = CInt(e.RowIndex)  ' Retrieves the row the button was clicked on
            Dim Row As DataGridViewRow = GridTournaments.Rows(RowIndex) ' Gets the data in the row
            'Ensures that the image form knows which type to look for
            DrawSheetOrRunningOrder(0) = Row.Cells(0).Value
            DrawSheetOrRunningOrder(1) = "Running Order"
            DrawSheetRunningOrderImageForm.ShowDialog()
        End If
    End Sub
End Class