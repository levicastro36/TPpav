Public Class DAOmodelo
    Friend Function getModelos(codMarca As String) As DataTable
        Dim strSQL As String = "Select * from Modelo WHERE codigomarca = " + codMarca
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
    Public Function cargarModelos(oModelo As Modelo) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.Modelo VALUES("
        sql += "'" + oModelo.nombre + "',"
        sql += "'" + oModelo.descripcion + "',"
        sql += "'" + oModelo.codigoMarca + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
