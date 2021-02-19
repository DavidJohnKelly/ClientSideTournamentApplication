Imports System.IO
Public Class DrawSheet
    Public participantslist As New List(Of String)
    Public participants As New Integer
    Private Sub DrawSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clears previous controls off of the form
        Me.Controls.Clear()

        'Downloads the tournament event file
        MsgBox("/Tournaments/" + tournamentFullLine + ".csv")
        My.Computer.Network.DownloadFile(ftphost + "/Tournaments/" + tournamentFullLine + ".csv", "C:\UserCSV\Tournament.csv", "FTPUser", "P@ssw0rd")
        'Opens the event file
        FileOpen(1, "C:\UserCSV\Tournament.csv", OpenMode.Input)

        'Adds each participant to a list
        Do Until EOF(1)
            Dim fullline As String = LineInput(1)
            participantslist.Add(fullline)

        Loop
        FileClose(1)

        'Deletes the local copy of the file
        My.Computer.FileSystem.DeleteFile("C:\UserCSV\Tournament.csv")

        'Stops the program crashing when there are zero elements in the list
        Try
            participants = participantslist.Count
        Catch ex As Exception
            participants = 0        'Saves the number of participants
        End Try

        'Adds the button to save results to the form
        Dim saveResults As New Button With {
            .Location = New Point(1900, 1000),
            .AutoSize = True,
            .Font = New Font("Microsoft Sans Serif", 22),
            .Text = "Submit Results"
        }

        'Adds the button to the form
        Controls.Add(saveResults)
        'Adds subroutine for when the button is clicked
        AddHandler saveResults.Click, AddressOf BtnSaveResults_Click

        'Creates a list to store entrant information and array index location
        Dim entrantlocations(participants, 1) As String

        'Runs when there are more than 3 participants
        If participants > 3 Then
            'Defines the category size to the nearest highest power of 2
            Dim categorysize As Integer = 2 ^ Math.Ceiling(Math.Log(participants, 2))
            'Defines the x axis location of the column
            Dim column As Integer = 0
            'Works out the column index
            Dim columnnumber As Integer = Math.Ceiling(Math.Log(categorysize, 2))
            'Saves the amount of textboxes in each column
            Dim columnHeight As New List(Of Integer)
            'Defines the entryboxes in a 2d array
            Dim entryboxes(columnnumber, categorysize) As TextBox
            Dim x As Integer = 0
            Dim highestpowerof2 As New Integer
            'Calculates the nearest power of two below the number of participtants
            Do While x <= columnnumber + 2
                If participants - (x ^ 2) < 0 Then
                    highestpowerof2 = 2 ^ (x - 3)
                End If
                x += 1
            Loop
            'Defines how many competitors should be in the first round
            Dim firstround As Integer = (participants - highestpowerof2) * 2
            'Runs until there is two boxes in the final column
            Do While categorysize >= 2
                x = 0
                'Used as a second counter for the first round
                Dim y As Integer = 0
                'Defines the widening gap between boxes
                Dim offset As Integer = 20 * (2 ^ (column))
                'Runs until the counter reaches the entrant number
                Do While x < categorysize
                    'Runs if currently on the first competitor column
                    If column = 0 Then
                        'Runs whilst the counter is less than the calculated amount of rounds in the first round
                        Do While y < firstround
                            'Creates a new textbox
                            entryboxes(column, y) = New TextBox
                            'Defines the entrybox parameters

                            With entryboxes(column, y)
                                'Defines its size as a rectangle
                                .Size = New Size(200, 100)
                                'Determines its position based on column number and x number
                                .Location = New Point(20 + (230 * (column)), offset + (y * 40) * (2 ^ (column)))
                            End With
                            'Adds the entry box to the form
                            Me.Controls.Add(entryboxes(column, y))

                            y += 1
                            If y = firstround - 1 Then
                                columnHeight.Add(firstround)
                            End If
                        Loop

                    Else
                        'Creates a new textbox
                        entryboxes(column, x) = New TextBox
                        With entryboxes(column, x)
                            'Defines its size as a rectangle
                            .Size = New Size(200, 100)
                            'Determines its position based on column number and x number
                            .Location = New Point(20 + (230 * (column)), offset + (x * 40) * (2 ^ (column)))
                        End With
                        'Adds the entry box to the form
                        Me.Controls.Add(entryboxes(column, x))
                    End If
                    If x = categorysize - 1 And column <> 0 Then
                        columnHeight.Add(x + 1)
                    End If
                    x += 1

                Loop
                'Divides the columns into even factors of two
                categorysize /= 2
                column += 1
            Loop


            'Adds users to the draw sheet
            Dim counter As Integer = 0
            'Fills in the first column from top to bottom
            Do Until counter = columnHeight(0)
                Dim participant() As String = participantslist(counter).Split(",")

                entryboxes(0, counter).Text = participant(0)
                'Adds all participant information and index locations to list
                entrantlocations(counter, 0) = participantslist(counter)
                entrantlocations(counter, 1) = "(0," + counter.ToString + ")"

                counter += 1
            Loop
            'Fills in the second column from bottom to top as bi number is not known
            Dim counter2 As Integer = columnHeight(1)
            Do Until counter = participants And counter2 > 0
                Dim participant() As String = participantslist(counter).Split(",")
                'Increments backwards
                counter2 -= 1
                entryboxes(1, counter2).Text = participant(0)
                'Adds all participant information and index locations to the list
                entrantlocations(counter, 0) = participantslist(counter)
                entrantlocations(counter, 1) = "(1," + counter2.ToString + ")"
                counter += 1
            Loop

            'Allows the sorting process to run multiple times
            Dim loopcount As Integer = 0
            'Iterates through the draw sheet
            Do Until loopcount = participants
                Dim item As Integer = 0
                Do Until item = participants - 1
                    'Sort users by club, alphabetically
                    If String.Compare(entrantlocations(item, 0).Split(",")(6), entrantlocations(item + 1, 0).Split(",")(6)) > 0 Then
                        'Creates variable to store value of overwritten user
                        Dim temp As String = entrantlocations(item + 1, 0)
                        'Retrieves the location of the next entrant
                        Dim nextlocation As New Point(entrantlocations(item + 1, 1).Split(",")(0).Replace("(", ""), entrantlocations(item + 1, 1).Split(",")(1).Replace(")", ""))
                        'Retrieves the location of the original entrant
                        Dim originallocation As New Point(entrantlocations(item, 1).Split(",")(0).Replace("(", ""), entrantlocations(item, 1).Split(",")(1).Replace(")", ""))
                        'Swaps entrant usernames on draw sheet
                        entryboxes(nextlocation.X, nextlocation.Y).Text = entrantlocations(item, 0).Split(",")(0)
                        entryboxes(originallocation.X, originallocation.Y).Text = temp.Split(",")(0)
                        'Swaps entrant data in list
                        entrantlocations(item + 1, 0) = entrantlocations(item, 0)
                        entrantlocations(item + 1, 1) = "(" + nextlocation.X.ToString + "," + nextlocation.Y.ToString + ")"
                        entrantlocations(item, 0) = temp
                        entrantlocations(item, 1) = "(" + originallocation.X.ToString + "," + originallocation.Y.ToString + ")"
                        'matches += 1
                    End If
                    item += 1
                Loop
                loopcount += 1
            Loop

            'Resets loopcount, rather than creating a new variable
            loopcount = 0
            'Runs the loop for different amounts for odds or evens
            'Leaves middle intact for evens
            Dim loopend As New Integer
            If participants Mod 2 = 0 Then
                loopend = (participants \ 2) - 2
            Else
                loopend = (participants \ 2) - 1
            End If
            Do Until loopcount = loopend
                'Creates variable to store value of overwritten user
                Dim temp As String = entrantlocations(participants - (loopcount * 2) - 1, 0)
                'Retrieves the location of the next entrant
                Dim nextlocation As New Point(entrantlocations(participants - (loopcount * 2) - 1, 1).Split(",")(0).Replace("(", ""), entrantlocations(participants - (loopcount * 2) - 1, 1).Split(",")(1).Replace(")", ""))
                'Retrieves the location of the original entrant
                Dim originallocation As New Point(entrantlocations(loopcount * 2, 1).Split(",")(0).Replace("(", ""), entrantlocations(loopcount * 2, 1).Split(",")(1).Replace(")", ""))
                'Swaps entrant usernames on draw sheet
                entryboxes(nextlocation.X, nextlocation.Y).Text = entrantlocations(loopcount * 2, 0).Split(",")(0)
                entryboxes(originallocation.X, originallocation.Y).Text = temp.Split(",")(0)
                'Swaps entrant data in list
                entrantlocations(participants - (loopcount * 2) - 1, 0) = entrantlocations(loopcount * 2, 0)
                entrantlocations(participants - (loopcount * 2) - 1, 1) = "(" + nextlocation.X.ToString + "," + nextlocation.Y.ToString + ")"
                entrantlocations(loopcount * 2, 0) = temp
                entrantlocations(loopcount * 2, 1) = "(" + originallocation.X.ToString + "," + originallocation.Y.ToString + ")"
                loopcount += 1
            Loop
            'Runs if there are an even number of participants
            If participants Mod 2 = 0 Then
                'Saves the information in the first and last boxes
                Dim temp1 As String = entrantlocations(0, 0)
                Dim temp2 As String = entrantlocations(participants - 1, 0)
                'Retrieves the location of the final entrant
                Dim finallocation As New Point(entrantlocations(participants - 1, 1).Split(",")(0).Replace("(", ""), entrantlocations(participants - 1, 1).Split(",")(1).Replace(")", ""))
                'Retrieves the sheet location of each of the middle entrants
                Dim middlelocationfirst As New Point(entrantlocations(participants / 2, 1).Split(",")(0).Replace("(", ""), entrantlocations(participants / 2, 1).Split(",")(1).Replace(")", ""))
                Dim middlelocationsecond As New Point(entrantlocations(participants / 2 + 1, 1).Split(",")(0).Replace("(", ""), entrantlocations(participants / 2 + 1, 1).Split(",")(1).Replace(")", ""))
                'Replaces entrant information in the list
                entrantlocations(0, 0) = entrantlocations(participants / 2, 0)
                entrantlocations(participants / 2, 0) = temp1
                entrantlocations(participants - 1, 0) = entrantlocations(participants / 2 + 1, 0)
                entrantlocations(participants / 2 + 1, 0) = temp2
                'Replaces entrant information in the textboxes
                entryboxes(0, 0).Text = entrantlocations(0, 0).Split(",")(0)
                entryboxes(finallocation.X, finallocation.Y).Text = entrantlocations(participants - 1, 0).Split(",")(0)
                entryboxes(middlelocationfirst.X, middlelocationfirst.Y).Text = temp1.Split(",")(0)
                entryboxes(middlelocationsecond.X, middlelocationsecond.Y).Text = temp2.Split(",")(0)
            End If
            'Runs when there are three participants

        ElseIf participants = 3 Then
            'Defines the entry boxes in a 2d array of textboxes
            Dim entryboxes(2, 3) As TextBox
            'Defines the column index
            Dim column As Integer = 0
            'Allows the x count to decrease by 1 between the first and second column
            Dim z As Integer = 0
            'Defines the height of the entry boxes
            Dim x As Integer = 0
            'Runs until 2 columns have been placed in the form
            Do Until column = 2
                'Caluulates the column offset and the height offset
                Dim offset As Integer = 20 * (2 ^ column)
                'Decreases the amount of rows in a column for each run through
                Do Until x = 4 - z
                    'Initialises a usable textbox in the array
                    entryboxes(column, x) = New TextBox
                    'Defines the parameters for the textbox
                    With entryboxes(column, x)
                        .Size = New Size(200, 100)
                        If column = 0 And x > 1 Then
                            'Separates the secondary group from the primary group
                            .Location = New Point(20 + (230 * (column)), offset * 5 + (x * 40) * (2 ^ (column)))
                        Else
                            .Location = New Point(20 + (230 * (column)), offset + (x * 40) * (2 ^ (column)))

                        End If
                        If x > 1 Then
                            'Highlights secondary group
                            .BackColor = Color.LightGray
                        End If
                    End With
                    'Adds the textbox to the form
                    Me.Controls.Add(entryboxes(column, x))
                    x += 1
                Loop
                column += 1
                x = 0
                z += 1
            Loop
            'Adds a final textbox to primary group. Needed as winner determines if secondary group is used
            entryboxes(2, 0) = New TextBox With {.Size = New Size(200, 100), .Location = New Point(480, 80)}
            Me.Controls.Add(entryboxes(2, 0))
            'Adds the users to the draw sheet
            entryboxes(0, 0).Text = participantslist(0).Split(",")(0)
            entryboxes(0, 1).Text = participantslist(1).Split(",")(0)
            entryboxes(0, 2).Text = participantslist(0).Split(",")(0) + " / " + participantslist(1).Split(",")(0)
            entryboxes(0, 3).Text = participantslist(2).Split(",")(0)
            entryboxes(1, 1).Text = participantslist(2).Split(",")(0)



        Else
            Debug.WriteLine("Event Invalid!")
        End If
    End Sub

    Private Sub BtnSaveResults_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'Creates a list to save the entrant results
        Dim entrantresultlist As New List(Of String)
        'Loops through each textbox control
        For Each entrantbox As TextBox In Me.Controls.OfType(Of TextBox)()
            'Adds the text to the list if not empty
            If entrantbox.ToString <> Nothing Then
                entrantresultlist.Add(entrantbox.Text)
            End If
        Next
        Dim entrantcounter As Integer = 0
        Do Until entrantcounter = participants
            'Attempts to download file, or creates file if it doesn't exist yet
            Try
                My.Computer.Network.DownloadFile(ftphost + "/Results/" + participantslist(entrantcounter).Split(",")(0) + "Results.csv", "C:\UserCSV\" + participantslist(entrantcounter).Split(",")(0) + "Results.csv", "FTPUser", "P@ssw0rd")
            Catch ex As Exception
                'Creates the file
                Dim resultfile As FileStream = File.Create("C:\UserCSV\" + participantslist(entrantcounter).Split(",")(0) + "Results.csv")
                resultfile.Close()
            End Try
            'Appends the result to the file
            Dim resultwrite As New StreamWriter("C:\UserCSV\" + participantslist(entrantcounter).Split(",")(0) + "Results.csv", True)
            Dim rounds As String = (entrantresultlist.LongCount(Function(x) x = participantslist(entrantcounter).Split(",")(0))).ToString
            resultwrite.WriteLine(tournamentFullLine + "," + rounds)
            resultwrite.Close()
            'Uploads the file to the ftp server
            Try
                FTPFunctions.Upload(ftphost + "/Results/" + participantslist(entrantcounter).Split(",")(0) + "Results.csv", "C:\UserCSV\" + participantslist(entrantcounter).Split(",")(0) + "Results.csv", True)
            Catch ex As Exception
                Debug.WriteLine(ex.ToString)
            End Try
            entrantcounter += 1
        Loop
    End Sub
End Class