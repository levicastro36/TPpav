Public Class FrmAltaProveedor
    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private sBarrio As New ServicioBarrio
    Private Sub FrmAltaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbProvincia.Items.Clear()
        cmbLocalidad.Items.Clear()
        cmbBarrio.Items.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal desc As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = desc

    End Sub

    Private Sub cmbProvincia_Click(sender As Object, e As EventArgs) Handles cmbProvincia.Click
        CargarCombo(cmbProvincia, sProvincia.listarProvincias(), "codProvincia", "descripcion")
    End Sub

    Private Sub cmbLocalidad_Click(sender As Object, e As EventArgs) Handles cmbLocalidad.Click
        If (Not (cmbProvincia.SelectedValue = Nothing)) Then
            CargarCombo(cmbLocalidad, sLocalidad.listarLocalidades(cmbProvincia.SelectedValue.ToString), "codLocalidad", "descripcion")
        Else
            MsgBox("cargue provincia")
        End If
    End Sub

    Private Sub cmbBarrio_Click(sender As Object, e As EventArgs) Handles cmbBarrio.Click
        If (Not (cmbLocalidad.SelectedValue = Nothing)) Then
            CargarCombo(cmbBarrio, sBarrio.listarBarrios(cmbLocalidad.SelectedValue.ToString), "codBarrio", "descripcion")
        Else
            MsgBox("cargue localidad")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos() Then
            Dim oProveedor As New Proveedor
            oProveedor.cuit = txtCUIT.Text
            oProveedor.razonSocial = txtRazonSocial.Text
            oProveedor.responsable = txtResponsable.Text
            oProveedor.telefono = txtTelefono.Text
            oProveedor.calle = txtCalle.Text
            oProveedor.numero = txtNro.Text
            oProveedor.piso = txtPiso.Text
            oProveedor.barrio = cmbBarrio.SelectedValue.ToString

            Dim sProveedor As New ServicioProveedor

            If sProveedor.nuevoProveedor(oProveedor) Then
                MsgBox("Carga Exitosa")
            Else
                MsgBox("No se pudo cargar")
            End If
        End If
    End Sub
    Private Function validarCampos() As Boolean
        Return True
    End Function
End Class