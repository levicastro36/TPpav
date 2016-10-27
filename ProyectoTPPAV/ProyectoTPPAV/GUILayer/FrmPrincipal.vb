Public Class FrmPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAltaProveedor.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmAltaProveedor.loadAltaProveedor()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmGralProductos.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        FrmAltaCliente.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class