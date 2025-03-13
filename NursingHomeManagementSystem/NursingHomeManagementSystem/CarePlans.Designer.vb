<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarePlans
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CarePlansDataGridView = New System.Windows.Forms.DataGridView()
        Me.labelResidentID = New System.Windows.Forms.Label()
        Me.labelcareplan = New System.Windows.Forms.Label()
        Me.labelStartDate = New System.Windows.Forms.Label()
        Me.labelEndDate = New System.Windows.Forms.Label()
        Me.labelProgressNotes = New System.Windows.Forms.Label()
        Me.textResidentID = New System.Windows.Forms.TextBox()
        Me.textCarePlanDescription = New System.Windows.Forms.TextBox()
        Me.textProgressNotes = New System.Windows.Forms.TextBox()
        Me.dateTimeStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dateTimeEndDate = New System.Windows.Forms.DateTimePicker()
        Me.buttonAddPlan = New System.Windows.Forms.Button()
        Me.buttonUpdatePlan = New System.Windows.Forms.Button()
        Me.buttonDeletePlan = New System.Windows.Forms.Button()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.CarePlansDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1333, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Care Plans"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.CarePlansDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(611, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 567)
        Me.Panel1.TabIndex = 1
        '
        'CarePlansDataGridView
        '
        Me.CarePlansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarePlansDataGridView.Location = New System.Drawing.Point(24, 184)
        Me.CarePlansDataGridView.Name = "CarePlansDataGridView"
        Me.CarePlansDataGridView.RowHeadersWidth = 51
        Me.CarePlansDataGridView.RowTemplate.Height = 24
        Me.CarePlansDataGridView.Size = New System.Drawing.Size(677, 373)
        Me.CarePlansDataGridView.TabIndex = 2
        '
        'labelResidentID
        '
        Me.labelResidentID.AutoSize = True
        Me.labelResidentID.Location = New System.Drawing.Point(31, 192)
        Me.labelResidentID.Name = "labelResidentID"
        Me.labelResidentID.Size = New System.Drawing.Size(77, 16)
        Me.labelResidentID.TabIndex = 2
        Me.labelResidentID.Text = "Resident ID"
        '
        'labelcareplan
        '
        Me.labelcareplan.AutoSize = True
        Me.labelcareplan.Location = New System.Drawing.Point(31, 233)
        Me.labelcareplan.Name = "labelcareplan"
        Me.labelcareplan.Size = New System.Drawing.Size(137, 16)
        Me.labelcareplan.TabIndex = 3
        Me.labelcareplan.Text = "Care Plan Description"
        '
        'labelStartDate
        '
        Me.labelStartDate.AutoSize = True
        Me.labelStartDate.Location = New System.Drawing.Point(31, 280)
        Me.labelStartDate.Name = "labelStartDate"
        Me.labelStartDate.Size = New System.Drawing.Size(66, 16)
        Me.labelStartDate.TabIndex = 4
        Me.labelStartDate.Text = "Start Date"
        '
        'labelEndDate
        '
        Me.labelEndDate.AutoSize = True
        Me.labelEndDate.Location = New System.Drawing.Point(31, 326)
        Me.labelEndDate.Name = "labelEndDate"
        Me.labelEndDate.Size = New System.Drawing.Size(63, 16)
        Me.labelEndDate.TabIndex = 5
        Me.labelEndDate.Text = "End Date"
        '
        'labelProgressNotes
        '
        Me.labelProgressNotes.AutoSize = True
        Me.labelProgressNotes.Location = New System.Drawing.Point(31, 372)
        Me.labelProgressNotes.Name = "labelProgressNotes"
        Me.labelProgressNotes.Size = New System.Drawing.Size(101, 16)
        Me.labelProgressNotes.TabIndex = 6
        Me.labelProgressNotes.Text = "Progress Notes"
        '
        'textResidentID
        '
        Me.textResidentID.Location = New System.Drawing.Point(187, 186)
        Me.textResidentID.Name = "textResidentID"
        Me.textResidentID.Size = New System.Drawing.Size(200, 22)
        Me.textResidentID.TabIndex = 7
        '
        'textCarePlanDescription
        '
        Me.textCarePlanDescription.Location = New System.Drawing.Point(187, 227)
        Me.textCarePlanDescription.Name = "textCarePlanDescription"
        Me.textCarePlanDescription.Size = New System.Drawing.Size(200, 22)
        Me.textCarePlanDescription.TabIndex = 8
        '
        'textProgressNotes
        '
        Me.textProgressNotes.Location = New System.Drawing.Point(187, 366)
        Me.textProgressNotes.Name = "textProgressNotes"
        Me.textProgressNotes.Size = New System.Drawing.Size(200, 22)
        Me.textProgressNotes.TabIndex = 9
        '
        'dateTimeStartDate
        '
        Me.dateTimeStartDate.Location = New System.Drawing.Point(187, 274)
        Me.dateTimeStartDate.Name = "dateTimeStartDate"
        Me.dateTimeStartDate.Size = New System.Drawing.Size(200, 22)
        Me.dateTimeStartDate.TabIndex = 10
        '
        'dateTimeEndDate
        '
        Me.dateTimeEndDate.Location = New System.Drawing.Point(187, 321)
        Me.dateTimeEndDate.Name = "dateTimeEndDate"
        Me.dateTimeEndDate.Size = New System.Drawing.Size(200, 22)
        Me.dateTimeEndDate.TabIndex = 11
        '
        'buttonAddPlan
        '
        Me.buttonAddPlan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonAddPlan.Location = New System.Drawing.Point(72, 485)
        Me.buttonAddPlan.Name = "buttonAddPlan"
        Me.buttonAddPlan.Size = New System.Drawing.Size(123, 50)
        Me.buttonAddPlan.TabIndex = 12
        Me.buttonAddPlan.Text = "Add Care Plan"
        Me.buttonAddPlan.UseVisualStyleBackColor = False
        '
        'buttonUpdatePlan
        '
        Me.buttonUpdatePlan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonUpdatePlan.Location = New System.Drawing.Point(253, 485)
        Me.buttonUpdatePlan.Name = "buttonUpdatePlan"
        Me.buttonUpdatePlan.Size = New System.Drawing.Size(137, 50)
        Me.buttonUpdatePlan.TabIndex = 13
        Me.buttonUpdatePlan.Text = "Update Care Plan"
        Me.buttonUpdatePlan.UseVisualStyleBackColor = False
        '
        'buttonDeletePlan
        '
        Me.buttonDeletePlan.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonDeletePlan.Location = New System.Drawing.Point(431, 485)
        Me.buttonDeletePlan.Name = "buttonDeletePlan"
        Me.buttonDeletePlan.Size = New System.Drawing.Size(134, 50)
        Me.buttonDeletePlan.TabIndex = 14
        Me.buttonDeletePlan.Text = "Delete Care Plan"
        Me.buttonDeletePlan.UseVisualStyleBackColor = False
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.Location = New System.Drawing.Point(294, 52)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(98, 33)
        Me.Butsearch.TabIndex = 15
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(122, 57)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(147, 22)
        Me.textsearch.TabIndex = 16
        '
        'CarePlans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 622)
        Me.Controls.Add(Me.buttonDeletePlan)
        Me.Controls.Add(Me.buttonUpdatePlan)
        Me.Controls.Add(Me.buttonAddPlan)
        Me.Controls.Add(Me.dateTimeEndDate)
        Me.Controls.Add(Me.dateTimeStartDate)
        Me.Controls.Add(Me.textProgressNotes)
        Me.Controls.Add(Me.textCarePlanDescription)
        Me.Controls.Add(Me.textResidentID)
        Me.Controls.Add(Me.labelProgressNotes)
        Me.Controls.Add(Me.labelEndDate)
        Me.Controls.Add(Me.labelStartDate)
        Me.Controls.Add(Me.labelcareplan)
        Me.Controls.Add(Me.labelResidentID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CarePlans"
        Me.Text = "CarePlans"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CarePlansDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CarePlansDataGridView As DataGridView
    Friend WithEvents labelResidentID As Label
    Friend WithEvents labelcareplan As Label
    Friend WithEvents labelStartDate As Label
    Friend WithEvents labelEndDate As Label
    Friend WithEvents labelProgressNotes As Label
    Friend WithEvents textResidentID As TextBox
    Friend WithEvents textCarePlanDescription As TextBox
    Friend WithEvents textProgressNotes As TextBox
    Friend WithEvents dateTimeStartDate As DateTimePicker
    Friend WithEvents dateTimeEndDate As DateTimePicker
    Friend WithEvents Butsearch As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents buttonAddPlan As Button
    Friend WithEvents buttonUpdatePlan As Button
    Friend WithEvents buttonDeletePlan As Button
End Class
