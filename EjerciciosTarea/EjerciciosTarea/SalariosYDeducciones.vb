Imports System.ComponentModel

Public Class SalariosYDeducciones
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtSueldo.Clear()
        txtSueldoNeto.Clear()
        txtDeducido.Clear()
        chkExento.Checked = False
        chk15.Checked = False
        chk20.Checked = False
        chk25.Checked = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        'Definir variables
        Dim nombre As String
        Dim sueldo, sueldoNeto, deduccion As Double

        'Asignar los valores a las variables
        nombre = txtNombre.Text
        sueldo = Val(txtSueldo.Text)

        'Validar los campos donde se introducirán datos
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtSueldo.Text <> String.Empty And Val(txtSueldo.Text) > 0 And IsNumeric(txtSueldo.Text) Then
                'Aplica las distintas deducciones en función al sueldo del empleado
                'Exento
                If (sueldo < 16582.92) Then
                    chkExento.Checked = True
                    chk15.Checked = False
                    chk20.Checked = False
                    chk25.Checked = False
                    sueldoNeto = sueldo
                    deduccion = 0
                    '15%
                ElseIf (sueldo < 23536.61) Then
                    chk15.Checked = True
                    chkExento.Checked = False
                    chk20.Checked = False
                    chk25.Checked = False
                    deduccion = sueldo * 0.15
                    sueldoNeto = sueldo - deduccion
                    '20%
                ElseIf (sueldo < 50317.69) Then
                    chk20.Checked = True
                    chkExento.Checked = False
                    chk15.Checked = False
                    chk25.Checked = False
                    deduccion = sueldo * 0.2
                    sueldoNeto = sueldoNeto - deduccion
                    '25%
                ElseIf (sueldo > 50317.69) Then
                    chk25.Checked = True
                    chkExento.Checked = False
                    chk15.Checked = False
                    chk20.Checked = False
                    deduccion = sueldo * 0.25
                    sueldoNeto = sueldo - deduccion
                End If
            End If

            'Asigna los valores de salida
            txtDeducido.Text = deduccion
            txtSueldoNeto.Text = sueldoNeto
        Catch ex As Exception
            MsgBox("Error al ingresar los datos", vbInformation)
        End Try
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el nombre del empleado")
        End If
    End Sub

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged

    End Sub

    Private Sub txtSueldo_Validating(sender As Object, e As CancelEventArgs) Handles txtSueldo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el salario del empleado")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub RegresarAlMenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenúToolStripMenuItem.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class