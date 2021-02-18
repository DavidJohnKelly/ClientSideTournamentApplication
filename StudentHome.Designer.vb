<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentHome
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
        Me.TxtResults = New System.Windows.Forms.Button()
        Me.BtnTournamentsignup = New System.Windows.Forms.Button()
        Me.BtnDrawSheets = New System.Windows.Forms.Button()
        Me.BtnRunningOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtResults
        '
        Me.TxtResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResults.Location = New System.Drawing.Point(12, 146)
        Me.TxtResults.Name = "TxtResults"
        Me.TxtResults.Size = New System.Drawing.Size(413, 128)
        Me.TxtResults.TabIndex = 5
        Me.TxtResults.Text = "Personal Results"
        Me.TxtResults.UseVisualStyleBackColor = True
        '
        'BtnTournamentsignup
        '
        Me.BtnTournamentsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTournamentsignup.Location = New System.Drawing.Point(12, 12)
        Me.BtnTournamentsignup.Name = "BtnTournamentsignup"
        Me.BtnTournamentsignup.Size = New System.Drawing.Size(413, 128)
        Me.BtnTournamentsignup.TabIndex = 4
        Me.BtnTournamentsignup.Text = "Tournament Sign-Up"
        Me.BtnTournamentsignup.UseVisualStyleBackColor = True
        '
        'BtnDrawSheets
        '
        Me.BtnDrawSheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrawSheets.Location = New System.Drawing.Point(12, 282)
        Me.BtnDrawSheets.Name = "BtnDrawSheets"
        Me.BtnDrawSheets.Size = New System.Drawing.Size(196, 128)
        Me.BtnDrawSheets.TabIndex = 6
        Me.BtnDrawSheets.Text = "Draw Sheets"
        Me.BtnDrawSheets.UseVisualStyleBackColor = True
        '
        'BtnRunningOrder
        '
        Me.BtnRunningOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunningOrder.Location = New System.Drawing.Point(214, 282)
        Me.BtnRunningOrder.Name = "BtnRunningOrder"
        Me.BtnRunningOrder.Size = New System.Drawing.Size(211, 128)
        Me.BtnRunningOrder.TabIndex = 7
        Me.BtnRunningOrder.Text = "Running Orders"
        Me.BtnRunningOrder.UseVisualStyleBackColor = True
        '
        'StudentHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 416)
        Me.Controls.Add(Me.BtnRunningOrder)
        Me.Controls.Add(Me.BtnDrawSheets)
        Me.Controls.Add(Me.TxtResults)
        Me.Controls.Add(Me.BtnTournamentsignup)
        Me.Name = "StudentHome"
        Me.Text = "StudentHome"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtResults As Button
    Friend WithEvents BtnTournamentsignup As Button
    Friend WithEvents BtnDrawSheets As Button
    Friend WithEvents BtnRunningOrder As Button
End Class
