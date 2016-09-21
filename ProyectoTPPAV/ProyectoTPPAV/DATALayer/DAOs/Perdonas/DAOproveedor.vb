Imports ProyectoTPPAV

Public Class DAOproveedor
    Friend Function cargarProveedor(oProveedor As Proveedor) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""

        sql += "INSERT INTO dbo.Proveedores VALUES("
        sql += "'" + oProveedor.cuit + "',"
        sql += "'" + oProveedor.razonSocial + "',"
        sql += "'" + oProveedor.telefono + "',"
        sql += "'" + oProveedor.calle + "',"
        sql += "'" + oProveedor.numero + "',"
        sql += "'" + oProveedor.piso + "',"
        sql += "'" + oProveedor.barrio + "',"
        sql += "'" + oProveedor.responsable + "')"

        If (BDHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
End Class
