Public Class FrmAltaCliente
    Private sProvincia As New ServicioPronvia
    Private sLocalidad As New ServicioLocalidad
    Private sBarrio As New ServicioBarrio
    Private SCliente As ServicioCliente
    Dim banderaEditar As Boolean = False
    Private Sub FrmAltaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetearCombos()

        btnEditar.Enabled = False
        btnEditar.Visible = False
        btnGuardar.Enabled = True
        btnGuardar.Visible = True

    End Sub
    Public Sub SetearCombos()
        Me.cmbProvincia.DataSource = Nothing
        Me.cmbLocalidad.DataSource = Nothing
        Me.cmbBarrio.DataSource = Nothing

        Me.cmbProvincia.Items.Clear()
        Me.cmbLocalidad.Items.Clear()
        Me.cmbBarrio.Items.Clear()
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
        Me.txtCodigo.Enabled = True
        Me.txtApellido.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtNro.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtPiso.Enabled = True
        Me.cmbProvincia.Enabled = True
        Me.cmbLocalidad.Enabled = True
        Me.cmbBarrio.Enabled = True

        btnGuardar.Enabled = True
        btnGuardar.Visible = True
        btnEditar.Visible = False
        Me.txtCodigo.Text = Nothing
        Me.txtNombre.Text = Nothing
        Me.txtApellido.Text = Nothing
        Me.txtTelefono.Text = Nothing
        Me.txtNro.Text = Nothing
        Me.txtCalle.Text = Nothing
        Me.txtPiso.Text = Nothing
        SetearCombos()
        banderaEditar = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oCliente As New Cliente
        'carga los datos al objeto
        If ValidarVacio() = True Then
            MsgBox("Ingrese todos los datos requeridos", MsgBoxStyle.Exclamation)
        Else

            oCliente.nombre = txtNombre.Text
            oCliente.apellido = txtApellido.Text
            oCliente.telefono = txtTelefono.Text
            oCliente.calle = txtCalle.Text
            oCliente.numero = txtNro.Text
            oCliente.piso = txtPiso.Text
            oCliente.barrio = cmbBarrio.SelectedValue.ToString
            If (banderaEditar = True) Then ' chequea que la ventana este en modo editar

                If (MsgBox("Seguro que desea sobreescribir los datos?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes) Then

                    If SCliente.sobreescribirCliente(oCliente) Then 'chequea que la carga se haga correctamente
                        MsgBox("Carga Exitosa")
                    Else
                        MsgBox("No se pudo cargar")
                    End If

                End If
            Else
                If SCliente.nuevoCliente(oCliente) Then 'chequea que la carga se haga correctamente
                    MsgBox("Carga Exitosa")
                Else
                    MsgBox("No se pudo cargar")
                End If
                'misma carga para el modo normal de la ventana


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
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tabla As New DataTable
        txtCodigo.Enabled = True
        Dim existeCodigo As Boolean
        If (txtCodigo.Text = Nothing) Then
            MsgBox("Ingrese un codigo para buscar", MsgBoxStyle.Information)

        Else
            existeCodigo = False

            'va a buscar datos a la base y los guarda en datatable 
            tabla = SCliente.buscarCodigo()

            For Each row In tabla.Rows 'ciclo for para recorrer fila por fila del datatable

                If txtCodigo.Text = row("cuit").ToString() Then
                    existeCodigo = True

                End If

            Next row

            If (existeCodigo = True) Then
                For Each row In tabla.Rows
                    'carga en la ventana los datos de cada elemento
                    If (txtCodigo.Text = row("codCliente").ToString()) Then
                        txtNombre.Text = row("nombre")
                        txtApellido.Text = row("apellido")
                        txtTelefono.Text = row("telefono")
                        txtCalle.Text = row("calle")
                        txtNro.Text = row.item("altura")
                        txtPiso.Text = row("piso")

                        SetearCombos()  'borra los datasource de los combo para evitar conflicto

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

                        Me.txtApellido.Enabled = False
                        Me.txtTelefono.Enabled = False
                        Me.txtNro.Enabled = False
                        Me.txtCalle.Enabled = False
                        Me.txtPiso.Enabled = False
                    End If
                    Exit For
                Next row
            Else
                MsgBox("Codigo no encontrado en los datos", MsgBoxStyle.Information)
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

        txtCodigo.Enabled = False
        Me.txtApellido.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtTelefono.Enabled = True
        Me.txtNro.Enabled = True
        Me.txtCalle.Enabled = True
        Me.txtPiso.Enabled = True

        banderaEditar = True
    End Sub

    Private Function ValidarVacio() As Boolean
        Dim vacio As Boolean = False

        For Each cn As Control In Me.Controls  'recorro todos los elementos del form

            If TypeOf cn Is GroupBox Then
                Dim group As GroupBox = cn
                For Each cn1 As Control In group.Controls

                    If TypeOf cn1 Is TextBox Then


                        If ((cn1.Text = "" Or cn1.Text = String.Empty) And cn1.Tag <> 1) Then
                            vacio = True
                        End If

                    End If

                    If TypeOf cn1 Is ComboBox Then
                        Dim cmb As ComboBox = cn1

                        If cmb.SelectedValue = Nothing Then
                            vacio = True
                        End If

                    End If
                Next

            End If

        Next
        If (vacio = True) Then

        End If

        Return vacio
    End Function
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

    Private Sub CodigoTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub NombreTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        soloLetras(e)
    End Sub
    Private Sub ApellidoTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        soloLetras(e)
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

End Class