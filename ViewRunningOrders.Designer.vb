<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRunningOrders
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
        Me.GridTournaments = New System.Windows.Forms.DataGridView()
        Me.Students = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewStudent = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GridTournaments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridTournaments
        '
        Me.GridTournaments.AllowUserToAddRows = False
        Me.GridTournaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GridTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTournaments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Students, Me.ViewStudent})
        Me.GridTournaments.Location = New System.Drawing.Point(12, 12)
        Me.GridTournaments.Name = "GridTournaments"
        Me.GridTournaments.RowTemplate.Height = 24
        Me.GridTournaments.Size = New System.Drawing.Size(582, 574)
        Me.GridTournaments.TabIndex = 2
        '
        'Students
        '
        Me.Students.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Students.HeaderText = "Tournament Name"
        Me.Students.Name = "Students"
        '
        'ViewStudent
        '
        Me.ViewStudent.HeaderText = "View Running Order"
        Me.ViewStudent.Name = "ViewStudent"
        Me.ViewStudent.Width = 127
        '
        'ViewRunningOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 598)
        Me.Controls.Add(Me.GridTournaments)
        Me.Name = "ViewRunningOrders"
        Me.Text = "ViewRunningOrders"
        CType(Me.GridTournaments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridTournaments As DataGridView
    Friend WithEvents Students As DataGridViewTextBoxColumn
    Friend WithEvents ViewStudent As DataGridViewButtonColumn
End Class
