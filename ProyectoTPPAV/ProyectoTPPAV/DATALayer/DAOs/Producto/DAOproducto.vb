Public Class DAOproducto

    Friend Function cargarProductor(oProducto As Producto) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""


        sql += "INSERT INTO dbo.Productos VALUES("
        sql += "'" + oProducto.codProducto + "',"
        sql += "'" + oProducto.nombre + "',"
        sql += "'" + oProducto.descripcion + "',"
        sql += "'" + oProducto.codModelo + "',"
        sql += "'" + oProducto.codTipoProd + "',"
        sql += "'" + oProducto.precio + "',"
        sql += "'" + oProducto.codProveedor + "',"
        sql += "'" + oProducto.stockActual + "',"
        sql += "'" + oProducto.stockMin + "')"

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
    Friend Function sobreescribirProducto(oProducto As Producto) As Boolean
        Dim rtn As Boolean = False
        Dim sql As String = ""
        sql = "UPDATE dbo.Productos 
               SET nombre ='" & oProducto.nombre & "',descripcion='" & oProducto.descripcion & "',codModelo=" & oProducto.codModelo & ",codTipoProd=" & oProducto.codTipoProd & ",precio=" & oProducto.precio & ",cuitProveedor=" & oProducto.codProveedor & "
               WHERE codProducto= " & oProducto.codProducto & " "

        If (DBHelper.getDBHelper.EjecutarSQL(sql) >= 1) Then
            rtn = True
        End If

        Return rtn
    End Function
    Public Function getCodigo(codigo As String) As DataTable
        Dim strSQL As String = ""
        strSQL = "select P.codProducto,P.nombre,P.descripcion,P.codModelo,P.codTipoProd,P.precio,P.cuitProveedor,M.nombre as nombreMar,M.codMarca as codMarca,Mo.nombre as nombreMo,Mo.codModelo as codMo,Pr.razonSocial as nombreRazon
from Productos P, Marcas M, Modelo Mo, Proveedores Pr
where (P.codModelo=Mo.codModelo) and (Mo.codigoMarca=M.codMarca) and(p.cuitProveedor=Pr.cuit)and P.codProducto = " & codigo & " "
        Return DBHelper.getDBHelper().ConsultaSQL(strSQL)
    End Function

    Public Function existe(ByVal codigo As String) As Boolean
        Dim rtn As Boolean = False
        Dim tabla As DataTable = DBHelper.getDBHelper.ConsultaSQL("SELECT codProducto FROM Productos WHERE codProducto = " + codigo)
        For Each row As DataRow In tabla.Rows
            If row.Item("codProducto").ToString = codigo Then
                rtn = True
            End If
        Next
        Return rtn
    End Function
End Class
