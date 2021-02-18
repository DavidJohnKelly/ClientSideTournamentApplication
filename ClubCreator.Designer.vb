<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClubCreator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridAssistantInstructors = New System.Windows.Forms.DataGridView()
        Me.TournamentList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttons = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.TxtClubName = New System.Windows.Forms.TextBox()
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.SlctMinBelt = New System.Windows.Forms.ComboBox()
        Me.SlctMaxBelt = New System.Windows.Forms.ComboBox()
        Me.SldrCapacity = New System.Windows.Forms.TrackBar()
        Me.LblCapacity = New System.Windows.Forms.Label()
        Me.BtnCreate = New System.Windows.Forms.Button()
        CType(Me.GridAssistantInstructors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SldrCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Club Creator"
        '
        'GridAssistantInstructors
        '
        Me.GridAssistantInstructors.AllowUserToAddRows = False
        Me.GridAssistantInstructors.AllowUserToResizeColumns = False
        Me.GridAssistantInstructors.AllowUserToResizeRows = False
        Me.GridAssistantInstructors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridAssistantInstructors.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridAssistantInstructors.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridAssistantInstructors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridAssistantInstructors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TournamentList, Me.Buttons})
        Me.GridAssistantInstructors.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridAssistantInstructors.Location = New System.Drawing.Point(20, 56)
        Me.GridAssistantInstructors.Name = "GridAssistantInstructors"
        Me.GridAssistantInstructors.RowTemplate.Height = 24
        Me.GridAssistantInstructors.Size = New System.Drawing.Size(512, 329)
        Me.GridAssistantInstructors.TabIndex = 1
        '
        'TournamentList
        '
        Me.TournamentList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TournamentList.HeaderText = "Assistant Instructors"
        Me.TournamentList.Name = "TournamentList"
        Me.TournamentList.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TournamentList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Buttons
        '
        Me.Buttons.HeaderText = "Select"
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblSearch.Enabled = False
        Me.LblSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSearch.Location = New System.Drawing.Point(264, 7)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(140, 44)
        Me.LblSearch.TabIndex = 6
        Me.LblSearch.Text = "Search"
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(253, 4)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(279, 49)
        Me.Search.TabIndex = 5
        '
        'TxtClubName
        '
        Me.TxtClubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClubName.Location = New System.Drawing.Point(538, 56)
        Me.TxtClubName.Name = "TxtClubName"
        Me.TxtClubName.Size = New System.Drawing.Size(530, 49)
        Me.TxtClubName.TabIndex = 7
        Me.TxtClubName.Text = "Club Name"
        '
        'TxtLocation
        '
        Me.TxtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocation.Location = New System.Drawing.Point(538, 111)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(530, 49)
        Me.TxtLocation.TabIndex = 8
        Me.TxtLocation.Text = "Club Location"
        '
        'SlctMinBelt
        '
        Me.SlctMinBelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctMinBelt.FormattingEnabled = True
        Me.SlctMinBelt.Items.AddRange(New Object() {"White", "Yellow", "Green", "Blue", "Red", "Black"})
        Me.SlctMinBelt.Location = New System.Drawing.Point(538, 166)
        Me.SlctMinBelt.Name = "SlctMinBelt"
        Me.SlctMinBelt.Size = New System.Drawing.Size(530, 50)
        Me.SlctMinBelt.TabIndex = 9
        Me.SlctMinBelt.Text = "Minimum Belt"
        '
        'SlctMaxBelt
        '
        Me.SlctMaxBelt.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlctMaxBelt.FormattingEnabled = True
        Me.SlctMaxBelt.Items.AddRange(New Object() {"White", "Yellow", "Green", "Blue", "Red", "Black"})
        Me.SlctMaxBelt.Location = New System.Drawing.Point(538, 222)
        Me.SlctMaxBelt.Name = "SlctMaxBelt"
        Me.SlctMaxBelt.Size = New System.Drawing.Size(530, 50)
        Me.SlctMaxBelt.TabIndex = 10
        Me.SlctMaxBelt.Text = "Maximum Belt"
        '
        'SldrCapacity
        '
        Me.SldrCapacity.Location = New System.Drawing.Point(712, 295)
        Me.SldrCapacity.Name = "SldrCapacity"
        Me.SldrCapacity.Size = New System.Drawing.Size(356, 56)
        Me.SldrCapacity.TabIndex = 11
        '
        'LblCapacity
        '
        Me.LblCapacity.AutoSize = True
        Me.LblCapacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCapacity.Location = New System.Drawing.Point(538, 279)
        Me.LblCapacity.Name = "LblCapacity"
        Me.LblCapacity.Size = New System.Drawing.Size(168, 44)
        Me.LblCapacity.TabIndex = 12
        Me.LblCapacity.Text = "Capacity"
        '
        'BtnCreate
        '
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(876, 328)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(192, 57)
        Me.BtnCreate.TabIndex = 14
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'ClubCreator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 405)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.LblCapacity)
        Me.Controls.Add(Me.SldrCapacity)
        Me.Controls.Add(Me.SlctMaxBelt)
        Me.Controls.Add(Me.SlctMinBelt)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.TxtClubName)
        Me.Controls.Add(Me.LblSearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.GridAssistantInstructors)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClubCreator"
        Me.Text = "ClubCreator"
        CType(Me.GridAssistantInstructors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SldrCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GridAssistantInstructors As DataGridView
    Friend WithEvents TournamentList As DataGridViewTextBoxColumn
    Friend WithEvents Buttons As DataGridViewCheckBoxColumn
    Friend WithEvents LblSearch As Label
    Friend WithEvents Search As TextBox
    Friend WithEvents TxtClubName As TextBox
    Friend WithEvents TxtLocation As TextBox
    Friend WithEvents SlctMinBelt As ComboBox
    Friend WithEvents SlctMaxBelt As ComboBox
    Friend WithEvents SldrCapacity As TrackBar
    Friend WithEvents LblCapacity As Label
    Friend WithEvents BtnCreate As Button
End Class
