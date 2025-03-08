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
End Class
