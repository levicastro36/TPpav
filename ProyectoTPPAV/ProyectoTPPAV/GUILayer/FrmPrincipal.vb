Public Class FrmPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmAltaProveedor.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FrmAltaProveedor.consultarProveedor()
    End Sub
End Class