Imports System.Data.SqlClient
Public Class DAOmarca
    Public Function getMarcas() As DataTable
        Dim strSQL As String = "Select * from Marcas where Tipo = 2"
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function cargarMarcas(oMarcas As Marca) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""
        sql += "INSERT INTO dbo.Marcas(Nombre,descripcion,Tipo) VALUES("
        sql += "'" + oMarcas.nombre + "',"
        sql += "'" + oMarcas.descripcion + "',"
        sql += "'" + oMarcas.tipo + "')"

        If (BDHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
