Public Class FrmAltaProveedor
    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private sBarrio As New ServicioBarrio
    Private Sub FrmAltaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbProvincia.DataSource = Nothing
        cmbLocalidad.DataSource = Nothing
        cmbBarrio.DataSource = Nothing

        cmbProvincia.Items.Clear()
        cmbLocalidad.Items.Clear()
        cmbBarrio.Items.Clear()

        btnEditar.Enabled = False
        btnEditar.Visible = False
        btnGuardar.Enabled = False
        btnGuardar.Visible = False


    End Sub

    Friend Sub consultarProveedor()
        Me.ShowDialog()
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

    Private Sub cmbLocalidad_Click(sender As Object, e As EventArgs) Handles cmbLocalidad.Click
        If (Not (cmbProvincia.SelectedValue = Nothing)) Then
            CargarCombo(cmbLocalidad, sLocalidad.listarLocalidades(cmbProvincia.SelectedValue.ToString), "codLocalidad", "nombre")
        Else
            MsgBox("Cargue provincia")
        End If
    End Sub

    Private Sub cmbBarrio_Click(sender As Object, e As EventArgs) Handles cmbBarrio.Click
        If (Not (cmbLocalidad.SelectedValue = Nothing)) Then
            CargarCombo(cmbBarrio, sBarrio.listarBarrios(cmbLocalidad.SelectedValue.ToString), "codBarrio", "nombre")
        Else
            MsgBox("Cargue localidad")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.txtResponsable.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtNro.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtPiso.Enabled = True
        Me.cmbProvincia.Enabled = True
        Me.cmbLocalidad.Enabled = True
        Me.cmbBarrio.Enabled = True

        btnGuardar.Enabled = True
        btnGuardar.Visible = True

        Me.txtCUIT.Text = Nothing
        Me.txtRazonSocial.Text = Nothing
        Me.txtResponsable.Text = Nothing
        Me.txtTelefono.Text = Nothing
        Me.txtNro.Text = Nothing
        Me.txtCalle.Text = Nothing
        Me.txtPiso.Text = Nothing
        Me.cmbProvincia.DataSource = Nothing
        Me.cmbLocalidad.DataSource = Nothing
        Me.cmbBarrio.DataSource = Nothing

        Me.cmbProvincia.Items.Clear()
        Me.cmbLocalidad.Items.Clear()
        Me.cmbBarrio.Items.Clear()
    End Sub
    Private Function validarCampos() As Boolean
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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

    Private Sub btnNuevaProvincia_Click(sender As Object, e As EventArgs) Handles btnNuevaProvincia.Click
        FrmAltaProvincia.Show()
    End Sub

    Private Sub btnNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles btnNuevaLocalidad.Click
        FrmAltaLocalidad.Show()
    End Sub

    Private Sub btnNuevoBarrio_Click(sender As Object, e As EventArgs) Handles btnNuevoBarrio.Click
        FrmAltaBarrio.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.txtResponsable.Enabled = False
        Me.txtTelefono.Enabled = False
        Me.txtNro.Enabled = False
        Me.txtCalle.Enabled = False
        Me.txtPiso.Enabled = False
        Me.cmbProvincia.Enabled = False
        Me.cmbLocalidad.Enabled = False
        Me.cmbBarrio.Enabled = False

        btnEditar.Enabled = True
        btnEditar.Visible = True
        btnGuardar.Enabled = False
        btnGuardar.Visible = False

        Me.txtCUIT.Text = Nothing
        Me.txtRazonSocial.Text = Nothing
        Me.txtResponsable.Text = Nothing
        Me.txtTelefono.Text = Nothing
        Me.txtNro.Text = Nothing
        Me.txtCalle.Text = Nothing
        Me.txtPiso.Text = Nothing
        Me.cmbProvincia.DataSource = Nothing
        Me.cmbLocalidad.DataSource = Nothing
        Me.cmbBarrio.DataSource = Nothing

        Me.cmbProvincia.Items.Clear()
        Me.cmbLocalidad.Items.Clear()
        Me.cmbBarrio.Items.Clear()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        btnGuardar.Visible = True
    End Sub
End Class