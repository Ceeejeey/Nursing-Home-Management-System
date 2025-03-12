<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicinesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IssueMedicineDataGridView = New System.Windows.Forms.DataGridView()
        Me.labelResidentID = New System.Windows.Forms.Label()
        Me.labelMedicineName = New System.Windows.Forms.Label()
        Me.labelDosage = New System.Windows.Forms.Label()
        Me.labelFrequency = New System.Windows.Forms.Label()
        Me.labelStartDate = New System.Windows.Forms.Label()
        Me.labelEndDate = New System.Windows.Forms.Label()
        Me.labelDrugIssues = New System.Windows.Forms.Label()
        Me.textResidentID = New System.Windows.Forms.TextBox()
        Me.textMedicineName = New System.Windows.Forms.TextBox()
        Me.textDosage = New System.Windows.Forms.TextBox()
        Me.textFrequency = New System.Windows.Forms.TextBox()
        Me.textDrugIssues = New System.Windows.Forms.TextBox()
        Me.dateTimeStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dateTimeEndDate = New System.Windows.Forms.DateTimePicker()
        Me.ButAddMedicine = New System.Windows.Forms.Button()
        Me.ButUpdate = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.IssueMedicineDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1322, 50)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Issue Medicines To Resident"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.IssueMedicineDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(668, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 513)
        Me.Panel1.TabIndex = 2
        '
        'IssueMedicineDataGridView
        '
        Me.IssueMedicineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssueMedicineDataGridView.Location = New System.Drawing.Point(17, 144)
        Me.IssueMedicineDataGridView.Name = "IssueMedicineDataGridView"
        Me.IssueMedicineDataGridView.RowHeadersWidth = 51
        Me.IssueMedicineDataGridView.RowTemplate.Height = 24
        Me.IssueMedicineDataGridView.Size = New System.Drawing.Size(627, 357)
        Me.IssueMedicineDataGridView.TabIndex = 3
        '
        'labelResidentID
        '
        Me.labelResidentID.AutoSize = True
        Me.labelResidentID.Location = New System.Drawing.Point(39, 151)
        Me.labelResidentID.Name = "labelResidentID"
        Me.labelResidentID.Size = New System.Drawing.Size(77, 16)
        Me.labelResidentID.TabIndex = 3
        Me.labelResidentID.Text = "Resident ID"
        '
        'labelMedicineName
        '
        Me.labelMedicineName.AutoSize = True
        Me.labelMedicineName.Location = New System.Drawing.Point(39, 185)
        Me.labelMedicineName.Name = "labelMedicineName"
        Me.labelMedicineName.Size = New System.Drawing.Size(102, 16)
        Me.labelMedicineName.TabIndex = 4
        Me.labelMedicineName.Text = "Medicine Name"
        '
        'labelDosage
        '
        Me.labelDosage.AutoSize = True
        Me.labelDosage.Location = New System.Drawing.Point(39, 219)
        Me.labelDosage.Name = "labelDosage"
        Me.labelDosage.Size = New System.Drawing.Size(56, 16)
        Me.labelDosage.TabIndex = 5
        Me.labelDosage.Text = "Dosage"
        '
        'labelFrequency
        '
        Me.labelFrequency.AutoSize = True
        Me.labelFrequency.Location = New System.Drawing.Point(39, 256)
        Me.labelFrequency.Name = "labelFrequency"
        Me.labelFrequency.Size = New System.Drawing.Size(71, 16)
        Me.labelFrequency.TabIndex = 6
        Me.labelFrequency.Text = "Frequency"
        '
        'labelStartDate
        '
        Me.labelStartDate.AutoSize = True
        Me.labelStartDate.Location = New System.Drawing.Point(39, 290)
        Me.labelStartDate.Name = "labelStartDate"
        Me.labelStartDate.Size = New System.Drawing.Size(66, 16)
        Me.labelStartDate.TabIndex = 7
        Me.labelStartDate.Text = "Start Date"
        '
        'labelEndDate
        '
        Me.labelEndDate.AutoSize = True
        Me.labelEndDate.Location = New System.Drawing.Point(39, 326)
        Me.labelEndDate.Name = "labelEndDate"
        Me.labelEndDate.Size = New System.Drawing.Size(63, 16)
        Me.labelEndDate.TabIndex = 8
        Me.labelEndDate.Text = "End Date"
        '
        'labelDrugIssues
        '
        Me.labelDrugIssues.AutoSize = True
        Me.labelDrugIssues.Location = New System.Drawing.Point(39, 359)
        Me.labelDrugIssues.Name = "labelDrugIssues"
        Me.labelDrugIssues.Size = New System.Drawing.Size(78, 16)
        Me.labelDrugIssues.TabIndex = 9
        Me.labelDrugIssues.Text = "Drug Issues"
        '
        'textResidentID
        '
        Me.textResidentID.Location = New System.Drawing.Point(199, 145)
        Me.textResidentID.Name = "textResidentID"
        Me.textResidentID.Size = New System.Drawing.Size(230, 22)
        Me.textResidentID.TabIndex = 10
        '
        'textMedicineName
        '
        Me.textMedicineName.Location = New System.Drawing.Point(199, 179)
        Me.textMedicineName.Name = "textMedicineName"
        Me.textMedicineName.Size = New System.Drawing.Size(230, 22)
        Me.textMedicineName.TabIndex = 11
        '
        'textDosage
        '
        Me.textDosage.Location = New System.Drawing.Point(199, 213)
        Me.textDosage.Name = "textDosage"
        Me.textDosage.Size = New System.Drawing.Size(230, 22)
        Me.textDosage.TabIndex = 12
        '
        'textFrequency
        '
        Me.textFrequency.Location = New System.Drawing.Point(199, 250)
        Me.textFrequency.Name = "textFrequency"
        Me.textFrequency.Size = New System.Drawing.Size(230, 22)
        Me.textFrequency.TabIndex = 13
        '
        'textDrugIssues
        '
        Me.textDrugIssues.Location = New System.Drawing.Point(199, 353)
        Me.textDrugIssues.Name = "textDrugIssues"
        Me.textDrugIssues.Size = New System.Drawing.Size(230, 22)
        Me.textDrugIssues.TabIndex = 14
        '
        'dateTimeStartDate
        '
        Me.dateTimeStartDate.Location = New System.Drawing.Point(199, 285)
        Me.dateTimeStartDate.Name = "dateTimeStartDate"
        Me.dateTimeStartDate.Size = New System.Drawing.Size(230, 22)
        Me.dateTimeStartDate.TabIndex = 15
        '
        'dateTimeEndDate
        '
        Me.dateTimeEndDate.Location = New System.Drawing.Point(199, 320)
        Me.dateTimeEndDate.Name = "dateTimeEndDate"
        Me.dateTimeEndDate.Size = New System.Drawing.Size(230, 22)
        Me.dateTimeEndDate.TabIndex = 16
        '
        'ButAddMedicine
        '
        Me.ButAddMedicine.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButAddMedicine.Location = New System.Drawing.Point(42, 440)
        Me.ButAddMedicine.Name = "ButAddMedicine"
        Me.ButAddMedicine.Size = New System.Drawing.Size(117, 49)
        Me.ButAddMedicine.TabIndex = 17
        Me.ButAddMedicine.Text = "Issue Medicine To Resident"
        Me.ButAddMedicine.UseVisualStyleBackColor = False
        '
        'ButUpdate
        '
        Me.ButUpdate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButUpdate.Location = New System.Drawing.Point(231, 440)
        Me.ButUpdate.Name = "ButUpdate"
        Me.ButUpdate.Size = New System.Drawing.Size(104, 49)
        Me.ButUpdate.TabIndex = 18
        Me.ButUpdate.Text = "Update Details"
        Me.ButUpdate.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ButDelete.Location = New System.Drawing.Point(416, 440)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(108, 49)
        Me.ButDelete.TabIndex = 19
        Me.ButDelete.Text = "Delete Details"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(197, 52)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(180, 22)
        Me.textsearch.TabIndex = 20
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.Location = New System.Drawing.Point(401, 46)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(112, 35)
        Me.Butsearch.TabIndex = 21
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'MedicinesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 578)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.ButUpdate)
        Me.Controls.Add(Me.ButAddMedicine)
        Me.Controls.Add(Me.dateTimeEndDate)
        Me.Controls.Add(Me.dateTimeStartDate)
        Me.Controls.Add(Me.textDrugIssues)
        Me.Controls.Add(Me.textFrequency)
        Me.Controls.Add(Me.textDosage)
        Me.Controls.Add(Me.textMedicineName)
        Me.Controls.Add(Me.textResidentID)
        Me.Controls.Add(Me.labelDrugIssues)
        Me.Controls.Add(Me.labelEndDate)
        Me.Controls.Add(Me.labelStartDate)
        Me.Controls.Add(Me.labelFrequency)
        Me.Controls.Add(Me.labelDosage)
        Me.Controls.Add(Me.labelMedicineName)
        Me.Controls.Add(Me.labelResidentID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MedicinesForm"
        Me.Text = "MedicinesForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IssueMedicineDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IssueMedicineDataGridView As DataGridView
    Friend WithEvents labelResidentID As Label
    Friend WithEvents labelMedicineName As Label
    Friend WithEvents labelDosage As Label
    Friend WithEvents labelFrequency As Label
    Friend WithEvents labelStartDate As Label
    Friend WithEvents labelEndDate As Label
    Friend WithEvents labelDrugIssues As Label
    Friend WithEvents textResidentID As TextBox
    Friend WithEvents textMedicineName As TextBox
    Friend WithEvents textDosage As TextBox
    Friend WithEvents textsearch As TextBox
    Friend WithEvents Butsearch As Button
    Friend WithEvents textFrequency As TextBox
    Friend WithEvents textDrugIssues As TextBox
    Friend WithEvents dateTimeStartDate As DateTimePicker
    Friend WithEvents dateTimeEndDate As DateTimePicker
    Friend WithEvents ButAddMedicine As Button
    Friend WithEvents ButUpdate As Button
    Friend WithEvents ButDelete As Button
End Class
