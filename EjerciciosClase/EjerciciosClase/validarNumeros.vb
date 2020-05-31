Public Class validarNumeros
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click
        'Definir variables
        Dim valor1 As Int16

        'Validar el valor ingresado
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not Isnumeric(txtValor1.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValor1.Text = ""
        ElseIf IsNumeric(valor1) Then
            valor1 = Val(txtValor1.Text)
            If valor1 = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor1 > 0 Then
                MsgBox("Numero positivo", vbInformation)
            ElseIf valor1 < 0 Then
                MsgBox("Numero negativo", vbInformation)
            End If
        End If
    End Sub
End Class