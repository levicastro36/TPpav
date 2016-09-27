Public Class ServicioPronvia
    Public oProvinciaDAO As New DAOprovincia

    Public Sub New()
        oProvinciaDAO = New DAOprovincia()
    End Sub

    Public Function listarProvincias() As DataTable
        Return oProvinciaDAO.getProvincias()
    End Function

    Public Function nuevaProvincia(oProvincia As Provincia) As Boolean
        Dim rtn As Boolean = False
        Dim carga As New DAOprovincia
        If carga.cargarProvincia(oProvincia) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
