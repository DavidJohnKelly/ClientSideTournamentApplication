<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.SldrHeight = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SldrWeight = New System.Windows.Forms.TrackBar()
        Me.DateDOB = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SlctGender = New System.Windows.Forms.ComboBox()
        Me.RBtnInstructor = New System.Windows.Forms.RadioButton()
        Me.RBtnStudent = New System.Windows.Forms.RadioButton()
        Me.SlctClub = New System.Windows.Forms.ComboBox()
        Me.SlctBelt = New System.Windows.Forms.ComboBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblHeight = New System.Windows.Forms.Label()
        Me.LblWeight = New System.Windows.Forms.Label()
        CType(Me.SldrHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SldrWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(530, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign Up"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(44, 117)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(448, 49)
        Me.TxtName.TabIndex = 1
        Me.TxtName.Text = "Name"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(505, 117)
        Me.TxtEmail.Margin = New System.Windows.Forms.Padding(6)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(708, 49)
        Me.TxtEmail.TabIndex = 2
        Me.TxtEmail.Text = "Email Address"
        '
        'SldrHeight
        '
        Me.SldrHeight.Location = New System.Drawing.Point(215, 204)
        Me.SldrHeight.Margin = New System.Windows.Forms.Padding(6)
        Me.SldrHeight.Name = "SldrHeight"
        Me.SldrHeight.Size = New System.Drawing.Size(629, 56)
        Me.SldrHeight.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 44)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 44)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Weight:"
        '
        'SldrWeight
        '
        Me.SldrWeight.Location = New System.Drawing.Point(215, 286)
        Me.SldrWeight.Margin = New System.Windows.Forms.Padding(6)
        Me.SldrWeight.Name = "SldrWeight"
        Me.SldrWeight.Size = New System.Drawing.Size(629, 56)
        Me.SldrWeight.TabIndex = 5
        '
        'DateDOB
        '
        Me.DateDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDOB.Location = New System.Drawing.Point(283, 361)
        Me.DateDOB.Margin = New System.Windows.Forms.Padding(6)
        Me.DateDOB.Name = "DateDOB"
        Me.DateDOB.Size = New System.Drawing.Size(424, 49)
        Me.DateDOB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(242, 44)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Date of Birth:"
        '
        'SlctGender
        '
        Me.SlctGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctGender.FormattingEnabled = True
        Me.SlctGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.SlctGender.Location = New System.Drawing.Point(724, 361)
        Me.SlctGender.Margin = New System.Windows.Forms.Padding(6)
        Me.SlctGender.Name = "SlctGender"
        Me.SlctGender.Size = New System.Drawing.Size(489, 50)
        Me.SlctGender.TabIndex = 9
        Me.SlctGender.Text = "Gender"
        '
        'RBtnInstructor
        '
        Me.RBtnInstructor.AutoSize = True
        Me.RBtnInstructor.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnInstructor.Location = New System.Drawing.Point(47, 430)
        Me.RBtnInstructor.Margin = New System.Windows.Forms.Padding(6)
        Me.RBtnInstructor.Name = "RBtnInstructor"
        Me.RBtnInstructor.Size = New System.Drawing.Size(200, 48)
        Me.RBtnInstructor.TabIndex = 10
        Me.RBtnInstructor.TabStop = True
        Me.RBtnInstructor.Text = "Instructor"
        Me.RBtnInstructor.UseVisualStyleBackColor = True
        '
        'RBtnStudent
        '
        Me.RBtnStudent.AutoSize = True
        Me.RBtnStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnStudent.Location = New System.Drawing.Point(284, 430)
        Me.RBtnStudent.Margin = New System.Windows.Forms.Padding(6)
        Me.RBtnStudent.Name = "RBtnStudent"
        Me.RBtnStudent.Size = New System.Drawing.Size(172, 48)
        Me.RBtnStudent.TabIndex = 11
        Me.RBtnStudent.TabStop = True
        Me.RBtnStudent.Text = "Student"
        Me.RBtnStudent.UseVisualStyleBackColor = True
        '
        'SlctClub
        '
        Me.SlctClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctClub.Items.AddRange(New Object() {"None"})
        Me.SlctClub.Location = New System.Drawing.Point(44, 506)
        Me.SlctClub.Margin = New System.Windows.Forms.Padding(6)
        Me.SlctClub.Name = "SlctClub"
        Me.SlctClub.Size = New System.Drawing.Size(663, 50)
        Me.SlctClub.TabIndex = 12
        Me.SlctClub.Text = "Club"
        '
        'SlctBelt
        '
        Me.SlctBelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctBelt.Items.AddRange(New Object() {"White", "Yellow Tag", "Yellow", "Green Tag", "Green", "Blue Tag", "Blue", "Red Tag", "Red", "Black Tag", "First Degree Black", "Second Degree Black", "Third Degree Black", "Fourth Degree Black", "Fifth Degree Black"})
        Me.SlctBelt.Location = New System.Drawing.Point(724, 506)
        Me.SlctBelt.Margin = New System.Windows.Forms.Padding(6)
        Me.SlctBelt.Name = "SlctBelt"
        Me.SlctBelt.Size = New System.Drawing.Size(489, 50)
        Me.SlctBelt.TabIndex = 13
        Me.SlctBelt.Text = "Belt"
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(539, 577)
        Me.BtnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(169, 65)
        Me.BtnSubmit.TabIndex = 14
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblHeight
        '
        Me.LblHeight.AutoSize = True
        Me.LblHeight.Location = New System.Drawing.Point(872, 204)
        Me.LblHeight.Name = "LblHeight"
        Me.LblHeight.Size = New System.Drawing.Size(53, 36)
        Me.LblHeight.TabIndex = 15
        Me.LblHeight.Text = "cm"
        '
        'LblWeight
        '
        Me.LblWeight.AutoSize = True
        Me.LblWeight.Location = New System.Drawing.Point(872, 286)
        Me.LblWeight.Name = "LblWeight"
        Me.LblWeight.Size = New System.Drawing.Size(47, 36)
        Me.LblWeight.TabIndex = 16
        Me.LblWeight.Text = "kg"
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 655)
        Me.Controls.Add(Me.LblWeight)
        Me.Controls.Add(Me.LblHeight)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.SlctBelt)
        Me.Controls.Add(Me.SlctClub)
        Me.Controls.Add(Me.RBtnStudent)
        Me.Controls.Add(Me.RBtnInstructor)
        Me.Controls.Add(Me.SlctGender)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateDOB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SldrWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SldrHeight)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "SignUp"
        CType(Me.SldrHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SldrWeight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents SldrHeight As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SldrWeight As TrackBar
    Friend WithEvents DateDOB As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents SlctGender As ComboBox
    Friend WithEvents RBtnInstructor As RadioButton
    Friend WithEvents RBtnStudent As RadioButton
    Friend WithEvents SlctClub As ComboBox
    Friend WithEvents SlctBelt As ComboBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents LblHeight As Label
    Friend WithEvents LblWeight As Label
End Class
