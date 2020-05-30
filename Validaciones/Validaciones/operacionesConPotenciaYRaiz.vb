Public Class operacionesConPotenciaYRaiz
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim valor1 As Int16
        Dim valor2 As Int16
        Dim suma, resta, mult, pot As Integer
        Dim div, raiz As Double

        'Validar el valor 1
        If txtValor1.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValor1.Text) Then
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

        'Validar el valor 2
        If txtValor2.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtValor2.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtValor2.Text = ""
        ElseIf IsNumeric(valor2) Then
            valor2 = Val(txtValor2.Text)
            If valor2 = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor2 > 0 Then
                MsgBox("Numero positivo", vbInformation)
            ElseIf valor2 < 0 Then
                MsgBox("Numero negativo", vbInformation)
            End If
        End If

        'Proceso
        suma = valor1 + valor2
        resta = valor1 - valor2
        mult = valor1 * valor2
        div = valor1 / valor2
        pot = valor1 ^ valor2
        raiz = valor1 ^ 0.5

        'Verifica que el usuario haya seleccionado una casilla 
        If Me.chkSuma.Checked = False And Me.chkResta.Checked = False And Me.chkMult.Checked = False And Me.chkDiv.Checked = False And Me.chkPot.Checked = False And Me.chkRaiz.Checked = False Then
            MsgBox("Porfavor seleccione una casilla", vbInformation)
        End If

        'Salidas
        If Me.chkSuma.Checked = True Then
            txtResultado.Text = suma
        ElseIf Me.chkResta.Checked = True Then
            txtResultado.Text = resta
        ElseIf Me.chkMult.Checked = True Then
            txtResultado.Text = mult
        ElseIf Me.chkDiv.Checked = True Then
            txtResultado.Text = div
            'Verifica si el valor 2 es "0" ya que no se puede dividir entre "0"
            If valor2 = 0 Then
                MsgBox("No se puede dividir entre cero")
            ElseIf valor2 <> 0 Then
                txtResultado.Text = 0
            End If
        ElseIf Me.chkPot.Checked = True Then
            txtResultado.Text = pot
        ElseIf Me.chkRaiz.Checked = True Then
            txtResultado.Text = raiz
        End If
    End Sub
End Class