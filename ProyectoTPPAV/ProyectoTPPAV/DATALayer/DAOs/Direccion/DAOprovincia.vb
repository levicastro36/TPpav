Imports System.Data.SqlClient
Public Class DAOprovincia
    Public Function getProvincias() As DataTable
        Dim strSQL As String = "Select * from Provincias"
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
