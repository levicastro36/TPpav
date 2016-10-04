Public Class FrmAltaLocalidad

    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreLocalidad.Text = Nothing
        txtDescripcion.Text = Nothing
        cmbProvincia.DataSource = Nothing
        cmbProvincia.Items.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal nombre As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        combo.SelectedIndex = -1
    End Sub
    Private Sub cmbProvincia_Click(sender As Object, e As EventArgs) Handles cmbProvincia.Click
        CargarCombo(cmbProvincia, sProvincia.listarProvincias(), "codProvincia", "nombre")
    End Sub

    Private Sub btnNuevaProvincia_Click(sender As Object, e As EventArgs) Handles btnNuevaProvincia.Click
        FrmAltaProvincia.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Esta seguro que desea salir", MsgBoxStyle.YesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Function validarCampos(ByVal txt_box As TextBox) As Boolean
        Dim rtn As Boolean = False
        If (Not (txt_box.Text = String.Empty)) Then
            rtn = True
        End If
        Return rtn
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If (validarCampos(txtNombreLocalidad) * (Not cmbProvincia.SelectedText = String.Empty)) Then
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
