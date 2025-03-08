Imports System.Data.OleDb
Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Residents
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
		
		

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Residents))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Butupload = New System.Windows.Forms.Button()
        Me.picboxresidentphoto = New System.Windows.Forms.PictureBox()
        Me.txtcareplan = New System.Windows.Forms.TextBox()
        Me.dtpadmissiondate = New System.Windows.Forms.DateTimePicker()
        Me.dtpdateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.txtfamilycontact = New System.Windows.Forms.TextBox()
        Me.txtmedicalhistory = New System.Windows.Forms.TextBox()
        Me.txtfulname = New System.Windows.Forms.TextBox()
        Me.txtresidentsid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridViewresidentlist = New System.Windows.Forms.DataGridView()
        Me.Butdelete = New System.Windows.Forms.Button()
        Me.Butupdate = New System.Windows.Forms.Button()
        Me.Butadd = New System.Windows.Forms.Button()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        
        Me.ResidentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalHistoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarePlanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyContactPhoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmissionDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picboxresidentphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridViewresidentlist, System.ComponentModel.ISupportInitialize).BeginInit()
        
       
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1315, 51)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1315, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Residents Management"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel2.Controls.Add(Me.Butupload)
        Me.Panel2.Controls.Add(Me.picboxresidentphoto)
        Me.Panel2.Controls.Add(Me.txtcareplan)
        Me.Panel2.Controls.Add(Me.dtpadmissiondate)
        Me.Panel2.Controls.Add(Me.dtpdateofbirth)
        Me.Panel2.Controls.Add(Me.txtfamilycontact)
        Me.Panel2.Controls.Add(Me.txtmedicalhistory)
        Me.Panel2.Controls.Add(Me.txtfulname)
        Me.Panel2.Controls.Add(Me.txtresidentsid)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(621, 662)
        Me.Panel2.TabIndex = 1
        '
        'Butupload
        '
        Me.Butupload.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butupload.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Butupload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butupload.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butupload.Location = New System.Drawing.Point(482, 463)
        Me.Butupload.Name = "Butupload"
        Me.Butupload.Size = New System.Drawing.Size(93, 66)
        Me.Butupload.TabIndex = 16
        Me.Butupload.Text = "Upload Photo"
        Me.Butupload.UseVisualStyleBackColor = False
        '
        'picboxresidentphoto
        '
        Me.picboxresidentphoto.Image = CType(resources.GetObject("picboxresidentphoto.Image"), System.Drawing.Image)
        Me.picboxresidentphoto.Location = New System.Drawing.Point(217, 311)
        Me.picboxresidentphoto.Name = "picboxresidentphoto"
        Me.picboxresidentphoto.Size = New System.Drawing.Size(259, 292)
        Me.picboxresidentphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxresidentphoto.TabIndex = 15
        Me.picboxresidentphoto.TabStop = False
        '
        'txtcareplan
        '
        Me.txtcareplan.Location = New System.Drawing.Point(217, 188)
        Me.txtcareplan.Multiline = True
        Me.txtcareplan.Name = "txtcareplan"
        Me.txtcareplan.Size = New System.Drawing.Size(277, 27)
        Me.txtcareplan.TabIndex = 14
        Me.txtcareplan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtpadmissiondate
        '
        Me.dtpadmissiondate.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpadmissiondate.Location = New System.Drawing.Point(217, 221)
        Me.dtpadmissiondate.Name = "dtpadmissiondate"
        Me.dtpadmissiondate.Size = New System.Drawing.Size(277, 31)
        Me.dtpadmissiondate.TabIndex = 13
        Me.dtpadmissiondate.Value = New Date(2025, 2, 5, 21, 36, 26, 0)
        '
        'dtpdateofbirth
        '
        Me.dtpdateofbirth.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpdateofbirth.Location = New System.Drawing.Point(217, 95)
        Me.dtpdateofbirth.Name = "dtpdateofbirth"
        Me.dtpdateofbirth.Size = New System.Drawing.Size(277, 31)
        Me.dtpdateofbirth.TabIndex = 12
        '
        'txtfamilycontact
        '
        Me.txtfamilycontact.Location = New System.Drawing.Point(217, 263)
        Me.txtfamilycontact.Multiline = True
        Me.txtfamilycontact.Name = "txtfamilycontact"
        Me.txtfamilycontact.Size = New System.Drawing.Size(277, 27)
        Me.txtfamilycontact.TabIndex = 11
        Me.txtfamilycontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtmedicalhistory
        '
        Me.txtmedicalhistory.Location = New System.Drawing.Point(217, 142)
        Me.txtmedicalhistory.Multiline = True
        Me.txtmedicalhistory.Name = "txtmedicalhistory"
        Me.txtmedicalhistory.Size = New System.Drawing.Size(277, 27)
        Me.txtmedicalhistory.TabIndex = 10
        Me.txtmedicalhistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfulname
        '
        Me.txtfulname.Location = New System.Drawing.Point(217, 44)
        Me.txtfulname.Multiline = True
        Me.txtfulname.Name = "txtfulname"
        Me.txtfulname.Size = New System.Drawing.Size(277, 27)
        Me.txtfulname.TabIndex = 9
        Me.txtfulname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtresidentsid
        '
        Me.txtresidentsid.Location = New System.Drawing.Point(217, 8)
        Me.txtresidentsid.Multiline = True
        Me.txtresidentsid.Name = "txtresidentsid"
        Me.txtresidentsid.Size = New System.Drawing.Size(277, 27)
        Me.txtresidentsid.TabIndex = 8
        Me.txtresidentsid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 311)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(193, 29)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Resident Photo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 263)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 29)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Family Contact:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 223)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 29)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Admission Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Care Plan:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 29)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Medical History:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 29)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Resident ID:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.DataGridViewresidentlist)
        Me.Panel3.Controls.Add(Me.Butdelete)
        Me.Panel3.Controls.Add(Me.Butupdate)
        Me.Panel3.Controls.Add(Me.Butadd)
        Me.Panel3.Controls.Add(Me.Butsearch)
        Me.Panel3.Controls.Add(Me.textsearch)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(621, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 662)
        Me.Panel3.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("News706 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(227, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 29)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Resident List"
        '
        'DataGridViewresidentlist
        '
        Me.DataGridViewresidentlist.AllowUserToOrderColumns = True
        Me.DataGridViewresidentlist.AutoGenerateColumns = False
        Me.DataGridViewresidentlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewresidentlist.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ResidentIDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.MedicalHistoryDataGridViewTextBoxColumn, Me.CarePlanDataGridViewTextBoxColumn, Me.FamilyContactNameDataGridViewTextBoxColumn, Me.FamilyContactPhoneDataGridViewTextBoxColumn, Me.AdmissionDateDataGridViewTextBoxColumn})
       
        Me.DataGridViewresidentlist.Location = New System.Drawing.Point(29, 142)
        Me.DataGridViewresidentlist.Name = "DataGridViewresidentlist"
        Me.DataGridViewresidentlist.RowTemplate.Height = 28
        Me.DataGridViewresidentlist.Size = New System.Drawing.Size(640, 333)
        Me.DataGridViewresidentlist.TabIndex = 5
        '
        'Butdelete
        '
        Me.Butdelete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butdelete.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butdelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butdelete.Location = New System.Drawing.Point(529, 536)
        Me.Butdelete.Name = "Butdelete"
        Me.Butdelete.Padding = New System.Windows.Forms.Padding(1)
        Me.Butdelete.Size = New System.Drawing.Size(94, 43)
        Me.Butdelete.TabIndex = 4
        Me.Butdelete.Text = "Delete"
        Me.Butdelete.UseVisualStyleBackColor = False
        '
        'Butupdate
        '
        Me.Butupdate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butupdate.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butupdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butupdate.Location = New System.Drawing.Point(302, 536)
        Me.Butupdate.Name = "Butupdate"
        Me.Butupdate.Padding = New System.Windows.Forms.Padding(1)
        Me.Butupdate.Size = New System.Drawing.Size(94, 43)
        Me.Butupdate.TabIndex = 3
        Me.Butupdate.Text = "Update"
        Me.Butupdate.UseVisualStyleBackColor = False
        '
        'Butadd
        '
        Me.Butadd.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butadd.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butadd.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butadd.Location = New System.Drawing.Point(63, 536)
        Me.Butadd.Name = "Butadd"
        Me.Butadd.Padding = New System.Windows.Forms.Padding(1)
        Me.Butadd.Size = New System.Drawing.Size(94, 43)
        Me.Butadd.TabIndex = 2
        Me.Butadd.Text = "Add"
        Me.Butadd.UseVisualStyleBackColor = False
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butsearch.Font = New System.Drawing.Font("News706 BT", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butsearch.Image = CType(resources.GetObject("Butsearch.Image"), System.Drawing.Image)
        Me.Butsearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butsearch.Location = New System.Drawing.Point(416, 17)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Padding = New System.Windows.Forms.Padding(1)
        Me.Butsearch.Size = New System.Drawing.Size(112, 33)
        Me.Butsearch.TabIndex = 1
        Me.Butsearch.Text = "Search"
        Me.Butsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(124, 15)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(286, 43)
        Me.textsearch.TabIndex = 0
        '
        'NursingHomeManagemetSystemdbDataSet1
        '
        
       
        '
        'ResidentsTableBindingSource
        '
        
        '
        'ResidentsTableTableAdapter
        '
        
        '
        'ResidentIDDataGridViewTextBoxColumn
        '
        Me.ResidentIDDataGridViewTextBoxColumn.DataPropertyName = "ResidentID"
        Me.ResidentIDDataGridViewTextBoxColumn.HeaderText = "ResidentID"
        Me.ResidentIDDataGridViewTextBoxColumn.Name = "ResidentIDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'MedicalHistoryDataGridViewTextBoxColumn
        '
        Me.MedicalHistoryDataGridViewTextBoxColumn.DataPropertyName = "MedicalHistory"
        Me.MedicalHistoryDataGridViewTextBoxColumn.HeaderText = "MedicalHistory"
        Me.MedicalHistoryDataGridViewTextBoxColumn.Name = "MedicalHistoryDataGridViewTextBoxColumn"
        '
        'CarePlanDataGridViewTextBoxColumn
        '
        Me.CarePlanDataGridViewTextBoxColumn.DataPropertyName = "CarePlan"
        Me.CarePlanDataGridViewTextBoxColumn.HeaderText = "CarePlan"
        Me.CarePlanDataGridViewTextBoxColumn.Name = "CarePlanDataGridViewTextBoxColumn"
        '
        'FamilyContactNameDataGridViewTextBoxColumn
        '
        Me.FamilyContactNameDataGridViewTextBoxColumn.DataPropertyName = "FamilyContactName"
        Me.FamilyContactNameDataGridViewTextBoxColumn.HeaderText = "FamilyContactName"
        Me.FamilyContactNameDataGridViewTextBoxColumn.Name = "FamilyContactNameDataGridViewTextBoxColumn"
        '
        
        '
        'AdmissionDateDataGridViewTextBoxColumn
        '
        Me.AdmissionDateDataGridViewTextBoxColumn.DataPropertyName = "AdmissionDate"
        Me.AdmissionDateDataGridViewTextBoxColumn.HeaderText = "AdmissionDate"
        Me.AdmissionDateDataGridViewTextBoxColumn.Name = "AdmissionDateDataGridViewTextBoxColumn"
        '
        'Residents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(20.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 713)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("News706 BT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 5, 7, 5)
        Me.Name = "Residents"
        Me.Text = "Residents management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picboxresidentphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridViewresidentlist, System.ComponentModel.ISupportInitialize).EndInit()
        
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtcareplan As System.Windows.Forms.TextBox
    Friend WithEvents dtpadmissiondate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpdateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfamilycontact As System.Windows.Forms.TextBox
    Friend WithEvents txtmedicalhistory As System.Windows.Forms.TextBox
    Friend WithEvents txtfulname As System.Windows.Forms.TextBox
    Friend WithEvents txtresidentsid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Butupload As System.Windows.Forms.Button
    Friend WithEvents picboxresidentphoto As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewresidentlist As System.Windows.Forms.DataGridView
    Friend WithEvents Butdelete As System.Windows.Forms.Button
    Friend WithEvents Butupdate As System.Windows.Forms.Button
    Friend WithEvents Butadd As System.Windows.Forms.Button
    Friend WithEvents Butsearch As System.Windows.Forms.Button
    Friend WithEvents textsearch As System.Windows.Forms.TextBox

    Private Sub txtresidentsid_TextChanged(sender As Object, e As EventArgs) Handles txtresidentsid.TextChanged

    End Sub

    Private Sub picboxresidentphoto_Click(sender As Object, e As EventArgs) Handles picboxresidentphoto.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set file filter to allow only image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Title = "Select Resident's Photo"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            picboxresidentphoto.Image = Image.FromFile(openFileDialog.FileName)
            ' Resize the image to fit the PictureBox
            picboxresidentphoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Butupload_Click(sender As Object, e As EventArgs) Handles Butupload.Click
        Dim openFileDialog As New OpenFileDialog()

        ' Set file filter to allow only image files
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        openFileDialog.Title = "Select Resident's Photo"

        ' Show the dialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Load the selected image into the PictureBox
            picboxresidentphoto.Image = Image.FromFile(openFileDialog.FileName)
            ' Resize the image to fit the PictureBox
            picboxresidentphoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to fetch Residents details by ResidentID
            Dim query As String = "SELECT * FROM ResidentsTable WHERE ResidentID = @ResidentID"
            Dim cmd As New OleDbCommand(query, conn)



            ' Execute the query
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            ' Check if a resident record exists
            If reader.Read() Then
                ' Assign values to TextBoxes or Labels
                txtResidentName.Text = reader("ResidentName").ToString()
                txtResidentName.Text = reader("Address").ToString()
                txtResidentName.Text = reader("Phone").ToString()

                ' Load and display the resident’s photo (assuming a file path is stored in the database)
                Dim photoPath As String = reader("PhotoPath").ToString()
                If System.IO.File.Exists(photoPath) Then
                    picboxresidentphoto.Image = Image.FromFile(photoPath)
                    picboxresidentphoto.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    picboxresidentphoto.Image = Nothing  ' Clear if file is missing
                End If

                MessageBox.Show("Resident found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Resident not found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Butadd_Click(sender As Object, e As EventArgs) Handles Butadd.Click
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        Dim query As String = "INSERT INTO ResidentsTable (ResidentID, Name, DateOfBirth, MedicalHistory, CarePlan, FamilyContact, AdmissionDate, Photo) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(query, conn)

        ' Use correct parameter order and provide default values
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtresidentsid.Text), "UnknownID", txtresidentsid.Text))
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtfulname.Text), "Unknown", txtfulname.Text))
        cmd.Parameters.AddWithValue("?", If(dtpdateofbirth.Value = DateTimePicker.MinimumDateTime, "2020-01-01", dtpdateofbirth.Value.ToString("yyyy-MM-dd")))
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtmedicalhistory.Text), "No Medical History", txtmedicalhistory.Text))
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtcareplan.Text), "No Care Plan", txtcareplan.Text))
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrWhiteSpace(txtfamilycontact.Text), "0000000000", txtfamilycontact.Text))
        cmd.Parameters.AddWithValue("?", If(dtpadmissiondate.Value = DateTimePicker.MinimumDateTime, Convert.ToDateTime("2020-01-01"), dtpadmissiondate.Value))

        ' Convert the photo to a byte array before inserting
        If picboxresidentphoto.Image IsNot Nothing Then
            Using ms As New IO.MemoryStream()
                picboxresidentphoto.Image.Save(ms, picboxresidentphoto.Image.RawFormat)
                cmd.Parameters.AddWithValue("?", ms.ToArray()) ' Add the photo as byte array
            End Using
        Else
            ' If no photo selected, store a default image (optional)
            cmd.Parameters.AddWithValue("?", DBNull.Value)
        End If

        ' Execute query
        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        ' Show success message if rows were inserted
        If rowsAffected > 0 Then
            MessageBox.Show("Resident added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear the input fields after success
            txtresidentsid.Clear()
            txtfulname.Clear()
            txtmedicalhistory.Clear()
            txtcareplan.Clear()
            txtfamilycontact.Clear()
            dtpdateofbirth.Value = DateTimePicker.MinimumDateTime
            dtpadmissiondate.Value = DateTimePicker.MinimumDateTime
            picboxresidentphoto.Image = Nothing ' Clear the picture box

            ' Refresh DataGridView to show the newly inserted data
            RefreshDataGridView()

        Else
            MessageBox.Show("Failed to add resident. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    Catch ex As Exception
        MessageBox.Show("Error adding resident: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        ' Ensure connection is closed properly
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Try
End Sub

Private Sub RefreshDataGridView()
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' Define the query to fetch all residents
        Dim query As String = "SELECT ResidentID, Name, DateOfBirth, MedicalHistory, CarePlan, FamilyContact, AdmissionDate FROM ResidentsTable"
        Dim adapter As New OleDbDataAdapter(query, conn)
        
        ' Create a DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Fill the DataTable with data from the database
        adapter.Fill(dataTable)

        ' Bind the DataTable to the DataGridView
        ResidentsDataGridView.DataSource = dataTable

    Catch ex As Exception
        MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        ' Ensure connection is closed properly
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Try
End Sub



    Private Sub Residents_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents ResidentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedicalHistoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CarePlanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyContactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FamilyContactPhoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdmissionDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

    Private Sub DataGridViewresidentlist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewresidentlist.CellContentClick

    End Sub
End Class
