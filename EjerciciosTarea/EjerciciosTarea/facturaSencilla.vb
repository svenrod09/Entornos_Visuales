Public Class facturaSencilla
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definir variables
        Dim precio, cantidad, subtotal As Integer
        Dim descuento, isv, total As Double

        'Validar que los valores ingresados en precio/cantidad sean númericos positivos
        'Verifica que no haya campos vacíos
        If txtPrecio.Text = "" Or txtCantidad.Text = "" Then
            MsgBox("No puede dejar campos vacíos", vbInformation)
            txtPrecio.Text = ""
            txtCantidad.Text = ""
            'Verifica que los valores ingresados sean números
        ElseIf Not IsNumeric(txtPrecio.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Debe ingresar solo valores númericos", vbInformation)
            'Verifica que los valores ingresados sean positivos
        ElseIf IsNumeric(txtPrecio.Text) And IsNumeric(txtCantidad.Text) Then
            precio = Val(txtPrecio.Text)
            cantidad = Val(txtCantidad.Text)
            If precio <= 0 Or cantidad <= 0 Then
                MsgBox("Ingrese valores positivos", vbInformation)
            End If
        End If

        'Proceso
        subtotal = precio * cantidad
        descuento = 0
        isv = 0

        'Aplica los descuentos en caso de ser seleccionados
        Select Case cmbDescuento.SelectedIndex
            Case 0
                descuento = subtotal * 0.5
            Case 1
                descuento = subtotal * 0.25
            Case 2
                descuento = subtotal * 0.2
            Case 3
                descuento = subtotal * 0.15
            Case 4
                descuento = subtotal * 0.1
            Case 5
                descuento = subtotal * 0.05
        End Select

        'Aplica el ISV en caso de ser seleccionado
        Select Case cmbISV.SelectedIndex
            Case 0
                isv = subtotal * 0.15
            Case 1
                isv = subtotal * 0.17
        End Select

        'Calcula el total a pagar
        total = subtotal - descuento + isv

        'Salidas 
        txtSubtotal.Text = subtotal
        txtDescuento.Text = descuento
        txtISV.Text = isv
        txtTotal.Text = total
        btnNuevo.Enabled = True
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            chkISV.Checked = False
            cmbDescuento.Enabled = True
        End If
    End Sub

    Private Sub chkISV_CheckedChanged(sender As Object, e As EventArgs) Handles chkISV.CheckedChanged
        If chkISV.Checked = True Then
            chkDescuento.Checked = False
            cmbISV.Enabled = True
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtSubtotal.Clear()
        txtDescuento.Clear()
        txtISV.Clear()
        txtTotal.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class