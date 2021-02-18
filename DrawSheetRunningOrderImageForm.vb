Imports System.IO
Public Class DrawSheetRunningOrderImageForm
    Private Sub DrawSheetRunningOrderImageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checks the global array to see if previous form was for draw sheets, or running orders
        If DrawSheetOrRunningOrder(1) = "Draw Sheet" Then
            'Splits the draw sheet array
            Dim InfoSplit As List(Of String) = DrawSheetOrRunningOrder(0).Split(" ").ToList
            'Gets the location on the FTP server
            Dim SheetLocation As String = "/Tournaments/" + InfoSplit(0).Replace("-", " ") + "/" + InfoSplit(1) + "/" + InfoSplit(2) + ".jpg"
            My.Computer.Network.DownloadFile(ftphost + SheetLocation, "C:\UserCSV\" + InfoSplit(0) + InfoSplit(1) + InfoSplit(2) + ".jpg", "FTPUser", "P@ssw0rd")
            Dim ImagePath As String = "C:\UserCSV\" + InfoSplit(0) + InfoSplit(1) + InfoSplit(2) + ".jpg" ' Sets the location of the image
            Dim ImageFileStream = New FileStream(ImagePath, FileMode.Open, FileAccess.Read) ' Gets a data stream of the image file
            PictureBox.Image = Image.FromStream(ImageFileStream) ' Sets the stream data to be the image in the picture box
            ImageFileStream.Close()
            File.Delete("C:\UserCSV\" + InfoSplit(0) + InfoSplit(1) + InfoSplit(2) + ".jpg") ' Deletes the local copy
        Else
            BtnPrint.Visible = False
            Dim SheetLocation As String = "/Tournaments/" + DrawSheetOrRunningOrder(0) + "/" + DrawSheetOrRunningOrder(0) + " RunningOrder.png" ' Gets the location on the FTP server
            My.Computer.Network.DownloadFile(ftphost + SheetLocation, "C:\UserCSV\" + DrawSheetOrRunningOrder(0) + ".png", "FTPUser", "P@ssw0rd")
            Dim ImagePath As String = "C:\UserCSV\" + DrawSheetOrRunningOrder(0) + ".png" ' Sets the location of the image
            Dim ImageFileStream = New FileStream(ImagePath, FileMode.Open, FileAccess.Read) ' Gets a data stream of the image file
            PictureBox.Image = Image.FromStream(ImageFileStream) ' Sets the stream data to be the image in the picture box
            ImageFileStream.Close()
            File.Delete("C:\UserCSV\" + DrawSheetOrRunningOrder(0) + ".png") ' Deletes the local copy

        End If



    End Sub

    'Creates a new instance of the image printing class
    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim pd As New Printing.PrintDocument
        'Gets the image from the picture box
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        'Prints to default local printer
        pd.Print()
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        'Defines the standard size of an A4 sheet of paper for the picturebox
        Dim A4PictureBox As New PictureBox With {
            .Width = 891,
            .Height = 1100,
            .Visible = False,
            .Image = PictureBox.Image
        }

        'Calculates the ratio between the width and height of an image
        Dim ImageAspectRatio As Double = A4PictureBox.Image.Width / A4PictureBox.Image.Height
        'If the image is wider than it is long, flips into portrait
        If A4PictureBox.Image.Width > A4PictureBox.Image.Height Then
            A4PictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If

        'Checks if the width is greater than the sheet
        If A4PictureBox.Image.Width > 891 Then
            'If it is, resizes the width, using the aspect ratio, and sets the height to sheet height
            Dim newImage As Bitmap = New Bitmap(A4PictureBox.Image, New Size(A4PictureBox.Image.Width / ImageAspectRatio, 1100))
            e.Graphics.DrawImage(newImage, 0, 0)

            'Checks if the height is greater than the sheet
        ElseIf A4PictureBox.Image.Height > 1100 Then
            'If it is, resizes the height, using the aspect ratio, and sets the width to sheet width
            Dim newImage As Bitmap = New Bitmap(A4PictureBox.Image, New Size(891, A4PictureBox.Image.Height / ImageAspectRatio))
            e.Graphics.DrawImage(newImage, 0, 0)

        Else 'Otherwise, image will fit on sheet
            e.Graphics.DrawImage(A4PictureBox.Image, 0, 0)
        End If
    End Sub

End Class