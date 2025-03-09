<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.deletebutton = New System.Windows.Forms.Button()
        Me.updatebutton = New System.Windows.Forms.Button()
        Me.addbutton = New System.Windows.Forms.Button()
        Me.genderdrop = New System.Windows.Forms.ComboBox()
        Me.genderlabel = New System.Windows.Forms.Label()
        Me.roledrop = New System.Windows.Forms.ComboBox()
        Me.contactlabel = New System.Windows.Forms.Label()
        Me.rolelabel = New System.Windows.Forms.Label()
        Me.namelabel = New System.Windows.Forms.Label()
        Me.staffidlabel = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.txtfulname = New System.Windows.Forms.TextBox()
        Me.txtstaffid = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DataGridViewstafflist = New System.Windows.Forms.DataGridView()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DataGridViewstafflist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1275, 50)
        Me.Panel4.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1275, 50)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "staff management"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel5.Controls.Add(Me.deletebutton)
        Me.Panel5.Controls.Add(Me.updatebutton)
        Me.Panel5.Controls.Add(Me.addbutton)
        Me.Panel5.Controls.Add(Me.genderdrop)
        Me.Panel5.Controls.Add(Me.genderlabel)
        Me.Panel5.Controls.Add(Me.roledrop)
        Me.Panel5.Controls.Add(Me.contactlabel)
        Me.Panel5.Controls.Add(Me.rolelabel)
        Me.Panel5.Controls.Add(Me.namelabel)
        Me.Panel5.Controls.Add(Me.staffidlabel)
        Me.Panel5.Controls.Add(Me.txtcontact)
        Me.Panel5.Controls.Add(Me.txtfulname)
        Me.Panel5.Controls.Add(Me.txtstaffid)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(488, 627)
        Me.Panel5.TabIndex = 1
        '
        'deletebutton
        '
        Me.deletebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.deletebutton.Location = New System.Drawing.Point(345, 402)
        Me.deletebutton.Name = "deletebutton"
        Me.deletebutton.Size = New System.Drawing.Size(99, 50)
        Me.deletebutton.TabIndex = 57
        Me.deletebutton.Text = "Delete Staff"
        Me.deletebutton.UseVisualStyleBackColor = False
        '
        'updatebutton
        '
        Me.updatebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.updatebutton.Location = New System.Drawing.Point(194, 402)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(99, 50)
        Me.updatebutton.TabIndex = 56
        Me.updatebutton.Text = "Update Staff"
        Me.updatebutton.UseVisualStyleBackColor = False
        '
        'addbutton
        '
        Me.addbutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.addbutton.Location = New System.Drawing.Point(42, 402)
        Me.addbutton.Name = "addbutton"
        Me.addbutton.Size = New System.Drawing.Size(99, 50)
        Me.addbutton.TabIndex = 55
        Me.addbutton.Text = "Add Staff"
        Me.addbutton.UseVisualStyleBackColor = False
        '
        'genderdrop
        '
        Me.genderdrop.FormattingEnabled = True
        Me.genderdrop.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.genderdrop.Location = New System.Drawing.Point(171, 305)
        Me.genderdrop.Name = "genderdrop"
        Me.genderdrop.Size = New System.Drawing.Size(273, 24)
        Me.genderdrop.TabIndex = 54
        '
        'genderlabel
        '
        Me.genderlabel.AutoSize = True
        Me.genderlabel.Location = New System.Drawing.Point(39, 313)
        Me.genderlabel.Name = "genderlabel"
        Me.genderlabel.Size = New System.Drawing.Size(52, 16)
        Me.genderlabel.TabIndex = 53
        Me.genderlabel.Text = "Gender"
        '
        'roledrop
        '
        Me.roledrop.FormattingEnabled = True
        Me.roledrop.Items.AddRange(New Object() {"Nurse", "Maintenance", "Caregiver", "Housekeeping"})
        Me.roledrop.Location = New System.Drawing.Point(171, 224)
        Me.roledrop.Name = "roledrop"
        Me.roledrop.Size = New System.Drawing.Size(273, 24)
        Me.roledrop.TabIndex = 52
        '
        'contactlabel
        '
        Me.contactlabel.AutoSize = True
        Me.contactlabel.Location = New System.Drawing.Point(39, 272)
        Me.contactlabel.Name = "contactlabel"
        Me.contactlabel.Size = New System.Drawing.Size(52, 16)
        Me.contactlabel.TabIndex = 50
        Me.contactlabel.Text = "Contact"
        '
        'rolelabel
        '
        Me.rolelabel.AutoSize = True
        Me.rolelabel.Location = New System.Drawing.Point(39, 233)
        Me.rolelabel.Name = "rolelabel"
        Me.rolelabel.Size = New System.Drawing.Size(36, 16)
        Me.rolelabel.TabIndex = 49
        Me.rolelabel.Text = "Role"
        '
        'namelabel
        '
        Me.namelabel.AutoSize = True
        Me.namelabel.Location = New System.Drawing.Point(39, 193)
        Me.namelabel.Name = "namelabel"
        Me.namelabel.Size = New System.Drawing.Size(44, 16)
        Me.namelabel.TabIndex = 48
        Me.namelabel.Text = "Name"
        '
        'staffidlabel
        '
        Me.staffidlabel.AutoSize = True
        Me.staffidlabel.Location = New System.Drawing.Point(39, 154)
        Me.staffidlabel.Name = "staffidlabel"
        Me.staffidlabel.Size = New System.Drawing.Size(47, 16)
        Me.staffidlabel.TabIndex = 47
        Me.staffidlabel.Text = "Staff Id"
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(171, 265)
        Me.txtcontact.Multiline = True
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(273, 23)
        Me.txtcontact.TabIndex = 46
        Me.txtcontact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtfulname
        '
        Me.txtfulname.Location = New System.Drawing.Point(171, 190)
        Me.txtfulname.Multiline = True
        Me.txtfulname.Name = "txtfulname"
        Me.txtfulname.Size = New System.Drawing.Size(273, 23)
        Me.txtfulname.TabIndex = 45
        Me.txtfulname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtstaffid
        '
        Me.txtstaffid.Location = New System.Drawing.Point(171, 154)
        Me.txtstaffid.Multiline = True
        Me.txtstaffid.Name = "txtstaffid"
        Me.txtstaffid.Size = New System.Drawing.Size(273, 23)
        Me.txtstaffid.TabIndex = 44
        Me.txtstaffid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel6.Controls.Add(Me.DataGridViewstafflist)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Butsearch)
        Me.Panel6.Controls.Add(Me.textsearch)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(488, 50)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(787, 627)
        Me.Panel6.TabIndex = 2
        '
        'DataGridViewstafflist
        '
        Me.DataGridViewstafflist.AllowUserToOrderColumns = True
        Me.DataGridViewstafflist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewstafflist.Location = New System.Drawing.Point(85, 224)
        Me.DataGridViewstafflist.Name = "DataGridViewstafflist"
        Me.DataGridViewstafflist.RowHeadersWidth = 51
        Me.DataGridViewstafflist.RowTemplate.Height = 28
        Me.DataGridViewstafflist.Size = New System.Drawing.Size(676, 366)
        Me.DataGridViewstafflist.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(355, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 25)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Staff List"
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butsearch.Image = CType(resources.GetObject("Butsearch.Image"), System.Drawing.Image)
        Me.Butsearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Butsearch.Location = New System.Drawing.Point(589, 39)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Padding = New System.Windows.Forms.Padding(1)
        Me.Butsearch.Size = New System.Drawing.Size(123, 42)
        Me.Butsearch.TabIndex = 9
        Me.Butsearch.Text = "Search"
        Me.Butsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(245, 48)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(321, 22)
        Me.textsearch.TabIndex = 8
        '
        'Staff
        '
        Me.ClientSize = New System.Drawing.Size(1275, 677)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Staff"
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DataGridViewstafflist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NursingHomeManagemetSystemdbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NursingHomeManagemetSystemdbDataSet As NursingHomeManagementSystem.MaintenanceRequests
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents roledrop As System.Windows.Forms.ComboBox
    Friend WithEvents contactlabel As System.Windows.Forms.Label
    Friend WithEvents rolelabel As System.Windows.Forms.Label
    Friend WithEvents namelabel As System.Windows.Forms.Label
    Friend WithEvents staffidlabel As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents txtfulname As System.Windows.Forms.TextBox
    Friend WithEvents txtstaffid As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewstafflist As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Butsearch As System.Windows.Forms.Button
    Friend WithEvents textsearch As System.Windows.Forms.TextBox
    Friend WithEvents deletebutton As Button
    Friend WithEvents updatebutton As Button
    Friend WithEvents addbutton As Button
    Friend WithEvents genderdrop As ComboBox
    Friend WithEvents genderlabel As Label
End Class
