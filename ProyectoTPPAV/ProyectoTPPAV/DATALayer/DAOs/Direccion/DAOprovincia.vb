Imports System.Data.SqlClient
Public Class DAOprovincia
    Public Function getProvincias() As DataTable
        Dim strSQL As String = "Select * from Provincias"
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function cargarProvincia(oprovincia As Provincia) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.Provincias VALUES("
        sql += "'" + oprovincia.nombre + "',"
        sql += "'" + oprovincia.descripcion + "')"

        If (BDHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
