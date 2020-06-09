Imports System.ComponentModel

Public Class ParesImpares
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Definir Variables
        Dim cantidad, contadorPares, contadorImpares, suma, validarInput As Integer

        'Asignar el valor a la variable cantidad
        cantidad = Val(txtCantidad.Text)

        Try
            If Me.ValidateChildren And txtCantidad.Text <> String.Empty And Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 And IsNumeric(txtCantidad.Text) And Val(txtCantidad.Text) > 0 Then
                Dim numeros(0 To cantidad) As Integer
                'Ciclo para ingresar la cantidad de números 
                For i = 1 To cantidad Step 1
                    'Valida que se ingresen solo valores válidos en el inputbox 
                    Do
                        numeros(i) = InputBox("Ingrese el número " & i, "Ingrese de Valores")
                        If (numeros(i) > 0 And IsNumeric(numeros(i))) Then
                            validarInput = 1
                        Else
                            validarInput = 0
                        End If
                    Loop While (validarInput = 0)

                    'Verifica si el número ingresado es par o impar
                    If (numeros(i) Mod 2 = 0) Then
                        contadorPares += 1
                    Else
                        contadorImpares += 1
                    End If

                    'Suma los números ingresados
                    suma += numeros(i)
                Next

                'Asigna los valores a los textbox
                txtImpares.Text = contadorImpares
                txtPares.Text = contadorPares
                txtSuma.Text = suma
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar datos", vbInformation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantidad.Clear()
        txtImpares.Clear()
        txtPares.Clear()
        txtSuma.Clear()
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese un valor númerico entero")
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