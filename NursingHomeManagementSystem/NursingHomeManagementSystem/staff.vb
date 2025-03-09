Imports System.Data.OleDb

Public Class Staff

    Private Sub addbutton_Click(sender As Object, e As EventArgs) Handles addbutton.Click
    ' Validate required fields
    If String.IsNullOrWhiteSpace(txtstaffid.Text) OrElse
       String.IsNullOrWhiteSpace(txtfulname.Text) OrElse
       String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
       roledrop.SelectedIndex = -1 OrElse
       genderdrop.SelectedIndex = -1 Then

        MessageBox.Show("Please fill in all fields before adding staff.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Confirmation message before adding staff
    Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to add this staff member?", "Confirm Addition", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If confirm = DialogResult.Yes Then
        ' Database connection string (same as used before)
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            ' Open database connection
            conn.Open()

            ' SQL query to insert staff details
            Dim query As String = "INSERT INTO StaffTable (StaffID, FullName, Role, Contact, Gender) VALUES (?, ?, ?, ?, ?)"
            Dim cmd As New OleDbCommand(query, conn)

            ' Assign parameters
            cmd.Parameters.AddWithValue("?", txtstaffid.Text)
            cmd.Parameters.AddWithValue("?", txtfulname.Text)
            cmd.Parameters.AddWithValue("?", roledrop.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("?", txtcontact.Text)
            cmd.Parameters.AddWithValue("?", genderdrop.SelectedItem.ToString())

            ' Execute insert query
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Staff member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh DataGridView after insertion
                RefreshDataGridView()

                ' Clear input fields
                txtstaffid.Clear()
                txtfulname.Clear()
                txtcontact.Clear()
                roledrop.SelectedIndex = -1
                genderdrop.SelectedIndex = -1
            Else
                MessageBox.Show("Failed to add staff. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error adding staff: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End If
End Sub

Private Sub RefreshDataGridView()
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the database connection
        conn.Open()

        ' SQL query to fetch all staff records
        Dim query As String = "SELECT StaffID, FullName, Role, Contact, Gender FROM StaffTable"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim table As New DataTable()

        ' Fill DataTable with fetched data
        adapter.Fill(table)

        ' Bind DataTable to DataGridView
        DataGridViewstafflist.DataSource = table
		' Resize columns to fill the entire DataGridView width
		DataGridViewstafflist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


    Catch ex As Exception
        MessageBox.Show("Error loading staff data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        ' Close the connection
        conn.Close()
    End Try
End Sub

Private Sub DataGridViewstafflist_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewstafflist.CellClick
    ' Ensure a valid row is clicked
    If e.RowIndex >= 0 Then
        Dim row As DataGridViewRow = DataGridViewstafflist.Rows(e.RowIndex)

        ' Fill input fields with selected staff data
        txtstaffid.Text = row.Cells("StaffID").Value.ToString()
        txtfulname.Text = row.Cells("FullName").Value.ToString()
        roledrop.Text = row.Cells("Role").Value.ToString()
        txtcontact.Text = row.Cells("Contact").Value.ToString()
        genderdrop.Text = row.Cells("Gender").Value.ToString()

        ' Change button colors
        updatebutton.BackColor = Color.Green
        deletebutton.BackColor = Color.Red
    End If
End Sub

Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
    ' Ensure a staff member is selected
    If String.IsNullOrWhiteSpace(txtstaffid.Text) Then
        MessageBox.Show("Please select a staff member to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Confirmation message box
    Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to update this staff member?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    If confirm = DialogResult.Yes Then
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' SQL query to update staff details
            Dim query As String = "UPDATE StaffTable SET FullName = ?, Role = ?, Contact = ?, Gender = ? WHERE StaffID = ?"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set parameters
            cmd.Parameters.AddWithValue("?", txtfulname.Text)
            cmd.Parameters.AddWithValue("?", roledrop.Text)
            cmd.Parameters.AddWithValue("?", txtcontact.Text)
            cmd.Parameters.AddWithValue("?", genderdrop.Text)
            cmd.Parameters.AddWithValue("?", txtstaffid.Text)

            ' Execute update
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Staff member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataGridView() ' Refresh DataGridView
				
				txtstaffid.Clear()
                txtfulname.Clear()
                roledrop.SelectedIndex = -1
                txtcontact.Clear()
                genderdrop.SelectedIndex = -1
				updatebutton.BackColor = System.Drawing.Color.LightSkyBlue
				deletebutton.BackColor = System.Drawing.Color.LightSkyBlue

            Else
                MessageBox.Show("Failed to update staff member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating staff member: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End If
End Sub

Private Sub deletebutton_Click(sender As Object, e As EventArgs) Handles deletebutton.Click
    ' Ensure a staff member is selected
    If String.IsNullOrWhiteSpace(txtstaffid.Text) Then
        MessageBox.Show("Please select a staff member to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Confirmation message box
    Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to delete this staff member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

    If confirm = DialogResult.Yes Then
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' SQL query to delete staff
            Dim query As String = "DELETE FROM StaffTable WHERE StaffID = ?"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set parameter (Staff ID)
            cmd.Parameters.AddWithValue("?", txtstaffid.Text)

            ' Execute delete
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Staff member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh DataGridView to remove deleted entry
                RefreshDataGridView()

                ' Clear input fields and reset button colors
                txtstaffid.Clear()
                txtfulname.Clear()
                roledrop.SelectedIndex = -1
                txtcontact.Clear()
                genderdrop.SelectedIndex = -1
                updatebutton.BackColor = System.Drawing.Color.LightSkyBlue
				deletebutton.BackColor = System.Drawing.Color.LightSkyBlue
            Else
                MessageBox.Show("Failed to delete staff member. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting staff member: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End If
End Sub

Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
            ' Open the connection
            conn.Open()

            ' SQL query to fetch Staff details by StaffID or Name
            Dim query As String = "SELECT * FROM StaffTable WHERE StaffID LIKE @SearchText OR FullName LIKE @SearchText"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set search parameter (wildcard for partial matching)
            cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

            ' Execute the query and load data into a DataTable
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the DataGridView to the filtered data
            DataGridViewstafflist.DataSource = dt

            ' Check if any results were found
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Staff member(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matching staff found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub



    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshDataGridView()
    End Sub




End Class