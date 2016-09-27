Public Class ServicioBarrio
    Private oDAObarrio As New DAObarrio

    Friend Function listarBarrios(ByVal codLocalidad As Int16) As DataTable
        Return oDAObarrio.getLocalidades(codLocalidad)
    End Function

    Public Function listarBarriosSinParam() As DataTable

        Return oDAObarrio.getBarriosSinParam()
    End Function

    Public Function nuevoBarrio(oBarrio As Barrio) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAObarrio
        If carga.cargarBarrios(oBarrio) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
