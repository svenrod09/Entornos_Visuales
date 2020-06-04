Imports System.ComponentModel

Public Class entregaMascarillas
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamentos.Text)
        Try
            If Me.ValidateChildren And txtDepartamentos.Text <> String.Empty And Val(txtDepartamentos.Text) - Int(Val(txtDepartamentos.Text)) = 0 And Val(txtDepartamentos.Text) <= 18 And IsNumeric(txtDepartamentos.Text) Then

                For i = 1 To departamentos Step 1
                    Do
                        mascarillas = InputBox("Ingrese la cantidad de mascarillas" & i, ", Ingresar")
                    Loop While (mascarillas < 0 Or mascarillas > 10000)
                    cmbDepartamento.Items.Add(mascarillas)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub entregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Function reparto(municipios As Integer, itemDepartamento As Integer) As Integer
        'Definir variables
        Dim cantEntrega As Integer

        'Proceso
        For i = 1 To municipios Step 1
            While (itemDepartamento > 0)
                cantEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                If (itemDepartamento > cantEntrega) Then
                    municipios += 1
                    itemDepartamento -= cantEntrega
                    txtStock.Text = itemDepartamento
                Else
                    MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End While
        Next

        Return itemDepartamento
    End Function


    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios As Integer
        Dim itemDepartamento As String
        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString
        municipios = Val(txtMunicipios.Text)

        Try
            If Me.ValidateChildren And txtMunicipios.Text <> String.Empty And Val(txtMunicipios.Text) - Int(Val(txtMunicipios.Text)) = 0 And IsNumeric(txtMunicipios.Text) Then
                Select Case idDepartamento
                    Case 0
                        reparto(municipios, itemDepartamento)
                    Case 1
                        reparto(municipios, itemDepartamento)
                    Case 2
                        reparto(municipios, itemDepartamento)
                    Case 3
                        reparto(municipios, itemDepartamento)
                    Case 4
                        reparto(municipios, itemDepartamento)
                    Case 5
                        reparto(municipios, itemDepartamento)
                    Case 6
                        reparto(municipios, itemDepartamento)
                    Case 7
                        reparto(municipios, itemDepartamento)
                    Case 8
                        reparto(municipios, itemDepartamento)
                    Case 9
                        reparto(municipios, itemDepartamento)
                    Case 10
                        reparto(municipios, itemDepartamento)
                    Case 11
                        reparto(municipios, itemDepartamento)
                    Case 12
                        reparto(municipios, itemDepartamento)
                    Case 13
                        reparto(municipios, itemDepartamento)
                    Case 14
                        reparto(municipios, itemDepartamento)
                    Case 15
                        reparto(municipios, itemDepartamento)
                    Case 16
                        reparto(municipios, itemDepartamento)
                    Case 17
                        reparto(municipios, itemDepartamento)
                End Select
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDepartamentos_TextChanged(sender As Object, e As EventArgs) Handles txtDepartamentos.TextChanged

    End Sub

    Private Sub txtDepartamentos_Validating(sender As Object, e As CancelEventArgs) Handles txtDepartamentos.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorProvider.SetError(sender, "")
        Else
            Me.errorProvider.SetError(sender, "No puede dejar este campo vacío ni ingresar datos que no sean enteros")
        End If
    End Sub

    Private Sub txtMunicipios_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipios.TextChanged

    End Sub

    Private Sub txtMunicipios_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipios.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorProvider.SetError(sender, "")
        Else
            Me.errorProvider.SetError(sender, "No puede dejar este campo vacío ni ingresar datos que no sean enteros")
        End If
    End Sub
End Class