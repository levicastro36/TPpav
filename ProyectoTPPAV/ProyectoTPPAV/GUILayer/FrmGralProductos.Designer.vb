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
        Me.id_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codModelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomTipoProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codTipoProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockMin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_prod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btn_salir.Location = New System.Drawing.Point(666, 337)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 23)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(575, 337)
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
        Me.dgv_gralProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_prod, Me.nombre, Me.desc_prod, Me.nomModelo, Me.codModelo, Me.nomTipoProd, Me.codTipoProd, Me.stockActual, Me.stockMin, Me.precio, Me.nom_proveedor, Me.stock_prod, Me.id_proveedor, Me.accion})
        Me.dgv_gralProductos.Location = New System.Drawing.Point(12, 12)
        Me.dgv_gralProductos.Name = "dgv_gralProductos"
        Me.dgv_gralProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgv_gralProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_gralProductos.Size = New System.Drawing.Size(841, 313)
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
        'id_prod
        '
        Me.id_prod.FillWeight = 44.38737!
        Me.id_prod.HeaderText = "Codigo Prodcuto"
        Me.id_prod.Name = "id_prod"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'desc_prod
        '
        Me.desc_prod.FillWeight = 272.0902!
        Me.desc_prod.HeaderText = "Descripcion"
        Me.desc_prod.Name = "desc_prod"
        '
        'nomModelo
        '
        Me.nomModelo.HeaderText = "Modelo"
        Me.nomModelo.Name = "nomModelo"
        '
        'codModelo
        '
        Me.codModelo.HeaderText = "codModelo"
        Me.codModelo.Name = "codModelo"
        Me.codModelo.Visible = False
        '
        'nomTipoProd
        '
        Me.nomTipoProd.HeaderText = "Tipo Producto"
        Me.nomTipoProd.Name = "nomTipoProd"
        Me.nomTipoProd.Visible = False
        '
        'codTipoProd
        '
        Me.codTipoProd.HeaderText = "codTipoProd"
        Me.codTipoProd.Name = "codTipoProd"
        Me.codTipoProd.Visible = False
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
        'nom_proveedor
        '
        Me.nom_proveedor.FillWeight = 83.35817!
        Me.nom_proveedor.HeaderText = "Proveedor"
        Me.nom_proveedor.Name = "nom_proveedor"
        Me.nom_proveedor.Visible = False
        '
        'stock_prod
        '
        Me.stock_prod.FillWeight = 50.76143!
        Me.stock_prod.HeaderText = "Stock Ingresante"
        Me.stock_prod.Name = "stock_prod"
        '
        'id_proveedor
        '
        Me.id_proveedor.HeaderText = "id_proveedor"
        Me.id_proveedor.Name = "id_proveedor"
        Me.id_proveedor.Visible = False
        '
        'accion
        '
        Me.accion.FillWeight = 49.40288!
        Me.accion.HeaderText = "Accion"
        Me.accion.Name = "accion"
        '
        'FrmGralProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 372)
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
    Friend WithEvents id_prod As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents desc_prod As DataGridViewTextBoxColumn
    Friend WithEvents nomModelo As DataGridViewTextBoxColumn
    Friend WithEvents codModelo As DataGridViewTextBoxColumn
    Friend WithEvents nomTipoProd As DataGridViewTextBoxColumn
    Friend WithEvents codTipoProd As DataGridViewTextBoxColumn
    Friend WithEvents stockActual As DataGridViewTextBoxColumn
    Friend WithEvents stockMin As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents nom_proveedor As DataGridViewTextBoxColumn
    Friend WithEvents stock_prod As DataGridViewTextBoxColumn
    Friend WithEvents id_proveedor As DataGridViewTextBoxColumn
    Friend WithEvents accion As DataGridViewTextBoxColumn
End Class
