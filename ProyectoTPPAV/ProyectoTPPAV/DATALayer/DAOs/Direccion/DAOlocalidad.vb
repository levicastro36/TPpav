Public Class DAOlocalidad
    Friend Function getLocalidades(codProvincia As String) As DataTable
        Dim strSQL As String = "Select * from Localidades WHERE codProvincia = " + codProvincia
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
    Friend Function getBarriosSinParam() As DataTable
        Dim strSQL As String = "Select * from Localidades"
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function cargarLocalidades(olocalidad As Localidad) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.Localidades VALUES("
        sql += "'" + olocalidad.nombre + "',"
        sql += "'" + olocalidad.descripcion + "',"
        sql += "'" + olocalidad.codProvincia + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
