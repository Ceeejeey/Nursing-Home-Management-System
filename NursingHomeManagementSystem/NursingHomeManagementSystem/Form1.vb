Imports System.Data.OleDb
Imports Microsoft.SqlServer.Types

Public Class Form1
	
	Protected Overrides Sub OnLoad(e As EventArgs)
    MyBase.OnLoad(e)

    ' Manually load SQL Server Types DLLs
    Dim path As String = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SqlServerTypes")
    LoadNativeAssemblies(path)
End Sub

Private Sub LoadNativeAssemblies(basePath As String)
    Dim nativePath As String = If(Environment.Is64BitProcess, "x64", "x86")
    Dim fullPath As String = System.IO.Path.Combine(basePath, nativePath)

    If System.IO.Directory.Exists(fullPath) Then
        NativeMethods.LoadLibrary(System.IO.Path.Combine(fullPath, "SqlServerSpatial140.dll"))
    End If
End Sub

Private Class NativeMethods
    <Runtime.InteropServices.DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function
End Class



    ' Connection String
    Private connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB.NET\NursingHomeManagementSystem\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"

    ' Login Button Click Event
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get user input
        Dim email As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Validate inputs
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Check user credentials in the database
        Using conn As New OleDbConnection(connString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM RegistrationForm WHERE Email = ? AND [Password] = ?"
                Using cmd As New OleDbCommand(query, conn)
                    ' Add parameters
                    cmd.Parameters.AddWithValue("?", email)
                    cmd.Parameters.AddWithValue("?", password) ' Hash the password in real applications

                    ' Execute query
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        ' Login successful
                        MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Open MainForm
                        Dim mainForm As New mainform()
                        mainForm.Show()

                        ' Close the login form
                        Me.Hide()
                    Else
                        ' Login failed
                        MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As OleDbException
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
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

    ' Open Register Form When Link Clicked
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegisterForm.Show()
        Me.Hide()
    End Sub

End Class
