Imports ProyectoTPPAV

Public Class ServicioProveedor
    Private oDAOproveedor As New DAOproveedor
    Public Function nuevoProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False

        If oDAOproveedor.cargarProveedor(oProveedor) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function sobreescribirProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False

        If oDAOproveedor.sobreescribirProveedor(oProveedor) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function listarProveedores() As DataTable
        Return oDAOproveedor.getProveedores

    End Function

    Public Function buscarCuit(ByVal cuit As String) As DataTable
        Return oDAOproveedor.getCuit(cuit)
    End Function
End Class
