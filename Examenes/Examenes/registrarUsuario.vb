Imports System.ComponentModel
Public Class registrarUsuario
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs)
        'Definir variables
        Dim validarUsuario As Integer
        Dim usuario, contraseña, usuarioAdmitido, contraseñaAdmitida As String

        'Asignar valores a las variables
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text
        usuarioAdmitido = "Administrador"
        contraseñaAdmitida = "SinHacer2020"

        'Valida que ninguno de los campos esté vacíos
        Try
            'Verfica que el nombre de usuario y contraseña sean los permitidos
            If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContraseña.Text <> String.Empty Then
                If (usuario = usuarioAdmitido) And (contraseña = contraseñaAdmitida) Then
                    MsgBox("Usuario registrado con éxito", vbInformation)
                    validarUsuario = 1
                Else
                    MsgBox("Usuario o contraseña no admitidos", vbInformation)
                    validarUsuario = 0
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                End If
            End If

            'Envia el valor que indica si el usuario está registrado al formulario inicio de sesion
            Examenes.EnviarValor.validarUsuario = validarUsuario

        Catch ex As Exception
            MsgBox("Error, no puede dejar campos vacíos", vbInformation)
        End Try
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged

    End Sub

    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        toolTip.SetToolTip(txtUsuario, "Ingrese el Usuario: Administrador")
        toolTip.ToolTipTitle = "Ingreso de Usuario"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
    End Sub

    Private Sub txtContraseña_MouseHover(sender As Object, e As EventArgs) Handles txtContraseña.MouseHover
        toolTip.SetToolTip(txtContraseña, "Ingrese el Usuario: SinHacer2020")
        toolTip.ToolTipTitle = "Ingreso de Contraseña"
        toolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese el Usuario")
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.errorValidacion.SetError(sender, "")
        Else
            Me.errorValidacion.SetError(sender, "Ingrese la Contraseña")
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        iniciodesesion.Show()
    End Sub

    Private Sub registrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        End
    End Sub

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        'Definir variables
        Dim validarUsuario As Integer
        Dim usuario, contraseña, usuarioAdmitido, contraseñaAdmitida As String

        'Asignar valores a las variables
        usuario = txtUsuario.Text
        contraseña = txtContraseña.Text
        usuarioAdmitido = "Administrador"
        contraseñaAdmitida = "SinHacer2020"

        'Valida que ninguno de los campos esté vacíos
        Try
            'Verfica que el nombre de usuario y contraseña sean los permitidos
            If Me.ValidateChildren And txtUsuario.Text <> String.Empty And txtContraseña.Text <> String.Empty Then
                If (usuario = usuarioAdmitido) And (contraseña = contraseñaAdmitida) Then
                    MsgBox("Usuario registrado con éxito", vbInformation)
                    validarUsuario = 1
                Else
                    MsgBox("Usuario o contraseña no admitidos", vbInformation)
                    validarUsuario = 0
                    txtUsuario.Clear()
                    txtContraseña.Clear()
                End If
            End If

            'Envia el valor que indica si el usuario está registrado al formulario inicio de sesion
            Examenes.EnviarValor.validarUsuario = validarUsuario

        Catch ex As Exception
            MsgBox("Error, no puede dejar campos vacíos", vbInformation)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Regresar.Click
        Me.Hide()
        iniciodesesion.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Cerrar.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Desea Salir?",
                              "Salir",
                              MessageBoxButtons.YesNo)

        If (respuesta = DialogResult.Yes) Then
            End
        Else
        End If
    End Sub
End Class