Public Class ServicioProducto
    Private oDAOproducto As New DAOproducto
    Public Function buscarCodigo(ByVal codigo As String) As DataTable
        Return oDAOproducto.getCodigo(codigo)
    End Function
    Public Function nuevoProveedor(oProductor As Producto) As Boolean
        Dim rtn As Boolean = False

        If oDAOproducto.cargarProductor(oProductor) Then
            rtn = True
        End If

        Return rtn
    End Function
    Public Function sobreescribirProducto(oProducto As Producto) As Boolean
        Dim rtn As Boolean = False

        If oDAOproducto.sobreescribirProducto(oProducto) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
