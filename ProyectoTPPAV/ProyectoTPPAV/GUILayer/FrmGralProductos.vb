Public Class FrmGralProductos
    Shared oProd As Producto
    Shared acci As String
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        FrmAltaProducto.ShowDialog()
        FrmAltaProducto.frmTransaccion()
        agregarProducto(oProd, acci)
    End Sub

    Private Sub FrmGralProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargrilla()
    End Sub

    Private Sub llenargrilla()

    End Sub
    Public Shared Sub addProducto(ByVal oProdcuto As Producto, ByVal accion As String)
        oProd = oProdcuto
        acci = accion
    End Sub

    Private Sub agregarProducto(ByVal oProdcuto As Producto, ByVal accion As String)
        With oProd
            Me.dgv_gralProductos.Rows.Add(New String() { .codProducto.ToString, .nombre.ToString, .descripcion.ToString, .codModelo.ToString, .codTipoProd.ToString, .stockActual.ToString, .stockMin.ToString, .precio.ToString, .costo.ToString, .codProveedor.ToString, .stockEntrante.ToString, acci})
        End With
    End Sub
End Class