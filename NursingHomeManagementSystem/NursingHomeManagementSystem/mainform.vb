﻿Imports System.Windows.Forms

Public Class mainform
    ' Load event for the main form
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can add initialization code here if needed
    End Sub

    ' Show Residents Form when "Add New Resident" is clicked
    Private Sub AddNewResidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewResidentToolStripMenuItem.Click
        Dim residentsForm As New Residents()
        residentsForm.Show()
    End Sub

    ' Show Residents Form when "View/Edit Resident Details" is clicked
    Private Sub ViewEditResidentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEditResidentDetailsToolStripMenuItem.Click
        Dim residentsForm As New Residents()
        residentsForm.Show()
    End Sub

    ' Show Residents Form when "Medical History & Care Plan" is clicked
    Private Sub MedicalHistoryCarePlanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicalHistoryCarePlanToolStripMenuItem.Click
        Dim residentsForm As New Residents()
        residentsForm.Show()
    End Sub

    ' Show Residents Form when "Discharge Resident" is clicked
    Private Sub DischargeResidentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DischargeResidentToolStripMenuItem.Click
        Dim residentsForm As New Residents()
        residentsForm.Show()
    End Sub
	
	Private Sub AddUpdateStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUpdateStaffToolStripMenuItem.Click
    ' Check if the form is already open to prevent multiple instances
    Dim staffForm As Staff = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            staffForm = CType(openForm, Staff)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If staffForm Is Nothing Then
        staffForm = New Staff()
        staffForm.Show()
    Else
        ' If already open, bring it to front
        staffForm.BringToFront()
    End If
End Sub

Private Sub AssignDutiesShiftsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignDutiesShiftsToolStripMenuItem.Click
    ' Check if the form is already open to prevent multiple instances
    Dim staffAttendanceForm As StaffAttendance = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            staffAttendanceForm = CType(openForm, StaffAttendance)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If staffAttendanceForm Is Nothing Then
        staffAttendanceForm = New StaffAttendance()
        staffAttendanceForm.Show()
    Else
        ' If already open, bring it to front
        staffAttendanceForm.BringToFront()
    End If
End Sub

Private Sub StaffAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffAttendanceToolStripMenuItem.Click
    ' Check if the form is already open to prevent multiple instances
    Dim staffAttendanceForm As StaffAttendance = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            staffAttendanceForm = CType(openForm, StaffAttendance)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If staffAttendanceForm Is Nothing Then
        staffAttendanceForm = New StaffAttendance()
        staffAttendanceForm.Show()
    Else
        ' If already open, bring it to front
        staffAttendanceForm.BringToFront()
    End If
End Sub

Private Sub TrackStatusOfRequestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrackStatusOfRequestsToolStripMenuItem.Click
    ' Check if the form is already open to prevent multiple instances
    Dim maintenanceRequestForm As MaintenanceRequests = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            maintenanceRequestForm = CType(openForm, MaintenanceRequests)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If maintenanceRequestForm Is Nothing Then
        maintenanceRequestForm = New MaintenanceRequests()
        maintenanceRequestForm.Show()
    Else
        ' If already open, bring it to front
        maintenanceRequestForm.BringToFront()
    End If
End Sub

Private Sub AssignMaintenanceStaffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignMaintenanceStaffToolStripMenuItem.Click
    ' Check if the form is already open to prevent multiple instances
    Dim maintenanceRequestForm As MaintenanceRequests = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            maintenanceRequestForm = CType(openForm, MaintenanceRequests)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If maintenanceRequestForm Is Nothing Then
        maintenanceRequestForm = New MaintenanceRequests()
        maintenanceRequestForm.Show()
    Else
        ' If already open, bring it to front
        maintenanceRequestForm.BringToFront()
    End If
End Sub

Private Sub ReportMaintenanceIssuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportMaintenanceIssuesToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim maintenanceRequestForm As MaintenanceRequests = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            maintenanceRequestForm = CType(openForm, MaintenanceRequests)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If maintenanceRequestForm Is Nothing Then
        maintenanceRequestForm = New MaintenanceRequests()
        maintenanceRequestForm.Show()
    Else
        ' If already open, bring it to front
        maintenanceRequestForm.BringToFront()
    End If
End Sub


Private Sub IssueMedicinesToResidentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssueMedicinesToResidentsToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim medicinesForm As MedicinesForm = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            medicinesForm = CType(openForm, MedicinesForm)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If medicinesForm Is Nothing Then
        medicinesForm = New MedicinesForm()
        medicinesForm.Show()
    Else
        ' If already open, bring it to front
        medicinesForm.BringToFront()
    End If
End Sub

Private Sub ResidentSpecificCarePlansToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidentSpecificCarePlansToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim carePlans As CarePlans = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is CarePlans Then
                carePlans = CType(carePlans, CarePlans)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If carePlans Is Nothing Then
        carePlans = New CarePlans()
        carePlans.Show()
    Else
        ' If already open, bring it to front
        carePlans.BringToFront()
    End If
