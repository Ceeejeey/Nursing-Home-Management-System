Imports System.Data.OleDb

Namespace Global.NursingHomeManagementSystem
    Class Residents

        Private Property NursingHomeManagemetSystemdbDataSet1 As NursingHomeManagemetSystemdbDataSet1

        Private Property ResidentsTableBindingSource As BindingSource

        Private Property ResidentsTableTableAdapter As NursingHomeManagemetSystemdbDataSet1TableAdapters.ResidentsTableTableAdapter

        Private Function No() As Boolean
            ' Implement logic, returning False by default
            Return False
        End Function

        Private Function savePath() As String
            ' Provide a valid save path for file storage
            Return "C:\Users\Public\Documents\ResidentsData"
        End Function

        Private Function txtResidentPhone() As Object
            If txtResidentPhone IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtResidentPhone.Text) Then
                Return txtResidentPhone.Text
            Else
                Return "No Phone Number"
            End If
        End Function

        Private Function ResidentID() As Object
            If ResidentID IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(ResidentID.Text) Then
                Return txtResidentName.Text
            Else
                Return "UnknownID"
            End If
        End Function

        Private Function txtResidentaddress() As Object
            If txtResidentaddress IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtResidentaddress.Text) Then
                Return txtResidentaddress.Text
            Else
                Return "No Address"
            End If
        End Function

        Private Function txtFullName() As Object
            If txtFullName IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtFullName.Text) Then
                Return txtFullName.Text
            Else
                Return "No Name"
            End If
        End Function

        Private Function txtDateOfBirth() As Object
            If txtDateOfBirth IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtDateOfBirth.Text) Then
                Return Convert.ToDateTime(txtDateOfBirth.Text)
            Else
                Return Convert.ToDateTime("1/1/2000") ' Default date
            End If
        End Function

        Private Function txtAdmissionDate() As Object
            If txtAdmissionDate IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtAdmissionDate.Text) Then
                Return Convert.ToDateTime(txtAdmissionDate.Text)
            Else
                Return Convert.ToDateTime("1/1/2020") ' Default date
            End If
        End Function

        Private Function txtfamilycontactnumber() As Object
            If txtfamilycontactnumber IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(txtfamilycontactnumber.Text) Then
                Return txtfamilycontactnumber.Text
            Else
                Return "0000000000"
            End If
        End Function

        Private Function cmd() As Object
            ' Creating a dummy OleDbCommand for example
            Dim query As String = "SELECT * FROM ResidentsTable"
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\b.a.shanika\OneDrive\Desktop\VB.NET\NursingHomeManagementSystem\NursingHomeManagemetSystemdb.accdb")
            Return New OleDbCommand(query, conn)
        End Function

        Private Sub d(p1 As Object)

        End Sub

    End Class
End Namespace
