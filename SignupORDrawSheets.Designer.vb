<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignupORDrawSheets
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
        Me.LblSignupORDrawsheets = New System.Windows.Forms.Label()
        Me.BtnSignup = New System.Windows.Forms.Button()
        Me.BtnViewDrawSheets = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblSignupORDrawsheets
        '
        Me.LblSignupORDrawsheets.AutoSize = True
        Me.LblSignupORDrawsheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSignupORDrawsheets.Location = New System.Drawing.Point(42, 9)
        Me.LblSignupORDrawsheets.Name = "LblSignupORDrawsheets"
        Me.LblSignupORDrawsheets.Size = New System.Drawing.Size(678, 29)
        Me.LblSignupORDrawsheets.TabIndex = 0
        Me.LblSignupORDrawsheets.Text = "Would you like to edit event results or sign up to a tournament?"
        '
        'BtnSignup
        '
        Me.BtnSignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignup.Location = New System.Drawing.Point(75, 71)
        Me.BtnSignup.Name = "BtnSignup"
        Me.BtnSignup.Size = New System.Drawing.Size(291, 85)
        Me.BtnSignup.TabIndex = 1
        Me.BtnSignup.Text = "Tournament Signup"
        Me.BtnSignup.UseVisualStyleBackColor = True
        '
        'BtnViewDrawSheets
        '
        Me.BtnViewDrawSheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewDrawSheets.Location = New System.Drawing.Point(391, 71)
        Me.BtnViewDrawSheets.Name = "BtnViewDrawSheets"
        Me.BtnViewDrawSheets.Size = New System.Drawing.Size(291, 85)
        Me.BtnViewDrawSheets.TabIndex = 2
        Me.BtnViewDrawSheets.Text = "Edit Event Results"
        Me.BtnViewDrawSheets.UseVisualStyleBackColor = True
        '
        'SignupORDrawSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 216)
        Me.Controls.Add(Me.BtnViewDrawSheets)
        Me.Controls.Add(Me.BtnSignup)
        Me.Controls.Add(Me.LblSignupORDrawsheets)
        Me.Name = "SignupORDrawSheets"
        Me.Text = "SignupORDrawSheets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSignupORDrawsheets As Label
    Friend WithEvents BtnSignup As Button
    Friend WithEvents BtnViewDrawSheets As Button
End Class
