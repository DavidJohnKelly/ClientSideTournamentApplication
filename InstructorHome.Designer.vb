<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorHome
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
        Me.BtnTournamentCreator = New System.Windows.Forms.Button()
        Me.BtnTournamentsignup = New System.Windows.Forms.Button()
        Me.BtnClubManagement = New System.Windows.Forms.Button()
        Me.TxtResults = New System.Windows.Forms.Button()
        Me.BtnRunningOrder = New System.Windows.Forms.Button()
        Me.BtnDrawSheets = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnTournamentCreator
        '
        Me.BtnTournamentCreator.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTournamentCreator.Location = New System.Drawing.Point(13, 13)
        Me.BtnTournamentCreator.Name = "BtnTournamentCreator"
        Me.BtnTournamentCreator.Size = New System.Drawing.Size(266, 128)
        Me.BtnTournamentCreator.TabIndex = 0
        Me.BtnTournamentCreator.Text = "Tournament Creator"
        Me.BtnTournamentCreator.UseVisualStyleBackColor = True
        '
        'BtnTournamentsignup
        '
        Me.BtnTournamentsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTournamentsignup.Location = New System.Drawing.Point(285, 13)
        Me.BtnTournamentsignup.Name = "BtnTournamentsignup"
        Me.BtnTournamentsignup.Size = New System.Drawing.Size(266, 128)
        Me.BtnTournamentsignup.TabIndex = 1
        Me.BtnTournamentsignup.Text = "Tournament Management"
        Me.BtnTournamentsignup.UseVisualStyleBackColor = True
        '
        'BtnClubManagement
        '
        Me.BtnClubManagement.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnClubManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClubManagement.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnClubManagement.Location = New System.Drawing.Point(12, 147)
        Me.BtnClubManagement.Name = "BtnClubManagement"
        Me.BtnClubManagement.Size = New System.Drawing.Size(266, 128)
        Me.BtnClubManagement.TabIndex = 2
        Me.BtnClubManagement.Text = "Club Management"
        Me.BtnClubManagement.UseVisualStyleBackColor = False
        '
        'TxtResults
        '
        Me.TxtResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResults.Location = New System.Drawing.Point(285, 147)
        Me.TxtResults.Name = "TxtResults"
        Me.TxtResults.Size = New System.Drawing.Size(266, 128)
        Me.TxtResults.TabIndex = 3
        Me.TxtResults.Text = "Personal Results"
        Me.TxtResults.UseVisualStyleBackColor = True
        '
        'BtnRunningOrder
        '
        Me.BtnRunningOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRunningOrder.Location = New System.Drawing.Point(285, 281)
        Me.BtnRunningOrder.Name = "BtnRunningOrder"
        Me.BtnRunningOrder.Size = New System.Drawing.Size(266, 128)
        Me.BtnRunningOrder.TabIndex = 4
        Me.BtnRunningOrder.Text = "Running Orders"
        Me.BtnRunningOrder.UseVisualStyleBackColor = True
        '
        'BtnDrawSheets
        '
        Me.BtnDrawSheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrawSheets.Location = New System.Drawing.Point(13, 281)
        Me.BtnDrawSheets.Name = "BtnDrawSheets"
        Me.BtnDrawSheets.Size = New System.Drawing.Size(266, 128)
        Me.BtnDrawSheets.TabIndex = 5
        Me.BtnDrawSheets.Text = "Draw Sheets"
        Me.BtnDrawSheets.UseVisualStyleBackColor = True
        '
        'InstructorHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 415)
        Me.Controls.Add(Me.BtnDrawSheets)
        Me.Controls.Add(Me.BtnRunningOrder)
        Me.Controls.Add(Me.TxtResults)
        Me.Controls.Add(Me.BtnClubManagement)
        Me.Controls.Add(Me.BtnTournamentsignup)
        Me.Controls.Add(Me.BtnTournamentCreator)
        Me.Name = "InstructorHome"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnTournamentCreator As Button
    Friend WithEvents BtnTournamentsignup As Button
    Friend WithEvents BtnClubManagement As Button
    Friend WithEvents TxtResults As Button
    Friend WithEvents BtnRunningOrder As Button
    Friend WithEvents BtnDrawSheets As Button
End Class
