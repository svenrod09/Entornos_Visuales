Imports System.ComponentModel

Public Class FormulaCuadratica
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValorA.Clear()
        txtValorB.Clear()
        txtValorC.Clear()
        txtX1.Clear()
        txtX2.Clear()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim a, b, c As Integer
        Dim cuadratica, resultado1, resultado2 As Double

        'Asignar los valores
        a = Val(txtValorA.Text)
        b = Val(txtValorB.Text)
        c = Val(txtValorC.Text)

        'Proceso
        Try
            If Me.ValidateChildren And txtValorA.Text <> String.Empty And txtValorB.Text <> String.Empty And txtValorC.Text <> String.Empty And Val(txtValorA.Text) - Val(Int(txtValorA.Text)) = 0 And Val(txtValorB.Text) - Val(Int(txtValorB.Text)) = 0 And Val(txtValorC.Text) - Val(Int(txtValorC.Text)) = 0 And IsNumeric(txtValorA.Text) And IsNumeric(txtValorB.Text) And IsNumeric(txtValorC.Text) Then
                cuadratica = ((b * b) - (4 * a * c))
                resultado1 = (-b + Math.Sqrt(cuadratica)) / (2 * a)
                resultado2 = (-b - Math.Sqrt(cuadratica)) / (2 * a)

                'Salidas
                txtX1.Text = resultado1
                txtX2.Text = resultado2
            End If
        Catch ex As Exception
            MsgBox("Error al Ingresar Datos", vbInformation)
        End Try
    End Sub

    Private Sub txtValorA_TextChanged(sender As Object, e As EventArgs) Handles txtValorA.TextChanged

    End Sub

    Private Sub txtValorA_Validating(sender As Object, e As CancelEventArgs) Handles txtValorA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor nùmerico entero")
        End If
    End Sub

    Private Sub txtValorB_TextChanged(sender As Object, e As EventArgs) Handles txtValorB.TextChanged

    End Sub

    Private Sub txtValorB_Validating(sender As Object, e As CancelEventArgs) Handles txtValorB.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor nùmerico entero")
        End If
    End Sub

    Private Sub txtValorC_TextChanged(sender As Object, e As EventArgs) Handles txtValorC.TextChanged

    End Sub

    Private Sub txtValorC_Validating(sender As Object, e As CancelEventArgs) Handles txtValorC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor nùmerico entero")
        End If
    End Sub

    Private Sub RegresarAlMenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenúToolStripMenuItem.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class