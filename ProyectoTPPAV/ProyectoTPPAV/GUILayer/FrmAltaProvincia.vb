Public Class FrmAltaProvincia

    Private sProvincia As New ServicioPronvia
    Private Sub FrmAltaProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function validarCampos() As Boolean
        Return True
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos() Then
            Dim oprovincia As New Provincia
            oprovincia.nombre = txtNombreProvincia.Text
            oprovincia.descripcion = txtDescripcion.Text

            If sProvincia.nuevaProvincia(oprovincia) Then
                MsgBox("Carga Exitosa")
            Else
                MsgBox("No se pudo cargar")
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class