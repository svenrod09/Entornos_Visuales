Public Class Calculadora
    Dim operacion, valor1, valor2, signo, resultado, historial As String
    Dim valorResultado As Nullable(Of Double) = Nothing
    Dim valor As Nullable(Of Double) = Nothing
    Dim validarOperador As Boolean
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        validarValores()
        txtCalcular.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        validarValores()
        txtCalcular.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        validarValores()
        txtCalcular.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        validarValores()
        txtCalcular.Text &= "3"
        valor1 = "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        validarValores()
        txtCalcular.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        validarValores()
        txtCalcular.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        validarValores()
        txtCalcular.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        validarValores()
        txtCalcular.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        validarValores()
        txtCalcular.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        validarValores()
        txtCalcular.Text = "9"
    End Sub

    Private Sub btnpunto_Click(sender As Object, e As EventArgs) Handles btnpunto.Click
        If InStr(txtCalcular.Text, ".", CompareMethod.Text) = 0 Then
            txtCalcular.Text &= "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCalcular.Clear()
        txtCalcular.Text &= "0"
        valor = Nothing
        valorResultado = Nothing
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        validarOperacion()
        operacion = "="
        historial = valor1 & signo & valor2 & " = " & resultado
        Operaciones.Items.Add(historial)
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        validarOperacion()
        operacion = "/"
        signo = "/"
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        validarOperacion()
        operacion = "*"
        signo = "*"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        validarOperacion()
        operacion = "-"
        signo = "-"
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        validarOperacion()
        operacion = "+"
        signo = "+"
    End Sub
    Public Sub validarOperacion()
        valor1 = Val(valorResultado)
        validarOperador = True
        valor = Val(txtCalcular.Text)
        valor2 = valor
        If valorResultado IsNot Nothing Then
            Select Case operacion
                Case "+"
                    valorResultado = valorResultado + valor
                Case "-"
                    valorResultado -= valor
                Case "*"
                    valorResultado *= valor
                Case "/"
                    valorResultado /= valor
            End Select
            txtCalcular.Text = valorResultado
            resultado = valorResultado
        Else
            valorResultado = valor
        End If
    End Sub

    Public Sub validarValores()
        If validarOperador = True Then
            txtCalcular.Text = ""
            validarOperador = False
        ElseIf txtCalcular.Text = "0" Then
            txtCalcular.Text = ""
        End If
    End Sub

    Private Sub RegresarAlMenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenúToolStripMenuItem.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub Operaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Operaciones.SelectedIndexChanged
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class