Imports System.Data.SqlClient
Public Class DAOprovincia
    Public Shared Function getProvincias() As DataTable
        Dim strSQL As String = "Select id_provincia,descripcion from Provincias"
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
