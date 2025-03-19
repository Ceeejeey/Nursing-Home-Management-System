Imports System.Data.OleDb

Public Class StaffAttendance
	' When the form loads, set check-in time and clear check-out time
Private Sub StaffAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set check-in time to the current time


        RefreshDataGridView()

    End Sub

    ' When user clicks "Check In Time" button, update the text box with current date and time
    Private Sub checkintimebutton_Click(sender As Object, e As EventArgs) Handles checkintimebutton.Click
        textcheckintime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    ' When user clicks "Check Out Time" button, update the text box with current date and time
    Private Sub checkouttimebutton_Click(sender As Object, e As EventArgs) Handles checkouttimebutton.Click
        textcheckouttime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub currentdatebutton_Click(sender As Object, e As EventArgs) Handles currentdatebutton.Click
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()

                ' Step 1: Get all staff details from StaffTable
                Dim queryFetch As String = "SELECT StaffID, FullName, Role FROM StaffTable"
                Dim staffList As New List(Of Tuple(Of Integer, String, String))()

                Using cmdFetch As New OleDbCommand(queryFetch, conn)
                    Using reader As OleDbDataReader = cmdFetch.ExecuteReader()
                        While reader.Read()
                            Dim staffID As Integer = Convert.ToInt32(reader("StaffID"))
                            Dim fullName As String = reader("FullName").ToString()
                            Dim role As String = reader("Role").ToString()
                            staffList.Add(Tuple.Create(staffID, fullName, role))
                        End While
                    End Using
                End Using

                ' Step 2: Insert new staff and update existing ones in StaffAttendanceTable
                For Each staff In staffList
                    Dim staffID As Integer = staff.Item1
                    Dim fullName As String = staff.Item2
                    Dim role As String = staff.Item3
                    Dim currentDate As Date = DateTime.Now.Date ' Store as Date type

                    ' Check if the staff already exists in StaffAttendanceTable
                    Dim checkQuery As String = "SELECT COUNT(*) FROM StaffAttendanceTable WHERE StaffID = ?"
                    Using checkCmd As New OleDbCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("?", staffID)

                        Dim result As Object = checkCmd.ExecuteScalar()
                        Dim count As Integer = If(result IsNot Nothing, Convert.ToInt32(result), 0)

                        If count = 0 Then
                            ' Insert new staff if they are not in the attendance table
                            Dim insertQuery As String = "INSERT INTO StaffAttendanceTable (StaffID, FullName, Role, CurrentDate) VALUES (?, ?, ?, ?)"
                            Using insertCmd As New OleDbCommand(insertQuery, conn)
                                insertCmd.Parameters.AddWithValue("?", staffID)
                                insertCmd.Parameters.AddWithValue("?", fullName)
                                insertCmd.Parameters.AddWithValue("?", role)
                                insertCmd.Parameters.AddWithValue("?", currentDate)
                                insertCmd.ExecuteNonQuery()
                            End Using
                        Else
                            ' Update existing staff's CurrentDate in the attendance table
                            Dim updateQuery As String = "UPDATE StaffAttendanceTable SET CurrentDate = ? WHERE StaffID = ?"
                            Using updateCmd As New OleDbCommand(updateQuery, conn)
                                updateCmd.Parameters.AddWithValue("?", currentDate)
                                updateCmd.Parameters.AddWithValue("?", staffID)
                                updateCmd.ExecuteNonQuery()
                            End Using
                        End If
                    End Using
                Next
            End Using

            ' Refresh DataGridView to show updated records
            RefreshDataGridView()
            MessageBox.Show("Attendance records updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub RefreshDataGridView()
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' Fetch all records from StaffAttendanceTable
            Dim query As String = "SELECT * FROM StaffAttendanceTable ORDER BY CurrentDate DESC, StaffID ASC"
            Dim adapter As New OleDbDataAdapter(query, conn)
            Dim dt As New DataTable()

            ' Fill DataTable with fetched records
            adapter.Fill(dt)

            ' Bind DataGridView to the updated DataTable
            StaffAttendanceDataGridView.DataSource = dt

            ' Auto-size columns for better display
            '' StaffAttendanceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error loading attendance records: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub StaffAttendanceDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffAttendanceDataGridView.CellClick
        ' Ensure the user clicked a valid row (not the header)
        If e.RowIndex >= 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = StaffAttendanceDataGridView.Rows(e.RowIndex)

            ' Retrieve Staff ID and Name
            Dim staffID As String = selectedRow.Cells("StaffID").Value.ToString()
            Dim staffName As String = selectedRow.Cells("FullName").Value.ToString()

            ' Retrieve the attendance details for the selected staff
            Dim checkInTime As String = If(selectedRow.Cells("CheckInTime").Value IsNot DBNull.Value, selectedRow.Cells("CheckInTime").Value.ToString(), "")
            Dim checkOutTime As String = If(selectedRow.Cells("CheckOutTime").Value IsNot DBNull.Value, selectedRow.Cells("CheckOutTime").Value.ToString(), "")
            Dim shift As String = If(selectedRow.Cells("Shift").Value IsNot DBNull.Value, selectedRow.Cells("Shift").Value.ToString(), "")
            Dim status As String = If(selectedRow.Cells("Attendance").Value IsNot DBNull.Value, selectedRow.Cells("Attendance").Value.ToString(), "")

            ' Update the label with selected staff details
            selectedstaff.Text = "Selected Staff: " & staffID & " - " & staffName
            selectedstaff.Tag = staffID ' Store StaffID in the Tag property for easy access

            ' Fill input fields with the attendance details
            textcheckintime.Text = checkInTime
            textcheckouttime.Text = checkOutTime
            shiftdrop.Text = shift
            statusdrop.Text = status
        End If
    End Sub


    Private Sub markattendancebutton_Click(sender As Object, e As EventArgs) Handles markattendancebutton.Click
        ' Check if a staff member is selected
        If String.IsNullOrEmpty(selectedstaff.Text) OrElse selectedstaff.Tag Is Nothing Then
            MessageBox.Show("Please select a staff member to mark attendance.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get the Staff ID from the label's Tag property
        Dim staffID As String = selectedstaff.Tag.ToString()



        ' Get input values from textboxes instead of DateTimePickers
        Dim checkInTime As String = If(String.IsNullOrEmpty(textcheckintime.Text.Trim()), "", textcheckintime.Text.Trim())
        Dim checkOutTime As String = If(String.IsNullOrEmpty(textcheckouttime.Text.Trim()), "", textcheckouttime.Text.Trim())

        Dim shift As String = shiftdrop.Text
        Dim status As String = statusdrop.Text
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")

        ' Get current month and year
        Dim currentMonth As Integer = DateTime.Now.Month
        Dim currentYear As Integer = DateTime.Now.Year

        ' Database connection
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        Dim conn As New OleDbConnection(connString)

        Try
            conn.Open()

            ' Check if the staff already has an attendance record for the selected date
            Dim checkQuery As String = "SELECT * FROM StaffAttendanceTable WHERE StaffID = ? AND CurrentDate = ?"
            Dim checkCmd As New OleDbCommand(checkQuery, conn)
            checkCmd.Parameters.AddWithValue("?", staffID)
            checkCmd.Parameters.AddWithValue("?", currentDate)

            Dim reader As OleDbDataReader = checkCmd.ExecuteReader()

            ' If no record exists, notify the user and exit
            If Not reader.HasRows Then
                reader.Close()
                MessageBox.Show("No attendance record found for this staff member on the selected date.", "Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            reader.Close()

            ' **Reset MonthlyCount if a new month has started**
            Dim resetMonthlyQuery As String = "UPDATE StaffAttendanceTable SET MonthlyCount = 0 WHERE StaffID = ? AND MONTH(CurrentDate) <> ?"
            Dim resetMonthlyCmd As New OleDbCommand(resetMonthlyQuery, conn)
            resetMonthlyCmd.Parameters.AddWithValue("?", staffID)
            resetMonthlyCmd.Parameters.AddWithValue("?", currentMonth)
            resetMonthlyCmd.ExecuteNonQuery()

            ' **Reset YearlyCount if a new year has started**
            Dim resetYearlyQuery As String = "UPDATE StaffAttendanceTable SET YearlyCount = 0 WHERE StaffID = ? AND YEAR(CurrentDate) <> ?"
            Dim resetYearlyCmd As New OleDbCommand(resetYearlyQuery, conn)
            resetYearlyCmd.Parameters.AddWithValue("?", staffID)
            resetYearlyCmd.Parameters.AddWithValue("?", currentYear)
            resetYearlyCmd.ExecuteNonQuery()

            ' **Update attendance record**
            Dim updateQuery As String = "UPDATE StaffAttendanceTable SET CheckInTime = ?, CheckOutTime = ?, Shift = ?, Attendance = ? WHERE StaffID = ? AND CurrentDate = ?"
            Dim updateCmd As New OleDbCommand(updateQuery, conn)
            updateCmd.Parameters.AddWithValue("?", If(checkInTime = "", DBNull.Value, checkInTime))
            updateCmd.Parameters.AddWithValue("?", If(checkOutTime = "", DBNull.Value, checkOutTime))
            updateCmd.Parameters.AddWithValue("?", shift)
            updateCmd.Parameters.AddWithValue("?", status)
            updateCmd.Parameters.AddWithValue("?", staffID)
            updateCmd.Parameters.AddWithValue("?", currentDate)

            updateCmd.ExecuteNonQuery()

            ' **Update MonthlyCount & YearlyCount if status is "Present"**
            If status = "Present" Then
                Dim updateCountQuery As String = "UPDATE StaffAttendanceTable SET MonthlyCount = MonthlyCount + 1, YearlyCount = YearlyCount + 1 WHERE StaffID = ? AND CurrentDate = ?"
                Dim updateCountCmd As New OleDbCommand(updateCountQuery, conn)
                updateCountCmd.Parameters.AddWithValue("?", staffID)
                updateCountCmd.Parameters.AddWithValue("?", currentDate)
                updateCountCmd.ExecuteNonQuery()
            End If

            ' Show success message
            MessageBox.Show("Attendance updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset input fields after successful attendance marking
            textcheckintime.Text = ""
            textcheckouttime.Text = ""
            shiftdrop.SelectedIndex = -1
            statusdrop.SelectedIndex = -1
            selectedstaff.Text = "No staff selected"
            selectedstaff.Tag = Nothing

            ' Refresh DataGridView to show updated data
            RefreshDataGridView()

        Catch ex As Exception
            MessageBox.Show("Error updating attendance: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub


Private Sub Butsearch_Click(sender As Object, e As EventArgs) Handles Butsearch.Click
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
    Dim conn As New OleDbConnection(connString)

    Try
        ' Open the connection
        conn.Open()

        ' SQL query to fetch staff attendance details by StaffID or FullName
        Dim query As String = "SELECT * FROM StaffAttendanceTable WHERE StaffID LIKE @SearchText OR FullName LIKE @SearchText"
        Dim cmd As New OleDbCommand(query, conn)

        ' Set search parameter (wildcard for partial matching)
        cmd.Parameters.AddWithValue("@SearchText", "%" & textsearch.Text.Trim() & "%")

        ' Execute the query and load data into a DataTable
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind the DataGridView to the filtered data
        StaffAttendanceDataGridView.DataSource = dt

        ' Check if any results were found
        If dt.Rows.Count > 0 Then
            MessageBox.Show("Staff Attendance(s) found!", "Search Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No matching staff attendance records found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    Catch ex As Exception
        MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    Finally
        conn.Close()
    End Try
End Sub





End Class