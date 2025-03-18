Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class MedicinesReport

    Private Sub buttonLoadMedicines_Click(sender As Object, e As EventArgs) Handles buttonLoadMedicines.Click
        ' Database connection string
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        ' SQL query to fetch medicine usage data
        Dim query As String = "SELECT ResidentID, MedicineName, Dosage, Frequency, StartDate, EndDate, DrugIssues FROM Medicines"

        ' Create connection and command
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim cmd As New OleDbCommand(query, conn)
                Dim adapter As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                ' Bind the data to DataGridView
                MedicinesUsageReportDataGridView.DataSource = dt

                ' Enable scrolling and adjust column sizes
                MedicinesUsageReportDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
                MedicinesUsageReportDataGridView.ScrollBars = ScrollBars.Both
                MedicinesUsageReportDataGridView.AutoResizeColumns()

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
            Dim reportDataSource As New ReportDataSource("MedicineUsageDataSet", GetMedicineUsageData())

            ' Clear existing data sources
            MedicinesDataDataReportViewer.LocalReport.DataSources.Clear()

            ' Add the new data source
            MedicinesDataDataReportViewer.LocalReport.DataSources.Add(reportDataSource)

            ' Set the report path (make sure the path is correct)
            MedicinesDataDataReportViewer.LocalReport.ReportEmbeddedResource = "NursingHomeManagementSystem.MedicineUsageReport.rdlc"

            ' Refresh the ReportViewer
            MedicinesDataDataReportViewer.RefreshReport()

            MessageBox.Show("Report generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Function to convert DataGridView data to DataTable
    Private Function GetMedicineUsageData() As DataTable
        Dim dt As New DataTable()

        ' Define columns (same as XSD dataset structure)
        dt.Columns.Add("ResidentID", GetType(Integer))
        dt.Columns.Add("MedicineName", GetType(String))
        dt.Columns.Add("Dosage", GetType(String))
        dt.Columns.Add("Frequency", GetType(String))
        dt.Columns.Add("StartDate", GetType(Date))
        dt.Columns.Add("EndDate", GetType(Date))
        dt.Columns.Add("DrugIssues", GetType(String))

        ' Add rows from DataGridView to DataTable
        For Each row As DataGridViewRow In MedicinesUsageReportDataGridView.Rows
            If Not row.IsNewRow Then
                dt.Rows.Add(
                If(row.Cells("ResidentID").Value IsNot Nothing, row.Cells("ResidentID").Value, DBNull.Value),
                If(row.Cells("MedicineName").Value IsNot Nothing, row.Cells("MedicineName").Value, DBNull.Value),
                If(row.Cells("Dosage").Value IsNot Nothing, row.Cells("Dosage").Value, DBNull.Value),
                If(row.Cells("Frequency").Value IsNot Nothing, row.Cells("Frequency").Value, DBNull.Value),
                If(row.Cells("StartDate").Value IsNot Nothing, row.Cells("StartDate").Value, DBNull.Value),
                If(row.Cells("EndDate").Value IsNot Nothing, row.Cells("EndDate").Value, DBNull.Value),
                If(row.Cells("DrugIssues").Value IsNot Nothing, row.Cells("DrugIssues").Value, DBNull.Value)
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
            Dim query As String = "SELECT * FROM Medicines WHERE ResidentID LIKE @SearchText"
            Dim cmd As New OleDbCommand(query, conn)

            ' Set search parameter (wildcard for partial matching)
            cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

            ' Execute the query and load data into a DataTable
            Dim adapter As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            ' Bind the DataGridView to the filtered data
            MedicinesUsageReportDataGridView.DataSource = dt

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

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButSearch_Click_1(sender As Object, e As EventArgs) Handles ButSearch.Click

    End Sub

    Private Sub MedicinesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class