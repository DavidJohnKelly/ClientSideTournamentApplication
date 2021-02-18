<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BulkSignup
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblTournamentName = New System.Windows.Forms.Label()
        Me.GridStudents = New System.Windows.Forms.DataGridView()
        Me.ChckSelfDefence = New System.Windows.Forms.CheckBox()
        Me.ChckSpecialTechnique = New System.Windows.Forms.CheckBox()
        Me.ChckSparring = New System.Windows.Forms.CheckBox()
        Me.ChckPatterns = New System.Windows.Forms.CheckBox()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.StudentList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Buttons = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblTournamentName
        '
        Me.LblTournamentName.AutoSize = True
        Me.LblTournamentName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTournamentName.Location = New System.Drawing.Point(14, 12)
        Me.LblTournamentName.Name = "LblTournamentName"
        Me.LblTournamentName.Size = New System.Drawing.Size(275, 36)
        Me.LblTournamentName.TabIndex = 0
        Me.LblTournamentName.Text = "[Tournament Name]"
        '
        'GridStudents
        '
        Me.GridStudents.AllowUserToAddRows = False
        Me.GridStudents.AllowUserToDeleteRows = False
        Me.GridStudents.AllowUserToResizeColumns = False
        Me.GridStudents.AllowUserToResizeRows = False
        Me.GridStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GridStudents.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStudents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentList, Me.Buttons})
        Me.GridStudents.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GridStudents.Location = New System.Drawing.Point(398, 12)
        Me.GridStudents.Name = "GridStudents"
        Me.GridStudents.RowTemplate.Height = 24
        Me.GridStudents.Size = New System.Drawing.Size(491, 373)
        Me.GridStudents.TabIndex = 1
        '
        'ChckSelfDefence
        '
        Me.ChckSelfDefence.AutoSize = True
        Me.ChckSelfDefence.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSelfDefence.Location = New System.Drawing.Point(20, 248)
        Me.ChckSelfDefence.Name = "ChckSelfDefence"
        Me.ChckSelfDefence.Size = New System.Drawing.Size(259, 48)
        Me.ChckSelfDefence.TabIndex = 8
        Me.ChckSelfDefence.Text = "Self Defence"
        Me.ChckSelfDefence.UseVisualStyleBackColor = True
        Me.ChckSelfDefence.Visible = False
        '
        'ChckSpecialTechnique
        '
        Me.ChckSpecialTechnique.AutoSize = True
        Me.ChckSpecialTechnique.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSpecialTechnique.Location = New System.Drawing.Point(20, 194)
        Me.ChckSpecialTechnique.Name = "ChckSpecialTechnique"
        Me.ChckSpecialTechnique.Size = New System.Drawing.Size(354, 48)
        Me.ChckSpecialTechnique.TabIndex = 7
        Me.ChckSpecialTechnique.Text = "Special Technique"
        Me.ChckSpecialTechnique.UseVisualStyleBackColor = True
        Me.ChckSpecialTechnique.Visible = False
        '
        'ChckSparring
        '
        Me.ChckSparring.AutoSize = True
        Me.ChckSparring.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckSparring.Location = New System.Drawing.Point(20, 140)
        Me.ChckSparring.Name = "ChckSparring"
        Me.ChckSparring.Size = New System.Drawing.Size(186, 48)
        Me.ChckSparring.TabIndex = 6
        Me.ChckSparring.Text = "Sparring"
        Me.ChckSparring.UseVisualStyleBackColor = True
        Me.ChckSparring.Visible = False
        '
        'ChckPatterns
        '
        Me.ChckPatterns.AutoSize = True
        Me.ChckPatterns.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChckPatterns.Location = New System.Drawing.Point(20, 86)
        Me.ChckPatterns.Name = "ChckPatterns"
        Me.ChckPatterns.Size = New System.Drawing.Size(184, 48)
        Me.ChckPatterns.TabIndex = 5
        Me.ChckPatterns.Text = "Patterns"
        Me.ChckPatterns.UseVisualStyleBackColor = True
        Me.ChckPatterns.Visible = False
        '
        'BtnApply
        '
        Me.BtnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApply.Location = New System.Drawing.Point(90, 326)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(175, 59)
        Me.BtnApply.TabIndex = 9
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'StudentList
        '
        Me.StudentList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.StudentList.HeaderText = "Students"
        Me.StudentList.Name = "StudentList"
        Me.StudentList.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Buttons
        '
        Me.Buttons.HeaderText = "Select"
        Me.Buttons.Name = "Buttons"
        Me.Buttons.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'BulkSignup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(899, 404)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.ChckSelfDefence)
        Me.Controls.Add(Me.ChckSpecialTechnique)
        Me.Controls.Add(Me.ChckSparring)
        Me.Controls.Add(Me.ChckPatterns)
        Me.Controls.Add(Me.GridStudents)
        Me.Controls.Add(Me.LblTournamentName)
        Me.Name = "BulkSignup"
        Me.Text = "BulkSignup"
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTournamentName As Label
    Friend WithEvents GridStudents As DataGridView
    Friend WithEvents ChckSelfDefence As CheckBox
    Friend WithEvents ChckSpecialTechnique As CheckBox
    Friend WithEvents ChckSparring As CheckBox
    Friend WithEvents ChckPatterns As CheckBox
    Friend WithEvents BtnApply As Button
    Friend WithEvents StudentList As DataGridViewTextBoxColumn
    Friend WithEvents Buttons As DataGridViewCheckBoxColumn
End Class
