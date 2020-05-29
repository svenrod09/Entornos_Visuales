Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Inicio
        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        'Proceso
        suma = valor1 + valor2
        resta = valor1 - valor2
        multiplicacion = valor1 * valor2
        division = valor1 / valor2

        'Salida
        txtSuma.Text = suma
        txtResta.Text = resta
        txtMultiplicacion.Text = multiplicacion

        If valor2 = 0 Then
            MsgBox("No se puede dividir entre cero")
        ElseIf valor2 <> 0 Then
            txtDivision.Text = 0
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtSuma.Clear()
        txtResta.Clear()
        txtMultiplicacion.Clear()
        txtDivision.Clear()
    End Sub
End Class
