Imports System.Data.OleDb

Public Class FamilyCommunication
    Private Sub FamilyCommunication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
	RefreshFamilyCommunication()
    End Sub
	
	Private Sub buttonAddFamilyContact_Click(sender As Object, e As EventArgs) Handles buttonAddFamilyContact.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

    Using conn As New OleDbConnection(connString)
        Try
            ' Open the database connection
            conn.Open()

            ' Insert query
            Dim query As String = "INSERT INTO FamilyCommunication (ResidentID, FamilyContact, ContactDate, ContactMethod, StaffID, ReasonForContact, FollowUpRequired, FollowUpDetails) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
            Using cmd As New OleDbCommand(query, conn)
                ' Add values to parameters
                cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFamilyContact.Text.Trim())
                cmd.Parameters.AddWithValue("?", dateTimeContactDate.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("?", textContactMethod.Text.Trim())
                cmd.Parameters.AddWithValue("?", textStaffID.Text.Trim())
                cmd.Parameters.AddWithValue("?", textReasonForContact.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFollowUpRequired.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFollowUpDetails.Text.Trim())

                ' Execute query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if insert was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Family contact added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh DataGridView
                    RefreshFamilyCommunication()

                    ' Clear input fields after successful insertion
                    ClearFields()
                Else
                    MessageBox.Show("Failed to add family contact.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub


Private Sub RefreshFamilyCommunication()
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    
    Using conn As New OleDbConnection(connString)
        Try
            ' Open connection
            conn.Open()

            ' Query to get all records
            Dim query As String = "SELECT * FROM FamilyCommunication"
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind data to DataGridView
            FamilyContactsDataGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error loading family communication records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

Private Sub ClearFields()
    textResidentID.Clear()
    textFamilyContact.Clear()
    textContactMethod.Clear()
    textStaffID.Clear()
    textReasonForContact.Clear()
    textFollowUpRequired.Clear()
    textFollowUpDetails.Clear()
    dateTimeContactDate.Value = DateTime.Now

    ' Reset button colors
    buttonUpdateFamilyContact.BackColor = System.Drawing.Color.LightSkyBlue
    buttonDeleteFamilyContact.BackColor = System.Drawing.Color.LightSkyBlue

    ' Clear tag
    textResidentID.Tag = Nothing
End Sub


	Private Sub FamilyContactsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FamilyContactsDataGridView.CellClick
    ' Ensure the user clicked on a valid row (not the header)
    If e.RowIndex >= 0 Then
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = FamilyContactsDataGridView.Rows(e.RowIndex)

        ' Fill input fields with the selected row data
        textResidentID.Text = selectedRow.Cells("ResidentID").Value.ToString()
        textFamilyContact.Text = selectedRow.Cells("FamilyContact").Value.ToString()
        dateTimeContactDate.Value = Convert.ToDateTime(selectedRow.Cells("ContactDate").Value)
        textContactMethod.Text = selectedRow.Cells("ContactMethod").Value.ToString()
        textStaffID.Text = selectedRow.Cells("StaffID").Value.ToString()
        textReasonForContact.Text = selectedRow.Cells("ReasonForContact").Value.ToString()
        textFollowUpRequired.Text = selectedRow.Cells("FollowUpRequired").Value.ToString()
        textFollowUpDetails.Text = selectedRow.Cells("FollowUpDetails").Value.ToString()

        ' Store the CommunicationID in the tag
        textResidentID.Tag = selectedRow.Cells("CommunicationID").Value.ToString()

        ' Change button colors to indicate selection
        buttonUpdateFamilyContact.BackColor = Color.Green
        buttonDeleteFamilyContact.BackColor = Color.Red
    End If
End Sub

	
	Private Sub buttonUpdateFamilyContact_Click(sender As Object, e As EventArgs) Handles buttonUpdateFamilyContact.Click
    ' Ensure a record is selected
    If textResidentID.Tag Is Nothing Then
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
            Dim query As String = "UPDATE FamilyCommunication SET ResidentID = ?, FamilyContact = ?, ContactDate = ?, ContactMethod = ?, StaffID = ?, ReasonForContact = ?, FollowUpRequired = ?, FollowUpDetails = ? WHERE CommunicationID = ?"
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameters
                cmd.Parameters.AddWithValue("?", textResidentID.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFamilyContact.Text.Trim())
                cmd.Parameters.AddWithValue("?", dateTimeContactDate.Value)
                cmd.Parameters.AddWithValue("?", textContactMethod.Text.Trim())
                cmd.Parameters.AddWithValue("?", textStaffID.Text.Trim())
                cmd.Parameters.AddWithValue("?", textReasonForContact.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFollowUpRequired.Text.Trim())
                cmd.Parameters.AddWithValue("?", textFollowUpDetails.Text.Trim())
                cmd.Parameters.AddWithValue("?", textResidentID.Tag.ToString()) ' CommunicationID stored in tag

                ' Execute update
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if update was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Family communication record updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh DataGridView
                    RefreshFamilyCommunication()

                    ' Clear input fields
                    ClearFields()
                Else
                    MessageBox.Show("Update failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

   Private Sub buttonDeleteFamilyContact_Click(sender As Object, e As EventArgs) Handles buttonDeleteFamilyContact.Click
    ' Ensure a record is selected
    If textResidentID.Tag Is Nothing Then
        MessageBox.Show("Please select a record to delete.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Confirm deletion
    Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    If confirmDelete <> DialogResult.Yes Then
        Return
    End If

    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

    Using conn As New OleDbConnection(connString)
        Try
            ' Open connection
            conn.Open()

            ' Delete query
            Dim query As String = "DELETE FROM FamilyCommunication WHERE CommunicationID = ?"
            Using cmd As New OleDbCommand(query, conn)
                ' Add parameter
                cmd.Parameters.AddWithValue("?", textResidentID.Tag.ToString()) ' Using CommunicationID from Tag

                ' Execute delete
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if delete was successful
                If rowsAffected > 0 Then
                    MessageBox.Show("Family communication record deleted successfully!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Refresh DataGridView
                    RefreshFamilyCommunication()

                    ' Clear input fields
                    ClearFields()
                Else
                    MessageBox.Show("Delete failed. Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Using
End Sub

Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' SQL query to fetch Family Communication details by ResidentID, FamilyContact, or CommunicationID
        Dim query As String = "SELECT * FROM FamilyCommunication WHERE ResidentID LIKE @SearchText OR FamilyContact LIKE @SearchText OR CommunicationID LIKE @SearchText"
        Dim cmd As New OleDbCommand(query, conn)

        ' Set search parameter (wildcard for partial matching)
        cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

        ' Execute the query and load data into a DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind the DataGridView to the filtered data
        FamilyContactsDataGridView.DataSource = dt

        ' Check if any results were found
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Family communication record(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching records found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub


    
End Class