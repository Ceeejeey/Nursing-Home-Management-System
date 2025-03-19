<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainform))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ResidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewResidentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEditResidentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicalHistoryCarePlanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DischargeResidentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUpdateStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignDutiesShiftsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueMedicinesToResidentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CarePlansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResidentSpecificCarePlansToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamilyContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResidentFamilyContactsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportMaintenanceIssuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackStatusOfRequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignMaintenanceStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResidentReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffPerformanceReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicineUsageReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResidentsToolStripMenuItem, Me.StaffToolStripMenuItem, Me.MedicinesToolStripMenuItem, Me.CarePlansToolStripMenuItem, Me.FamilyContactsToolStripMenuItem, Me.MaintenanceRequestsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1257, 36)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ResidentsToolStripMenuItem
        '
        Me.ResidentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewResidentToolStripMenuItem, Me.ViewEditResidentDetailsToolStripMenuItem, Me.MedicalHistoryCarePlanToolStripMenuItem, Me.DischargeResidentToolStripMenuItem})
        Me.ResidentsToolStripMenuItem.Name = "ResidentsToolStripMenuItem"
        Me.ResidentsToolStripMenuItem.Size = New System.Drawing.Size(108, 32)
        Me.ResidentsToolStripMenuItem.Text = "Residents"
        '
        'AddNewResidentToolStripMenuItem
        '
        Me.AddNewResidentToolStripMenuItem.Image = Global.NursingHomeManagementSystem.My.Resources.Resources.user
        Me.AddNewResidentToolStripMenuItem.Name = "AddNewResidentToolStripMenuItem"
        Me.AddNewResidentToolStripMenuItem.Size = New System.Drawing.Size(334, 32)
        Me.AddNewResidentToolStripMenuItem.Text = "Add New Resident"
        '
        'ViewEditResidentDetailsToolStripMenuItem
        '
        Me.ViewEditResidentDetailsToolStripMenuItem.Image = CType(resources.GetObject("ViewEditResidentDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ViewEditResidentDetailsToolStripMenuItem.Name = "ViewEditResidentDetailsToolStripMenuItem"
        Me.ViewEditResidentDetailsToolStripMenuItem.Size = New System.Drawing.Size(334, 32)
        Me.ViewEditResidentDetailsToolStripMenuItem.Text = "View / Edit Resident Details"
        '
        'MedicalHistoryCarePlanToolStripMenuItem
        '
        Me.MedicalHistoryCarePlanToolStripMenuItem.Image = CType(resources.GetObject("MedicalHistoryCarePlanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MedicalHistoryCarePlanToolStripMenuItem.Name = "MedicalHistoryCarePlanToolStripMenuItem"
        Me.MedicalHistoryCarePlanToolStripMenuItem.Size = New System.Drawing.Size(334, 32)
        Me.MedicalHistoryCarePlanToolStripMenuItem.Text = "Medical History & Care Plan"
        '
        'DischargeResidentToolStripMenuItem
        '
        Me.DischargeResidentToolStripMenuItem.Image = CType(resources.GetObject("DischargeResidentToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DischargeResidentToolStripMenuItem.Name = "DischargeResidentToolStripMenuItem"
        Me.DischargeResidentToolStripMenuItem.Size = New System.Drawing.Size(334, 32)
        Me.DischargeResidentToolStripMenuItem.Text = "Discharge Resident"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUpdateStaffToolStripMenuItem, Me.AssignDutiesShiftsToolStripMenuItem, Me.StaffAttendanceToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(65, 32)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'AddUpdateStaffToolStripMenuItem
        '
        Me.AddUpdateStaffToolStripMenuItem.Image = CType(resources.GetObject("AddUpdateStaffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddUpdateStaffToolStripMenuItem.Name = "AddUpdateStaffToolStripMenuItem"
        Me.AddUpdateStaffToolStripMenuItem.Size = New System.Drawing.Size(273, 32)
        Me.AddUpdateStaffToolStripMenuItem.Text = "Add / Update Staff"
        '
        'AssignDutiesShiftsToolStripMenuItem
        '
        Me.AssignDutiesShiftsToolStripMenuItem.Image = CType(resources.GetObject("AssignDutiesShiftsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AssignDutiesShiftsToolStripMenuItem.Name = "AssignDutiesShiftsToolStripMenuItem"
        Me.AssignDutiesShiftsToolStripMenuItem.Size = New System.Drawing.Size(273, 32)
        Me.AssignDutiesShiftsToolStripMenuItem.Text = "Assign Duties & Shifts"
        '
        'StaffAttendanceToolStripMenuItem
        '
        Me.StaffAttendanceToolStripMenuItem.Image = CType(resources.GetObject("StaffAttendanceToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StaffAttendanceToolStripMenuItem.Name = "StaffAttendanceToolStripMenuItem"
        Me.StaffAttendanceToolStripMenuItem.Size = New System.Drawing.Size(273, 32)
        Me.StaffAttendanceToolStripMenuItem.Text = "Staff Attendance"
        '
        'MedicinesToolStripMenuItem
        '
        Me.MedicinesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IssueMedicinesToResidentsToolStripMenuItem})
        Me.MedicinesToolStripMenuItem.Name = "MedicinesToolStripMenuItem"
        Me.MedicinesToolStripMenuItem.Size = New System.Drawing.Size(114, 32)
        Me.MedicinesToolStripMenuItem.Text = "Medicines"
        '
        'IssueMedicinesToResidentsToolStripMenuItem
        '
        Me.IssueMedicinesToResidentsToolStripMenuItem.Image = CType(resources.GetObject("IssueMedicinesToResidentsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IssueMedicinesToResidentsToolStripMenuItem.Name = "IssueMedicinesToResidentsToolStripMenuItem"
        Me.IssueMedicinesToResidentsToolStripMenuItem.Size = New System.Drawing.Size(344, 32)
        Me.IssueMedicinesToResidentsToolStripMenuItem.Text = "Issue Medicines to Residents"
        '
        'CarePlansToolStripMenuItem
        '
        Me.CarePlansToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResidentSpecificCarePlansToolStripMenuItem})
        Me.CarePlansToolStripMenuItem.Name = "CarePlansToolStripMenuItem"
        Me.CarePlansToolStripMenuItem.Size = New System.Drawing.Size(115, 32)
        Me.CarePlansToolStripMenuItem.Text = "Care Plans"
        '
        'ResidentSpecificCarePlansToolStripMenuItem
        '
        Me.ResidentSpecificCarePlansToolStripMenuItem.Image = CType(resources.GetObject("ResidentSpecificCarePlansToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResidentSpecificCarePlansToolStripMenuItem.Name = "ResidentSpecificCarePlansToolStripMenuItem"
        Me.ResidentSpecificCarePlansToolStripMenuItem.Size = New System.Drawing.Size(341, 32)
        Me.ResidentSpecificCarePlansToolStripMenuItem.Text = "Resident-Specific Care Plans"
        '
        'FamilyContactsToolStripMenuItem
        '
        Me.FamilyContactsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResidentFamilyContactsToolStripMenuItem})
        Me.FamilyContactsToolStripMenuItem.Name = "FamilyContactsToolStripMenuItem"
        Me.FamilyContactsToolStripMenuItem.Size = New System.Drawing.Size(163, 32)
        Me.FamilyContactsToolStripMenuItem.Text = "Family Contacts"
        '
        'ResidentFamilyContactsToolStripMenuItem
        '
        Me.ResidentFamilyContactsToolStripMenuItem.Image = CType(resources.GetObject("ResidentFamilyContactsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResidentFamilyContactsToolStripMenuItem.Name = "ResidentFamilyContactsToolStripMenuItem"
        Me.ResidentFamilyContactsToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.ResidentFamilyContactsToolStripMenuItem.Text = "Resident Family Contacts"
        '
        'MaintenanceRequestsToolStripMenuItem
        '
        Me.MaintenanceRequestsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportMaintenanceIssuesToolStripMenuItem, Me.TrackStatusOfRequestsToolStripMenuItem, Me.AssignMaintenanceStaffToolStripMenuItem})
        Me.MaintenanceRequestsToolStripMenuItem.Name = "MaintenanceRequestsToolStripMenuItem"
        Me.MaintenanceRequestsToolStripMenuItem.Size = New System.Drawing.Size(220, 32)
        Me.MaintenanceRequestsToolStripMenuItem.Text = "Maintenance Requests"
        '
        'ReportMaintenanceIssuesToolStripMenuItem
        '
        Me.ReportMaintenanceIssuesToolStripMenuItem.Image = CType(resources.GetObject("ReportMaintenanceIssuesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportMaintenanceIssuesToolStripMenuItem.Name = "ReportMaintenanceIssuesToolStripMenuItem"
        Me.ReportMaintenanceIssuesToolStripMenuItem.Size = New System.Drawing.Size(329, 32)
        Me.ReportMaintenanceIssuesToolStripMenuItem.Text = "Report Maintenance Issues"
        '
        'TrackStatusOfRequestsToolStripMenuItem
        '
        Me.TrackStatusOfRequestsToolStripMenuItem.Image = CType(resources.GetObject("TrackStatusOfRequestsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TrackStatusOfRequestsToolStripMenuItem.Name = "TrackStatusOfRequestsToolStripMenuItem"
        Me.TrackStatusOfRequestsToolStripMenuItem.Size = New System.Drawing.Size(329, 32)
        Me.TrackStatusOfRequestsToolStripMenuItem.Text = "Track Status of Requests"
        '
        'AssignMaintenanceStaffToolStripMenuItem
        '
        Me.AssignMaintenanceStaffToolStripMenuItem.Image = CType(resources.GetObject("AssignMaintenanceStaffToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AssignMaintenanceStaffToolStripMenuItem.Name = "AssignMaintenanceStaffToolStripMenuItem"
        Me.AssignMaintenanceStaffToolStripMenuItem.Size = New System.Drawing.Size(329, 32)
        Me.AssignMaintenanceStaffToolStripMenuItem.Text = "Assign Maintenance Staff"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResidentReportsToolStripMenuItem, Me.StaffPerformanceReportsToolStripMenuItem, Me.MedicineUsageReportsToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(98, 32)
        Me.ReportsToolStripMenuItem.Text = "Reports "
        '
        'ResidentReportsToolStripMenuItem
        '
        Me.ResidentReportsToolStripMenuItem.Image = CType(resources.GetObject("ResidentReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResidentReportsToolStripMenuItem.Name = "ResidentReportsToolStripMenuItem"
        Me.ResidentReportsToolStripMenuItem.Size = New System.Drawing.Size(323, 32)
        Me.ResidentReportsToolStripMenuItem.Text = "Resident Reports"
        '
        'StaffPerformanceReportsToolStripMenuItem
        '
        Me.StaffPerformanceReportsToolStripMenuItem.Image = CType(resources.GetObject("StaffPerformanceReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StaffPerformanceReportsToolStripMenuItem.Name = "StaffPerformanceReportsToolStripMenuItem"
        Me.StaffPerformanceReportsToolStripMenuItem.Size = New System.Drawing.Size(323, 32)
        Me.StaffPerformanceReportsToolStripMenuItem.Text = "Staff Performance Reports"
        '
        'MedicineUsageReportsToolStripMenuItem
        '
        Me.MedicineUsageReportsToolStripMenuItem.Image = CType(resources.GetObject("MedicineUsageReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MedicineUsageReportsToolStripMenuItem.Name = "MedicineUsageReportsToolStripMenuItem"
        Me.MedicineUsageReportsToolStripMenuItem.Size = New System.Drawing.Size(323, 32)
        Me.MedicineUsageReportsToolStripMenuItem.Text = "Medicine Usage Reports"
        '
        'ToolStrip
        '
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator6, Me.ToolStripButton2, Me.ToolStripSeparator7, Me.ToolStripButton4, Me.ToolStripSeparator9, Me.ToolStripButton5, Me.ToolStripSeparator11, Me.ToolStripButton6, Me.ToolStripSeparator12, Me.ToolStripButton3, Me.ToolStripSeparator10})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 36)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip.Size = New System.Drawing.Size(1257, 27)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.NursingHomeManagementSystem.My.Resources.Resources.user1
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "Residents"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.NursingHomeManagementSystem.My.Resources.Resources.group_chat
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton2.Text = "staff"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.NursingHomeManagementSystem.My.Resources.Resources.medicine
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton4.Text = "Medicines"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton5.Text = "ToolStripButton5"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton6.Text = "Family Contact"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 27)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.NursingHomeManagementSystem.My.Resources.Resources.requirement
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton3.Text = "Maitenance Requests"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 27)
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1257, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1257, 558)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mainform"
        Me.Text = "Nursing Home Management form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CarePlansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FamilyContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceRequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUpdateStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueMedicinesToResidentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResidentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewResidentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEditResidentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicalHistoryCarePlanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DischargeResidentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResidentSpecificCarePlansToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResidentFamilyContactsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportMaintenanceIssuesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrackStatusOfRequestsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignMaintenanceStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResidentReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffPerformanceReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicineUsageReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator

    Private Sub sender()


    End Sub

    Friend WithEvents AssignDutiesShiftsToolStripMenuItem As ToolStripMenuItem
End Class
