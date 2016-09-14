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
        Me.btnNuevaBarrio = New System.Windows.Forms.Button()
        Me.cmbBarrio = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.txtNombreBarrio = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNuevaBarrio
        '
        Me.btnNuevaBarrio.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevaBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaBarrio.Location = New System.Drawing.Point(313, 63)
        Me.btnNuevaBarrio.Name = "btnNuevaBarrio"
        Me.btnNuevaBarrio.Size = New System.Drawing.Size(28, 23)
        Me.btnNuevaBarrio.TabIndex = 58
        Me.btnNuevaBarrio.Text = "..."
        Me.btnNuevaBarrio.UseVisualStyleBackColor = False
        '
        'cmbBarrio
        '
        Me.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBarrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBarrio.FormattingEnabled = True
        Me.cmbBarrio.Items.AddRange(New Object() {"Base de Datos"})
        Me.cmbBarrio.Location = New System.Drawing.Point(112, 65)
        Me.cmbBarrio.Name = "cmbBarrio"
        Me.cmbBarrio.Size = New System.Drawing.Size(182, 21)
        Me.cmbBarrio.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Barrio:"
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
        'FrmAltaBarrio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 207)
        Me.Controls.Add(Me.btnNuevaBarrio)
        Me.Controls.Add(Me.cmbBarrio)
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

    Friend WithEvents btnNuevaBarrio As Button
    Friend WithEvents cmbBarrio As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtNombreBarrio As TextBox
    Friend WithEvents lblNombre As Label
End Class
