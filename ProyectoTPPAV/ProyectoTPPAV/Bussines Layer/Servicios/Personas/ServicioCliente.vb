Imports ProyectoTPPAV
Public Class ServicioCliente

    Private oDAOCliente As New DAOcliente
    Public Function nuevoCliente(oCliente As Cliente) As Boolean
        Dim rtn As Boolean = False

        If oDAOCliente.cargarClientes(oCliente) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function sobreescribirCliente(oCliente As Cliente) As Boolean
        Dim rtn As Boolean = False

        If oDAOCliente.sobreescribirCliente(oCliente) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function listarClientes() As DataTable
        Return oDAOCliente.getClientes()

    End Function

    Public Function buscarCodigo() As DataTable
        Return oDAOCliente.getCodigo()
    End Function
End Class
