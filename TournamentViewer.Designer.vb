<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TournamentViewer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridTournaments = New System.Windows.Forms.DataGridView()
        Me.TournamentList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttons = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.LblAddTournament = New System.Windows.Forms.LinkLabel()
        Me.LblSearch = New System.Windows.Forms.Label()
        CType(Me.GridTournaments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridTournaments
        '
        Me.GridTournaments.AllowUserToAddRows = False
        Me.GridTournaments.AllowUserToDeleteRows = False
        Me.GridTournaments.AllowUserToResizeColumns = False
        Me.GridTournaments.AllowUserToResizeRows = False
        Me.GridTournaments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridTournaments.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridTournaments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTournaments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TournamentList, Me.Buttons})
        Me.GridTournaments.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridTournaments.Location = New System.Drawing.Point(20, 67)
        Me.GridTournaments.Name = "GridTournaments"
        Me.GridTournaments.RowTemplate.Height = 24
        Me.GridTournaments.Size = New System.Drawing.Size(698, 496)
        Me.GridTournaments.TabIndex = 0
        '
        'TournamentList
        '
        Me.TournamentList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TournamentList.HeaderText = "Tournaments"
        Me.TournamentList.Name = "TournamentList"
        Me.TournamentList.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TournamentList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Buttons
        '
        Me.Buttons.HeaderText = "Apply"
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tournaments"
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(263, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(455, 49)
        Me.Search.TabIndex = 2
        '
        'LblAddTournament
        '
        Me.LblAddTournament.AutoSize = True
        Me.LblAddTournament.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddTournament.Location = New System.Drawing.Point(20, 570)
        Me.LblAddTournament.Name = "LblAddTournament"
        Me.LblAddTournament.Size = New System.Drawing.Size(201, 29)
        Me.LblAddTournament.TabIndex = 3
        Me.LblAddTournament.TabStop = True
        Me.LblAddTournament.Text = "Add a tournament"
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSearch.Enabled = False
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(272, 15)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(140, 44)
        Me.LblSearch.TabIndex = 4
        Me.LblSearch.Text = "Search"
        '
        'TournamentViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 613)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.LblAddTournament)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridTournaments)
        Me.Name = "TournamentViewer"
        Me.Text = "TournamentViewer"
        CType(Me.GridTournaments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridTournaments As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents LblAddTournament As LinkLabel
    Friend WithEvents TournamentList As DataGridViewTextBoxColumn
    Friend WithEvents Buttons As DataGridViewButtonColumn
    Friend WithEvents LblSearch As Label
End Class
