Imports System.Data.OleDb

Public Class CarePlans

    Private Sub CarePlansForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshCarePlans()
    End Sub


    Private Sub buttonAddPlan_Click(sender As Object, e As EventArgs) Handles buttonAddPlan.Click
        ' Validate input fields
        If textResidentID.Text.Trim() = "" OrElse textCarePlanDescription.Text.Trim() = "" Then
            MessageBox.Show("Please fill in all required fields!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database connection string
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()

                ' SQL Insert Query
                Dim query As String = "INSERT INTO CarePlans (ResidentID, CarePlanDescription, StartDate, EndDate, ProgressNotes) VALUES (?, ?, ?, ?, ?)"
                Using cmd As New OleDbCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())
                    cmd.Parameters.AddWithValue("?", textCarePlanDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("?", dateTimeStartDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("?", dateTimeEndDate.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("?", textProgressNotes.Text.Trim())

                    ' Execute insert
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if the insertion was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Care plan added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh DataGridView
                        RefreshCarePlans()

                        ' Clear input fields
                        textResidentID.Clear()
                        textCarePlanDescription.Clear()
                        textProgressNotes.Clear()
                        dateTimeStartDate.Value = DateTime.Now
                        dateTimeEndDate.Value = DateTime.Now
                    Else
                        MessageBox.Show("Failed to add care plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub RefreshCarePlans()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM CarePlans"
                Dim adapter As New OleDbDataAdapter(query, conn)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind data to DataGridView
                CarePlansDataGridView.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error loading care plans: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CarePlansDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CarePlansDataGridView.CellClick
        ' Ensure the user clicked on a valid row (not the header)
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = CarePlansDataGridView.Rows(e.RowIndex)

            ' Fill input fields with the selected row data
            textResidentID.Text = selectedRow.Cells("ResidentID").Value.ToString()
            textCarePlanDescription.Text = selectedRow.Cells("CarePlanDescription").Value.ToString()
            dateTimeStartDate.Value = Convert.ToDateTime(selectedRow.Cells("StartDate").Value)
            dateTimeEndDate.Value = Convert.ToDateTime(selectedRow.Cells("EndDate").Value)
            textProgressNotes.Text = selectedRow.Cells("ProgressNotes").Value.ToString()

            ' Store CarePlanID (use a hidden label or the Tag property of a button)
            buttonUpdatePlan.Tag = selectedRow.Cells("CarePlanID").Value.ToString()

            ' Change button colors
            buttonUpdatePlan.BackColor = Color.Green
            buttonDeletePlan.BackColor = Color.Red
        End If
    End Sub


    Private Sub buttonUpdatePlan_Click(sender As Object, e As EventArgs) Handles buttonUpdatePlan.Click
        ' Ensure a row is selected
        If textResidentID.Text.Trim() = "" Then
            MessageBox.Show("Please select a care plan to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Database connection string
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        Using conn As New OleDbConnection(connString)
            Try
                ' Open connection
                conn.Open()

                ' Update query
                Dim query As String = "UPDATE CarePlans SET CarePlanDescription = ?, StartDate = ?, EndDate = ?, ProgressNotes = ? WHERE ResidentID = ?"
                Using cmd As New OleDbCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("?", textCarePlanDescription.Text.Trim())
                    cmd.Parameters.AddWithValue("?", dateTimeStartDate.Value)
                    cmd.Parameters.AddWithValue("?", dateTimeEndDate.Value)
                    cmd.Parameters.AddWithValue("?", textProgressNotes.Text.Trim())
                    cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())

                    ' Execute update
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Check if update was successful
                    If rowsAffected > 0 Then
                        MessageBox.Show("Care plan updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Refresh DataGridView
                        RefreshCarePlans()

                        ' Clear fields after update
                        textResidentID.Clear()
                        textCarePlanDescription.Clear()
                        textProgressNotes.Clear()
                        dateTimeStartDate.Value = DateTime.Now
                        dateTimeEndDate.Value = DateTime.Now

                        ' Button color effect
                        buttonUpdatePlan.BackColor = System.Drawing.Color.LightSkyBlue
                        buttonDeletePlan.BackColor = System.Drawing.Color.LightSkyBlue
                    Else
                        MessageBox.Show("Update failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub buttonDeletePlan_Click(sender As Object, e As EventArgs) Handles buttonDeletePlan.Click
        ' Ensure a row is selected
        If textResidentID.Text.Trim() = "" Then
            MessageBox.Show("Please select a record to delete.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim selectedCarePlanID As Integer = Convert.ToInt32(buttonUpdatePlan.Tag)

        ' Confirm deletion
        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this care plan?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirmDelete = DialogResult.Yes Then
            ' Database connection string
            Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

            Using conn As New OleDbConnection(connString)
                Try
                    ' Open connection
                    conn.Open()

                    ' Delete query
                    Dim query As String = "DELETE FROM CarePlans WHERE CarePlanID = ?"
                    Using cmd As New OleDbCommand(query, conn)
                        ' Add parameter
                        cmd.Parameters.AddWithValue("?", selectedCarePlanID) ' Use the stored selected CarePlanID

                        ' Execute delete
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        ' Check if delete was successful
                        If rowsAffected > 0 Then
                            MessageBox.Show("Care plan deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh DataGridView
                            RefreshCarePlans()

                            ' Clear input fields
                            ClearFields()

                            ' Button color effect
                            buttonUpdatePlan.BackColor = System.Drawing.Color.LightSkyBlue
                            buttonDeletePlan.BackColor = System.Drawing.Color.LightSkyBlue
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

    Private Sub ClearFields()
        textResidentID.Clear()
        textCarePlanDescription.Clear()
        textProgressNotes.Clear()
        dateTimeStartDate.Value = DateTime.Now
        dateTimeEndDate.Value = DateTime.Now
    End Sub

Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' SQL query to fetch Care Plan details by ResidentID or CarePlanDescription
        Dim query As String = "SELECT * FROM CarePlans WHERE ResidentID LIKE @SearchText OR CarePlanDescription LIKE @SearchText OR CarePlanID LIKE @SearchText"
        Dim cmd As New OleDbCommand(query, conn)

        ' Set search parameter (wildcard for partial matching)
        cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

        ' Execute the query and load data into a DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind the DataGridView to the filtered data
        CarePlansDataGridView.DataSource = dt

        ' Check if any results were found
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Care plan(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching care plans found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles textCarePlanDescription.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textResidentID.TextChanged

    End Sub
End Class