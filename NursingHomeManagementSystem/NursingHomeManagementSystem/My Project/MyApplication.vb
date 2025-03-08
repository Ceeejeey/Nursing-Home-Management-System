Imports System
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.ApplicationServices

' This is the entry point for the application
Public Class MyApplication
    Inherits WindowsFormsApplicationBase

    Public Sub New()
        ' Set the application to run Form1 on startup
        Me.MainForm = New Form1()
    End Sub

    ' Override the OnCreateMainForm to set the starting form
    Protected Overrides Sub OnCreateMainForm()
        ' Set the starting form for the application
        Me.MainForm = New Form1() ' Replace Form1 with the actual form class you want to use as the startup form
    End Sub

End Class
