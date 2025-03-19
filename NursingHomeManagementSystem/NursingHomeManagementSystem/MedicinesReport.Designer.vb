<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicinesReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicinesReport))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButSearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.MedicinesUsageReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MedicinesDataDataReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.buttonGenerateReport = New System.Windows.Forms.Button()
        Me.buttonLoadMedicines = New System.Windows.Forms.Button()
        Me.MedicinesUsage = New System.Windows.Forms.BindingSource(Me.components)
        Me.MedicineUsageDataSet = New NursingHomeManagementSystem.MedicineUsageDataSet()
        Me.Panel1.SuspendLayout()
        CType(Me.MedicinesUsageReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.MedicinesUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicineUsageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.ButSearch)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.MedicinesUsageReportDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(596, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 558)
        Me.Panel1.TabIndex = 0
        '
        'ButSearch
        '
        Me.ButSearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButSearch.Location = New System.Drawing.Point(352, 23)
        Me.ButSearch.Name = "ButSearch"
        Me.ButSearch.Size = New System.Drawing.Size(98, 40)
        Me.ButSearch.TabIndex = 5
        Me.ButSearch.Text = "Search"
        Me.ButSearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(155, 32)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(174, 22)
        Me.textsearch.TabIndex = 2
        '
        'MedicinesUsageReportDataGridView
        '
        Me.MedicinesUsageReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MedicinesUsageReportDataGridView.Location = New System.Drawing.Point(12, 129)
        Me.MedicinesUsageReportDataGridView.Name = "MedicinesUsageReportDataGridView"
        Me.MedicinesUsageReportDataGridView.RowHeadersWidth = 51
        Me.MedicinesUsageReportDataGridView.RowTemplate.Height = 24
        Me.MedicinesUsageReportDataGridView.Size = New System.Drawing.Size(637, 417)
        Me.MedicinesUsageReportDataGridView.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.MedicinesDataDataReportViewer)
        Me.Panel2.Location = New System.Drawing.Point(12, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 285)
        Me.Panel2.TabIndex = 1
        '
        'MedicinesDataDataReportViewer
        '
        Me.MedicinesDataDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.MedicineUsageReport.rdlc"
        Me.MedicinesDataDataReportViewer.Location = New System.Drawing.Point(15, 15)
        Me.MedicinesDataDataReportViewer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MedicinesDataDataReportViewer.Name = "MedicinesDataDataReportViewer"
        Me.MedicinesDataDataReportViewer.ServerReport.BearerToken = Nothing
        Me.MedicinesDataDataReportViewer.Size = New System.Drawing.Size(560, 258)
        Me.MedicinesDataDataReportViewer.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1257, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Medicines Usage Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.buttonGenerateReport)
        Me.Panel3.Controls.Add(Me.buttonLoadMedicines)
        Me.Panel3.Location = New System.Drawing.Point(12, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(578, 257)
        Me.Panel3.TabIndex = 3
        '
        'buttonGenerateReport
        '
        Me.buttonGenerateReport.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonGenerateReport.Location = New System.Drawing.Point(357, 103)
        Me.buttonGenerateReport.Name = "buttonGenerateReport"
        Me.buttonGenerateReport.Size = New System.Drawing.Size(155, 47)
        Me.buttonGenerateReport.TabIndex = 1
        Me.buttonGenerateReport.Text = "Generate Report"
        Me.buttonGenerateReport.UseVisualStyleBackColor = False
        '
        'buttonLoadMedicines
        '
        Me.buttonLoadMedicines.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonLoadMedicines.Location = New System.Drawing.Point(115, 103)
        Me.buttonLoadMedicines.Name = "buttonLoadMedicines"
        Me.buttonLoadMedicines.Size = New System.Drawing.Size(161, 47)
        Me.buttonLoadMedicines.TabIndex = 0
        Me.buttonLoadMedicines.Text = "Load Medicineas Data"
        Me.buttonLoadMedicines.UseVisualStyleBackColor = False
        '
        'MedicineUsageDataSet
        '
        Me.MedicineUsageDataSet.DataSetName = "MedicineUsageDataSet"
        Me.MedicineUsageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicinesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1257, 653)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MedicinesReport"
        Me.Text = "MedicinesReport"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MedicinesUsageReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.MedicinesUsage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicineUsageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MedicinesUsageReportDataGridView As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents buttonGenerateReport As Button
    Friend WithEvents buttonLoadMedicines As Button
    Friend WithEvents ButSearch As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents MedicinesDataDataReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MedicinesUsage As BindingSource
    Friend WithEvents MedicineUsageDataSet As MedicineUsageDataSet
End Class
