<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaCliente
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.btnNuevoBarrio = New System.Windows.Forms.Button()
        Me.btnNuevaLocalidad = New System.Windows.Forms.Button()
        Me.btnNuevaProvincia = New System.Windows.Forms.Button()
        Me.cmbBarrio = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbProvincia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCUIT = New System.Windows.Forms.Label()
        Me.lblRazonSocial = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(247, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 36)
        Me.btnGuardar.TabIndex = 67
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPiso)
        Me.GroupBox2.Controls.Add(Me.lblPiso)
        Me.GroupBox2.Controls.Add(Me.btnNuevoBarrio)
        Me.GroupBox2.Controls.Add(Me.btnNuevaLocalidad)
        Me.GroupBox2.Controls.Add(Me.btnNuevaProvincia)
        Me.GroupBox2.Controls.Add(Me.cmbBarrio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbLocalidad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbProvincia)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCalle)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 178)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 166)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Domicilio"
        '
        'txtPiso
        '
        Me.txtPiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPiso.Location = New System.Drawing.Point(267, 45)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(59, 20)
        Me.txtPiso.TabIndex = 49
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(197, 52)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(30, 13)
        Me.lblPiso.TabIndex = 51
        Me.lblPiso.Text = "Piso:"
        '
        'btnNuevoBarrio
        '
        Me.btnNuevoBarrio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevoBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoBarrio.Location = New System.Drawing.Point(360, 133)
        Me.btnNuevoBarrio.Name = "btnNuevoBarrio"
        Me.btnNuevoBarrio.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevoBarrio.TabIndex = 55
        Me.btnNuevoBarrio.Text = "..."
        Me.btnNuevoBarrio.UseVisualStyleBackColor = False
        '
        'btnNuevaLocalidad
        '
        Me.btnNuevaLocalidad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaLocalidad.Location = New System.Drawing.Point(360, 101)
        Me.btnNuevaLocalidad.Name = "btnNuevaLocalidad"
        Me.btnNuevaLocalidad.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevaLocalidad.TabIndex = 53
        Me.btnNuevaLocalidad.Text = "..."
        Me.btnNuevaLocalidad.UseVisualStyleBackColor = False
        '
        'btnNuevaProvincia
        '
        Me.btnNuevaProvincia.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevaProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaProvincia.Location = New System.Drawing.Point(360, 71)
        Me.btnNuevaProvincia.Name = "btnNuevaProvincia"
        Me.btnNuevaProvincia.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevaProvincia.TabIndex = 51
        Me.btnNuevaProvincia.Text = "..."
        Me.btnNuevaProvincia.UseVisualStyleBackColor = False
        '
        'cmbBarrio
        '
        Me.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarrio.FormattingEnabled = True
        Me.cmbBarrio.Items.AddRange(New Object() {"Luis Damiano"})
        Me.cmbBarrio.Location = New System.Drawing.Point(93, 135)
        Me.cmbBarrio.Name = "cmbBarrio"
        Me.cmbBarrio.Size = New System.Drawing.Size(261, 21)
        Me.cmbBarrio.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Barrio:"
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Items.AddRange(New Object() {"Luis Damiano"})
        Me.cmbLocalidad.Location = New System.Drawing.Point(93, 104)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(261, 21)
        Me.cmbLocalidad.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Localidad:"
        '
        'cmbProvincia
        '
        Me.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProvincia.FormattingEnabled = True
        Me.cmbProvincia.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbProvincia.Location = New System.Drawing.Point(93, 71)
        Me.cmbProvincia.Name = "cmbProvincia"
        Me.cmbProvincia.Size = New System.Drawing.Size(261, 21)
        Me.cmbProvincia.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Provincia:"
        '
        'txtNro
        '
        Me.txtNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNro.Location = New System.Drawing.Point(93, 45)
        Me.txtNro.Name = "txtNro"
        Me.txtNro.Size = New System.Drawing.Size(59, 20)
        Me.txtNro.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Nro.:"
        '
        'txtCalle
        '
        Me.txtCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCalle.Location = New System.Drawing.Point(93, 19)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(261, 20)
        Me.txtCalle.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Calle:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblCUIT)
        Me.GroupBox1.Controls.Add(Me.lblRazonSocial)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 148)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contacto:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(93, 97)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(261, 20)
        Me.txtTelefono.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Telefono"
        '
        'txtApellido
        '
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Location = New System.Drawing.Point(93, 71)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(261, 20)
        Me.txtApellido.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Apellido:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.Location = New System.Drawing.Point(93, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(261, 20)
        Me.txtCodigo.TabIndex = 61
        Me.txtCodigo.Tag = "1"
        '
        'lblCUIT
        '
        Me.lblCUIT.AutoSize = True
        Me.lblCUIT.Location = New System.Drawing.Point(12, 26)
        Me.lblCUIT.Name = "lblCUIT"
        Me.lblCUIT.Size = New System.Drawing.Size(65, 13)
        Me.lblCUIT.TabIndex = 59
        Me.lblCUIT.Text = "Documento:"
        '
        'lblRazonSocial
        '
        Me.lblRazonSocial.AutoSize = True
        Me.lblRazonSocial.Location = New System.Drawing.Point(12, 52)
        Me.lblRazonSocial.Name = "lblRazonSocial"
        Me.lblRazonSocial.Size = New System.Drawing.Size(47, 13)
        Me.lblRazonSocial.TabIndex = 60
        Me.lblRazonSocial.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(93, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(261, 20)
        Me.txtNombre.TabIndex = 62
        '
        'btnSalir
        '
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(428, 372)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 36)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(428, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(84, 30)
        Me.btnBuscar.TabIndex = 63
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(428, 61)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(84, 31)
        Me.btnEditar.TabIndex = 64
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(337, 372)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 36)
        Me.btnNuevo.TabIndex = 68
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'FrmAltaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 437)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "FrmAltaCliente"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents lblPiso As Label
    Friend WithEvents btnNuevoBarrio As Button
    Friend WithEvents btnNuevaLocalidad As Button
    Friend WithEvents btnNuevaProvincia As Button
    Friend WithEvents cmbBarrio As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbLocalidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbProvincia As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblRazonSocial As Label
    Friend WithEvents lblCUIT As Label
End Class
