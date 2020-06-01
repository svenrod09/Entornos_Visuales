Public Class Acumulador
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msktxtCombos.MaskInputRejected

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        Try
            Dim precio, total, totalaPagar, orden As Integer
            orden = msktxtCombos.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el patillo No." & i, "Precio del Platillo")
                'Acumulador
                totalaPagar += precio
            Next
            total = totalaPagar / orden
            txtTotal.Text = totalaPagar
            txtIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIndividual.Clear()
        txtTotal.Clear()
        msktxtCombos.Clear()
    End Sub
End Class