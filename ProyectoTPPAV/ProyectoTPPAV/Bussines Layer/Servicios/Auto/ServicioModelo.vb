Public Class ServicioModelo
    Public oModeloDAO As New DAOmodelo
    Public Function listarModelos(ByVal codMarca As Int16) As DataTable
        Return oModeloDAO.getModelos(codMarca)
    End Function
    Public Function nuevoModelo(oMODELO As Modelo) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAOmodelo
        If carga.cargarModelos(oMODELO) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
