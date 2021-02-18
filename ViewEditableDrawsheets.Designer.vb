<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewEditableDrawsheets
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
        Me.DrawSheetGrid = New System.Windows.Forms.DataGridView()
        Me.Tournament = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tournament_Event = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditResults = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DrawSheetGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawSheetGrid
        '
        Me.DrawSheetGrid.AllowUserToAddRows = False
        Me.DrawSheetGrid.AllowUserToDeleteRows = False
        Me.DrawSheetGrid.AllowUserToResizeColumns = False
        Me.DrawSheetGrid.AllowUserToResizeRows = False
        Me.DrawSheetGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DrawSheetGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrawSheetGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tournament, Me.Tournament_Event, Me.Group, Me.EditResults})
        Me.DrawSheetGrid.Location = New System.Drawing.Point(12, 12)
        Me.DrawSheetGrid.Name = "DrawSheetGrid"
        Me.DrawSheetGrid.RowTemplate.Height = 24
        Me.DrawSheetGrid.Size = New System.Drawing.Size(642, 708)
        Me.DrawSheetGrid.TabIndex = 0
        '
        'Tournament
        '
        Me.Tournament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Tournament.HeaderText = "Tournament"
        Me.Tournament.Name = "Tournament"
        Me.Tournament.ReadOnly = True
        '
        'Tournament_Event
        '
        Me.Tournament_Event.HeaderText = "Event"
        Me.Tournament_Event.Name = "Tournament_Event"
        Me.Tournament_Event.ReadOnly = True
        Me.Tournament_Event.Width = 73
        '
        'Group
        '
        Me.Group.HeaderText = "Group"
        Me.Group.Name = "Group"
        Me.Group.ReadOnly = True
        Me.Group.Width = 77
        '
        'EditResults
        '
        Me.EditResults.HeaderText = "Edit Results"
        Me.EditResults.Name = "EditResults"
        Me.EditResults.ReadOnly = True
        Me.EditResults.Width = 89
        '
        'ViewEditableDrawsheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 732)
        Me.Controls.Add(Me.DrawSheetGrid)
        Me.Name = "ViewEditableDrawsheets"
        Me.Text = "ViewEditableDrawsheets"
        CType(Me.DrawSheetGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DrawSheetGrid As DataGridView
    Friend WithEvents Tournament As DataGridViewTextBoxColumn
    Friend WithEvents Tournament_Event As DataGridViewTextBoxColumn
    Friend WithEvents Group As DataGridViewTextBoxColumn
    Friend WithEvents EditResults As DataGridViewButtonColumn
End Class
