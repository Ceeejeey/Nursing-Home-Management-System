Imports System.Data.OleDb

Public Class MedicinesForm


	Private Sub MedicineForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    RefreshMedicineData()
	End Sub

	
	Private Sub ButAddMedicine_Click(sender As Object, e As EventArgs) Handles ButAddMedicine.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    
    ' Create a new database connection
    Using conn As New OleDbConnection(connString)
        Try
            conn.Open()

            ' SQL query to insert data
            Dim query As String = "INSERT INTO Medicines (ResidentID, MedicineName, Dosage, Frequency, StartDate, EndDate, DrugIssues) VALUES (?, ?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())
                cmd.Parameters.AddWithValue("?", textMedicineName.Text.Trim())
                cmd.Parameters.AddWithValue("?", textDosage.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFrequency.Text.Trim())
                cmd.Parameters.AddWithValue("?", dateTimeStartDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("?", dateTimeEndDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("?", textDrugIssues.Text.Trim())

                ' Execute query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if insertion was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Medicine issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    
                    ' Refresh the DataGridView
                    RefreshMedicineData()
                Else
                    MessageBox.Show("Failed to issue medicine.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

Private Sub RefreshMedicineData()
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

    ' Create a new database connection
    Using conn As New OleDbConnection(connString)
        Try
            conn.Open()
            ' SQL query to fetch all medicine records
            Dim query As String = "SELECT * FROM Medicines"
            Using cmd As New OleDbCommand(query, conn)
                ' Execute the query and fill the DataTable
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind DataGridView to the fetched data
                IssueMedicineDataGridView.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

Private Sub IssueMedicineDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IssueMedicineDataGridView.CellClick
    ' Ensure a valid row index is selected (avoid clicking the header row)
    If e.RowIndex >= 0 Then
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = IssueMedicineDataGridView.Rows(e.RowIndex)

        ' Fill the input fields with the selected row's data
        textResidentID.Text = selectedRow.Cells("ResidentID").Value.ToString()
        textMedicineName.Text = selectedRow.Cells("MedicineName").Value.ToString()
        textDosage.Text = selectedRow.Cells("Dosage").Value.ToString()
        textFrequency.Text = selectedRow.Cells("Frequency").Value.ToString()
        dateTimeStartDate.Value = Convert.ToDateTime(selectedRow.Cells("StartDate").Value)
        dateTimeEndDate.Value = Convert.ToDateTime(selectedRow.Cells("EndDate").Value)
        textDrugIssues.Text = selectedRow.Cells("DrugIssues").Value.ToString()
		
		ButUpdate.BackColor = Color.Green
        ButDelete.BackColor = Color.Red
    End If
End Sub

Private Sub ButUpdate_Click(sender As Object, e As EventArgs) Handles ButUpdate.Click
    ' Ensure a row is selected
    If textResidentID.Text.Trim() = "" Then
        MessageBox.Show("Please select a record to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    
    Using conn As New OleDbConnection(connString)
        Try
            ' Open connection
            conn.Open()

            ' Update query
            Dim query As String = "UPDATE Medicines SET MedicineName = ?, Dosage = ?, Frequency = ?, StartDate = ?, EndDate = ?, DrugIssues = ? WHERE ResidentID = ?"
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("?", textMedicineName.Text.Trim())
                cmd.Parameters.AddWithValue("?", textDosage.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFrequency.Text.Trim())
                cmd.Parameters.AddWithValue("?", dateTimeStartDate.Value)
                cmd.Parameters.AddWithValue("?", dateTimeEndDate.Value)
                cmd.Parameters.AddWithValue("?", textDrugIssues.Text.Trim())
                cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())

                ' Execute update
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Medicine record updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh DataGridView
                    RefreshMedicineData()

                    ' Clear input fields
                    ClearInputFields()

                    ' Change button colors for better UX
                    ButUpdate.BackColor = System.Drawing.Color.LightSkyBlue
                    ButDelete.BackColor = System.Drawing.Color.LightSkyBlue
                Else
                    MessageBox.Show("Update failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
    ' Ensure a row is selected
    If textResidentID.Text.Trim() = "" Then
        MessageBox.Show("Please select a record to delete.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Confirm before deleting
    Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    If confirm = DialogResult.Yes Then
        ' Database connection string
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        
        Using conn As New OleDbConnection(connString)
            Try
                ' Open connection
                conn.Open()

                ' Delete query
                Dim query As String = "DELETE FROM Medicines WHERE ResidentID = ?"
                Using cmd As New OleDbCommand(query, conn)
                    ' Add parameter
                    cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())

                    ' Execute delete
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if delete was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Medicine record deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh DataGridView
                        RefreshMedicineData()

                        ' Clear input fields
                        ClearInputFields()

                        ' Change button colors for better UX
                        ButUpdate.BackColor = System.Drawing.Color.LightSkyBlue
                        ButDelete.BackColor = System.Drawing.Color.LightSkyBlue
                    Else
                        MessageBox.Show("Delete failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End If
End Sub

Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' SQL query to fetch medicine records by ResidentID
        Dim query As String = "SELECT * FROM Medicines WHERE ResidentID LIKE @SearchText"
        Dim cmd As New OleDbCommand(query, conn)

        ' Set search parameter (wildcard for partial matching)
        cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

        ' Execute the query and load data into a DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind the DataGridView to the filtered data
        IssueMedicineDataGridView.DataSource = dt

        ' Check if any results were found
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Medicine records found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching medicine records found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub

Private Sub ClearInputFields()
    textResidentID.Clear()
    textMedicineName.Clear()
    textDosage.Clear()
    textFrequency.Clear()
    textDrugIssues.Clear()
    dateTimeStartDate.Value = DateTime.Now
    dateTimeEndDate.Value = DateTime.Now
End Sub


End Class