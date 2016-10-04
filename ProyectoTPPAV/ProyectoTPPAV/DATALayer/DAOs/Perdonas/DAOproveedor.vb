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
        Dim strSQL As String = "select cuit,razonSocial,responsable,telefono,calle,altura,piso,Barrios.nombre as nombreBarr,Barrios.codBarrio as codBarrio,Provincias.nombre as nombrePro,Provincias.codProvincia as codProvincia,Localidades.nombre as nombreLoc,Localidades.codLocalidad as codLocalidad from Proveedores inner join Barrios on (Barrios.codBarrio=Proveedores.codBarrio) inner join Localidades on (Barrios.codLocalidad=Localidades.codLocalidad) inner join Provincias on (Localidades.codProvincia=provincias.codProvincia) and cuit =" + cuit
        Return BDHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function
End Class
