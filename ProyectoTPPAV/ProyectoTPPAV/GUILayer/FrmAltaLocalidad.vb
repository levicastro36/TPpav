Public Class FrmAltaLocalidad

    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProvincia.DataSource = Nothing
        cmbProvincia.Items.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal desc As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = desc
        combo.SelectedIndex = -1
    End Sub
    Private Sub cmbProvincia_Click(sender As Object, e As EventArgs) Handles cmbProvincia.Click
        CargarCombo(cmbProvincia, sProvincia.listarProvincias(), "codProvincia", "descripcion")
    End Sub

    Private Sub btnNuevaProvincia_Click(sender As Object, e As EventArgs) Handles btnNuevaProvincia.Click
        FrmAltaProvincia.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Function validarCampos() As Boolean
        Return True
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos() Then
            Dim oLocalidad As New Localidad
            oLocalidad.nombre = txtNombreLocalidad.Text
            oLocalidad.descripcion = txtDescripcion.Text
            oLocalidad.codProvincia = cmbProvincia.SelectedValue.ToString


            If sLocalidad.nuevaLocalidad(oLocalidad) Then
                MsgBox("Carga Exitosa")
            Else
                MsgBox("No se pudo cargar")
            End If
        End If
    End Sub
End Class
