Imports ProyectoTPPAV

Public Class ServicioProveedor
    Private oDAOproveedor As New DAOproveedor
    Friend Function nuevoProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False

        If oDAOproveedor.cargarProveedor(oProveedor) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
