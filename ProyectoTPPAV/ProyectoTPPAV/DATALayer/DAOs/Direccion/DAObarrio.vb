Public Class DAObarrio
    Friend Function getLocalidades(codLocalidad As String) As DataTable
        Dim strSQL As String = "Select * from Barrios WHERE codLocalidad = " + codLocalidad
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Friend Function getBarriosSinParam() As DataTable
        Dim strSQL As String = "Select * from Barrios"
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function cargarBarrios(obarrio As Barrio) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.Barrios VALUES("
        sql += "'" + obarrio.nombre + "',"
        sql += "'" + obarrio.descripcion + "',"
        sql += "'" + obarrio.codLocalidad + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
