Imports System.Windows.Forms

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

End Class
