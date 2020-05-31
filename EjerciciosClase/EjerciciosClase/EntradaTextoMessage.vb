Public Class EntradaTextoMessage
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim valor As Integer
        valor = InputBox("Ingrese un numero", "Ingreso")
        txtIngresar.Text = valor
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim suma, resta, mult, valor As Integer
        Dim div As Double
        valor = Val(txtIngresar.Text)
        For i = 0 To 10 Step 1
            suma = valor + i
            resta = valor - i
            mult = valor * i
            div = (valor / i)
            cmbSuma.Items.Add(valor & "+" & i & "=" & suma)
            cmbResta.Items.Add(valor & "-" & i & "=" & resta)
            cmbMult.Items.Add(valor & "*" & i & "=" & mult)
            cmbDiv.Items.Add(valor & "/" & i & "=" & div)
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub ErrorProviderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErrorProviderToolStripMenuItem.Click
        Validaciones.Show()
    End Sub
End Class