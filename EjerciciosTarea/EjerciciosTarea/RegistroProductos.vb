Imports System.ComponentModel

Public Class RegistroProductos

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        'Definir variables
        Dim codigo, nombre, producto As String
        Dim precio As Integer
        Dim descuento, docena As Double

        'Valida los valores que se ingresarán en las cajas de texto
        Try
            If Me.ValidateChildren And txtCodigo.Text <> String.Empty And txtCodigo.TextLength < 4 And txtNombre.Text <> String.Empty And txtPrecio.Text <> String.Empty And Val(txtPrecio.Text) - Val(Int(txtPrecio.Text)) = 0 Then

                'Asigna los valores que se obtuvieron desde la caja de texto
                codigo = txtCodigo.Text
                nombre = txtNombre.Text
                precio = txtPrecio.Text

                'Calcula el precio por docena por medio de un ciclo for y un acumulador
                For i = 1 To 12 Step 1
                    docena += precio
                Next

                'Verifica si se aplica un descuento
                If chkDescuento.Checked = True Then
                    Select Case cmbDescuento.SelectedIndex
                        Case 0
                            descuento = docena * 0.1
                            docena = docena - descuento
                        Case 1
                            descuento = docena * 0.15
                            docena = docena - descuento
                        Case Else
                            MsgBox("Seleccione un tipo de descuento", vbInformation)
                    End Select
                End If

                'Asigna a las cajas de texto de salida
                txtCodigo1.Text = codigo
                txtNombre1.Text = nombre
                txtPrecio1.Text = precio
                txtDocena.Text = docena

                'Concatena los datos para luego agregarlos al combobox
                producto = "Código: " & codigo & "  Nombre: " & nombre & "  Precio unitario: " & precio & "  Precio por Docena: " & docena

                'Agrega los valores al combobox que contendrá el listado de productos
                cmbProductos.Items.Add(producto)
                incrementarContador = True
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar Datos", vbInformation)
        End Try
    End Sub

    Private Sub chkDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chkDescuento.CheckedChanged
        If chkDescuento.Checked = True Then
            cmbDescuento.Enabled = True
        ElseIf chkDescuento.Checked = False Then
            cmbDescuento.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_MouseHover(sender As Object, e As EventArgs)
        toolTip.SetToolTip(txtCodigo, "Ingrese un código de 3 caracteres")
        toolTip.ToolTipTitle = "Código"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtCodigo, "Ingrese el nombre del producto")
        toolTip.ToolTipTitle = "Nombre"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorProvider.SetError(sender, "")
        Else
            Me.errorProvider.SetError(sender, "Ingrese un nombre")
        End If
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        toolTip.SetToolTip(txtCodigo, "Ingrese el precio del producto (Solo valores enteros)")
        toolTip.ToolTipTitle = "Precio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio.TextChanged

    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorProvider.SetError(sender, "")
        Else
            Me.errorProvider.SetError(sender, "Ingrese un precio")
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 And DirectCast(sender, TextBox).Text.Length < 4 Then
            Me.errorProvider.SetError(sender, "")
        Else
            Me.errorProvider.SetError(sender, "Ingrese un código de 3 o menos caracteres")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCodigo.Clear()
        txtCodigo1.Clear()
        txtNombre.Clear()
        txtNombre1.Clear()
        txtPrecio.Clear()
        txtPrecio1.Clear()
        txtDocena.Clear()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub cmbDescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDescuento.SelectedIndexChanged
    End Sub
End Class