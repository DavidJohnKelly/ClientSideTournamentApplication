Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions ' Allows regex functions to be used
Imports WinSCP

Module GlobalFunctions ' Globally accessible module created

    Public Class RegexFunctions ' Creates RegexFunctions to house any functions to do with Regex

        'Creates getName function, passing the username as a parameter
        Public Shared Function getNamefromusername(ByVal user As String)
            'Replaces the numbers in the username
            Dim Name As String = Regex.Replace(user, "\d", "")
            Dim sb As New StringBuilder()
            'Loops through the string and finds capital letters
            For Each c As Char In Name
                If Char.IsUpper(c) AndAlso sb.Length > 0 Then
                    'Adds a space when a capital letter is found
                    sb.Append(" "c)
                End If
                sb.Append(c)
                'Returns the name
            Next
            'MsgBox(sb.ToString)
            Return sb.ToString()
        End Function

        Public Shared Function ContainsNumbers(ByVal inputstring As String) ' Creates ContainsNumbers function, passing inputstring as a parameter

            Return Not (Regex.IsMatch(inputstring, "[0-9]")) ' Checks for the presence of digits between 0 and 9 in the string

        End Function

        Public Shared Function ContainsSymbols(ByVal passstring As String) ' Creates ContainsSymbols, passing inputstring as a parameter
            Return Regex.IsMatch(passstring, "[^a-z0-9A-Z]") ' Checks for the presence of characters other than alphanumerical ones
        End Function

        Public Shared Function IsValidEmail(ByVal Email As String) ' Creates ValidEmail function, passing Email as a parameter

            If String.IsNullOrWhiteSpace(Email) Then ' Checks if string is empty

                Return False ' If it is, email is flagged as invalid

            End If

            Try ' Uses IdnMapping class to allow the system to recognize when characters are outside of the standard ASCII system

                Dim DomainMap = ' Creates variable used to map the domain part of the email
                    Function(CheckMatch As Match) As String

                        Dim idnmap = New IdnMapping ' Uses IdnMapping class to convert the Unicode domain names

                        Dim domainname As String = idnmap.GetAscii(CheckMatch.Groups(2).Value) ' Removes the domain name from the string

                        Return CheckMatch.Groups(1).Value & domainname ' Processes the domain name

                    End Function

                Email = Regex.Replace(Email, "(@)(.+)$", DomainMap, RegexOptions.None) ' Normalizes the domain

            Catch e As ArgumentException ' Exception thrown if email is invalid
                Return False

            End Try

            Try ' Holds the patterns for the email
                Return Regex.IsMatch(Email, "^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                     "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                                     RegexOptions.IgnoreCase)
            Catch e As ArgumentException ' Exception thrown if email is invalid
                Return False

            End Try

        End Function
    End Class

    Public Class FTPFunctions
        Public Shared Sub CreateDirectory(ByVal directory_location As String)
            'Location of the tournament folder to be created is imported as a parameter
            Dim request As Net.FtpWebRequest = CType(FtpWebRequest.Create(directory_location), FtpWebRequest)
            ' Logs onto the server
            request.Credentials = New NetworkCredential("FTPUser", "P@ssw0rd")
            'Creates the directory
            request.Method = WebRequestMethods.Ftp.MakeDirectory
            request.GetResponse()
        End Sub

        Public Shared Sub Upload(ByVal file_location As String, ByVal file As String, ByVal deletelocal As Boolean)
            ' Creates the object used to access the FTP server
            Dim fileUpload As FtpWebRequest = CType(WebRequest.Create(file_location), FtpWebRequest)
            fileUpload.Method = WebRequestMethods.Ftp.UploadFile
            ' Houses the login credentials
            fileUpload.Credentials = New NetworkCredential("FTPUser", "P@ssw0rd")

            Dim fileContents As Byte() ' Creates a byte array
            Using sourceStream As StreamReader = New StreamReader(file)
                ' Saves the contents of the file to the stream 
                fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd())
            End Using
            fileUpload.ContentLength = fileContents.Length

            ' Uploads the file
            Using requestStream As Stream = fileUpload.GetRequestStream()
                requestStream.Write(fileContents, 0, fileContents.Length)
            End Using
            If deletelocal = True Then
                System.IO.File.Delete(file)
            End If
        End Sub

        Public Shared Sub SynchroniseDirectory(ByVal locallocation As String, ByVal ftplocation As String, ByVal operation As String)
            'Defines the session parameters
            Dim options As New SessionOptions
            With options
                .Protocol = Protocol.Ftp
                'Uses active FTP to allow access through AWS firewall
                .FtpMode = FtpMode.Active
                .HostName = ftphost.Replace("ftp://", "")
                .UserName = "FTPUser"
                .Password = "P@ssw0rd"
            End With
            'Creates the local directory to store the downloaded files
            If operation = "Download" Then
                Directory.CreateDirectory(locallocation)
            End If
            'Defines the new download session
            Using Synchronise As New Session
                'Uses the options defined earlier
                Synchronise.Open(options)
                'Either syncs local with remote, or remote with local
                If operation = "Download" Then
                    'Synchronizes local directory with FTP directory
                    Dim Synchronization As SynchronizationResult = Synchronise.SynchronizeDirectories(SynchronizationMode.Local, locallocation, ftplocation, False)
                    'Returns exception upon any thrown errors
                    Synchronization.Check()
                ElseIf operation = "Upload" Then
                    'Synchronizes FTP directory with local directory
                    Try
                        Dim Synchronization As SynchronizationResult = Synchronise.SynchronizeDirectories(SynchronizationMode.Remote, locallocation, ftplocation, False)
                        'Returns exception upon any thrown
                        Synchronization.Check()
                    Catch
                        'Creates FTP directory if not available
                        FTPFunctions.CreateDirectory(ftplocation)
                        Dim Synchronization As SynchronizationResult = Synchronise.SynchronizeDirectories(SynchronizationMode.Remote, locallocation, ftplocation, False)
                        'Returns exception upon any thrown
                        Synchronization.Check()
                    End Try
                End If
            End Using
        End Sub

        Public Shared Sub Delete(ByVal location As String)
            'Creates the request
            Dim filedelete As FtpWebRequest = CType(WebRequest.Create(location), FtpWebRequest)
            filedelete.Credentials = New NetworkCredential("FTPUser", "P@ssw0rd")
            'Specifies that the file will be deleted
            filedelete.Method = WebRequestMethods.Ftp.DeleteFile
            filedelete.GetResponse()
        End Sub

        Public Shared Function ListDirectoryNames(ByVal ftplocation As String) As List(Of String)
            Dim DirectoryList As New List(Of String) ' Houses the directory names
            'Connects to the FTP server
            Dim DirectoryNames As FtpWebRequest = DirectCast(WebRequest.Create(ftphost & ftplocation), FtpWebRequest)
            DirectoryNames.Method = WebRequestMethods.Ftp.ListDirectory
            DirectoryNames.Credentials = New NetworkCredential("FTPUser", "P@ssw0rd")

            Dim response As FtpWebResponse = DirectCast(DirectoryNames.GetResponse(), FtpWebResponse)
            Dim responseStream As Stream = response.GetResponseStream
            ' Reads the directory names
            Using reader As New StreamReader(responseStream)
                'Runs until the end of the directories
                Do While reader.Peek <> -1
                    ' Adds tournament name to the list
                    DirectoryList.Add(reader.ReadLine)
                Loop
            End Using
            response.Close()
            Return DirectoryList
        End Function
    End Class

    Public Class HelperFunctions ' Creates HelperFunctions class
        ' Creates the GetMd5Hash function, calling hash and password as parameters
        Public Shared Function GetMd5Hash(ByVal hash As MD5, ByVal password As String)
            ' Converts the user's password to an array of bytes and then computes the hash
            Dim passworddata As Byte() = hash.ComputeHash(Encoding.UTF8.GetBytes(password))
            Dim sb As New StringBuilder() ' calls a new Stringbuilder collects the bytes

            For i As Integer = 0 To passworddata.Length - 1 ' Iterates through the password
                sb.Append(passworddata(i).ToString("x2")) ' For each part of the byte data, it converts it to a hexadecimal string
                i += 1 ' Allows the loop to iterate
            Next
            Return sb.ToString() ' Returns the hashed password
        End Function

        'Passes age and gender in order to calculate user group
        Public Shared Function GroupCalculator(ByVal age As Integer, ByVal gender As String)

            Dim group As String = ""
            'Works out what event group users should be in
            If age > 39 Then
                group = "Veteran(40+" + gender + ")"
            ElseIf age < 40 And age > 19 Then
                group = "Adult(20-40" + gender + ")"
            ElseIf age < 18 And age > 16 Then
                group = "Junior(17-19" + gender + ")"
            ElseIf age < 17 And age > 13 Then
                group = "Junior(14-16" + gender + ")"
            ElseIf age < 14 And age > 10 Then
                group = "Children(11-14" + gender + ")"
            ElseIf age < 11 And age > 7 Then
                group = "Children(8-10" + gender + ")"
            End If

            Return group
        End Function
    End Class

    Public DrawSheetOrRunningOrder(1) As String
    Public ftphost As String = "ftp://ec2-35-179-79-245.eu-west-2.compute.amazonaws.com"
    Public ActiveUser As String
    Public TournamentApplication As String
    Public tournamentFullLine As String

End Module
