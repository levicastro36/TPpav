Public Class ServicioBarrio
    Private oDAObarrio As New DAObarrio

    Friend Function listarBarrios(ByVal codLocalidad As Int16) As DataTable
        Return oDAObarrio.getLocalidades(codLocalidad)
    End Function
End Class
