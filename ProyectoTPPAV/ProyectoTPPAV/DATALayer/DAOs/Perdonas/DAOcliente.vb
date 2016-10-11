Imports ProyectoTPPAV
Public Class DAOcliente
    Friend Function cargarClientes(oCliente As Cliente) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""


        sql += "INSERT INTO Clientes VALUES("
        sql += "'" + oCliente.nombre + "',"
        sql += "'" + oCliente.apellido + "',"
        sql += "'" + oCliente.telefono + "',"
        sql += "'" + oCliente.calle + "',"
        sql += "'" + oCliente.numero + "',"
        sql += "'" + oCliente.piso + "',"
        sql += "'" + oCliente.barrio + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function

    Friend Function sobreescribirCliente(oCliente As Cliente) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql = "UPDATE Clientes SET "
        sql += "nombre = '" & oCliente.nombre & "', "
        sql += "apellido = '" & oCliente.apellido & "', "
        sql += "telefono = '" & oCliente.telefono & "', "
        sql += "calle = '" & oCliente.calle & "', "
        sql += "altura = '" & oCliente.piso & "', "
        sql += "piso = '" & oCliente.piso & "', "
        sql += "codBarrio = '" & oCliente.barrio & "' "
        sql += "WHERE codCliente = " & oCliente.codigoCliente & " "

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function getClientes() As DataTable
        Dim strSQL As String = "Select * from Clientes"
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function getCodigo() As DataTable
        Dim SQL As String = ""

        SQL = "select c.codCliente,c.nombre,c.apellido,c.telefono,c.calle,c.altura,c.piso,c.codBarrio,B.nombre as nombreBarr,B.codBarrio as codBarrio,Pr.nombre as nombrePro,Pr.codProvincia as codProvincia,L.nombre as nombreLoc,L.codLocalidad as codLocalidad from Clientes C, Barrios B, Provincias Pr, Localidades L where (B.codBarrio=c.codBarrio) and (B.codLocalidad=L.codLocalidad) and (L.codProvincia=Pr.codProvincia)"
        Return DBHelper.getDBHelper().ConsultaSQL(SQL)
    End Function
End Class
