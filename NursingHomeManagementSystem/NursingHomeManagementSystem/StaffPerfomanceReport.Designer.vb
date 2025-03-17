<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPerfomanceReport
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StaffPerfomanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.buttonLoadStaffPerfomance = New System.Windows.Forms.Button()
        Me.buttonGenerateReport = New System.Windows.Forms.Button()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.StaffPerfomanceDataReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.StaffPerfomanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffPerfomanceDataSet = New NursingHomeManagementSystem.StaffPerfomanceDataSet()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.StaffPerfomanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffPerfomanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffPerfomanceDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1331, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Perfomance Reports"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.StaffPerfomanceDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(663, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 578)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.StaffPerfomanceDataReportViewer)
        Me.Panel2.Location = New System.Drawing.Point(12, 302)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(645, 329)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.buttonGenerateReport)
        Me.Panel3.Controls.Add(Me.buttonLoadStaffPerfomance)
        Me.Panel3.Location = New System.Drawing.Point(12, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(645, 243)
        Me.Panel3.TabIndex = 3
        '
        'StaffPerfomanceDataGridView
        '
        Me.StaffPerfomanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffPerfomanceDataGridView.Location = New System.Drawing.Point(12, 166)
        Me.StaffPerfomanceDataGridView.Name = "StaffPerfomanceDataGridView"
        Me.StaffPerfomanceDataGridView.RowHeadersWidth = 51
        Me.StaffPerfomanceDataGridView.RowTemplate.Height = 24
        Me.StaffPerfomanceDataGridView.Size = New System.Drawing.Size(641, 409)
        Me.StaffPerfomanceDataGridView.TabIndex = 0
        '
        'buttonLoadStaffPerfomance
        '
        Me.buttonLoadStaffPerfomance.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonLoadStaffPerfomance.Location = New System.Drawing.Point(143, 83)
        Me.buttonLoadStaffPerfomance.Name = "buttonLoadStaffPerfomance"
        Me.buttonLoadStaffPerfomance.Size = New System.Drawing.Size(172, 46)
        Me.buttonLoadStaffPerfomance.TabIndex = 1
        Me.buttonLoadStaffPerfomance.Text = "Load Staff Perfomance"
        Me.buttonLoadStaffPerfomance.UseVisualStyleBackColor = False
        '
        'buttonGenerateReport
        '
        Me.buttonGenerateReport.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonGenerateReport.Location = New System.Drawing.Point(353, 83)
        Me.buttonGenerateReport.Name = "buttonGenerateReport"
        Me.buttonGenerateReport.Size = New System.Drawing.Size(160, 46)
        Me.buttonGenerateReport.TabIndex = 2
        Me.buttonGenerateReport.Text = "Generate Report"
        Me.buttonGenerateReport.UseVisualStyleBackColor = False
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.Location = New System.Drawing.Point(325, 66)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(102, 34)
        Me.Butsearch.TabIndex = 3
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(135, 72)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(169, 22)
        Me.textsearch.TabIndex = 4
        '
        'StaffPerfomanceDataReportViewer
        '
        Me.StaffPerfomanceDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.MedicineUsageReport.rdlc"
        Me.StaffPerfomanceDataReportViewer.Location = New System.Drawing.Point(10, 19)
        Me.StaffPerfomanceDataReportViewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.StaffPerfomanceDataReportViewer.Name = "StaffPerfomanceDataReportViewer"
        Me.StaffPerfomanceDataReportViewer.ServerReport.BearerToken = Nothing
        Me.StaffPerfomanceDataReportViewer.Size = New System.Drawing.Size(625, 295)
        Me.StaffPerfomanceDataReportViewer.TabIndex = 34
        '
        'StaffPerfomanceBindingSource
        '
        Me.StaffPerfomanceBindingSource.DataSource = Me.StaffPerfomanceDataSet
        Me.StaffPerfomanceBindingSource.Position = 0
        '
        'StaffPerfomanceDataSet
        '
        Me.StaffPerfomanceDataSet.DataSetName = "StaffPerfomanceDataSet"
        Me.StaffPerfomanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffPerfomanceReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1331, 643)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffPerfomanceReport"
        Me.Text = "StaffPerfomanceReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.StaffPerfomanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffPerfomanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffPerfomanceDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents StaffPerfomanceDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents buttonLoadStaffPerfomance As Button
    Friend WithEvents Butsearch As Button
    Friend WithEvents buttonGenerateReport As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents StaffPerfomanceDataReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents StaffPerfomanceBindingSource As BindingSource
    Friend WithEvents StaffPerfomanceDataSet As StaffPerfomanceDataSet
End Class
