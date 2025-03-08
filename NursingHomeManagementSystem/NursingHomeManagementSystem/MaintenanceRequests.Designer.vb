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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NursingHomeManagemetSystemdbDataSet3 = New NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3()
        Me.MaintenanceRequests_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaintenanceRequests_TableTableAdapter = New NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3TableAdapters.MaintenanceRequests_TableTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NursingHomeManagemetSystemdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaintenanceRequests_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1462, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("News706 BT", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1462, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maintenance Requests"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(320, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 52)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Generate Report"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(159, 275)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 52)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Update Status"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(240, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(122, 28)
        Me.ComboBox1.TabIndex = 22
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(240, 233)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(204, 26)
        Me.TextBox3.TabIndex = 21
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(240, 128)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(237, 26)
        Me.TextBox2.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(240, 96)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(122, 26)
        Me.TextBox1.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Assigned Technician:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Maintenance Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Reported By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Request ID:"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(240, 199)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(122, 28)
        Me.ComboBox2.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(489, 275)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 52)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Search Request"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Maintenance Requests List"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(79, 399)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(543, 175)
        Me.DataGridView1.TabIndex = 30
        '
        'Column1
        '
        Me.Column1.HeaderText = "Request ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Reported By"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Type"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Technician"
        Me.Column5.Name = "Column5"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.MaintenanceRequests_TableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(674, 181)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(764, 406)
        Me.ReportViewer1.TabIndex = 31
        '
        'NursingHomeManagemetSystemdbDataSet3
        '
        Me.NursingHomeManagemetSystemdbDataSet3.DataSetName = "NursingHomeManagemetSystemdbDataSet3"
        Me.NursingHomeManagemetSystemdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaintenanceRequests_TableBindingSource
        '
        Me.MaintenanceRequests_TableBindingSource.DataMember = "MaintenanceRequests Table"
        Me.MaintenanceRequests_TableBindingSource.DataSource = Me.NursingHomeManagemetSystemdbDataSet3
        '
        'MaintenanceRequests_TableTableAdapter
        '
        Me.MaintenanceRequests_TableTableAdapter.ClearBeforeFill = True
        '
        'MaintenanceRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1462, 685)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MaintenanceRequests"
        Me.Text = "MaintenanceRequests"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NursingHomeManagemetSystemdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaintenanceRequests_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MaintenanceRequests_TableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NursingHomeManagemetSystemdbDataSet3 As NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3
    Friend WithEvents MaintenanceRequests_TableTableAdapter As NursingHomeManagementSystem.NursingHomeManagemetSystemdbDataSet3TableAdapters.MaintenanceRequests_TableTableAdapter
End Class
