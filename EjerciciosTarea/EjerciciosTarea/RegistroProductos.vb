Public Class RegistroProductos

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Definir variables
        'Dim codigo, nombre As String
        'Dim contador, precio As Integer
        'Dim descuento, docena As Double

    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            cmbDescuento.Enabled = True
        ElseIf chkDescuento.Checked = False Then
            cmbDescuento.Enabled = False
        End If
    End Sub
End Class