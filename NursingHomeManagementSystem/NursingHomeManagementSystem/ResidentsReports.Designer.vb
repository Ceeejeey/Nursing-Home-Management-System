<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResidentsReports
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResidentsDataDataGridView = New System.Windows.Forms.DataGridView()
        Me.ResidentsDataReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.buttonResidentsData = New System.Windows.Forms.Button()
        Me.buttonGenerateReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ResidentsDataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.ResidentsDataDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(706, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 550)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ResidentsDataReportViewer)
        Me.Panel2.Location = New System.Drawing.Point(12, 284)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(677, 347)
        Me.Panel2.TabIndex = 0
        '
        'ResidentsDataDataGridView
        '
        Me.ResidentsDataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResidentsDataDataGridView.Location = New System.Drawing.Point(16, 97)
        Me.ResidentsDataDataGridView.Name = "ResidentsDataDataGridView"
        Me.ResidentsDataDataGridView.RowHeadersWidth = 51
        Me.ResidentsDataDataGridView.RowTemplate.Height = 24
        Me.ResidentsDataDataGridView.Size = New System.Drawing.Size(596, 502)
        Me.ResidentsDataDataGridView.TabIndex = 1
        '
        'ResidentsDataReportViewer
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Nothing
        Me.ResidentsDataReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ResidentsDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.Report1.rdlc"
        Me.ResidentsDataReportViewer.Location = New System.Drawing.Point(14, 16)
        Me.ResidentsDataReportViewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ResidentsDataReportViewer.Name = "ResidentsDataReportViewer"
        Me.ResidentsDataReportViewer.ServerReport.BearerToken = Nothing
        Me.ResidentsDataReportViewer.Size = New System.Drawing.Size(649, 311)
        Me.ResidentsDataReportViewer.TabIndex = 32
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.buttonGenerateReport)
        Me.Panel3.Controls.Add(Me.buttonResidentsData)
        Me.Panel3.Location = New System.Drawing.Point(12, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(677, 182)
        Me.Panel3.TabIndex = 1
        '
        'buttonResidentsData
        '
        Me.buttonResidentsData.Location = New System.Drawing.Point(159, 97)
        Me.buttonResidentsData.Name = "buttonResidentsData"
        Me.buttonResidentsData.Size = New System.Drawing.Size(172, 51)
        Me.buttonResidentsData.TabIndex = 0
        Me.buttonResidentsData.Text = "Load All Residents Data"
        Me.buttonResidentsData.UseVisualStyleBackColor = True
        '
        'buttonGenerateReport
        '
        Me.buttonGenerateReport.Location = New System.Drawing.Point(401, 97)
        Me.buttonGenerateReport.Name = "buttonGenerateReport"
        Me.buttonGenerateReport.Size = New System.Drawing.Size(158, 51)
        Me.buttonGenerateReport.TabIndex = 1
        Me.buttonGenerateReport.Text = "Generate Report"
        Me.buttonGenerateReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1347, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Residents Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(219, 40)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(100, 22)
        Me.textsearch.TabIndex = 2
        '
        'Butsearch
        '
        Me.Butsearch.Location = New System.Drawing.Point(384, 39)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(75, 23)
        Me.Butsearch.TabIndex = 3
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = True
        '
        'ResidentsReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1347, 643)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ResidentsReports"
        Me.Text = "ResidentsReports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ResidentsDataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResidentsDataDataGridView As DataGridView
    Friend WithEvents ResidentsDataReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents buttonGenerateReport As Button
    Friend WithEvents buttonResidentsData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textsearch As TextBox
    Friend WithEvents Butsearch As Button
End Class
