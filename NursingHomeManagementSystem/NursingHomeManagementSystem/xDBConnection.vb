Imports System.Data.OleDb
Module DBConnection


    Public xConn As New OleDbConnection
    Dim DBProvider As String
    Dim DBSource As String


    Friend Sub xConnopen()

        xConn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\b.a.shanika\OneDrive\Desktop\VB.NET\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb"
        xConn.Open()
    End Sub

    Friend Sub xConnClose()
        xConn.Close()
    End Sub


End Module
