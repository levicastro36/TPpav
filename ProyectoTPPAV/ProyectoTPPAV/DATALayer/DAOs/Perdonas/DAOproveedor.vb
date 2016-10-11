Imports ProyectoTPPAV

Public Class DAOproveedor
    Friend Function cargarProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""


        sql += "INSERT INTO dbo.Proveedores VALUES("
        sql += "'" + oProveedor.cuit + "',"
        sql += "'" + oProveedor.razonSocial + "',"
        sql += "'" + oProveedor.responsable + "',"
        sql += "'" + oProveedor.telefono + "',"
        sql += "'" + oProveedor.calle + "',"
        sql += "'" + oProveedor.numero + "',"
        sql += "'" + oProveedor.piso + "',"
        sql += "'" + oProveedor.barrio + "')"

        If (BDHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function

    Friend Function sobreescribirProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql = "UPDATE Proveedores SET "
        sql += "razonSocial = '" & oProveedor.razonSocial & "', "
        sql += "responsable = '" & oProveedor.responsable & "', "
        sql += "telefono = '" & oProveedor.telefono & "', "
        sql += "calle = '" & oProveedor.calle & "', "
        sql += "altura = '" & oProveedor.piso & "', "
        sql += "piso = '" & oProveedor.piso & "', "
        sql += "codBarrio = '" & oProveedor.barrio & "' "
        sql += "WHERE cuit = " & oProveedor.cuit & " "

        If (BDHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function

    Public Function getProveedores() As DataTable
        Dim strSQL As String = "Select * from Proveedores"
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function getCuit(cuit As String) As DataTable
        Dim strSQL As String = ""
        strSQL = "select P.cuit,P.razonSocial,P.responsable,P.telefono,P.calle,P.altura,P.piso,B.nombre as nombreBarr,B.codBarrio as codBarrio,Pr.nombre as nombrePro,Pr.codProvincia as codProvincia,L.nombre as nombreLoc,L.codLocalidad as codLocalidad from Proveedores P, Barrios B, Provincias Pr, Localidades L where (B.codBarrio=P.codBarrio) and (B.codLocalidad=L.codLocalidad) and (L.codProvincia=Pr.codProvincia) and p.cuit = " & cuit & " "
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
