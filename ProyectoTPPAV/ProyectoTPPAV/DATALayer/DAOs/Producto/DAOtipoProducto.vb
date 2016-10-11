Public Class DAOtipoProducto
    Public Function getProvincias() As DataTable
        Dim strSQL As String = "Select * from TipoProductos"
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
    Public Function cargarTipo(oTipo As TipoProducto) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.TipoProductos VALUES("
        sql += "'" + oTipo.nombre + "',"
        sql += "'" + oTipo.descripcion + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
