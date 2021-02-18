<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserSignUp
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
        Me.LblTournament = New System.Windows.Forms.Label()
        Me.ChckPatterns = New System.Windows.Forms.CheckBox()
        Me.ChckSparring = New System.Windows.Forms.CheckBox()
        Me.ChckSelfDefence = New System.Windows.Forms.CheckBox()
        Me.ChckSpecialTechnique = New System.Windows.Forms.CheckBox()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtBelt = New System.Windows.Forms.TextBox()
        Me.TxtClub = New System.Windows.Forms.TextBox()
        Me.TxtDOB = New System.Windows.Forms.TextBox()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.TxtGender = New System.Windows.Forms.TextBox()
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.ChckUmpire = New System.Windows.Forms.CheckBox()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTournament
        '
        Me.LblTournament.AutoSize = True
        Me.LblTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTournament.Location = New System.Drawing.Point(12, 20)
        Me.LblTournament.Name = "LblTournament"
        Me.LblTournament.Size = New System.Drawing.Size(360, 44)
        Me.LblTournament.TabIndex = 0
        Me.LblTournament.Text = "[Tournament Name]"
        '
        'ChckPatterns
        '
        Me.ChckPatterns.AutoSize = True
        Me.ChckPatterns.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckPatterns.Location = New System.Drawing.Point(20, 88)
        Me.ChckPatterns.Name = "ChckPatterns"
        Me.ChckPatterns.Size = New System.Drawing.Size(184, 48)
        Me.ChckPatterns.TabIndex = 1
        Me.ChckPatterns.Text = "Patterns"
        Me.ChckPatterns.UseVisualStyleBackColor = True
        Me.ChckPatterns.Visible = False
        '
        'ChckSparring
        '
        Me.ChckSparring.AutoSize = True
        Me.ChckSparring.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSparring.Location = New System.Drawing.Point(20, 142)
        Me.ChckSparring.Name = "ChckSparring"
        Me.ChckSparring.Size = New System.Drawing.Size(186, 48)
        Me.ChckSparring.TabIndex = 2
        Me.ChckSparring.Text = "Sparring"
        Me.ChckSparring.UseVisualStyleBackColor = True
        Me.ChckSparring.Visible = False
        '
        'ChckSelfDefence
        '
        Me.ChckSelfDefence.AutoSize = True
        Me.ChckSelfDefence.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSelfDefence.Location = New System.Drawing.Point(20, 250)
        Me.ChckSelfDefence.Name = "ChckSelfDefence"
        Me.ChckSelfDefence.Size = New System.Drawing.Size(259, 48)
        Me.ChckSelfDefence.TabIndex = 4
        Me.ChckSelfDefence.Text = "Self Defence"
        Me.ChckSelfDefence.UseVisualStyleBackColor = True
        Me.ChckSelfDefence.Visible = False
        '
        'ChckSpecialTechnique
        '
        Me.ChckSpecialTechnique.AutoSize = True
        Me.ChckSpecialTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSpecialTechnique.Location = New System.Drawing.Point(20, 196)
        Me.ChckSpecialTechnique.Name = "ChckSpecialTechnique"
        Me.ChckSpecialTechnique.Size = New System.Drawing.Size(354, 48)
        Me.ChckSpecialTechnique.TabIndex = 3
        Me.ChckSpecialTechnique.Text = "Special Technique"
        Me.ChckSpecialTechnique.UseVisualStyleBackColor = True
        Me.ChckSpecialTechnique.Visible = False
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(392, 85)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(343, 49)
        Me.TxtName.TabIndex = 5
        Me.TxtName.Text = "Name"
        '
        'TxtBelt
        '
        Me.TxtBelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBelt.Location = New System.Drawing.Point(741, 87)
        Me.TxtBelt.Name = "TxtBelt"
        Me.TxtBelt.Size = New System.Drawing.Size(343, 49)
        Me.TxtBelt.TabIndex = 6
        Me.TxtBelt.Text = "Belt"
        '
        'TxtClub
        '
        Me.TxtClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClub.Location = New System.Drawing.Point(741, 143)
        Me.TxtClub.Name = "TxtClub"
        Me.TxtClub.Size = New System.Drawing.Size(343, 49)
        Me.TxtClub.TabIndex = 8
        Me.TxtClub.Text = "Club"
        '
        'TxtDOB
        '
        Me.TxtDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOB.Location = New System.Drawing.Point(392, 140)
        Me.TxtDOB.Name = "TxtDOB"
        Me.TxtDOB.Size = New System.Drawing.Size(343, 49)
        Me.TxtDOB.TabIndex = 7
        Me.TxtDOB.Text = "Date of Birth"
        '
        'TxtWeight
        '
        Me.TxtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWeight.Location = New System.Drawing.Point(392, 251)
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(343, 49)
        Me.TxtWeight.TabIndex = 11
        Me.TxtWeight.Text = "Weight"
        '
        'TxtGender
        '
        Me.TxtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGender.Location = New System.Drawing.Point(741, 198)
        Me.TxtGender.Name = "TxtGender"
        Me.TxtGender.Size = New System.Drawing.Size(343, 49)
        Me.TxtGender.TabIndex = 10
        Me.TxtGender.Text = "Gender"
        '
        'TxtHeight
        '
        Me.TxtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHeight.Location = New System.Drawing.Point(392, 196)
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(343, 49)
        Me.TxtHeight.TabIndex = 9
        Me.TxtHeight.Text = "Height"
        '
        'ChckUmpire
        '
        Me.ChckUmpire.AutoSize = True
        Me.ChckUmpire.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckUmpire.Location = New System.Drawing.Point(741, 313)
        Me.ChckUmpire.Name = "ChckUmpire"
        Me.ChckUmpire.Size = New System.Drawing.Size(166, 48)
        Me.ChckUmpire.TabIndex = 12
        Me.ChckUmpire.Text = "Umpire"
        Me.ChckUmpire.UseVisualStyleBackColor = True
        '
        'BtnApply
        '
        Me.BtnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApply.Location = New System.Drawing.Point(913, 306)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(171, 61)
        Me.BtnApply.TabIndex = 13
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(741, 251)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(343, 49)
        Me.TxtEmail.TabIndex = 14
        Me.TxtEmail.Text = "Email"
        '
        'UserSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 380)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.ChckUmpire)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.TxtGender)
        Me.Controls.Add(Me.TxtHeight)
        Me.Controls.Add(Me.TxtClub)
        Me.Controls.Add(Me.TxtDOB)
        Me.Controls.Add(Me.TxtBelt)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.ChckSelfDefence)
        Me.Controls.Add(Me.ChckSpecialTechnique)
        Me.Controls.Add(Me.ChckSparring)
        Me.Controls.Add(Me.ChckPatterns)
        Me.Controls.Add(Me.LblTournament)
        Me.Name = "UserSignUp"
        Me.Text = "UserSignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTournament As Label
    Friend WithEvents ChckPatterns As CheckBox
    Friend WithEvents ChckSparring As CheckBox
    Friend WithEvents ChckSelfDefence As CheckBox
    Friend WithEvents ChckSpecialTechnique As CheckBox
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtBelt As TextBox
    Friend WithEvents TxtClub As TextBox
    Friend WithEvents TxtDOB As TextBox
    Friend WithEvents TxtWeight As TextBox
    Friend WithEvents TxtGender As TextBox
    Friend WithEvents TxtHeight As TextBox
    Friend WithEvents ChckUmpire As CheckBox
    Friend WithEvents BtnApply As Button
    Friend WithEvents TxtEmail As TextBox
End Class