End Sub



Private Sub ResidentFamilyContactsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidentFamilyContactsToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim familyCommunication As FamilyCommunication = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is FamilyCommunication Then
                familyCommunication = CType(familyCommunication, FamilyCommunication)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If familyCommunication Is Nothing Then
        familyCommunication = New FamilyCommunication()
        familyCommunication.Show()
    Else
        ' If already open, bring it to front
        familyCommunication.BringToFront()
    End If
End Sub



Private Sub ResidentReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResidentReportsToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim residentsReports As ResidentsReports = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is ResidentsReports Then
                residentsReports = CType(residentsReports, ResidentsReports)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If residentsReports Is Nothing Then
        residentsReports = New ResidentsReports()
        residentsReports.Show()
    Else
        ' If already open, bring it to front
        residentsReports.BringToFront()
    End If
End Sub


Private Sub MedicineUsageReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicineUsageReportsToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim medicinesReport As MedicinesReport = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is MedicinesReport Then
                medicinesReport = CType(medicinesReport, MedicinesReport)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If medicinesReport Is Nothing Then
        medicinesReport = New MedicinesReport()
        medicinesReport.Show()
    Else
        ' If already open, bring it to front
        medicinesReport.BringToFront()
    End If
End Sub

Private Sub StaffPerformanceReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffPerformanceReportsToolStripMenuItem.Click
     ' Check if the form is already open to prevent multiple instances
    Dim staffPerfomanceReport As StaffPerfomanceReport = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is StaffPerfomanceReport Then
                staffPerfomanceReport = CType(staffPerfomanceReport, StaffPerfomanceReport)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If staffPerfomanceReport Is Nothing Then
        staffPerfomanceReport = New StaffPerfomanceReport()
        staffPerfomanceReport.Show()
    Else
        ' If already open, bring it to front
        staffPerfomanceReport.BringToFront()
    End If
End Sub

	Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
     ' Check if the form is already open to prevent multiple instances
    Dim residentsForm As Residents = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is Residents Then
                residentsForm = CType(residentsForm, Residents)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If residentsForm Is Nothing Then
        residentsForm = New Residents()
        residentsForm.Show()
    Else
        ' If already open, bring it to front
        residentsForm.BringToFront()
    End If
End Sub



Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
    ' Check if the form is already open to prevent multiple instances
    Dim staffForm As Staff = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            staffForm = CType(openForm, Staff)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If staffForm Is Nothing Then
        staffForm = New Staff()
        staffForm.Show()
    Else
        ' If already open, bring it to front
        staffForm.BringToFront()
    End If
End Sub



Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
     ' Check if the form is already open to prevent multiple instances
    Dim medicinesForm As MedicinesForm = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            medicinesForm = CType(openForm, MedicinesForm)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If medicinesForm Is Nothing Then
        medicinesForm = New MedicinesForm()
        medicinesForm.Show()
    Else
        ' If already open, bring it to front
        medicinesForm.BringToFront()
    End If
End Sub



Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
     ' Check if the form is already open to prevent multiple instances
    Dim carePlans As CarePlans = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is CarePlans Then
                carePlans = CType(carePlans, CarePlans)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If carePlans Is Nothing Then
        carePlans = New CarePlans()
        carePlans.Show()
    Else
        ' If already open, bring it to front
        carePlans.BringToFront()
    End If
End Sub


Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
     ' Check if the form is already open to prevent multiple instances
    Dim familyCommunication As FamilyCommunication = Nothing

        ' Loop through open forms to check if Staff form is already opened
        For Each openForm As Form In Application.OpenForms
            If TypeOf openForm Is FamilyCommunication Then
                familyCommunication = CType(familyCommunication, FamilyCommunication)
                Exit For
            End If
        Next

    ' If the form is not open, create a new instance and show it
    If familyCommunication Is Nothing Then
        familyCommunication = New FamilyCommunication()
        familyCommunication.Show()
    Else
        ' If already open, bring it to front
        familyCommunication.BringToFront()
    End If
End Sub


Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
     ' Check if the form is already open to prevent multiple instances
    Dim maintenanceRequestForm As MaintenanceRequests = Nothing

    ' Loop through open forms to check if Staff form is already opened
    For Each openForm As Form In Application.OpenForms
        If TypeOf openForm Is Staff Then
            maintenanceRequestForm = CType(openForm, MaintenanceRequests)
            Exit For
        End If
    Next

    ' If the form is not open, create a new instance and show it
    If maintenanceRequestForm Is Nothing Then
        maintenanceRequestForm = New MaintenanceRequests()
        maintenanceRequestForm.Show()
    Else
        ' If already open, bring it to front
        maintenanceRequestForm.BringToFront()
    End If
End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub
End Class
