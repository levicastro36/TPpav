<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaBarrio
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
        Me.btnNuevaLocalidad = New System.Windows.Forms.Button()
        Me.cmbLocalidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreBarrio = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNuevaLocalidad
        '
        Me.btnNuevaLocalidad.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevaLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaLocalidad.Location = New System.Drawing.Point(313, 112)
        Me.btnNuevaLocalidad.Name = "btnNuevaLocalidad"
        Me.btnNuevaLocalidad.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevaLocalidad.TabIndex = 58
        Me.btnNuevaLocalidad.Text = "..."
        Me.btnNuevaLocalidad.UseVisualStyleBackColor = False
        '
        'cmbLocalidad
        '
        Me.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLocalidad.FormattingEnabled = True
        Me.cmbLocalidad.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbLocalidad.Location = New System.Drawing.Point(112, 114)
        Me.cmbLocalidad.Name = "cmbLocalidad"
        Me.cmbLocalidad.Size = New System.Drawing.Size(182, 21)
        Me.cmbLocalidad.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Localidad:"
        '
        'btnSalir
        '
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(257, 159)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 36)
        Me.btnSalir.TabIndex = 55
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevo.Location = New System.Drawing.Point(149, 159)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 36)
        Me.btnNuevo.TabIndex = 54
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txtNombreBarrio
        '
        Me.txtNombreBarrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreBarrio.Location = New System.Drawing.Point(112, 25)
        Me.txtNombreBarrio.Name = "txtNombreBarrio"
        Me.txtNombreBarrio.Size = New System.Drawing.Size(182, 20)
        Me.txtNombreBarrio.TabIndex = 53
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(34, 27)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 52
        Me.lblNombre.Text = "Nombre"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 69)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(182, 20)
        Me.txtDescripcion.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Nombre"
        '
        'FrmAltaBarrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 207)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNuevaLocalidad)
        Me.Controls.Add(Me.cmbLocalidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtNombreBarrio)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "FrmAltaBarrio"
        Me.Text = "FrmAltaBarrio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevaLocalidad As Button
    Friend WithEvents cmbLocalidad As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNombreBarrio As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label1 As Label
End Class
