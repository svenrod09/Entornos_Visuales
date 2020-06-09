<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalculadora = New System.Windows.Forms.Button()
        Me.btnFC = New System.Windows.Forms.Button()
        Me.btnAlmacenes = New System.Windows.Forms.Button()
        Me.btnParImpar = New System.Windows.Forms.Button()
        Me.btnSueldoNeto = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSueldoNeto)
        Me.GroupBox1.Controls.Add(Me.btnParImpar)
        Me.GroupBox1.Controls.Add(Me.btnAlmacenes)
        Me.GroupBox1.Controls.Add(Me.btnFC)
        Me.GroupBox1.Controls.Add(Me.btnCalculadora)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 275)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formularios Disponibles"
        '
        'btnCalculadora
        '
        Me.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCalculadora.Location = New System.Drawing.Point(29, 49)
        Me.btnCalculadora.Name = "btnCalculadora"
        Me.btnCalculadora.Size = New System.Drawing.Size(132, 53)
        Me.btnCalculadora.TabIndex = 0
        Me.btnCalculadora.Text = "Calculadora"
        Me.btnCalculadora.UseVisualStyleBackColor = True
        '
        'btnFC
        '
        Me.btnFC.Location = New System.Drawing.Point(218, 49)
        Me.btnFC.Name = "btnFC"
        Me.btnFC.Size = New System.Drawing.Size(132, 53)
        Me.btnFC.TabIndex = 1
        Me.btnFC.Text = "Fórmula Cuadrática"
        Me.btnFC.UseVisualStyleBackColor = True
        '
        'btnAlmacenes
        '
        Me.btnAlmacenes.Location = New System.Drawing.Point(29, 130)
        Me.btnAlmacenes.Name = "btnAlmacenes"
        Me.btnAlmacenes.Size = New System.Drawing.Size(132, 53)
        Me.btnAlmacenes.TabIndex = 2
        Me.btnAlmacenes.Text = "Almacenes"
        Me.btnAlmacenes.UseVisualStyleBackColor = True
        '
        'btnParImpar
        '
        Me.btnParImpar.Location = New System.Drawing.Point(218, 130)
        Me.btnParImpar.Name = "btnParImpar"
        Me.btnParImpar.Size = New System.Drawing.Size(132, 53)
        Me.btnParImpar.TabIndex = 3
        Me.btnParImpar.Text = "Conteo Par o Impar"
        Me.btnParImpar.UseVisualStyleBackColor = True
        '
        'btnSueldoNeto
        '
        Me.btnSueldoNeto.Location = New System.Drawing.Point(29, 207)
        Me.btnSueldoNeto.Name = "btnSueldoNeto"
        Me.btnSueldoNeto.Size = New System.Drawing.Size(132, 53)
        Me.btnSueldoNeto.TabIndex = 4
        Me.btnSueldoNeto.Text = "Sueldo Neto"
        Me.btnSueldoNeto.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(325, 302)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(412, 337)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSueldoNeto As Button
    Friend WithEvents btnParImpar As Button
    Friend WithEvents btnAlmacenes As Button
    Friend WithEvents btnFC As Button
    Friend WithEvents btnCalculadora As Button
    Friend WithEvents btnSalir As Button
End Class
