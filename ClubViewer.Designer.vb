<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClubViewer
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
        Me.LblClub = New System.Windows.Forms.Label()
        Me.GridStudents = New System.Windows.Forms.DataGridView()
        Me.Students = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemoveStudent = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ViewStudent = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.LblBulkApplication = New System.Windows.Forms.LinkLabel()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblClub
        '
        Me.LblClub.AutoSize = True
        Me.LblClub.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClub.Location = New System.Drawing.Point(14, 21)
        Me.LblClub.Name = "LblClub"
        Me.LblClub.Size = New System.Drawing.Size(178, 36)
        Me.LblClub.TabIndex = 0
        Me.LblClub.Text = "[Club Name]"
        '
        'GridStudents
        '
        Me.GridStudents.AllowUserToAddRows = False
        Me.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Students, Me.RemoveStudent, Me.ViewStudent})
        Me.GridStudents.Location = New System.Drawing.Point(20, 79)
        Me.GridStudents.Name = "GridStudents"
        Me.GridStudents.RowTemplate.Height = 24
        Me.GridStudents.Size = New System.Drawing.Size(582, 574)
        Me.GridStudents.TabIndex = 1
        '
        'Students
        '
        Me.Students.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Students.HeaderText = "Students"
        Me.Students.Name = "Students"
        '
        'RemoveStudent
        '
        Me.RemoveStudent.HeaderText = "Remove"
        Me.RemoveStudent.Name = "RemoveStudent"
        '
        'ViewStudent
        '
        Me.ViewStudent.HeaderText = "View"
        Me.ViewStudent.Name = "ViewStudent"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(355, 12)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(247, 49)
        Me.TxtSearch.TabIndex = 2
        Me.TxtSearch.Text = "Search"
        '
        'LblBulkApplication
        '
        Me.LblBulkApplication.AutoSize = True
        Me.LblBulkApplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBulkApplication.Location = New System.Drawing.Point(12, 656)
        Me.LblBulkApplication.Name = "LblBulkApplication"
        Me.LblBulkApplication.Size = New System.Drawing.Size(361, 44)
        Me.LblBulkApplication.TabIndex = 3
        Me.LblBulkApplication.TabStop = True
        Me.LblBulkApplication.Text = "Apply to tournament"
        '
        'ClubViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 707)
        Me.Controls.Add(Me.LblBulkApplication)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.GridStudents)
        Me.Controls.Add(Me.LblClub)
        Me.Name = "ClubViewer"
        Me.Text = "ClubViewer"
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblClub As Label
    Friend WithEvents GridStudents As DataGridView
    Friend WithEvents Students As DataGridViewTextBoxColumn
    Friend WithEvents RemoveStudent As DataGridViewImageColumn
    Friend WithEvents ViewStudent As DataGridViewButtonColumn
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblBulkApplication As LinkLabel
End Class
