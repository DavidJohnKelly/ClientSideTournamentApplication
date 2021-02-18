<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultsForm
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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend7 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend8 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.LstResults = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ChrtPatterns = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChrtSparring = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChrtSpecialTechnique = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChrtSelfDefence = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.ChrtPatterns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrtSparring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrtSpecialTechnique, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChrtSelfDefence, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LstResults
        '
        Me.LstResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstResults.FormattingEnabled = True
        Me.LstResults.HorizontalScrollbar = True
        Me.LstResults.ItemHeight = 29
        Me.LstResults.Location = New System.Drawing.Point(12, 53)
        Me.LstResults.Name = "LstResults"
        Me.LstResults.Size = New System.Drawing.Size(400, 613)
        Me.LstResults.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Results"
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(112, 10)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(300, 34)
        Me.TxtSearch.TabIndex = 2
        '
        'ChrtPatterns
        '
        ChartArea5.Name = "ChartArea1"
        Me.ChrtPatterns.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.ChrtPatterns.Legends.Add(Legend5)
        Me.ChrtPatterns.Location = New System.Drawing.Point(418, 53)
        Me.ChrtPatterns.Name = "ChrtPatterns"
        Me.ChrtPatterns.Size = New System.Drawing.Size(372, 300)
        Me.ChrtPatterns.TabIndex = 3
        Me.ChrtPatterns.Text = "Pattern Statistics"
        '
        'ChrtSparring
        '
        ChartArea6.Name = "ChartArea1"
        Me.ChrtSparring.ChartAreas.Add(ChartArea6)
        Legend6.Name = "Legend1"
        Me.ChrtSparring.Legends.Add(Legend6)
        Me.ChrtSparring.Location = New System.Drawing.Point(809, 53)
        Me.ChrtSparring.Name = "ChrtSparring"
        Me.ChrtSparring.Size = New System.Drawing.Size(372, 300)
        Me.ChrtSparring.TabIndex = 4
        Me.ChrtSparring.Text = "Pattern Statistics"
        '
        'ChrtSpecialTechnique
        '
        ChartArea7.Name = "ChartArea1"
        Me.ChrtSpecialTechnique.ChartAreas.Add(ChartArea7)
        Legend7.Name = "Legend1"
        Me.ChrtSpecialTechnique.Legends.Add(Legend7)
        Me.ChrtSpecialTechnique.Location = New System.Drawing.Point(809, 365)
        Me.ChrtSpecialTechnique.Name = "ChrtSpecialTechnique"
        Me.ChrtSpecialTechnique.Size = New System.Drawing.Size(372, 300)
        Me.ChrtSpecialTechnique.TabIndex = 6
        Me.ChrtSpecialTechnique.Text = "Pattern Statistics"
        '
        'ChrtSelfDefence
        '
        ChartArea8.Name = "ChartArea1"
        Me.ChrtSelfDefence.ChartAreas.Add(ChartArea8)
        Legend8.Name = "Legend1"
        Me.ChrtSelfDefence.Legends.Add(Legend8)
        Me.ChrtSelfDefence.Location = New System.Drawing.Point(418, 365)
        Me.ChrtSelfDefence.Name = "ChrtSelfDefence"
        Me.ChrtSelfDefence.Size = New System.Drawing.Size(372, 300)
        Me.ChrtSelfDefence.TabIndex = 5
        Me.ChrtSelfDefence.Text = "Pattern Statistics"
        '
        'ResultsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1193, 689)
        Me.Controls.Add(Me.ChrtSpecialTechnique)
        Me.Controls.Add(Me.ChrtSelfDefence)
        Me.Controls.Add(Me.ChrtSparring)
        Me.Controls.Add(Me.ChrtPatterns)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LstResults)
        Me.Name = "ResultsForm"
        Me.Text = "ResultsForm"
        CType(Me.ChrtPatterns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrtSparring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrtSpecialTechnique, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChrtSelfDefence, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstResults As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ChrtPatterns As DataVisualization.Charting.Chart
    Friend WithEvents ChrtSparring As DataVisualization.Charting.Chart
    Friend WithEvents ChrtSpecialTechnique As DataVisualization.Charting.Chart
    Friend WithEvents ChrtSelfDefence As DataVisualization.Charting.Chart
End Class
