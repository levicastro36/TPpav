Public Class ServicioTipoProducto
    Public oTipoDAO As New DAOtipoProducto
    Public Function listarTipos() As DataTable
        Return oTipoDAO.getProvincias()
    End Function
    Public Function nuevoTipo(oTipoDAO As TipoProducto) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAOtipoProducto
        If carga.cargarTipo(oTipoDAO) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
