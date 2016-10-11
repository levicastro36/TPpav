Public Class ServicioMarca
    Public oMarcaDAO As New DAOmarca
    Public Function listarMarcas() As DataTable
        Return oMarcaDAO.getMarcas()
    End Function

    Public Function nuevAmARCA(oMarcaDAO As Marca) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAOmarca
        If carga.cargarMarcas(oMarcaDAO) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
