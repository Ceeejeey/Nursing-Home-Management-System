<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamilyCommunication
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
        Me.FamilyContactsDataGridView = New System.Windows.Forms.DataGridView()
        Me.labelResidentID = New System.Windows.Forms.Label()
        Me.labelFamilyContact = New System.Windows.Forms.Label()
        Me.labelContactDate = New System.Windows.Forms.Label()
        Me.labelContactMethod = New System.Windows.Forms.Label()
        Me.labelStaffID = New System.Windows.Forms.Label()
        Me.labelReasonForContact = New System.Windows.Forms.Label()
        Me.labelFollowUpRequired = New System.Windows.Forms.Label()
        Me.labelFollowUpDetails = New System.Windows.Forms.Label()
        Me.dateTimeContactDate = New System.Windows.Forms.DateTimePicker()
        Me.textContactMethod = New System.Windows.Forms.TextBox()
        Me.textFamilyContact = New System.Windows.Forms.TextBox()
        Me.textResidentID = New System.Windows.Forms.TextBox()
        Me.textStaffID = New System.Windows.Forms.TextBox()
        Me.textReasonForContact = New System.Windows.Forms.TextBox()
        Me.textFollowUpRequired = New System.Windows.Forms.TextBox()
        Me.textFollowUpDetails = New System.Windows.Forms.TextBox()
        Me.buttonAddFamilyContact = New System.Windows.Forms.Button()
        Me.buttonUpdateFamilyContact = New System.Windows.Forms.Button()
        Me.buttonDeleteFamilyContact = New System.Windows.Forms.Button()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.FamilyContactsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1329, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Family Communication"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.FamilyContactsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(661, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 556)
        Me.Panel1.TabIndex = 1
        '
        'FamilyContactsDataGridView
        '
        Me.FamilyContactsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FamilyContactsDataGridView.Location = New System.Drawing.Point(22, 148)
        Me.FamilyContactsDataGridView.Name = "FamilyContactsDataGridView"
        Me.FamilyContactsDataGridView.RowHeadersWidth = 51
        Me.FamilyContactsDataGridView.RowTemplate.Height = 24
        Me.FamilyContactsDataGridView.Size = New System.Drawing.Size(611, 388)
        Me.FamilyContactsDataGridView.TabIndex = 2
        '
        'labelResidentID
        '
        Me.labelResidentID.AutoSize = True
        Me.labelResidentID.Location = New System.Drawing.Point(57, 172)
        Me.labelResidentID.Name = "labelResidentID"
        Me.labelResidentID.Size = New System.Drawing.Size(77, 16)
        Me.labelResidentID.TabIndex = 3
        Me.labelResidentID.Text = "Resident ID"
        '
        'labelFamilyContact
        '
        Me.labelFamilyContact.AutoSize = True
        Me.labelFamilyContact.Location = New System.Drawing.Point(57, 212)
        Me.labelFamilyContact.Name = "labelFamilyContact"
        Me.labelFamilyContact.Size = New System.Drawing.Size(95, 16)
        Me.labelFamilyContact.TabIndex = 4
        Me.labelFamilyContact.Text = "Family Contact"
        '
        'labelContactDate
        '
        Me.labelContactDate.AutoSize = True
        Me.labelContactDate.Location = New System.Drawing.Point(57, 256)
        Me.labelContactDate.Name = "labelContactDate"
        Me.labelContactDate.Size = New System.Drawing.Size(84, 16)
        Me.labelContactDate.TabIndex = 5
        Me.labelContactDate.Text = "Contact Date"
        '
        'labelContactMethod
        '
        Me.labelContactMethod.AutoSize = True
        Me.labelContactMethod.Location = New System.Drawing.Point(57, 298)
        Me.labelContactMethod.Name = "labelContactMethod"
        Me.labelContactMethod.Size = New System.Drawing.Size(100, 16)
        Me.labelContactMethod.TabIndex = 6
        Me.labelContactMethod.Text = "Contact Method"
        '
        'labelStaffID
        '
        Me.labelStaffID.AutoSize = True
        Me.labelStaffID.Location = New System.Drawing.Point(57, 338)
        Me.labelStaffID.Name = "labelStaffID"
        Me.labelStaffID.Size = New System.Drawing.Size(49, 16)
        Me.labelStaffID.TabIndex = 7
        Me.labelStaffID.Text = "Staff ID"
        '
        'labelReasonForContact
        '
        Me.labelReasonForContact.AutoSize = True
        Me.labelReasonForContact.Location = New System.Drawing.Point(57, 382)
        Me.labelReasonForContact.Name = "labelReasonForContact"
        Me.labelReasonForContact.Size = New System.Drawing.Size(134, 16)
        Me.labelReasonForContact.TabIndex = 8
        Me.labelReasonForContact.Text = "Reaseon For Contact"
        '
        'labelFollowUpRequired
        '
        Me.labelFollowUpRequired.AutoSize = True
        Me.labelFollowUpRequired.Location = New System.Drawing.Point(57, 423)
        Me.labelFollowUpRequired.Name = "labelFollowUpRequired"
        Me.labelFollowUpRequired.Size = New System.Drawing.Size(126, 16)
        Me.labelFollowUpRequired.TabIndex = 9
        Me.labelFollowUpRequired.Text = "Follow Up Required"
        '
        'labelFollowUpDetails
        '
        Me.labelFollowUpDetails.AutoSize = True
        Me.labelFollowUpDetails.Location = New System.Drawing.Point(57, 464)
        Me.labelFollowUpDetails.Name = "labelFollowUpDetails"
        Me.labelFollowUpDetails.Size = New System.Drawing.Size(112, 16)
        Me.labelFollowUpDetails.TabIndex = 10
        Me.labelFollowUpDetails.Text = "Follow Up Details"
        '
        'dateTimeContactDate
        '
        Me.dateTimeContactDate.Location = New System.Drawing.Point(259, 250)
        Me.dateTimeContactDate.Name = "dateTimeContactDate"
        Me.dateTimeContactDate.Size = New System.Drawing.Size(200, 22)
        Me.dateTimeContactDate.TabIndex = 11
        '
        'textContactMethod
        '
        Me.textContactMethod.Location = New System.Drawing.Point(259, 292)
        Me.textContactMethod.Name = "textContactMethod"
        Me.textContactMethod.Size = New System.Drawing.Size(200, 22)
        Me.textContactMethod.TabIndex = 12
        '
        'textFamilyContact
        '
        Me.textFamilyContact.Location = New System.Drawing.Point(259, 206)
        Me.textFamilyContact.Name = "textFamilyContact"
        Me.textFamilyContact.Size = New System.Drawing.Size(200, 22)
        Me.textFamilyContact.TabIndex = 13
        '
        'textResidentID
        '
        Me.textResidentID.Location = New System.Drawing.Point(259, 166)
        Me.textResidentID.Name = "textResidentID"
        Me.textResidentID.Size = New System.Drawing.Size(200, 22)
        Me.textResidentID.TabIndex = 14
        '
        'textStaffID
        '
        Me.textStaffID.Location = New System.Drawing.Point(259, 332)
        Me.textStaffID.Name = "textStaffID"
        Me.textStaffID.Size = New System.Drawing.Size(200, 22)
        Me.textStaffID.TabIndex = 15
        '
        'textReasonForContact
        '
        Me.textReasonForContact.Location = New System.Drawing.Point(259, 376)
        Me.textReasonForContact.Name = "textReasonForContact"
        Me.textReasonForContact.Size = New System.Drawing.Size(200, 22)
        Me.textReasonForContact.TabIndex = 16
        '
        'textFollowUpRequired
        '
        Me.textFollowUpRequired.Location = New System.Drawing.Point(259, 417)
        Me.textFollowUpRequired.Name = "textFollowUpRequired"
        Me.textFollowUpRequired.Size = New System.Drawing.Size(200, 22)
        Me.textFollowUpRequired.TabIndex = 17
        '
        'textFollowUpDetails
        '
        Me.textFollowUpDetails.Location = New System.Drawing.Point(259, 458)
        Me.textFollowUpDetails.Name = "textFollowUpDetails"
        Me.textFollowUpDetails.Size = New System.Drawing.Size(200, 22)
        Me.textFollowUpDetails.TabIndex = 18
        '
        'buttonAddFamilyContact
        '
        Me.buttonAddFamilyContact.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonAddFamilyContact.Location = New System.Drawing.Point(77, 552)
        Me.buttonAddFamilyContact.Name = "buttonAddFamilyContact"
        Me.buttonAddFamilyContact.Size = New System.Drawing.Size(139, 57)
        Me.buttonAddFamilyContact.TabIndex = 19
        Me.buttonAddFamilyContact.Text = "Add New Family Contact"
        Me.buttonAddFamilyContact.UseVisualStyleBackColor = False
        '
        'buttonUpdateFamilyContact
        '
        Me.buttonUpdateFamilyContact.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonUpdateFamilyContact.Location = New System.Drawing.Point(259, 552)
        Me.buttonUpdateFamilyContact.Name = "buttonUpdateFamilyContact"
        Me.buttonUpdateFamilyContact.Size = New System.Drawing.Size(134, 57)
        Me.buttonUpdateFamilyContact.TabIndex = 20
        Me.buttonUpdateFamilyContact.Text = "Update Family Contacts"
        Me.buttonUpdateFamilyContact.UseVisualStyleBackColor = False
        '
        'buttonDeleteFamilyContact
        '
        Me.buttonDeleteFamilyContact.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonDeleteFamilyContact.Location = New System.Drawing.Point(442, 552)
        Me.buttonDeleteFamilyContact.Name = "buttonDeleteFamilyContact"
        Me.buttonDeleteFamilyContact.Size = New System.Drawing.Size(123, 57)
        Me.buttonDeleteFamilyContact.TabIndex = 21
        Me.buttonDeleteFamilyContact.Text = "Delete family Contacts"
        Me.buttonDeleteFamilyContact.UseVisualStyleBackColor = False
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.Location = New System.Drawing.Point(364, 59)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(100, 39)
        Me.Butsearch.TabIndex = 22
        Me.Butsearch.Text = "Search"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(157, 67)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(190, 22)
        Me.textsearch.TabIndex = 23
        '
        'FamilyCommunication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 621)
        Me.Controls.Add(Me.buttonDeleteFamilyContact)
        Me.Controls.Add(Me.buttonUpdateFamilyContact)
        Me.Controls.Add(Me.buttonAddFamilyContact)
        Me.Controls.Add(Me.textFollowUpDetails)
        Me.Controls.Add(Me.textFollowUpRequired)
        Me.Controls.Add(Me.textReasonForContact)
        Me.Controls.Add(Me.textStaffID)
        Me.Controls.Add(Me.textResidentID)
        Me.Controls.Add(Me.textFamilyContact)
        Me.Controls.Add(Me.textContactMethod)
        Me.Controls.Add(Me.dateTimeContactDate)
        Me.Controls.Add(Me.labelFollowUpDetails)
        Me.Controls.Add(Me.labelFollowUpRequired)
        Me.Controls.Add(Me.labelReasonForContact)
        Me.Controls.Add(Me.labelStaffID)
        Me.Controls.Add(Me.labelContactMethod)
        Me.Controls.Add(Me.labelContactDate)
        Me.Controls.Add(Me.labelFamilyContact)
        Me.Controls.Add(Me.labelResidentID)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FamilyCommunication"
        Me.Text = "FamilyCommunication"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.FamilyContactsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FamilyContactsDataGridView As DataGridView
    Friend WithEvents labelResidentID As Label
    Friend WithEvents labelFamilyContact As Label
    Friend WithEvents labelContactDate As Label
    Friend WithEvents labelContactMethod As Label
    Friend WithEvents labelStaffID As Label
    Friend WithEvents labelReasonForContact As Label
    Friend WithEvents labelFollowUpRequired As Label
    Friend WithEvents labelFollowUpDetails As Label
    Friend WithEvents dateTimeContactDate As DateTimePicker
    Friend WithEvents textContactMethod As TextBox
    Friend WithEvents textFamilyContact As TextBox
    Friend WithEvents textResidentID As TextBox
    Friend WithEvents textStaffID As TextBox
    Friend WithEvents textReasonForContact As TextBox
    Friend WithEvents textFollowUpRequired As TextBox
    Friend WithEvents textFollowUpDetails As TextBox
    Friend WithEvents buttonAddFamilyContact As Button
    Friend WithEvents buttonUpdateFamilyContact As Button
    Friend WithEvents buttonDeleteFamilyContact As Button
    Friend WithEvents Butsearch As Button
    Friend WithEvents textsearch As TextBox
End Class
