<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffAttendance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Butsearch = New System.Windows.Forms.Button()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.StaffAttendanceDataGridView = New System.Windows.Forms.DataGridView()
        Me.labelcheckintime = New System.Windows.Forms.Label()
        Me.labelcheckouttime = New System.Windows.Forms.Label()
        Me.labelshift = New System.Windows.Forms.Label()
        Me.labelstatus = New System.Windows.Forms.Label()
        Me.currentdatebutton = New System.Windows.Forms.Button()
        Me.shiftdrop = New System.Windows.Forms.ComboBox()
        Me.statusdrop = New System.Windows.Forms.ComboBox()
        Me.markattendancebutton = New System.Windows.Forms.Button()
        Me.selectedstaff = New System.Windows.Forms.Label()
        Me.textcheckintime = New System.Windows.Forms.TextBox()
        Me.textcheckouttime = New System.Windows.Forms.TextBox()
        Me.checkintimebutton = New System.Windows.Forms.Button()
        Me.checkouttimebutton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.StaffAttendanceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.MinimumSize = New System.Drawing.Size(0, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1257, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Attendance"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Butsearch)
        Me.Panel1.Controls.Add(Me.textsearch)
        Me.Panel1.Controls.Add(Me.StaffAttendanceDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(521, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 574)
        Me.Panel1.TabIndex = 1
        '
        'Butsearch
        '
        Me.Butsearch.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Butsearch.Location = New System.Drawing.Point(386, 31)
        Me.Butsearch.Name = "Butsearch"
        Me.Butsearch.Size = New System.Drawing.Size(101, 46)
        Me.Butsearch.TabIndex = 4
        Me.Butsearch.Text = "Search A Staff"
        Me.Butsearch.UseVisualStyleBackColor = False
        '
        'textsearch
        '
        Me.textsearch.Location = New System.Drawing.Point(169, 45)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(188, 22)
        Me.textsearch.TabIndex = 3
        '
        'StaffAttendanceDataGridView
        '
        Me.StaffAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffAttendanceDataGridView.Location = New System.Drawing.Point(27, 130)
        Me.StaffAttendanceDataGridView.Name = "StaffAttendanceDataGridView"
        Me.StaffAttendanceDataGridView.RowHeadersWidth = 51
        Me.StaffAttendanceDataGridView.RowTemplate.Height = 24
        Me.StaffAttendanceDataGridView.Size = New System.Drawing.Size(684, 400)
        Me.StaffAttendanceDataGridView.TabIndex = 2
        '
        'labelcheckintime
        '
        Me.labelcheckintime.AutoSize = True
        Me.labelcheckintime.Location = New System.Drawing.Point(4, 263)
        Me.labelcheckintime.Name = "labelcheckintime"
        Me.labelcheckintime.Size = New System.Drawing.Size(92, 16)
        Me.labelcheckintime.TabIndex = 2
        Me.labelcheckintime.Text = "Check In Time"
        '
        'labelcheckouttime
        '
        Me.labelcheckouttime.AutoSize = True
        Me.labelcheckouttime.Location = New System.Drawing.Point(4, 332)
        Me.labelcheckouttime.Name = "labelcheckouttime"
        Me.labelcheckouttime.Size = New System.Drawing.Size(102, 16)
        Me.labelcheckouttime.TabIndex = 3
        Me.labelcheckouttime.Text = "Check Out Time"
        '
        'labelshift
        '
        Me.labelshift.AutoSize = True
        Me.labelshift.Location = New System.Drawing.Point(4, 397)
        Me.labelshift.Name = "labelshift"
        Me.labelshift.Size = New System.Drawing.Size(67, 16)
        Me.labelshift.TabIndex = 4
        Me.labelshift.Text = "Shift Type"
        '
        'labelstatus
        '
        Me.labelstatus.AutoSize = True
        Me.labelstatus.Location = New System.Drawing.Point(4, 455)
        Me.labelstatus.Name = "labelstatus"
        Me.labelstatus.Size = New System.Drawing.Size(44, 16)
        Me.labelstatus.TabIndex = 5
        Me.labelstatus.Text = "Status"
        '
        'currentdatebutton
        '
        Me.currentdatebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.currentdatebutton.Location = New System.Drawing.Point(94, 75)
        Me.currentdatebutton.Name = "currentdatebutton"
        Me.currentdatebutton.Size = New System.Drawing.Size(319, 55)
        Me.currentdatebutton.TabIndex = 7
        Me.currentdatebutton.Text = "Set Current Date And Initialize Staffs For Today"
        Me.currentdatebutton.UseVisualStyleBackColor = False
        '
        'shiftdrop
        '
        Me.shiftdrop.FormattingEnabled = True
        Me.shiftdrop.Items.AddRange(New Object() {"Morning", "Afternoon", "Night"})
        Me.shiftdrop.Location = New System.Drawing.Point(133, 389)
        Me.shiftdrop.Name = "shiftdrop"
        Me.shiftdrop.Size = New System.Drawing.Size(196, 24)
        Me.shiftdrop.TabIndex = 10
        '
        'statusdrop
        '
        Me.statusdrop.FormattingEnabled = True
        Me.statusdrop.Items.AddRange(New Object() {"Present", "Absent", "On Leave"})
        Me.statusdrop.Location = New System.Drawing.Point(133, 447)
        Me.statusdrop.Name = "statusdrop"
        Me.statusdrop.Size = New System.Drawing.Size(196, 24)
        Me.statusdrop.TabIndex = 11
        '
        'markattendancebutton
        '
        Me.markattendancebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.markattendancebutton.Location = New System.Drawing.Point(133, 519)
        Me.markattendancebutton.Name = "markattendancebutton"
        Me.markattendancebutton.Size = New System.Drawing.Size(121, 49)
        Me.markattendancebutton.TabIndex = 12
        Me.markattendancebutton.Text = "Mark Staff Attendance"
        Me.markattendancebutton.UseVisualStyleBackColor = False
        '
        'selectedstaff
        '
        Me.selectedstaff.AutoSize = True
        Me.selectedstaff.BackColor = System.Drawing.Color.SpringGreen
        Me.selectedstaff.Location = New System.Drawing.Point(91, 165)
        Me.selectedstaff.Name = "selectedstaff"
        Me.selectedstaff.Padding = New System.Windows.Forms.Padding(5)
        Me.selectedstaff.Size = New System.Drawing.Size(113, 26)
        Me.selectedstaff.TabIndex = 13
        Me.selectedstaff.Text = "Selected Staff Is"
        '
        'textcheckintime
        '
        Me.textcheckintime.Location = New System.Drawing.Point(133, 257)
        Me.textcheckintime.Name = "textcheckintime"
        Me.textcheckintime.Size = New System.Drawing.Size(196, 22)
        Me.textcheckintime.TabIndex = 14
        '
        'textcheckouttime
        '
        Me.textcheckouttime.Location = New System.Drawing.Point(133, 326)
        Me.textcheckouttime.Name = "textcheckouttime"
        Me.textcheckouttime.Size = New System.Drawing.Size(196, 22)
        Me.textcheckouttime.TabIndex = 15
        '
        'checkintimebutton
        '
        Me.checkintimebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.checkintimebutton.Location = New System.Drawing.Point(357, 237)
        Me.checkintimebutton.Name = "checkintimebutton"
        Me.checkintimebutton.Size = New System.Drawing.Size(140, 49)
        Me.checkintimebutton.TabIndex = 16
        Me.checkintimebutton.Text = "Select Current Time"
        Me.checkintimebutton.UseVisualStyleBackColor = False
        '
        'checkouttimebutton
        '
        Me.checkouttimebutton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.checkouttimebutton.Location = New System.Drawing.Point(357, 307)
        Me.checkouttimebutton.Name = "checkouttimebutton"
        Me.checkouttimebutton.Size = New System.Drawing.Size(140, 47)
        Me.checkouttimebutton.TabIndex = 17
        Me.checkouttimebutton.Text = "Select Current Time"
        Me.checkouttimebutton.UseVisualStyleBackColor = False
        '
        'StaffAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 630)
        Me.Controls.Add(Me.checkouttimebutton)
        Me.Controls.Add(Me.checkintimebutton)
        Me.Controls.Add(Me.textcheckouttime)
        Me.Controls.Add(Me.textcheckintime)
        Me.Controls.Add(Me.selectedstaff)
        Me.Controls.Add(Me.markattendancebutton)
        Me.Controls.Add(Me.statusdrop)
        Me.Controls.Add(Me.shiftdrop)
        Me.Controls.Add(Me.currentdatebutton)
        Me.Controls.Add(Me.labelstatus)
        Me.Controls.Add(Me.labelshift)
        Me.Controls.Add(Me.labelcheckouttime)
        Me.Controls.Add(Me.labelcheckintime)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffAttendance"
        Me.Text = "StaffAttendance"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StaffAttendanceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents StaffAttendanceDataGridView As DataGridView
    Friend WithEvents labelcheckintime As Label
    Friend WithEvents labelcheckouttime As Label
    Friend WithEvents labelshift As Label
    Friend WithEvents labelstatus As Label
    Friend WithEvents currentdatebutton As Button
    Friend WithEvents shiftdrop As ComboBox
    Friend WithEvents statusdrop As ComboBox
    Friend WithEvents markattendancebutton As Button
    Friend WithEvents Butsearch As Button
    Friend WithEvents textsearch As TextBox
    Friend WithEvents selectedstaff As Label
    Friend WithEvents textcheckintime As TextBox
    Friend WithEvents textcheckouttime As TextBox
    Friend WithEvents checkintimebutton As Button
    Friend WithEvents checkouttimebutton As Button
End Class
