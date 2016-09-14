Public Class FrmAltaProveedor
    Private sProvincia As New ServicioPronvia
    Private Sub FrmAltaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombo(cmbProvincia, sProvincia.listarProvincias(), "id_provincia", "descripcion")

    End Sub

    Private Sub CargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.Items.Clear()
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion

    End Sub

End Class