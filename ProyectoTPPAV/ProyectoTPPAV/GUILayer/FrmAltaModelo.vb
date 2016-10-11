Public Class FrmAltaModelo

    Private sMarca As New ServicioMarca
    Private sModelo As New ServicioModelo
    Private Sub FrmAltaModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = Nothing
        txtDescripcion.Text = Nothing
        cmbMarca.DataSource = Nothing
        cmbMarca.Items.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal nombre As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        combo.SelectedIndex = -1
    End Sub
    Private Sub cmbMarca_Click(sender As Object, e As EventArgs) Handles cmbMarca.Click
        CargarCombo(cmbMarca, sMarca.listarMarcas(), "codMarca", "nombre")
    End Sub

    Private Sub btnNuevaProvincia_Click(sender As Object, e As EventArgs) Handles btnNuevaProvincia.Click
        FrmAltaMarca.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Function validarCampos(ByVal txt_box As TextBox, ByVal cmb_cm As ComboBox) As Boolean
        Dim rtn As Boolean = True
        If (txt_box.Text = String.Empty) Then
            rtn = False
        End If

        If (cmb_cm.SelectedValue = Nothing) Then
            rtn = False
        End If
        Return rtn
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos(txtNombre, cmbMarca) Then
            Dim oModelo As New Modelo
            oModelo.nombre = txtNombre.Text
            oModelo.descripcion = txtDescripcion.Text
            oModelo.codigoMarca = cmbMarca.SelectedValue.ToString


            If sModelo.nuevoModelo(oModelo) Then
                MsgBox("Carga Exitosa", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo cargar", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Ingrese todos los valores requeridos")
        End If
    End Sub
End Class