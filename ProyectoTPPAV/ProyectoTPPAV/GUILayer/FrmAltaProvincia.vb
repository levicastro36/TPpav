﻿Public Class FrmAltaProvincia

    Private sProvincia As New ServicioPronvia
    Private Sub FrmAltaProvincia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreProvincia.Text = Nothing
        txtDescripcion.Text = Nothing
    End Sub

    Private Function validarCampos(ByVal txt_box As TextBox) As Boolean
        Dim rtn As Boolean = False
        If (Not (txt_box.Text = String.Empty)) Then
            rtn = True
        End If
        Return rtn
    End Function
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        If validarCampos(txtNombreProvincia) Then
            Dim oprovincia As New Provincia
            oprovincia.nombre = txtNombreProvincia.Text
            oprovincia.descripcion = txtDescripcion.Text

            If sProvincia.nuevaProvincia(oprovincia) Then
                MsgBox("Carga Exitosa", MsgBoxStyle.Information)
            Else
                MsgBox("No se pudo cargar")
            End If
        Else
            MsgBox("Nombre de Provincia vacio", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("Seguro que desea salir de todas formas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Function ValidarVacio() As Boolean
        Dim vacio As Boolean = False
        For Each cn As Control In Me.Controls
            If TypeOf cn Is TextBox Then
                Dim txt As TextBox = cn
                If txt.Text = String.Empty Then
                    vacio = True
                End If
            End If
        Next
        Return vacio
    End Function

End Class