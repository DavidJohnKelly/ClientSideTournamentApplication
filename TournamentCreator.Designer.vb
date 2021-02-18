<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TournamentCreator
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChckSpecialTechnique = New System.Windows.Forms.CheckBox()
        Me.ChckPatterns = New System.Windows.Forms.CheckBox()
        Me.ChckSparring = New System.Windows.Forms.CheckBox()
        Me.ChckSelfDefence = New System.Windows.Forms.CheckBox()
        Me.TxtTournamentName = New System.Windows.Forms.TextBox()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.SlctMinBelt = New System.Windows.Forms.ComboBox()
        Me.ChckDynamicCategories = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DteClosing = New System.Windows.Forms.DateTimePicker()
        Me.DteOpening = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SldrCapacity = New System.Windows.Forms.TrackBar()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblCapacity = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SldrRings = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TimeOpening = New System.Windows.Forms.DateTimePicker()
        Me.TimeClosing = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblRings = New System.Windows.Forms.Label()
        CType(Me.SldrCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SldrRings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tournament Creator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 44)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Events"
        '
        'ChckSpecialTechnique
        '
        Me.ChckSpecialTechnique.AutoSize = True
        Me.ChckSpecialTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSpecialTechnique.Location = New System.Drawing.Point(29, 130)
        Me.ChckSpecialTechnique.Name = "ChckSpecialTechnique"
        Me.ChckSpecialTechnique.Size = New System.Drawing.Size(354, 48)
        Me.ChckSpecialTechnique.TabIndex = 2
        Me.ChckSpecialTechnique.Text = "Special Technique"
        Me.ChckSpecialTechnique.UseVisualStyleBackColor = True
        '
        'ChckPatterns
        '
        Me.ChckPatterns.AutoSize = True
        Me.ChckPatterns.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckPatterns.Location = New System.Drawing.Point(29, 184)
        Me.ChckPatterns.Name = "ChckPatterns"
        Me.ChckPatterns.Size = New System.Drawing.Size(184, 48)
        Me.ChckPatterns.TabIndex = 3
        Me.ChckPatterns.Text = "Patterns"
        Me.ChckPatterns.UseVisualStyleBackColor = True
        '
        'ChckSparring
        '
        Me.ChckSparring.AutoSize = True
        Me.ChckSparring.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSparring.Location = New System.Drawing.Point(29, 238)
        Me.ChckSparring.Name = "ChckSparring"
        Me.ChckSparring.Size = New System.Drawing.Size(186, 48)
        Me.ChckSparring.TabIndex = 4
        Me.ChckSparring.Text = "Sparring"
        Me.ChckSparring.UseVisualStyleBackColor = True
        '
        'ChckSelfDefence
        '
        Me.ChckSelfDefence.AutoSize = True
        Me.ChckSelfDefence.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSelfDefence.Location = New System.Drawing.Point(29, 292)
        Me.ChckSelfDefence.Name = "ChckSelfDefence"
        Me.ChckSelfDefence.Size = New System.Drawing.Size(259, 48)
        Me.ChckSelfDefence.TabIndex = 5
        Me.ChckSelfDefence.Text = "Self Defence"
        Me.ChckSelfDefence.UseVisualStyleBackColor = True
        '
        'TxtTournamentName
        '
        Me.TxtTournamentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTournamentName.Location = New System.Drawing.Point(410, 129)
        Me.TxtTournamentName.Name = "TxtTournamentName"
        Me.TxtTournamentName.Size = New System.Drawing.Size(376, 49)
        Me.TxtTournamentName.TabIndex = 6
        Me.TxtTournamentName.Text = "Tournament Name"
        '
        'TxtLocation
        '
        Me.TxtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocation.Location = New System.Drawing.Point(410, 184)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(376, 49)
        Me.TxtLocation.TabIndex = 7
        Me.TxtLocation.Text = "Location"
        '
        'SlctMinBelt
        '
        Me.SlctMinBelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctMinBelt.FormattingEnabled = True
        Me.SlctMinBelt.Items.AddRange(New Object() {"White", "Yellow", "Green", "Blue", "Red", "Black"})
        Me.SlctMinBelt.Location = New System.Drawing.Point(410, 240)
        Me.SlctMinBelt.Name = "SlctMinBelt"
        Me.SlctMinBelt.Size = New System.Drawing.Size(376, 50)
        Me.SlctMinBelt.TabIndex = 8
        Me.SlctMinBelt.Text = "Minimum Belt"
        '
        'ChckDynamicCategories
        '
        Me.ChckDynamicCategories.AutoSize = True
        Me.ChckDynamicCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckDynamicCategories.Location = New System.Drawing.Point(410, 297)
        Me.ChckDynamicCategories.Name = "ChckDynamicCategories"
        Me.ChckDynamicCategories.Size = New System.Drawing.Size(385, 48)
        Me.ChckDynamicCategories.TabIndex = 9
        Me.ChckDynamicCategories.Text = "Dynamic Categories"
        Me.ChckDynamicCategories.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(344, 44)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Application Closing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 44)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Application Opening"
        '
        'DteClosing
        '
        Me.DteClosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteClosing.Location = New System.Drawing.Point(411, 426)
        Me.DteClosing.Name = "DteClosing"
        Me.DteClosing.Size = New System.Drawing.Size(376, 49)
        Me.DteClosing.TabIndex = 12
        '
        'DteOpening
        '
        Me.DteOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DteOpening.Location = New System.Drawing.Point(410, 358)
        Me.DteOpening.Name = "DteOpening"
        Me.DteOpening.Size = New System.Drawing.Size(376, 49)
        Me.DteOpening.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 495)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 44)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Capacity"
        '
        'SldrCapacity
        '
        Me.SldrCapacity.Location = New System.Drawing.Point(195, 503)
        Me.SldrCapacity.Name = "SldrCapacity"
        Me.SldrCapacity.Size = New System.Drawing.Size(459, 56)
        Me.SldrCapacity.TabIndex = 15
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(602, 705)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(183, 56)
        Me.BtnCreate.TabIndex = 16
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 280)
        Me.Panel1.TabIndex = 17
        '
        'LblCapacity
        '
        Me.LblCapacity.AutoSize = True
        Me.LblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapacity.Location = New System.Drawing.Point(660, 495)
        Me.LblCapacity.Name = "LblCapacity"
        Me.LblCapacity.Size = New System.Drawing.Size(0, 44)
        Me.LblCapacity.TabIndex = 18
        '
        'SldrRings
        '
        Me.SldrRings.Location = New System.Drawing.Point(144, 715)
        Me.SldrRings.Name = "SldrRings"
        Me.SldrRings.Size = New System.Drawing.Size(407, 56)
        Me.SldrRings.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 562)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(380, 44)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tournament Opening"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 632)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(363, 44)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tournament Closing"
        '
        'TimeOpening
        '
        Me.TimeOpening.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOpening.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeOpening.Location = New System.Drawing.Point(411, 562)
        Me.TimeOpening.Name = "TimeOpening"
        Me.TimeOpening.ShowUpDown = True
        Me.TimeOpening.Size = New System.Drawing.Size(375, 49)
        Me.TimeOpening.TabIndex = 22
        '
        'TimeClosing
        '
        Me.TimeClosing.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeClosing.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.TimeClosing.Location = New System.Drawing.Point(410, 635)
        Me.TimeClosing.Name = "TimeClosing"
        Me.TimeClosing.ShowUpDown = True
        Me.TimeClosing.Size = New System.Drawing.Size(375, 49)
        Me.TimeClosing.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 705)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 44)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Rings"
        '
        'LblRings
        '
        Me.LblRings.AutoSize = True
        Me.LblRings.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRings.Location = New System.Drawing.Point(557, 705)
        Me.LblRings.Name = "LblRings"
        Me.LblRings.Size = New System.Drawing.Size(0, 44)
        Me.LblRings.TabIndex = 25
        '
        'TournamentCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 777)
        Me.Controls.Add(Me.LblRings)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TimeClosing)
        Me.Controls.Add(Me.TimeOpening)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SldrRings)
        Me.Controls.Add(Me.LblCapacity)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.SldrCapacity)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DteOpening)
        Me.Controls.Add(Me.DteClosing)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ChckDynamicCategories)
        Me.Controls.Add(Me.SlctMinBelt)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.TxtTournamentName)
        Me.Controls.Add(Me.ChckSelfDefence)
        Me.Controls.Add(Me.ChckSparring)
        Me.Controls.Add(Me.ChckPatterns)
        Me.Controls.Add(Me.ChckSpecialTechnique)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TournamentCreator"
        CType(Me.SldrCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SldrRings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ChckSpecialTechnique As CheckBox
    Friend WithEvents ChckPatterns As CheckBox
    Friend WithEvents ChckSparring As CheckBox
    Friend WithEvents ChckSelfDefence As CheckBox
    Friend WithEvents TxtTournamentName As TextBox
    Friend WithEvents TxtLocation As TextBox
    Friend WithEvents SlctMinBelt As ComboBox
    Friend WithEvents ChckDynamicCategories As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DteClosing As DateTimePicker
    Friend WithEvents DteOpening As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents SldrCapacity As TrackBar
    Friend WithEvents BtnCreate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblCapacity As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SldrRings As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TimeOpening As DateTimePicker
    Friend WithEvents TimeClosing As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents LblRings As Label
End Class
