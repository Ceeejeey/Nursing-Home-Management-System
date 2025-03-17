Partial Class MedicineUsageDataSet
    Partial Public Class MedicinesDataTable
        Private Sub MedicinesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ResidentIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
