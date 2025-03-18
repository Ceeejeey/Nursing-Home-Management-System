<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaintenanceRequests
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MaintenanceRequests))
        Me.MaintenanceRequests_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NursingHomeManagemetSystemdbDataSet3 = New NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Butgeneratereport = New System.Windows.Forms.Button()
        Me.Butupdate = New System.Windows.Forms.Button()
        Me.combomaintenancetype = New System.Windows.Forms.ComboBox()
        Me.textassignedtechnician = New System.Windows.Forms.TextBox()
        Me.textreportedby = New System.Windows.Forms.TextBox()
        Me.labelassignedtechnician = New System.Windows.Forms.Label()
        Me.labelstatus = New System.Windows.Forms.Label()
        Me.labelmaintenancetype = New System.Windows.Forms.Label()
        Me.labelreportedby = New System.Windows.Forms.Label()
        Me.combostatus = New System.Windows.Forms.ComboBox()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.labelmaintenancelist = New System.Windows.Forms.Label()
        Me.MaintenanceRequestDataGridView = New System.Windows.Forms.DataGridView()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MaintenanceRequests_TableTableAdapter = New NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3TableAdapters.MaintenanceRequests_TableTableAdapter()
        Me.labelissuedescription = New System.Windows.Forms.Label()
        Me.textissuedescription = New System.Windows.Forms.TextBox()
        Me.textsearch = New System.Windows.Forms.TextBox()
        CType(Me.MaintenanceRequests_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NursingHomeManagemetSystemdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MaintenanceRequestDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaintenanceRequests_TableBindingSource
        '
        Me.MaintenanceRequests_TableBindingSource.DataMember = "MaintenanceRequests Table"
        Me.MaintenanceRequests_TableBindingSource.DataSource = Me.NursingHomeManagemetSystemdbDataSet3
        '
        'NursingHomeManagemetSystemdbDataSet3
        '
        Me.NursingHomeManagemetSystemdbDataSet3.DataSetName = "NursingHomeManagemetSystemdbDataSet3"
        Me.NursingHomeManagemetSystemdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1239, 37)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1239, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maintenance Requests"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Butgeneratereport
        '
        Me.Butgeneratereport.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butgeneratereport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butgeneratereport.Location = New System.Drawing.Point(251, 274)
        Me.Butgeneratereport.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Butgeneratereport.Name = "Butgeneratereport"
        Me.Butgeneratereport.Size = New System.Drawing.Size(328, 42)
        Me.Butgeneratereport.TabIndex = 25
        Me.Butgeneratereport.Text = "Generate Report"
        Me.Butgeneratereport.UseVisualStyleBackColor = False
        '
        'Butupdate
        '
        Me.Butupdate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butupdate.Location = New System.Drawing.Point(70, 274)
        Me.Butupdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Butupdate.Name = "Butupdate"
        Me.Butupdate.Size = New System.Drawing.Size(119, 42)
        Me.Butupdate.TabIndex = 24
        Me.Butupdate.Text = "Update Status"
        Me.Butupdate.UseVisualStyleBackColor = False
        '
        'combomaintenancetype
        '
        Me.combomaintenancetype.FormattingEnabled = True
        Me.combomaintenancetype.Location = New System.Drawing.Point(251, 146)
        Me.combomaintenancetype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.combomaintenancetype.Name = "combomaintenancetype"
        Me.combomaintenancetype.Size = New System.Drawing.Size(211, 24)
        Me.combomaintenancetype.TabIndex = 22
        '
        'textassignedtechnician
        '
        Me.textassignedtechnician.Location = New System.Drawing.Point(251, 231)
        Me.textassignedtechnician.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textassignedtechnician.Name = "textassignedtechnician"
        Me.textassignedtechnician.Size = New System.Drawing.Size(211, 22)
        Me.textassignedtechnician.TabIndex = 21
        '
        'textreportedby
        '
        Me.textreportedby.Location = New System.Drawing.Point(251, 71)
        Me.textreportedby.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textreportedby.Name = "textreportedby"
        Me.textreportedby.Size = New System.Drawing.Size(211, 22)
        Me.textreportedby.TabIndex = 20
        '
        'labelassignedtechnician
        '
        Me.labelassignedtechnician.AutoSize = True
        Me.labelassignedtechnician.BackColor = System.Drawing.Color.Transparent
        Me.labelassignedtechnician.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelassignedtechnician.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelassignedtechnician.Location = New System.Drawing.Point(67, 235)
        Me.labelassignedtechnician.Name = "labelassignedtechnician"
        Me.labelassignedtechnician.Size = New System.Drawing.Size(147, 18)
        Me.labelassignedtechnician.TabIndex = 18
        Me.labelassignedtechnician.Text = "Assigned Technician:"
        '
        'labelstatus
        '
        Me.labelstatus.AutoSize = True
        Me.labelstatus.BackColor = System.Drawing.Color.Transparent
        Me.labelstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelstatus.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelstatus.Location = New System.Drawing.Point(67, 193)
        Me.labelstatus.Name = "labelstatus"
        Me.labelstatus.Size = New System.Drawing.Size(54, 18)
        Me.labelstatus.TabIndex = 17
        Me.labelstatus.Text = "Status:"
        '
        'labelmaintenancetype
        '
        Me.labelmaintenancetype.AutoSize = True
        Me.labelmaintenancetype.BackColor = System.Drawing.Color.Transparent
        Me.labelmaintenancetype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelmaintenancetype.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelmaintenancetype.Location = New System.Drawing.Point(67, 152)
        Me.labelmaintenancetype.Name = "labelmaintenancetype"
        Me.labelmaintenancetype.Size = New System.Drawing.Size(132, 18)
        Me.labelmaintenancetype.TabIndex = 16
        Me.labelmaintenancetype.Text = "Maintenance Type:"
        '
        'labelreportedby
        '
        Me.labelreportedby.AutoSize = True
        Me.labelreportedby.BackColor = System.Drawing.Color.Transparent
        Me.labelreportedby.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelreportedby.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelreportedby.Location = New System.Drawing.Point(67, 75)
        Me.labelreportedby.Name = "labelreportedby"
        Me.labelreportedby.Size = New System.Drawing.Size(94, 18)
        Me.labelreportedby.TabIndex = 15
        Me.labelreportedby.Text = "Reported By:"
        '
        'combostatus
        '
        Me.combostatus.FormattingEnabled = True
        Me.combostatus.Location = New System.Drawing.Point(251, 187)
        Me.combostatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.combostatus.Name = "combostatus"
        Me.combostatus.Size = New System.Drawing.Size(211, 24)
        Me.combostatus.TabIndex = 28
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Butsearch.Location = New System.Drawing.Point(1023, 119)
        Me.Butsearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(127, 42)
        Me.Butsearch.TabIndex = 26
        Me.Butsearch.Text = "Search Request"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'labelmaintenancelist
        '
        Me.labelmaintenancelist.AutoSize = True
        Me.labelmaintenancelist.Location = New System.Drawing.Point(210, 357)
        Me.labelmaintenancelist.Name = "labelmaintenancelist"
        Me.labelmaintenancelist.Size = New System.Drawing.Size(168, 16)
        Me.labelmaintenancelist.TabIndex = 29
        Me.labelmaintenancelist.Text = "Maintenance Requests List"
        '
        'MaintenanceRequestDataGridView
        '
        Me.MaintenanceRequestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MaintenanceRequestDataGridView.Location = New System.Drawing.Point(659, 218)
        Me.MaintenanceRequestDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaintenanceRequestDataGridView.Name = "MaintenanceRequestDataGridView"
        Me.MaintenanceRequestDataGridView.RowHeadersWidth = 51
        Me.MaintenanceRequestDataGridView.RowTemplate.Height = 28
        Me.MaintenanceRequestDataGridView.Size = New System.Drawing.Size(568, 362)
        Me.MaintenanceRequestDataGridView.TabIndex = 30
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MaintenanceRequests_TableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 347)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(641, 233)
        Me.ReportViewer1.TabIndex = 31
        '
        'MaintenanceRequests_TableTableAdapter
        '
        Me.MaintenanceRequests_TableTableAdapter.ClearBeforeFill = True
        '
        'labelissuedescription
        '
        Me.labelissuedescription.AutoSize = True
        Me.labelissuedescription.BackColor = System.Drawing.Color.Transparent
        Me.labelissuedescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelissuedescription.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelissuedescription.Location = New System.Drawing.Point(67, 112)
        Me.labelissuedescription.Name = "labelissuedescription"
        Me.labelissuedescription.Size = New System.Drawing.Size(122, 18)
        Me.labelissuedescription.TabIndex = 32
        Me.labelissuedescription.Text = "Issue Description"
        '
        'textissuedescription
        '
        Me.textissuedescription.Location = New System.Drawing.Point(251, 108)
        Me.textissuedescription.Name = "textissuedescription"
        Me.textissuedescription.Size = New System.Drawing.Size(211, 22)
        Me.textissuedescription.TabIndex = 33
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(711, 129)
        Me.textsearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(273, 22)
        Me.textsearch.TabIndex = 34
        Me.textsearch.Text = "search by RequestId or Reported Staff ID"
        '
        'MaintenanceRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1239, 620)
        Me.Controls.Add(Me.textsearch)
        Me.Controls.Add(Me.textissuedescription)
        Me.Controls.Add(Me.labelissuedescription)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MaintenanceRequestDataGridView)
        Me.Controls.Add(Me.labelmaintenancelist)
        Me.Controls.Add(Me.combostatus)
        Me.Controls.Add(Me.Butsearch)
        Me.Controls.Add(Me.Butgeneratereport)
        Me.Controls.Add(Me.Butupdate)
        Me.Controls.Add(Me.combomaintenancetype)
        Me.Controls.Add(Me.textassignedtechnician)
        Me.Controls.Add(Me.textreportedby)
        Me.Controls.Add(Me.labelassignedtechnician)
        Me.Controls.Add(Me.labelstatus)
        Me.Controls.Add(Me.labelmaintenancetype)
        Me.Controls.Add(Me.labelreportedby)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "MaintenanceRequests"
        Me.Text = "MaintenanceRequests"
        CType(Me.MaintenanceRequests_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NursingHomeManagemetSystemdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.MaintenanceRequestDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Butgeneratereport As System.Windows.Forms.Button
    Friend WithEvents Butupdate As System.Windows.Forms.Button
    Friend WithEvents combomaintenancetype As System.Windows.Forms.ComboBox
    Friend WithEvents textassignedtechnician As System.Windows.Forms.TextBox
    Friend WithEvents textreportedby As System.Windows.Forms.TextBox
    Friend WithEvents labelassignedtechnician As System.Windows.Forms.Label
    Friend WithEvents labelstatus As System.Windows.Forms.Label
    Friend WithEvents labelmaintenancetype As System.Windows.Forms.Label
    Friend WithEvents labelreportedby As System.Windows.Forms.Label
    Friend WithEvents combostatus As System.Windows.Forms.ComboBox
    Friend WithEvents Butsearch As System.Windows.Forms.Button
    Friend WithEvents labelmaintenancelist As System.Windows.Forms.Label
    Friend WithEvents MaintenanceRequestDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaintenanceRequests_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NursingHomeManagemetSystemdbDataSet3 As NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3
    Friend WithEvents MaintenanceRequests_TableTableAdapter As NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3TableAdapters.MaintenanceRequests_TableTableAdapter
    Friend WithEvents labelissuedescription As Label
    Friend WithEvents textissuedescription As TextBox
    Friend WithEvents textsearch As TextBox
End Class
