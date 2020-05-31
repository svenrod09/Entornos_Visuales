Public Class sumaDeDosNumeros
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim valor1, valor2, suma As Integer

        'Entrada
        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'Proceso
        suma = valor1 + valor2

        'Salida
        txtResultado.Text = suma
    End Sub
End Class