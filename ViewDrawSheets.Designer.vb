<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewDrawSheets
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
        Me.GridEvents = New System.Windows.Forms.DataGridView()
        Me.Students = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewStudent = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GridEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEvents
        '
        Me.GridEvents.AllowUserToAddRows = False
        Me.GridEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Students, Me.ViewStudent})
        Me.GridEvents.Location = New System.Drawing.Point(12, 12)
        Me.GridEvents.Name = "GridEvents"
        Me.GridEvents.RowTemplate.Height = 24
        Me.GridEvents.Size = New System.Drawing.Size(582, 574)
        Me.GridEvents.TabIndex = 3
        '
        'Students
        '
        Me.Students.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Students.HeaderText = "Event Name"
        Me.Students.Name = "Students"
        '
        'ViewStudent
        '
        Me.ViewStudent.HeaderText = "View Draw Sheet"
        Me.ViewStudent.Name = "ViewStudent"
        Me.ViewStudent.Width = 108
        '
        'ViewDrawSheets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 596)
        Me.Controls.Add(Me.GridEvents)
        Me.Name = "ViewDrawSheets"
        Me.Text = "ViewDrawSheets"
        CType(Me.GridEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridEvents As DataGridView
    Friend WithEvents Students As DataGridViewTextBoxColumn
    Friend WithEvents ViewStudent As DataGridViewButtonColumn
End Class
