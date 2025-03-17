Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class StaffPerfomanceReport
    Private Sub buttonLoadStaffPerfomance_Click(sender As Object, e As EventArgs) Handles buttonLoadStaffPerfomance.Click
        ' Database connection string
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        ' SQL query to fetch medicine usage data
        Dim query As String = "SELECT * FROM StaffAttendanceTable"

        ' Create connection and command
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand(query, conn)
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the data to DataGridView
                StaffPerfomanceDataGridView.DataSource = dt

                ' Enable scrolling and adjust column sizes
                StaffPerfomanceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                StaffPerfomanceDataGridView.ScrollBars = ScrollBars.Both
                StaffPerfomanceDataGridView.AutoResizeColumns()

                ' Success message
                MessageBox.Show("Medicines usage data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error loading medicines data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
	
	Private Sub buttonGenerateReport_Click(sender As Object, e As EventArgs) Handles buttonGenerateReport.Click
        Try
            ' Create a new ReportDataSource with the DataTable function
            Dim reportDataSource As New ReportDataSource("StaffPerfomanceDataSet", GetStaffPerfomanceData())

            ' Clear existing data sources
            StaffPerfomanceDataReportViewer.LocalReport.DataSources.Clear()

            ' Add the new data source
            StaffPerfomanceDataReportViewer.LocalReport.DataSources.Add(reportDataSource)

            ' Set the report path (make sure the path is correct)
            StaffPerfomanceDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.StaffPerfomanceReport.rdlc"

            ' Refresh the ReportViewer
            StaffPerfomanceDataReportViewer.RefreshReport()

            MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to convert DataGridView data to DataTable
    ' Function to convert DataGridView data to DataTable
Private Function GetStaffPerfomanceData() As DataTable
    Dim dt As New DataTable()

    ' Define columns (same as XSD dataset structure)
    dt.Columns.Add("StaffID", GetType(Integer))
    dt.Columns.Add("FullName", GetType(String))
    dt.Columns.Add("Role", GetType(String))
    dt.Columns.Add("CurrentDate", GetType(Date))
    dt.Columns.Add("CheckInTime", GetType(DateTime))
    dt.Columns.Add("CheckOutTime", GetType(DateTime))
    dt.Columns.Add("Shift", GetType(String))
    dt.Columns.Add("Attendance", GetType(String))
    dt.Columns.Add("MonthlyCount", GetType(Integer))
    dt.Columns.Add("YearlyCount", GetType(Integer))

    ' Add rows from DataGridView to DataTable
    For Each row As DataGridViewRow In StaffPerfomanceDataGridView.Rows
        If Not row.IsNewRow Then
            dt.Rows.Add(
                If(row.Cells("StaffID").Value IsNot Nothing, row.Cells("StaffID").Value, DBNull.Value),
                If(row.Cells("FullName").Value IsNot Nothing, row.Cells("FullName").Value, DBNull.Value),
                If(row.Cells("Role").Value IsNot Nothing, row.Cells("Role").Value, DBNull.Value),
                If(row.Cells("CurrentDate").Value IsNot Nothing, row.Cells("CurrentDate").Value, DBNull.Value),
                If(row.Cells("CheckInTime").Value IsNot Nothing, row.Cells("CheckInTime").Value, DBNull.Value),
                If(row.Cells("CheckOutTime").Value IsNot Nothing, row.Cells("CheckOutTime").Value, DBNull.Value),
                If(row.Cells("Shift").Value IsNot Nothing, row.Cells("Shift").Value, DBNull.Value),
                If(row.Cells("Attendance").Value IsNot Nothing, row.Cells("Attendance").Value, DBNull.Value),
                If(row.Cells("MonthlyCount").Value IsNot Nothing, row.Cells("MonthlyCount").Value, DBNull.Value),
                If(row.Cells("YearlyCount").Value IsNot Nothing, row.Cells("YearlyCount").Value, DBNull.Value)
            ) ' <-- Removed the extra comma here!
        End If
    Next

    Return dt
End Function

	
	Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            ' Open the connection
            conn.Open()

            ' SQL query to fetch Resident details by ID or Name
            Dim query As String = "SELECT * FROM StaffAttendanceTable WHERE StaffID LIKE @SearchText"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set search parameter (wildcard for partial matching)
            cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

            ' Execute the query and load data into a DataTable
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the DataGridView to the filtered data
            StaffPerfomanceDataGridView.DataSource = dt

            ' Check if any results were found
            If dt.Rows.Count > 0 Then
                MessageBox.Show("Resident(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("No matching residents found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub
End Class