Imports System.ComponentModel

Public Class cicloFor
    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Definir Variables
        Dim inicio, final As Integer

        'Asigna y valida los valores
        If IsNumeric(txtIncio.Text) And IsNumeric(txtFinal.Text) Then
            inicio = Val(txtIncio.Text)
            final = Val(txtFinal.Text)
        Else
            inicio = 0
            final = 0
            MsgBox("No ingresó valores númericos", vbInformation)
        End If

        'Proceso
        For i = inicio To final
            MsgBox("" & inicio)
            inicio = inicio + 1
        Next

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        MsgBox("El programa imprimirá un conteo de números desde el valor inicial hasta el valor final", vbInformation)
    End Sub

    Private Sub txtIncio_TextChanged(sender As Object, e As EventArgs) Handles txtIncio.TextChanged

    End Sub
End Class