<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGralProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_gralProductos = New System.Windows.Forms.DataGridView()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_gralProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(174, 337)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 9
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(693, 337)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(602, 337)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 7
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 337)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_gralProductos
        '
        Me.dgv_gralProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_gralProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_gralProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.nombre, Me.descripcion, Me.id_modelo, Me.id_marca, Me.id_tipoP, Me.stockActual, Me.stockMin, Me.precio, Me.costo, Me.id_proveedor, Me.stock, Me.accion})
        Me.dgv_gralProductos.Location = New System.Drawing.Point(12, 12)
        Me.dgv_gralProductos.Name = "dgv_gralProductos"
        Me.dgv_gralProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_gralProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_gralProductos.Size = New System.Drawing.Size(756, 313)
        Me.dgv_gralProductos.TabIndex = 5
        '
        'btn_editar
        '
        Me.btn_editar.Location = New System.Drawing.Point(93, 337)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(75, 23)
        Me.btn_editar.TabIndex = 10
        Me.btn_editar.Text = "Editar"
        Me.btn_editar.UseVisualStyleBackColor = True
        '
        'id_producto
        '
        Me.id_producto.FillWeight = 62.60324!
        Me.id_producto.HeaderText = "Codigo Prodcuto"
        Me.id_producto.Name = "id_producto"
        '
        'nombre
        '
        Me.nombre.FillWeight = 107.8914!
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'descripcion
        '
        Me.descripcion.FillWeight = 293.5619!
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        '
        'id_modelo
        '
        Me.id_modelo.HeaderText = "codModelo"
        Me.id_modelo.Name = "id_modelo"
        Me.id_modelo.Visible = False
        '
        'id_marca
        '
        Me.id_marca.HeaderText = "id_marca"
        Me.id_marca.Name = "id_marca"
        Me.id_marca.Visible = False
        '
        'id_tipoP
        '
        Me.id_tipoP.HeaderText = "codTipoProd"
        Me.id_tipoP.Name = "id_tipoP"
        Me.id_tipoP.Visible = False
        '
        'stockActual
        '
        Me.stockActual.HeaderText = "stockActual"
        Me.stockActual.Name = "stockActual"
        Me.stockActual.Visible = False
        '
        'stockMin
        '
        Me.stockMin.HeaderText = "stockMin"
        Me.stockMin.Name = "stockMin"
        Me.stockMin.Visible = False
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.Visible = False
        '
        'costo
        '
        Me.costo.FillWeight = 44.5168!
        Me.costo.HeaderText = "Costo"
        Me.costo.Name = "costo"
        '
        'id_proveedor
        '
        Me.id_proveedor.HeaderText = "id_proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        Me.id_proveedor.Visible = False
        '
        'stock
        '
        Me.stock.FillWeight = 54.7672!
        Me.stock.HeaderText = "Stock Ingresante"
        Me.stock.Name = "stock"
        '
        'accion
        '
        Me.accion.FillWeight = 53.30144!
        Me.accion.HeaderText = "Accion"
        Me.accion.Name = "accion"
        '
        'FrmGralProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 372)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_gralProductos)
        Me.Name = "FrmGralProductos"
        Me.Text = "FrmGralProductos"
        CType(Me.dgv_gralProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_aceptar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dgv_gralProductos As DataGridView
    Friend WithEvents btn_editar As Button
    Friend WithEvents id_producto As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents id_modelo As DataGridViewTextBoxColumn
    Friend WithEvents id_marca As DataGridViewTextBoxColumn
    Friend WithEvents id_tipoP As DataGridViewTextBoxColumn
    Friend WithEvents stockActual As DataGridViewTextBoxColumn
    Friend WithEvents stockMin As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents costo As DataGridViewTextBoxColumn
    Friend WithEvents id_proveedor As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents accion As DataGridViewTextBoxColumn
End Class
