Public Class ServicioPronvia
    Private oProvinciaDAO As New DAOprovincia

    Public Sub New()
        oProvinciaDAO = New DAOprovincia()
    End Sub

    Public Function listarProvincias() As DataTable
        Return oProvinciaDAO.getProvincias()
    End Function

End Class
