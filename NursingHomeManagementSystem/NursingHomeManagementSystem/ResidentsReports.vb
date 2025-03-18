Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms


Public Class ResidentsReports
	

Private Sub buttonResidentsData_Click(sender As Object, e As EventArgs) Handles buttonResidentsData.Click
    ' Database connection string
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    
    ' SQL query to fetch data (excluding the Photo column)
    Dim query As String = "SELECT ResidentID, Name, DateOfBirth, MedicalHistory, CarePlan, FamilyContact, AdmissionDate, DischargeDate FROM ResidentsTable"

    ' Create connection and command
    Using conn As New OleDbConnection(connString)
        Try
            conn.Open()
            Dim cmd As New OleDbCommand(query, conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the data to DataGridView
            ResidentsDataDataGridView.DataSource = dt
                ' Set DataGridView properties to allow scrolling
                ResidentsDataDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                ResidentsDataDataGridView.ScrollBars = ScrollBars.Both ' Enable both scrollbars

                ' Adjust column width to fit content (increase width if needed)
                For Each column As DataGridViewColumn In ResidentsDataDataGridView.Columns
                    column.Width = 120 ' Increase column width for better visibility
                Next


                ' Success message
                MessageBox.Show("Residents data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error loading residents data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



    Private Sub buttonGenerateReport_Click(sender As Object, e As EventArgs) Handles buttonGenerateReport.Click
        Try
            ' Create a new ReportDataSource
            Dim reportDataSource As New ReportDataSource("ResidentsDataSet", GetResidentsData())

            ' Clear existing data sources
            ResidentsDataReportViewer.LocalReport.DataSources.Clear()

            ' Add the new data source
            ResidentsDataReportViewer.LocalReport.DataSources.Add(reportDataSource)

            ' Set the report path (make sure the path is correct)
            ResidentsDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.ResidentsReport.rdlc"

            ' Refresh the ReportViewer
            ResidentsDataReportViewer.RefreshReport()

            MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetResidentsData() As DataTable
        Dim dt As New DataTable()

        ' Define columns (same as XSD dataset structure)
        dt.Columns.Add("ResidentID", GetType(Integer))
        dt.Columns.Add("Name", GetType(String))
        dt.Columns.Add("DateOfBirth", GetType(Date))
        dt.Columns.Add("MedicalHistory", GetType(String))
        dt.Columns.Add("CarePlan", GetType(String))
        dt.Columns.Add("FamilyContact", GetType(String))
        dt.Columns.Add("AdmissionDate", GetType(Date))
        dt.Columns.Add("DischargeDate", GetType(Date))

        ' Add rows from DataGridView to DataTable
        For Each row As DataGridViewRow In ResidentsDataDataGridView.Rows
            If Not row.IsNewRow Then
                dt.Rows.Add(
                row.Cells("ResidentID").Value,
                row.Cells("Name").Value,
                row.Cells("DateOfBirth").Value,
                row.Cells("MedicalHistory").Value,
                row.Cells("CarePlan").Value,
                row.Cells("FamilyContact").Value,
                row.Cells("AdmissionDate").Value,
                row.Cells("DischargeDate").Value
            )
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
            Dim query As String = "SELECT ResidentID, Name, DateOfBirth, MedicalHistory, CarePlan, FamilyContact, AdmissionDate, DischargeDate FROM ResidentsTable WHERE ResidentID LIKE @SearchText OR Name LIKE @SearchText"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set search parameter (wildcard for partial matching)
            cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

            ' Execute the query and load data into a DataTable
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the DataGridView to the filtered data
            ResidentsDataDataGridView.DataSource = dt

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

    Private Sub ResidentsDataReportViewer_Load(sender As Object, e As EventArgs) Handles ResidentsDataReportViewer.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class