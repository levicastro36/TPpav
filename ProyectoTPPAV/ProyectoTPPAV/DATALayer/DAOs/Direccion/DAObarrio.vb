Public Class DAObarrio
    Friend Function getLocalidades(codLocalidad As String) As DataTable
        Dim strSQL As String = "Select * from Barrios WHERE codLocalidad = " + codLocalidad
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
