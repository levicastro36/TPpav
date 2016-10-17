Public Class FrmGralProductos
    Shared oProd As Producto
    Shared acci As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        FrmAltaProducto.frmTransaccion()
    End Sub

    Private Sub FrmGralProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargrilla()
    End Sub

    Private Sub llenargrilla()

    End Sub
    Friend Sub addProducto(ByVal oProducto As Producto, ByVal accion As String)
        With oProducto
            Me.dgv_gralProductos.Rows.Add(New String() { .codProducto.ToString, .nombre.ToString, .descripcion.ToString, .codModelo.ToString, .codTipoProd.ToString, .stockActual.ToString, .stockMin.ToString, .precio.ToString, .costo.ToString, .codProveedor.ToString, .stockEntrante.ToString, accion})
        End With
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

    End Sub

    Private Function listadoProductos() As List(Of Producto)
        Dim list As New List(Of Producto)
        Dim p As New Producto
        For Each row As DataGridViewRow In dgv_gralProductos.Rows

            With row
                p.codProducto = .Cells("id_producto").Value
                p.nombre = .Cells("nombre").Value
                p.descripcion = .Cells("descripcion").Value
                p.codTipoProd = .Cells("id_tipoP").Value
                p.codMarca = .Cells("id_marca").Value
                p.codModelo = .Cells("id_modelo").Value
                p.codProveedor = .Cells("id_proveedor").Value
                p.costo = Double.Parse(.Cells("costo").Value)
                p.precio = Double.Parse(.Cells("precio").Value)
                p.stockActual = Integer.Parse(.Cells("stockActual").Value) + Integer.Parse(.Cells("strock").Value)
                p.stockMin = Integer.Parse(.Cells("stockMin").Value)
            End With
            list.Add(p)
        Next

        Return list
    End Function
End Class