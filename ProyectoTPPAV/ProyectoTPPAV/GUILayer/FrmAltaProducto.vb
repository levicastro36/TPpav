Public Class FrmAltaProducto
    Private sMarca As New ServicioMarca
    Private sModelo As New ServicioModelo
    Private sBarrio As New ServicioBarrio
    Private sProducto As New ServicioProducto
    Private STipoProd As New ServicioTipoProducto
    Private Sproveedor As New ServicioProveedor
    Dim banderaEditar As Boolean = False

    Private Sub FrmAltaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetearCombos()
    End Sub
    Public Sub SetearCombos()
        Me.cmbMarca.DataSource = Nothing
        Me.cmbModelo.DataSource = Nothing
        Me.cmbTipoProducto.DataSource = Nothing
        Me.cmbProveedor.DataSource = Nothing

        Me.cmbMarca.Items.Clear()
        Me.cmbModelo.Items.Clear()
        Me.cmbTipoProducto.Items.Clear()
        Me.cmbProveedor.Items.Clear()
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

    Private Sub cmbTipoProd_Click(sender As Object, e As EventArgs) Handles cmbTipoProducto.Click
        CargarCombo(cmbTipoProducto, STipoProd.listarTipos(), "codTipo", "nombre")
    End Sub
    Private Sub cmbProvedor_Click(sender As Object, e As EventArgs) Handles cmbProveedor.Click
        CargarCombo(cmbProveedor, Sproveedor.listarProveedores(), "cuit", "razonSocial")
    End Sub
    Private Sub cmbMarca_Click(sender As Object, e As EventArgs) Handles cmbMarca.Click
        CargarCombo(cmbMarca, sMarca.listarMarcas(), "codMarca", "nombre")
    End Sub

    Private Sub cmbModelo_Click(sender As Object, e As EventArgs) Handles cmbModelo.Click
        If (Not (cmbMarca.SelectedValue = Nothing)) Then 'valida que el combo provincias tenga cargado algo 
            CargarCombo(cmbModelo, sModelo.listarModelos(cmbMarca.SelectedValue.ToString), "codModelo", "nombre")
        Else
            MsgBox("Cargue Marca")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'se setea todo a blanco
        Me.txtCodigo.Enabled = True
        Me.txtCosto.Enabled = True
        Me.txtDescripcion.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtPrecioVenta.Enabled = True
        Me.txtStockActual.Enabled = True
        Me.cmbMarca.Enabled = True
        Me.cmbModelo.Enabled = True
        Me.cmbProveedor.Enabled = True
        Me.cmbTipoProducto.Enabled = True
        Me.cmbProveedor.Enabled = True
        btnGuardar.Enabled = True
        btnGuardar.Visible = True
        Me.txtCodigo.Text = Nothing
        Me.txtCosto.Text = Nothing
        Me.txtDescripcion.Text = Nothing
        Me.txtNombre.Text = Nothing
        Me.txtPrecioVenta.Text = Nothing
        Me.txtStockActual.Text = Nothing
        Me.txtStockMin.Text = Nothing
        SetearCombos()
        banderaEditar = False
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnGuardar.Enabled = True
        btnGuardar.Visible = True

        Me.cmbMarca.Enabled = True  'habilito todo 
        Me.cmbModelo.Enabled = True
        Me.cmbTipoProducto.Enabled = True
        Me.cmbProveedor.Enabled = True

        btnGuardar.Enabled = True   'boton ahora visible
        btnGuardar.Visible = True

        Me.txtCodigo.Enabled = False
        Me.txtPrecioVenta.Enabled = True
        Me.txtNombre.Enabled = True
        Me.txtDescripcion.Enabled = True

        banderaEditar = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tabla As New DataTable
        Dim existeCodigo As Boolean
        If (txtCodigo.Text = Nothing) Then
            MsgBox("Ingrese un Codigo para buscar", MsgBoxStyle.Information)

        Else
            existeCodigo = False
            tabla = sProducto.buscarCodigo(txtCodigo.Text.ToString) 'va a buscar datos a la base y los guarda en datatable 

            For Each row In tabla.Rows 'ciclo for para recorrer fila por fila del datatable

                If txtCodigo.Text = row("codProducto").ToString() Then
                    existeCodigo = True

                End If

            Next row

            If (existeCodigo = True) Then
                For Each row In tabla.Rows
                    'carga en la ventana los datos de cada elemento
                    If (txtCodigo.Text = row("codProducto").ToString()) Then
                        txtNombre.Text = row("nombre")
                        txtDescripcion.Text = row("descripcion")
                        txtPrecioVenta.Text = row("precio")
                        SetearCombos()  'borra los datasource de los combo para evitar conflicto
                        CargarComboEditar(cmbMarca, sMarca.listarMarcas(), "codMarca", "nombre", row("codMarca"))
                        CargarComboEditar(cmbModelo, sModelo.listarModelos(row("codMarca")), "codModelo", "nombre", row("codMo"))
                        CargarComboEditar(cmbTipoProducto, STipoProd.listarTipos(), "codTipo", "nombre", row("codTipoProd"))
                        CargarComboEditar(cmbProveedor, Sproveedor.listarProveedores(), "cuit", "razonSocial", row("cuitProveedor"))
                        'carga de nuevo los combo pero con el metodo para modo editar

                        Me.cmbMarca.Enabled = False
                        Me.cmbModelo.Enabled = False
                        Me.cmbTipoProducto.Enabled = False
                        Me.cmbProveedor.Enabled = False
                        btnGuardar.Enabled = False    'bloqueo todos los elementos de la ventana
                        btnGuardar.Visible = False

                        Me.txtCodigo.Enabled = False
                        Me.txtNombre.Enabled = False
                        Me.txtDescripcion.Enabled = False
                        Me.txtPrecioVenta.Enabled = False
                    End If
                    Exit For
                Next row
            Else
                MsgBox("Producto no encontrado en los datos", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oproducto As New Producto
        'carga los datos al objeto
        If ValidarVacio() = True Then
            MsgBox("Ingrese todos los datos requeridos", MsgBoxStyle.Exclamation)
        Else
            oproducto.codProducto = txtCodigo.Text
            oproducto.nombre = txtNombre.Text
            oproducto.descripcion = txtDescripcion.Text
            oproducto.codModelo = cmbModelo.SelectedValue.ToString
            oproducto.codTipoProd = cmbTipoProducto.SelectedValue.ToString
            oproducto.codProveedor = cmbProveedor.SelectedValue.ToString
            oproducto.stockMin = txtStockMin.Text

            If (banderaEditar = True) Then ' chequea que la ventana este en modo editar

                If (MsgBox("Seguro que desea sobreescribir los datos?", MsgBoxStyle.YesNo, "Advertencia") = MsgBoxResult.Yes) Then

                    If sProducto.nuevoProveedor(oproducto) Then
                        MsgBox("Carga Exitosa", MsgBoxStyle.Information)
                    Else
                        MsgBox("No se pudo cargar", MsgBoxStyle.Information)
                    End If

                End If

            Else
                'misma carga para el modo normal de la ventana
                If sProducto.nuevoProveedor(oproducto) Then
                    MsgBox("Carga Exitosa", MsgBoxStyle.Information)
                Else
                    MsgBox("No se pudo cargar", MsgBoxStyle.Information)
                End If
            End If
        End If
    End Sub

    Private Function ValidarVacio() As Boolean
        Dim vacio As Boolean = False

        For Each cn As Control In Me.Controls  'recorro todos los elementos del form

            If TypeOf cn Is GroupBox Then
                Dim group As GroupBox = cn
                For Each cn1 As Control In group.Controls

                    If TypeOf cn1 Is TextBox Then


                        If (cn1.Text = "" Or cn1.Text = String.Empty) And cn1.Tag=1 Then
                            vacio = True
                        End If

                    End If

                    If TypeOf cn1 Is ComboBox Then
                        Dim cmb As ComboBox = cn1

                        If (cmb.SelectedValue = Nothing) And cn1.Tag = 1 Then
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

    Private Sub btnTipoProducto_Click(sender As Object, e As EventArgs) Handles btnTipoProducto.Click
        FrmAltaTipoProducto.Show()
    End Sub

    Private Sub btnNuevoMarca_Click(sender As Object, e As EventArgs) Handles btnNuevoMarca.Click
        DBHelper.getDBHelper.deDondeViene = 2
        FrmAltaMarca.Show()
    End Sub

    Private Sub btnNuevoModelo_Click(sender As Object, e As EventArgs) Handles btnNuevoModelo.Click
        FrmAltaModelo.Show()
    End Sub

    Private Sub btnNuevoProvedor_Click(sender As Object, e As EventArgs) Handles btnNuevoProvedor.Click
        FrmAltaProveedor.Show()
    End Sub
End Class