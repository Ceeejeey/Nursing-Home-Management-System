Imports System.Data.OleDb

Public Class RegisterForm

    ' Connection String (Relative Path to DB)
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

    ' Event handler for Register button click
    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        ' Get the data from the form fields
        Dim fullName As String = TextBoxFullName.Text
        Dim email As String = TextBoxEmail.Text
        Dim password As String = TextBoxPassword.Text
        Dim gender As String = ""

        If RadioButtonMale.Checked Then
            gender = "Male"
        ElseIf RadioButtonFemale.Checked Then
            gender = "Female"
        ElseIf RadioButtonOther.Checked Then
            gender = "Other"
        End If

        ' Simple validation
        If String.IsNullOrEmpty(fullName) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill all the fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Create a connection to the Access database
            Using conn As New OleDbConnection(connString)
                Try
                    ' Open the database connection
                    conn.Open()

                    ' Prepare the SQL Insert statement
                    Dim query As String = "INSERT INTO RegistrationForm (Fullname, Email, [Password], Gender) VALUES (?, ?, ?, ?)"
                    Using cmd As New OleDbCommand(query, conn)
                        ' Add parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("?", fullName)
                        cmd.Parameters.AddWithValue("?", email)
                        cmd.Parameters.AddWithValue("?", password) ' You can hash the password before storing
                        cmd.Parameters.AddWithValue("?", gender)

                        ' Execute the command
                        cmd.ExecuteNonQuery()
                    End Using

                    ' Show a success message
                    MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Open Form1
                    Dim mainForm As New Form1()
                    mainForm.Show()

                    ' Close the RegisterForm
                    Me.Hide()
                    ' Clear the fields after registration
                    TextBoxFullName.Clear()
                    TextBoxEmail.Clear()
                    TextBoxPassword.Clear()
                    RadioButtonMale.Checked = False
                    RadioButtonFemale.Checked = False
                    RadioButtonOther.Checked = False

                Catch ex As OleDbException
                    ' Handle any database errors
                    MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
	
	 ' Close Button Click Event
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs)
        Me.Close()  ' Closes the form
    End Sub

    ' Minimize Button Click Event
    Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized  ' Minimizes the form
    End Sub

    ' Maximize Button Click Event
    Private Sub ButtonMaximize_Click(sender As Object, e As EventArgs)
        ' Toggle between normal and maximized window state
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal  ' Restore to normal state
        Else
            Me.WindowState = FormWindowState.Maximized  ' Maximize the form
        End If
    End Sub
	
	Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

End Class
