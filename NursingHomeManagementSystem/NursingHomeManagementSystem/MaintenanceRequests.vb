Imports System.Data.OleDb

Public Class MaintenanceRequests

Private Sub MaintenanceRequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' Refresh DataGridView with existing maintenance requests when the form loads
    RefreshMaintenanceRequests()
End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combostatus.SelectedIndexChanged

    End Sub
	
	Private Sub Butaddrequest_Click(sender As Object, e As EventArgs) Handles Butupdate.Click
    ' Validate required fields
    If String.IsNullOrEmpty(textreportedby.Text.Trim()) OrElse
       String.IsNullOrEmpty(textissuedescription.Text.Trim()) OrElse
       String.IsNullOrEmpty(combomaintenancetype.Text.Trim()) OrElse
       String.IsNullOrEmpty(combostatus.Text.Trim()) Then

        MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Get input values
    Dim reportedBy As String = textreportedby.Text.Trim()
    Dim issueDescription As String = textissuedescription.Text.Trim()
    Dim maintenanceType As String = combomaintenancetype.Text.Trim()
    Dim status As String = combostatus.Text.Trim()
    Dim assignedTechnician As String = textassignedtechnician.Text.Trim()

    ' Database connection
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        conn.Open()

        ' SQL query to insert the request (AutoNumber RequestID will be generated automatically)
        Dim query As String = "INSERT INTO MaintenanceRequestTable (ReportedBy, IssueDescription, MaintenanceType, Status, AssignedTechnician) VALUES (?, ?, ?, ?, ?)"
        Dim cmd As New OleDbCommand(query, conn)

        ' Add parameters to prevent SQL injection
        cmd.Parameters.AddWithValue("?", reportedBy)
        cmd.Parameters.AddWithValue("?", issueDescription)
        cmd.Parameters.AddWithValue("?", maintenanceType)
        cmd.Parameters.AddWithValue("?", status)
        cmd.Parameters.AddWithValue("?", If(String.IsNullOrEmpty(assignedTechnician), DBNull.Value, assignedTechnician)) ' Allow empty technician name

        ' Execute the query
        cmd.ExecuteNonQuery()

        ' Show success message
        MessageBox.Show("Maintenance request added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh DataGridView
        RefreshMaintenanceRequests()

        ' Clear input fields after successful insertion
        textreportedby.Clear()
        textissuedescription.Clear()
        combomaintenancetype.SelectedIndex = -1
        combostatus.SelectedIndex = -1
        textassignedtechnician.Clear()

    Catch ex As Exception
        MessageBox.Show("Error adding maintenance request: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub

Private Sub RefreshMaintenanceRequests()
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        conn.Open()
        Dim query As String = "SELECT * FROM MaintenanceRequestTable"
        Dim adapter As New OleDbDataAdapter(query, conn)
        Dim dt As New DataTable()

        ' Fill DataTable with database data
        adapter.Fill(dt)

        ' Bind DataGridView to DataTable
        MaintenanceRequestDataGridView.DataSource = dt

    Catch ex As Exception
        MessageBox.Show("Error loading maintenance requests: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub

Private Sub MaintenanceRequestDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MaintenanceRequestDataGridView.CellClick
    ' Ensure the user clicked a valid row (not the header)
    If e.RowIndex >= 0 Then
        ' Get the selected row
        Dim selectedRow As DataGridViewRow = MaintenanceRequestDataGridView.Rows(e.RowIndex)

        ' Fill input fields with selected row data
        textreportedby.Text = selectedRow.Cells("ReportedBy").Value.ToString()
        textissuedescription.Text = selectedRow.Cells("IssueDescription").Value.ToString()
        combomaintenancetype.Text = selectedRow.Cells("MaintenanceType").Value.ToString()
        combostatus.Text = selectedRow.Cells("Status").Value.ToString()
        textassignedtechnician.Text = selectedRow.Cells("AssignedTechnician").Value.ToString()

        ' Store RequestID in the button tag (for easy reference when generating report)
        Butgeneratereport.Tag = selectedRow.Cells("RequestID").Value.ToString()
    End If
End Sub

Private Sub Butgeneratereport_Click(sender As Object, e As EventArgs) Handles Butgeneratereport.Click
    ' Ensure a row is selected
    If Butgeneratereport.Tag Is Nothing Then
        MessageBox.Show("Please select a maintenance request to generate a report.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return
    End If

    ' Get the selected RequestID
    Dim selectedRequestID As Integer = CInt(Butgeneratereport.Tag)

    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        conn.Open()

        ' SQL Query to fetch details of the selected maintenance request
        Dim query As String = "SELECT * FROM MaintenanceRequestTable WHERE RequestID = ?"
        Dim cmd As New OleDbCommand(query, conn)
        cmd.Parameters.AddWithValue("?", selectedRequestID)

        ' Load data into DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Check if data exists
        If dt.Rows.Count = 0 Then
            MessageBox.Show("No data found for the selected request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Set up the ReportViewer
        Dim ReportDataSource1 As New Microsoft.Reporting.WinForms.ReportDataSource()
        ReportDataSource1.Name = "DataSet1"  ' Must match the dataset name in RDLC
        ReportDataSource1.Value = dt

        ' Clear previous data sources and add the new one
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)

        ' Refresh the ReportViewer
        ReportViewer1.RefreshReport()

    Catch ex As Exception
        MessageBox.Show("Error loading report: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub

Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' SQL query to fetch Maintenance Request details by RequestID or ReportedBy
        Dim query As String = "SELECT * FROM MaintenanceRequestTable WHERE RequestID LIKE @SearchText OR ReportedBy LIKE @SearchText"
        Dim cmd As New OleDbCommand(query, conn)

        ' Set search parameter (wildcard for partial matching)
        cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

        ' Execute the query and load data into a DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind the DataGridView to the filtered data
        MaintenanceRequestDataGridView.DataSource = dt

        ' Check if any results were found
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Maintenance request(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching maintenance requests found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub

    Private Sub textsearch_TextChanged(sender As Object, e As EventArgs) Handles textsearch.TextChanged

    End Sub

    Private Sub textreportedby_TextChanged(sender As Object, e As EventArgs) Handles textreportedby.TextChanged

    End Sub
End Class