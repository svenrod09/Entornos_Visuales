Imports System.ComponentModel

Public Class ingresoPruebas
    Dim contador(0 To 17), contadorActivos(0 To 17), contadorRecuperados(0 To 17), contadorFallecidos(0 To 17)
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs)
        'Definir Variables
        Dim nombre, municipio, edad, departamento As String
        Dim estadoPrueba, idDepartamento As Integer

        'Asignar los valores a las variables
        nombre = txtNombre.Text
        edad = txtEdad.Text
        departamento = cmbDepartamentos.SelectedIndex
        municipio = txtMunicipio.Text

        'Validar que se seleccione una casilla
        If (chkPositivo.Checked = True Or chkNegativo.Checked = True) Then
            If (chkActivo.Checked = True Or chkFallecido.Checked = True Or chkRecuperado.Checked = True) Then
                estadoPrueba = 1
            End If
        Else
            estadoPrueba = 0
        End If

        'Validar que se ingresen valores válidos
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtMunicipio.Text <> String.Empty And Val(txtEdad.Text) - Val(Int(txtEdad.Text)) = 0 And IsNumeric(txtEdad.Text) And txtDescripcion.Text <> String.Empty And estadoPrueba = 1 Then
                'Hace un conteo de los casos ingresados
                Select Case departamento
                    Case 0
                        idDepartamento = 0
                        registroDepartamento(idDepartamento)
                    Case 1
                        idDepartamento = 1
                        registroDepartamento(idDepartamento)
                    Case 2
                        idDepartamento = 2
                        registroDepartamento(idDepartamento)
                    Case 3
                        idDepartamento = 3
                        registroDepartamento(idDepartamento)
                    Case 4
                        idDepartamento = 4
                        registroDepartamento(idDepartamento)
                    Case 5
                        idDepartamento = 5
                        registroDepartamento(idDepartamento)
                    Case 6
                        idDepartamento = 6
                        registroDepartamento(idDepartamento)
                    Case 7
                        idDepartamento = 7
                        registroDepartamento(idDepartamento)
                    Case 8
                        idDepartamento = 8
                        registroDepartamento(idDepartamento)
                    Case 9
                        idDepartamento = 9
                        registroDepartamento(idDepartamento)
                    Case 10
                        idDepartamento = 10
                        registroDepartamento(idDepartamento)
                    Case 11
                        idDepartamento = 11
                        registroDepartamento(idDepartamento)
                    Case 12
                        idDepartamento = 12
                        registroDepartamento(idDepartamento)
                    Case 13
                        idDepartamento = 13
                        registroDepartamento(idDepartamento)
                    Case 14
                        idDepartamento = 14
                        registroDepartamento(idDepartamento)
                    Case 15
                        idDepartamento = 15
                        registroDepartamento(idDepartamento)
                    Case 16
                        idDepartamento = 16
                        registroDepartamento(idDepartamento)
                    Case 17
                        idDepartamento = 17
                        registroDepartamento(idDepartamento)
                End Select
                MsgBox("Cliente ingresado con éxito", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar los datos", vbInformation)
        End Try
    End Sub

    Private Sub chkPositivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPositivo.CheckedChanged
        'Valida que no se puedan seleccionar varias casillas a la vez
        If chkPositivo.Checked = True Then
            chkNegativo.Checked = False
            chkActivo.Enabled = True
            chkFallecido.Enabled = True
            chkRecuperado.Enabled = True
        Else
            chkActivo.Enabled = False
            chkFallecido.Enabled = False
            chkRecuperado.Enabled = False
        End If
    End Sub

    Private Sub chkNegativo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegativo.CheckedChanged
        'Valida que no se puedan seleccionar varias casillas a la vez
        If (chkNegativo.Checked = True) Then
            chkPositivo.Checked = False
            chkActivo.Enabled = False
            chkFallecido.Enabled = False
            chkRecuperado.Enabled = False
        End If
    End Sub

    Private Sub chkActivo_CheckedChanged(sender As Object, e As EventArgs) Handles chkActivo.CheckedChanged
        'Valida que no se puedan seleccionar varias casillas a la vez
        If (chkActivo.Checked = True) Then
            chkFallecido.Checked = False
            chkRecuperado.Checked = False
        End If
    End Sub

    Private Sub chkFallecido_CheckedChanged(sender As Object, e As EventArgs) Handles chkFallecido.CheckedChanged
        'Valida que no se puedan seleccionar varias casillas a la vez
        If (chkFallecido.Checked = True) Then
            chkActivo.Checked = False
            chkRecuperado.Checked = False
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        'Limpia las cajas de texto y deselecciona las casillas
        txtActivos.Clear()
        txtCasosPositivos.Clear()
        txtFallecidos.Clear()
        txtRecuperados.Clear()
        txtNombre.Clear()
        txtEdad.Clear()
        txtDescripcion.Clear()
        chkPositivo.Checked = False
        chkNegativo.Checked = False
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub chkRecuperado_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecuperado.CheckedChanged
        If (chkRecuperado.Checked = True) Then
            chkFallecido.Checked = False
            chkActivo.Checked = False
        End If
    End Sub

    Private Sub txtEdad_TextChanged(sender As Object, e As EventArgs) Handles txtEdad.TextChanged

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea Salir?",
                              "Salir",
                              MessageBoxButtons.YesNo)

        If (respuesta = DialogResult.Yes) Then
            End
        Else
        End If
    End Sub

    Private Sub txtMunicipio_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipio.TextChanged

    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs)
        'Definir variables
        Dim idDepartamento As Integer
        Dim departamento As String
        departamento = cmbDepartamento1.SelectedIndex

        'Despliega los datos que se contabilizan en el apartado de ingresar
        Select Case departamento
            Case 0
                idDepartamento = 0
                reporteDepartamento(idDepartamento)
            Case 1
                idDepartamento = 1
                reporteDepartamento(idDepartamento)
            Case 2
                idDepartamento = 2
                reporteDepartamento(idDepartamento)
            Case 3
                idDepartamento = 3
                reporteDepartamento(idDepartamento)
            Case 4
                idDepartamento = 4
                reporteDepartamento(idDepartamento)
            Case 5
                idDepartamento = 5
                reporteDepartamento(idDepartamento)
            Case 6
                idDepartamento = 6
                reporteDepartamento(idDepartamento)
            Case 7
                idDepartamento = 7
                reporteDepartamento(idDepartamento)
            Case 8
                idDepartamento = 8
                reporteDepartamento(idDepartamento)
            Case 9
                idDepartamento = 9
                reporteDepartamento(idDepartamento)
            Case 10
                idDepartamento = 10
                reporteDepartamento(idDepartamento)
            Case 11
                idDepartamento = 11
                reporteDepartamento(idDepartamento)
            Case 12
                idDepartamento = 12
                reporteDepartamento(idDepartamento)
            Case 13
                idDepartamento = 13
                reporteDepartamento(idDepartamento)
            Case 14
                idDepartamento = 14
                reporteDepartamento(idDepartamento)
            Case 15
                idDepartamento = 15
                reporteDepartamento(idDepartamento)
            Case 16
                idDepartamento = 16
                reporteDepartamento(idDepartamento)
            Case 17
                idDepartamento = 17
                reporteDepartamento(idDepartamento)
        End Select
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el nombre del paciente")
        End If
    End Sub

    Private Sub txtEdad_Validating(sender As Object, e As CancelEventArgs) Handles txtEdad.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese la edad del paciente")
        End If
    End Sub

    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el municipio donde reside el paciente")
        End If
    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        toolTip.SetToolTip(txtNombre, "Ingrese el nombre del paciente")
        toolTip.ToolTipTitle = "Nombre"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEdad_MouseHover(sender As Object, e As EventArgs) Handles txtEdad.MouseHover
        toolTip.SetToolTip(txtEdad, "Ingrese la edad del paciente (valor entero)")
        toolTip.ToolTipTitle = "Edad"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        toolTip.SetToolTip(txtMunicipio, "Ingrese el nombre del municipio donde reside el paciente")
        toolTip.ToolTipTitle = "Municipio"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese una breve descripción del estado del paciente")
        End If
    End Sub

    Private Sub Cerrar_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea Salir?",
                              "Salir",
                              MessageBoxButtons.YesNo)

        If (respuesta = DialogResult.Yes) Then
            End
        Else
        End If
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        'Limpia las cajas de texto y deselecciona las casillas
        txtActivos.Clear()
        txtCasosPositivos.Clear()
        txtFallecidos.Clear()
        txtRecuperados.Clear()
        txtNombre.Clear()
        txtEdad.Clear()
        txtDescripcion.Clear()
        chkPositivo.Checked = False
        chkNegativo.Checked = False
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        'Definir Variables
        Dim nombre, municipio, edad, departamento As String
        Dim estadoPrueba, idDepartamento As Integer

        'Asignar los valores a las variables
        nombre = txtNombre.Text
        edad = txtEdad.Text
        departamento = cmbDepartamentos.SelectedIndex
        municipio = txtMunicipio.Text

        'Validar que se seleccione una casilla
        If (chkPositivo.Checked = True Or chkNegativo.Checked = True) Then
            If (chkActivo.Checked = True Or chkFallecido.Checked = True Or chkRecuperado.Checked = True) Then
                estadoPrueba = 1
            End If
        Else
            estadoPrueba = 0
        End If

        'Validar que se ingresen valores válidos
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtEdad.Text <> String.Empty And txtMunicipio.Text <> String.Empty And Val(txtEdad.Text) - Val(Int(txtEdad.Text)) = 0 And IsNumeric(txtEdad.Text) And txtDescripcion.Text <> String.Empty And estadoPrueba = 1 Then
                'Hace un conteo de los casos ingresados
                Select Case departamento
                    Case 0
                        idDepartamento = 0
                        registroDepartamento(idDepartamento)
                    Case 1
                        idDepartamento = 1
                        registroDepartamento(idDepartamento)
                    Case 2
                        idDepartamento = 2
                        registroDepartamento(idDepartamento)
                    Case 3
                        idDepartamento = 3
                        registroDepartamento(idDepartamento)
                    Case 4
                        idDepartamento = 4
                        registroDepartamento(idDepartamento)
                    Case 5
                        idDepartamento = 5
                        registroDepartamento(idDepartamento)
                    Case 6
                        idDepartamento = 6
                        registroDepartamento(idDepartamento)
                    Case 7
                        idDepartamento = 7
                        registroDepartamento(idDepartamento)
                    Case 8
                        idDepartamento = 8
                        registroDepartamento(idDepartamento)
                    Case 9
                        idDepartamento = 9
                        registroDepartamento(idDepartamento)
                    Case 10
                        idDepartamento = 10
                        registroDepartamento(idDepartamento)
                    Case 11
                        idDepartamento = 11
                        registroDepartamento(idDepartamento)
                    Case 12
                        idDepartamento = 12
                        registroDepartamento(idDepartamento)
                    Case 13
                        idDepartamento = 13
                        registroDepartamento(idDepartamento)
                    Case 14
                        idDepartamento = 14
                        registroDepartamento(idDepartamento)
                    Case 15
                        idDepartamento = 15
                        registroDepartamento(idDepartamento)
                    Case 16
                        idDepartamento = 16
                        registroDepartamento(idDepartamento)
                    Case 17
                        idDepartamento = 17
                        registroDepartamento(idDepartamento)
                    Case Else
                        MsgBox("No seleccionó ningún departamento", vbInformation)
                End Select
                MsgBox("Datos ingresados con éxito", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Error al ingresar los datos", vbInformation)
        End Try
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        'Definir variables
        Dim idDepartamento As Integer
        Dim departamento As String
        departamento = cmbDepartamento1.SelectedIndex

        'Despliega los datos que se contabilizan en el apartado de ingresar
        Select Case departamento
            Case 0
                idDepartamento = 0
                reporteDepartamento(idDepartamento)
            Case 1
                idDepartamento = 1
                reporteDepartamento(idDepartamento)
            Case 2
                idDepartamento = 2
                reporteDepartamento(idDepartamento)
            Case 3
                idDepartamento = 3
                reporteDepartamento(idDepartamento)
            Case 4
                idDepartamento = 4
                reporteDepartamento(idDepartamento)
            Case 5
                idDepartamento = 5
                reporteDepartamento(idDepartamento)
            Case 6
                idDepartamento = 6
                reporteDepartamento(idDepartamento)
            Case 7
                idDepartamento = 7
                reporteDepartamento(idDepartamento)
            Case 8
                idDepartamento = 8
                reporteDepartamento(idDepartamento)
            Case 9
                idDepartamento = 9
                reporteDepartamento(idDepartamento)
            Case 10
                idDepartamento = 10
                reporteDepartamento(idDepartamento)
            Case 11
                idDepartamento = 11
                reporteDepartamento(idDepartamento)
            Case 12
                idDepartamento = 12
                reporteDepartamento(idDepartamento)
            Case 13
                idDepartamento = 13
                reporteDepartamento(idDepartamento)
            Case 14
                idDepartamento = 14
                reporteDepartamento(idDepartamento)
            Case 15
                idDepartamento = 15
                reporteDepartamento(idDepartamento)
            Case 16
                idDepartamento = 16
                reporteDepartamento(idDepartamento)
            Case 17
                idDepartamento = 17
                reporteDepartamento(idDepartamento)
            Case Else
                MsgBox("Debe seleccionar un departamento", vbInformation)
        End Select
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        toolTip.SetToolTip(txtDescripcion, "Ingrese una breve descripción del estado del paciente")
        toolTip.ToolTipTitle = "Descripción"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Public Sub registroDepartamento(idDepartamento As Integer)
        'Inicializa los valores en 0
        contador(idDepartamento) = 0
        contadorActivos(idDepartamento) = 0
        contadorFallecidos(idDepartamento) = 0
        contadorRecuperados(idDepartamento) = 0

        'Compara y contabiliza los datos ingresados
        If (chkPositivo.Checked = True) Then
            contador(idDepartamento) += 1
            If (chkActivo.Checked = True) Then
                contadorActivos(idDepartamento) += 1
            ElseIf (chkFallecido.Checked = True) Then
                contadorFallecidos(idDepartamento) += 1
            ElseIf (chkRecuperado.Checked = True) Then
                contadorRecuperados(idDepartamento) += 1
            End If
        End If
    End Sub
    Public Sub reporteDepartamento(idDepartamento As Integer)
        'Muestra en las cajas de texto de salida los valores procesados anteriormente
        txtCasosPositivos.Text = contador(idDepartamento)
        txtRecuperados.Text = contadorRecuperados(idDepartamento)
        txtFallecidos.Text = contadorFallecidos(idDepartamento)
        txtActivos.Text = contadorActivos(idDepartamento)
    End Sub
End Class