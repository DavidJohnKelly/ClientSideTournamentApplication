<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordForm
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
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TxtCreatePassword = New System.Windows.Forms.TextBox()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.CheckNumbers = New System.Windows.Forms.CheckBox()
        Me.CheckLength = New System.Windows.Forms.CheckBox()
        Me.CheckSymbols = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsername.Location = New System.Drawing.Point(12, 45)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(338, 44)
        Me.LblUsername.TabIndex = 0
        Me.LblUsername.Text = "Your username is: "
        '
        'TxtCreatePassword
        '
        Me.TxtCreatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCreatePassword.Location = New System.Drawing.Point(20, 120)
        Me.TxtCreatePassword.Name = "TxtCreatePassword"
        Me.TxtCreatePassword.Size = New System.Drawing.Size(427, 49)
        Me.TxtCreatePassword.TabIndex = 1
        Me.TxtCreatePassword.Text = "Create Password"
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(20, 210)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(427, 49)
        Me.TxtConfirmPassword.TabIndex = 2
        Me.TxtConfirmPassword.Text = "Confirm Password"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(332, 306)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(181, 54)
        Me.BtnConfirm.TabIndex = 3
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'CheckNumbers
        '
        Me.CheckNumbers.AutoSize = True
        Me.CheckNumbers.Enabled = False
        Me.CheckNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckNumbers.Location = New System.Drawing.Point(469, 120)
        Me.CheckNumbers.Name = "CheckNumbers"
        Me.CheckNumbers.Size = New System.Drawing.Size(357, 48)
        Me.CheckNumbers.TabIndex = 7
        Me.CheckNumbers.Text = "Contains Numbers"
        Me.CheckNumbers.UseVisualStyleBackColor = True
        '
        'CheckLength
        '
        Me.CheckLength.AutoSize = True
        Me.CheckLength.Enabled = False
        Me.CheckLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckLength.Location = New System.Drawing.Point(469, 165)
        Me.CheckLength.Name = "CheckLength"
        Me.CheckLength.Size = New System.Drawing.Size(314, 48)
        Me.CheckLength.TabIndex = 8
        Me.CheckLength.Text = "8-20 Characters"
        Me.CheckLength.UseVisualStyleBackColor = True
        '
        'CheckSymbols
        '
        Me.CheckSymbols.AutoSize = True
        Me.CheckSymbols.Enabled = False
        Me.CheckSymbols.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSymbols.Location = New System.Drawing.Point(469, 211)
        Me.CheckSymbols.Name = "CheckSymbols"
        Me.CheckSymbols.Size = New System.Drawing.Size(349, 48)
        Me.CheckSymbols.TabIndex = 9
        Me.CheckSymbols.Text = "Contains Symbols"
        Me.CheckSymbols.UseVisualStyleBackColor = True
        '
        'PasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 422)
        Me.Controls.Add(Me.CheckSymbols)
        Me.Controls.Add(Me.CheckLength)
        Me.Controls.Add(Me.CheckNumbers)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.TxtConfirmPassword)
        Me.Controls.Add(Me.TxtCreatePassword)
        Me.Controls.Add(Me.LblUsername)
        Me.Name = "PasswordForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsername As Label
    Friend WithEvents TxtCreatePassword As TextBox
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents CheckNumbers As CheckBox
    Friend WithEvents CheckLength As CheckBox
    Friend WithEvents CheckSymbols As CheckBox
End Class
