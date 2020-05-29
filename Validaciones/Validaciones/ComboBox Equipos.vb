Public Class ComboBox_Equipos
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEquipos.SelectedIndexChanged
        Dim itemId As Integer
        Dim itemNombre As String

        itemId = cmbEquipos.SelectedIndex
        itemNombre = cmbEquipos.SelectedItem.ToString
        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case 4
                MsgBox(itemNombre)
            Case 5
                MsgBox(itemNombre)
            Case Else
                MsgBox("Selecciona un valor correcto")
        End Select
    End Sub
End Class