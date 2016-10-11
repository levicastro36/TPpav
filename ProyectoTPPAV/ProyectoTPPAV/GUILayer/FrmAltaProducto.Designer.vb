<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTipoProducto = New System.Windows.Forms.Button()
        Me.cmbTipoProducto = New System.Windows.Forms.ComboBox()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevoModelo = New System.Windows.Forms.Button()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.btnNuevoMarca = New System.Windows.Forms.Button()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtStockMin = New System.Windows.Forms.TextBox()
        Me.lblSTOCKmIN = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.lblStockActual = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnNuevoProvedor = New System.Windows.Forms.Button()
        Me.cmbProveedor = New System.Windows.Forms.ComboBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.txt_StockEntrante = New System.Windows.Forms.TextBox()
        Me.lbl_stockEntrante = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(362, 442)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 36)
        Me.btnSalir.TabIndex = 106
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_StockEntrante)
        Me.GroupBox1.Controls.Add(Me.lbl_stockEntrante)
        Me.GroupBox1.Controls.Add(Me.btnTipoProducto)
        Me.GroupBox1.Controls.Add(Me.cmbTipoProducto)
        Me.GroupBox1.Controls.Add(Me.lblTipoProducto)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnNuevoModelo)
        Me.GroupBox1.Controls.Add(Me.cmbModelo)
        Me.GroupBox1.Controls.Add(Me.btnNuevoMarca)
        Me.GroupBox1.Controls.Add(Me.lblModelo)
        Me.GroupBox1.Controls.Add(Me.cmbMarca)
        Me.GroupBox1.Controls.Add(Me.lblMarca)
        Me.GroupBox1.Controls.Add(Me.txtStockMin)
        Me.GroupBox1.Controls.Add(Me.lblSTOCKmIN)
        Me.GroupBox1.Controls.Add(Me.txtStockActual)
        Me.GroupBox1.Controls.Add(Me.lblStockActual)
        Me.GroupBox1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupBox1.Controls.Add(Me.lblPrecio)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.lblDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCosto)
        Me.GroupBox1.Controls.Add(Me.lblCosto)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 327)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Producto"
        '
        'btnTipoProducto
        '
        Me.btnTipoProducto.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipoProducto.Location = New System.Drawing.Point(315, 77)
        Me.btnTipoProducto.Name = "btnTipoProducto"
        Me.btnTipoProducto.Size = New System.Drawing.Size(28, 23)
        Me.btnTipoProducto.TabIndex = 92
        Me.btnTipoProducto.Text = "..."
        Me.btnTipoProducto.UseVisualStyleBackColor = False
        '
        'cmbTipoProducto
        '
        Me.cmbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoProducto.FormattingEnabled = True
        Me.cmbTipoProducto.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbTipoProducto.Location = New System.Drawing.Point(100, 80)
        Me.cmbTipoProducto.Name = "cmbTipoProducto"
        Me.cmbTipoProducto.Size = New System.Drawing.Size(209, 21)
        Me.cmbTipoProducto.TabIndex = 91
        Me.cmbTipoProducto.Tag = "1"
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(14, 83)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(56, 13)
        Me.lblTipoProducto.TabIndex = 88
        Me.lblTipoProducto.Text = "Tipo Prod:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(100, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(229, 20)
        Me.txtCodigo.TabIndex = 87
        Me.txtCodigo.Tag = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Codigo:"
        '
        'btnNuevoModelo
        '
        Me.btnNuevoModelo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevoModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoModelo.Location = New System.Drawing.Point(315, 133)
        Me.btnNuevoModelo.Name = "btnNuevoModelo"
        Me.btnNuevoModelo.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevoModelo.TabIndex = 96
        Me.btnNuevoModelo.Text = "..."
        Me.btnNuevoModelo.UseVisualStyleBackColor = False
        '
        'cmbModelo
        '
        Me.cmbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbModelo.Location = New System.Drawing.Point(100, 135)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(209, 21)
        Me.cmbModelo.TabIndex = 95
        Me.cmbModelo.Tag = "1"
        '
        'btnNuevoMarca
        '
        Me.btnNuevoMarca.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevoMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoMarca.Location = New System.Drawing.Point(315, 104)
        Me.btnNuevoMarca.Name = "btnNuevoMarca"
        Me.btnNuevoMarca.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevoMarca.TabIndex = 94
        Me.btnNuevoMarca.Text = "..."
        Me.btnNuevoMarca.UseVisualStyleBackColor = False
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(14, 138)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 81
        Me.lblModelo.Text = "Modelo"
        '
        'cmbMarca
        '
        Me.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbMarca.Location = New System.Drawing.Point(100, 107)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(209, 21)
        Me.cmbMarca.TabIndex = 93
        Me.cmbMarca.Tag = "1"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(14, 110)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 13)
        Me.lblMarca.TabIndex = 79
        Me.lblMarca.Text = "Marca:"
        '
        'txtStockMin
        '
        Me.txtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockMin.Location = New System.Drawing.Point(255, 193)
        Me.txtStockMin.Name = "txtStockMin"
        Me.txtStockMin.Size = New System.Drawing.Size(74, 20)
        Me.txtStockMin.TabIndex = 100
        '
        'lblSTOCKmIN
        '
        Me.lblSTOCKmIN.AutoSize = True
        Me.lblSTOCKmIN.Location = New System.Drawing.Point(194, 200)
        Me.lblSTOCKmIN.Name = "lblSTOCKmIN"
        Me.lblSTOCKmIN.Size = New System.Drawing.Size(55, 13)
        Me.lblSTOCKmIN.TabIndex = 77
        Me.lblSTOCKmIN.Text = "Stock Min"
        '
        'txtStockActual
        '
        Me.txtStockActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockActual.Location = New System.Drawing.Point(255, 162)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(74, 20)
        Me.txtStockActual.TabIndex = 98
        '
        'lblStockActual
        '
        Me.lblStockActual.AutoSize = True
        Me.lblStockActual.Location = New System.Drawing.Point(181, 167)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(68, 13)
        Me.lblStockActual.TabIndex = 75
        Me.lblStockActual.Text = "Stock Actual"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Location = New System.Drawing.Point(100, 193)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(74, 20)
        Me.txtPrecioVenta.TabIndex = 99
        Me.txtPrecioVenta.Tag = "1"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(14, 195)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(83, 13)
        Me.lblPrecio.TabIndex = 73
        Me.lblPrecio.Text = "Precio de Venta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(100, 263)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(229, 51)
        Me.txtDescripcion.TabIndex = 101
        Me.txtDescripcion.Tag = "1"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(14, 263)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 71
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtCosto
        '
        Me.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCosto.Location = New System.Drawing.Point(100, 165)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(74, 20)
        Me.txtCosto.TabIndex = 97
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(14, 167)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(34, 13)
        Me.lblCosto.TabIndex = 69
        Me.lblCosto.Text = "Costo"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(100, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(229, 20)
        Me.txtNombre.TabIndex = 89
        Me.txtNombre.Tag = "1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 47)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 62
        Me.lblNombre.Text = "Nombre:"
        '
        'btnNuevoProvedor
        '
        Me.btnNuevoProvedor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevoProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoProvedor.Location = New System.Drawing.Point(315, 38)
        Me.btnNuevoProvedor.Name = "btnNuevoProvedor"
        Me.btnNuevoProvedor.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevoProvedor.TabIndex = 103
        Me.btnNuevoProvedor.Text = "..."
        Me.btnNuevoProvedor.UseVisualStyleBackColor = False
        '
        'cmbProveedor
        '
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.FormattingEnabled = True
        Me.cmbProveedor.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbProveedor.Location = New System.Drawing.Point(100, 38)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(209, 21)
        Me.cmbProveedor.TabIndex = 102
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(14, 38)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(59, 13)
        Me.lblProveedor.TabIndex = 64
        Me.lblProveedor.Text = "Proveedor:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(377, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(70, 30)
        Me.btnBuscar.TabIndex = 88
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(272, 442)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 36)
        Me.btnNuevo.TabIndex = 105
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(182, 442)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 36)
        Me.btnGuardar.TabIndex = 104
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbProveedor)
        Me.GroupBox2.Controls.Add(Me.lblProveedor)
        Me.GroupBox2.Controls.Add(Me.btnNuevoProvedor)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 345)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 78)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proveedores del Producto"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(377, 64)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(70, 30)
        Me.btnEditar.TabIndex = 90
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'txt_StockEntrante
        '
        Me.txt_StockEntrante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_StockEntrante.Location = New System.Drawing.Point(255, 228)
        Me.txt_StockEntrante.Name = "txt_StockEntrante"
        Me.txt_StockEntrante.Size = New System.Drawing.Size(74, 20)
        Me.txt_StockEntrante.TabIndex = 103
        '
        'lbl_stockEntrante
        '
        Me.lbl_stockEntrante.AutoSize = True
        Me.lbl_stockEntrante.Location = New System.Drawing.Point(171, 230)
        Me.lbl_stockEntrante.Name = "lbl_stockEntrante"
        Me.lbl_stockEntrante.Size = New System.Drawing.Size(78, 13)
        Me.lbl_stockEntrante.TabIndex = 102
        Me.lbl_stockEntrante.Text = "Stock Entrante"
        '
        'FrmAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 496)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmAltaProducto"
        Me.Text = "Alta Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNuevoMarca As Button
    Friend WithEvents lblModelo As Label
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtStockMin As TextBox
    Friend WithEvents lblSTOCKmIN As Label
    Friend WithEvents txtStockActual As TextBox
    Friend WithEvents lblStockActual As Label
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents lblCosto As Label
    Friend WithEvents btnNuevoProvedor As Button
    Friend WithEvents cmbProveedor As ComboBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnNuevoModelo As Button
    Friend WithEvents cmbModelo As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnTipoProducto As Button
    Friend WithEvents cmbTipoProducto As ComboBox
    Friend WithEvents lblTipoProducto As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEditar As Button
    Friend WithEvents txt_StockEntrante As TextBox
    Friend WithEvents lbl_stockEntrante As Label
End Class
