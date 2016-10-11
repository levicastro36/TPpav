Public Class FrmGralProductos
    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        FrmAltaProducto.ShowDialog()
    End Sub

    Private Sub FrmGralProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenargrilla()
    End Sub

    Private Sub llenargrilla()

    End Sub
End Class