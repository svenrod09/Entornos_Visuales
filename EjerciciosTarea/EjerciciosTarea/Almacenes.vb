Public Class Almacenes
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        'Definir Variables
        Dim almacenes(0 To 10), sumaVentas, mediaVentas As Double

        'Ciclo para ingresar los datos
        For i = 1 To 10 Step 1
            'Ciclo que valida los valores que se ingresarán
            Do
                almacenes(i) = InputBox("Ingrese el total de ventas del almacen " & i, "Registro de ventas")
            Loop While (almacenes(i) < 0 Or Not IsNumeric(almacenes(i)) Or almacenes(i).ToString = String.Empty)
            sumaVentas += almacenes(i)
        Next
        mediaVentas = sumaVentas / 10
        txtMedia.Text = mediaVentas

        'Ciclo para agregar los almacenes a la lista 
        For i = 1 To 10 Step 1
            If (almacenes(i) > mediaVentas) Then
                Listado.Items.Add("Almacen #" & i & ", Total Vendido: " & almacenes(i))
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub RegresarAlMenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresarAlMenúToolStripMenuItem.Click
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub
End Class