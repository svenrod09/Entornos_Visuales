Public Class MenuPrincipal
    Private Sub btnCalculadora_Click(sender As Object, e As EventArgs) Handles btnCalculadora.Click
        Me.Hide()
        Calculadora.Show()
    End Sub

    Private Sub btnFC_Click(sender As Object, e As EventArgs) Handles btnFC.Click
        Me.Hide()
        FormulaCuadratica.Show()
    End Sub

    Private Sub btnAlmacenes_Click(sender As Object, e As EventArgs) Handles btnAlmacenes.Click
        Me.Hide()
        Almacenes.Show()
    End Sub

    Private Sub btnParImpar_Click(sender As Object, e As EventArgs) Handles btnParImpar.Click
        Me.Hide()
        ParesImpares.Show()
    End Sub

    Private Sub btnSueldoNeto_Click(sender As Object, e As EventArgs) Handles btnSueldoNeto.Click
        Me.Hide()
        SalariosYDeducciones.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class