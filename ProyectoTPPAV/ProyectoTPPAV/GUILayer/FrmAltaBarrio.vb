Public Class FrmAltaBarrio


    Private sBarrio As New ServicioBarrio
    Private sLocalidad As New ServicioLocalidad
    Private Sub FrmAltaBarrio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbLocalidad.DataSource = Nothing
        cmbLocalidad.Items.Clear()
    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal nombre As String)

        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        combo.SelectedIndex = -1
    End Sub

    Private Sub cmbLocalidad_Click(sender As Object, e As EventArgs) Handles cmbLocalidad.Click
        CargarCombo(cmbLocalidad, sLocalidad.listarLocalidadSinParam(), "codLocalidad", "nombre")
    End Sub

    Private Sub btnNuevaLocalidad_Click(sender As Object, e As EventArgs) Handles btnNuevaLocalidad.Click
        FrmAltaLocalidad.Show()
    End Sub

    Private Function validarCampos() As Boolean
        Return True
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos() Then
            Dim oBarrio As New Barrio
            oBarrio.nombre = txtNombreBarrio.Text
            oBarrio.descripcion = txtDescripcion.Text
            oBarrio.codLocalidad = cmbLocalidad.SelectedValue.ToString


            If sBarrio.nuevoBarrio(oBarrio) Then
                MsgBox("Carga Exitosa", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo cargar", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class