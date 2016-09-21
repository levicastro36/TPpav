Public Class DAOlocalidad
    Friend Function getLocalidades(codProvincia As String) As DataTable
        Dim strSQL As String = "Select * from Localidades WHERE codProvincia = " + codProvincia
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
