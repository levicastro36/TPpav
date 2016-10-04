Public Class FrmAltaProveedor
    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private sBarrio As New ServicioBarrio
    Private sProveedor As New ServicioProveedor
    Dim banderaEditar As Boolean = False


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

        txtCUIT.MaxLength = 11 'seteo en 11 el maximo de numeros a ingresar

    End Sub

    Friend Sub consultarProveedor()
        Me.ShowDialog()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal nombre As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        combo.SelectedIndex = -1
    End Sub 'metodo de cargar comun para combo. index -1 indica que empieza en blanco  

    Private Sub CargarComboEditar(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal nombre As String, ByVal valor As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        combo.SelectedValue = valor
    End Sub 'mismo metodo que cargar combo comun pero con valor para setear el valor predeterminado que muestra

    Private Sub cmbProvincia_Click(sender As Object, e As EventArgs) Handles cmbProvincia.Click
        CargarCombo(cmbProvincia, sProvincia.listarProvincias(), "codProvincia", "nombre")
    End Sub

    Private Sub cmbLocalidad_Click(sender As Object, e As EventArgs) Handles cmbLocalidad.Click
        If (Not (cmbProvincia.SelectedValue = Nothing)) Then 'valida que el combo provincias tenga cargado algo 
            CargarCombo(cmbLocalidad, sLocalidad.listarLocalidades(cmbProvincia.SelectedValue.ToString), "codLocalidad", "nombre")
        Else
            MsgBox("Cargue provincia")
        End If
    End Sub

    Private Sub cmbBarrio_Click(sender As Object, e As EventArgs) Handles cmbBarrio.Click
        If (Not (cmbLocalidad.SelectedValue = Nothing)) Then 'valida que el combo loc tenga algo cargado 
            CargarCombo(cmbBarrio, sBarrio.listarBarrios(cmbLocalidad.SelectedValue.ToString), "codBarrio", "nombre")
        Else
            MsgBox("Cargue localidad")
        End If

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'se setea todo a blanco
        Me.txtCUIT.Enabled = True
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
        banderaEditar = False
    End Sub
    Private Function validarCampos() As Boolean
        Return True
    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oProveedor As New Proveedor
        'carga los datos al objeto
        oProveedor.cuit = txtCUIT.Text
        oProveedor.razonSocial = txtRazonSocial.Text
        oProveedor.responsable = txtResponsable.Text
        oProveedor.telefono = txtTelefono.Text
        oProveedor.calle = txtCalle.Text
        oProveedor.numero = txtNro.Text
        oProveedor.piso = txtPiso.Text
        oProveedor.barrio = cmbBarrio.SelectedValue.ToString
        If (banderaEditar = True) Then ' chequea que la ventana este en modo editar

            If (MsgBox("Seguro que desea sobreescribir los datos?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes) Then

                If sProveedor.sobreescribirProveedor(oProveedor) Then 'chequea que la carga se haga correctamente
                    MsgBox("Carga Exitosa")
                Else
                    MsgBox("No se pudo cargar")
                End If

            End If
        Else
            'misma carga para el modo normal de la ventana
            If sProveedor.nuevoProveedor(oProveedor) Then
                MsgBox("Carga Exitosa", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo cargar", MsgBoxStyle.Information)
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
        Dim tabla As New DataTable
        Dim existeCuit As Boolean
        If (txtCUIT.Text = Nothing) Then
            MsgBox("Ingrese un CUIT para buscar", MsgBoxStyle.Information)

        Else
            existeCuit = False
            If (Len(txtCUIT.Text) < 11) Then 'propiedad len() cuenta los numeros del textbox. lo encontre en internet
                MsgBox("Ingrese un CUIT valido. (11 numeros)", MsgBoxStyle.Exclamation)
            Else


                tabla = sProveedor.buscarCuit(txtCUIT.Text.ToString) 'va a buscar datos a la base y los guarda en datatable 

                For Each row In tabla.Rows 'ciclo for para recorrer fila por fila del datatable

                    If txtCUIT.Text = row("cuit").ToString() Then
                        existeCuit = True

                    End If

                Next row

                If (existeCuit = True) Then
                    For Each row In tabla.Rows
                        'carga en la ventana los datos de cada elemento
                        If (txtCUIT.Text = row("cuit").ToString()) Then
                            txtRazonSocial.Text = row("razonSocial")
                            txtResponsable.Text = row("responsable")
                            txtTelefono.Text = row("telefono")
                            txtCalle.Text = row("calle")
                            txtNro.Text = row.item("altura")
                            txtPiso.Text = row("piso")

                            cmbProvincia.DataSource = Nothing
                            cmbLocalidad.DataSource = Nothing
                            cmbBarrio.DataSource = Nothing
                            cmbBarrio.Items.Clear()  'borra los datasource de los combo para evitar conflicto

                            'carga de nuevo los combo pero con el metodo para modo editar
                            CargarComboEditar(cmbProvincia, sProvincia.listarProvincias(), "codProvincia", "nombre", row("codProvincia"))
                            CargarComboEditar(cmbLocalidad, sLocalidad.listarLocalidades(row("codProvincia")), "codLocalidad", "nombre", row("codLocalidad"))
                            CargarComboEditar(cmbBarrio, sBarrio.listarBarrios(row("codLocalidad")), "codBarrio", "nombre", row("codBarrio"))

                            Me.cmbProvincia.Enabled = False
                            Me.cmbLocalidad.Enabled = False
                            Me.cmbBarrio.Enabled = False

                            btnGuardar.Enabled = False    'bloqueo todos los elementos de la ventana
                            btnGuardar.Visible = False
                            btnEditar.Enabled = True
                            btnEditar.Visible = True

                            Me.txtResponsable.Enabled = False
                            Me.txtTelefono.Enabled = False
                            Me.txtNro.Enabled = False
                            Me.txtCalle.Enabled = False
                            Me.txtPiso.Enabled = False
                        End If
                        Exit For
                    Next row
                Else
                    MsgBox("CUIT no encontrado en los datos", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        btnGuardar.Visible = True

        Me.cmbProvincia.Enabled = True  'habilito todo 
        Me.cmbLocalidad.Enabled = True
        Me.cmbBarrio.Enabled = True

        btnGuardar.Enabled = True   'boton ahora visible
        btnGuardar.Visible = True

        txtCUIT.Enabled = False
        Me.txtResponsable.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtNro.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtPiso.Enabled = True

        banderaEditar = True
    End Sub

    Private Sub soloNumeros(ByRef e As KeyPressEventArgs) 'valida q solo se ingresen nros en un textBox
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub soloLetras(ByRef e As KeyPressEventArgs) 'valida q solo se ingresen letras en un textBox
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub CUITTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCUIT.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub TelefonoTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub NroTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNro.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub PisoTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPiso.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub ResponsableTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResponsable.KeyPress
        soloLetras(e)
    End Sub
    Private Sub CalleTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRazonSocial.KeyPress
        soloLetras(e)
    End Sub
End Class