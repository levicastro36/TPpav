Public Class ServicioLocalidad
    Private oDAOlocalidad As New DAOlocalidad

    Public Sub New()
        oDAOlocalidad = New DAOlocalidad()
    End Sub

    Public Function listarLocalidades(ByVal codProvincia As Int16) As DataTable
        Return oDAOlocalidad.getLocalidades(codProvincia)
    End Function

    Public Function listarLocalidadSinParam() As DataTable

        Return oDAOlocalidad.getBarriosSinParam()
    End Function

    Public Function nuevaLocalidad(olocalidad As Localidad) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAOlocalidad
        If carga.cargarLocalidades(olocalidad) Then
            rtn = True
        End If

        Return rtn
    End Function

End Class
