Public Class ServicioLocalidad
    Private oDAOlocalidad As New DAOlocalidad

    Public Sub New()
        oDAOlocalidad = New DAOlocalidad()
    End Sub

    Public Function listarLocalidades(ByVal codProvincia As Int16) As DataTable
        Return oDAOlocalidad.getLocalidades(codProvincia)
    End Function

End Class
