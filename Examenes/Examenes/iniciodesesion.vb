Imports System.ComponentModel

Public Class iniciodesesion
    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()
        registrarUsuario.Show()
    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        'Definir variables
        Dim usuario, contraseña, usuarioAdmitido, contraseñaAdmitida As String
        Dim validarSesion, validarRegistro As Integer

        'Asignar los valores a las variables
        usuarioAdmitido = "Administrador"
        contraseñaAdmitida = "SinHacer2020"
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text

        'Verifica que se ingresen los datos correctos
        If (usuario = usuarioAdmitido) Then
            validarSesion = 1
        Else
            validarSesion = 0
        End If

        'Recibe los valores del formulario registrarUsuario
        validarRegistro = EnviarValor.validarUsuario

        'Valida que ninguno de los campos estén vacíos
        Try
            If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContraseña.Text <> String.Empty Then
                'Verifica que ya se haya registrado el usuario y que se ingresen los datos correctos 
                If (validarSesion = 1) And (validarRegistro = 1) Then
                    Me.Hide()
                    ingresoPruebas.Show()
                Else
                    MsgBox("Usuario o contraseña no encontrados", vbInformation)
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, no puede dejar los campos vaciíos", vbInformation)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Cerrar.Click
        End
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Registrarse.Click
        Me.Hide()
        registrarUsuario.Show()
    End Sub

    Private Sub iniciodesesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged

    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese la Contraseña")
        End If
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el Usuario")
        End If
    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        toolTip.SetToolTip(txtUsuario, "Ingrese un usuario")
        toolTip.ToolTipTitle = "Usuario"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        toolTip.SetToolTip(txtUsuario, "Ingrese un usuario")
        toolTip.ToolTipTitle = "Usuario"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
