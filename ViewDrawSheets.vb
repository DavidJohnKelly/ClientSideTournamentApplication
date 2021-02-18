Public Class ViewDrawSheets
    Private Sub ViewDrawSheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Opens the UserCSV file in csv mode
        Dim CSVRead As New FileIO.TextFieldParser("C:\UserCSV\" + ActiveUser + ".csv") With {
                    .Delimiters = New String() {","},
                    .TextFieldType = FileIO.FieldType.Delimited
                }
        'Runs until the end of the file is reached
        While CSVRead.EndOfData = False
            'Gets cell values on the current line
            Dim fullLine As String = CSVRead.ReadLine
            'Only adds event entry data, not user data
            If Not fullLine.Contains("@") Then
                'Adds the event information to the grid
                GridEvents.Rows.Add(fullLine.Replace(Chr(34), "").Replace(" ", "-").Replace(",", " "))
            End If
        End While
        CSVRead.Close()
    End Sub

    Private Sub GridEvents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridEvents.CellContentClick
        If TypeOf GridEvents.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim RowIndex As Integer = CInt(e.RowIndex)  ' Retrieves the row the button was clicked on
            Dim Row As DataGridViewRow = GridEvents.Rows(RowIndex) ' Gets the data in the row
            'Ensures that the image form knows which type to look for
            DrawSheetOrRunningOrder(0) = Row.Cells(0).Value
            DrawSheetOrRunningOrder(1) = "Draw Sheet"
            DrawSheetRunningOrderImageForm.ShowDialog()
        End If
    End Sub
End Class