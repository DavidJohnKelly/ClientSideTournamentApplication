Imports System.Text.RegularExpressions
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ResultsForm
    Dim tournamentitems As New List(Of String)
    Private Sub ResultsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears any items from previous form instance
        LstResults.Items.Clear()
        'Opens the result file
        FileOpen(1, "C:\UserCSV\" + ActiveUser + "Results.csv", OpenMode.Input)
        'Defines the lists to hold the results for each event
        Dim patternResults As New List(Of Integer)
        Dim sparringResults As New List(Of Integer)
        Dim selfdefenceResults As New List(Of Integer)
        Dim specialtechniqueResults As New List(Of Integer)
        'Holds the results with the tournament name
        Dim tournamentresults As New List(Of String)
        'Adds each result to each result list
        Do Until EOF(1)
            Dim fullline() As String = LineInput(1).Split(",")
            If fullline(0).Contains("Patterns") Then
                patternResults.Add(CInt(fullline(1)))
            ElseIf fullline(0).Contains("Sparring") Then
                sparringResults.Add(CInt(fullline(1)))
            ElseIf fullline(0).Contains("Self Defence") Then
                selfdefenceResults.Add(CInt(fullline(1)))
            ElseIf fullline(0).Contains("Special Technique") Then
                specialtechniqueResults.Add(CInt(fullline(1)))
            End If
            'Adds the tournament results to the list box
            Dim tournamentfullline() = (fullline(0) + "/" + fullline(1)).Split("/")
            LstResults.Items.Add(tournamentfullline(0) + " - " + tournamentfullline(1) + " - " + "Round " + tournamentfullline(3))
        Loop
        FileClose(1)
        'Deletes the local copy of the file
        System.IO.File.Delete("C:\UserCSV\" + ActiveUser + "Results.csv")
        Dim chartnum As Integer = 1
        'Cycles through each control on the form
        For Each controlitem As Control In Me.Controls
            'Runs if control is a chart
            If TypeOf controlitem Is Chart Then
                'Defines a new chart to allow value editing
                Dim chartvar As Chart = controlitem
                'Defines a new series
                Dim Chartseries As New Series
                'Makes the series a line graph
                Chartseries.ChartType = SeriesChartType.Line
                Dim counter As Integer = 0
                'Adds a viewable title, adding a space between joined words
                chartvar.Titles.Add(Regex.Replace(controlitem.Name.Replace("Chrt", ""), "([A-Z])", " $1") + " Results")
                'Runs for each event as loop cannot be implemented in variable names
                If chartnum = 1 Then
                    'Loops through the pattern results, adding them to the series
                    Do Until counter = patternResults.Count
                        Chartseries.Points.AddXY(counter + 1, patternResults(counter))
                        counter += 1
                    Loop
                    'Adds the series to the chart
                    ChrtPatterns.Series.Add(Chartseries)
                End If
                If chartnum = 2 Then
                    'Loops through the sparring results, adding them to the series
                    Do Until counter = sparringResults.Count
                        Chartseries.Points.AddXY(counter + 1, sparringResults(counter))
                        counter += 1
                    Loop
                    'Adds the series to the chart
                    ChrtSparring.Series.Add(Chartseries)
                End If
                If chartnum = 3 Then
                    'Loops through the self defence results, adding them to the series
                    Do Until counter = selfdefenceResults.Count
                        Chartseries.Points.AddXY(counter + 1, selfdefenceResults(counter))
                        counter += 1
                    Loop
                    'Adds the series to the chart
                    ChrtSelfDefence.Series.Add(Chartseries)
                End If
                If chartnum = 4 Then
                    'Loops through the special technique results, adding them to the series
                    Do Until counter = specialtechniqueResults.Count
                        Chartseries.Points.AddXY(counter + 1, specialtechniqueResults(counter))
                        counter += 1
                    Loop
                    'Adds the series to the chart
                    ChrtSpecialTechnique.Series.Add(Chartseries)
                End If

            End If
            chartnum += 1
        Next
        'Loops through each item in the listbox
        For Each tournamentitem As String In LstResults.Items
            If tournamentitem <> "" Then
                'Adds the item to the list
                tournamentitems.Add(tournamentitem)
            End If
        Next
    End Sub
    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        'Clears the list box of any original values
        LstResults.Items.Clear()
        'Defines the item to search for
        Dim searchitem As String = TxtSearch.Text
        'Loops through each item in list
        For index As Integer = 0 To tournamentitems.Count() - 1
            'Checks if the list item contains the search term
            If tournamentitems(index).ToLower.Contains(searchitem.ToLower) Then
                'If it does, it adds it to the list box
                LstResults.Items.Add(tournamentitems(index))
            End If
        Next index
    End Sub
End Class