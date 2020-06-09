<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Me.txtCalcular = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnIgual = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnpunto = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Operaciones = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarAlMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCalcular)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.btnSuma)
        Me.GroupBox1.Controls.Add(Me.btnResta)
        Me.GroupBox1.Controls.Add(Me.btnMult)
        Me.GroupBox1.Controls.Add(Me.btnDividir)
        Me.GroupBox1.Controls.Add(Me.btnIgual)
        Me.GroupBox1.Controls.Add(Me.btn3)
        Me.GroupBox1.Controls.Add(Me.btn6)
        Me.GroupBox1.Controls.Add(Me.btn9)
        Me.GroupBox1.Controls.Add(Me.btnpunto)
        Me.GroupBox1.Controls.Add(Me.btn0)
        Me.GroupBox1.Controls.Add(Me.btn2)
        Me.GroupBox1.Controls.Add(Me.btn5)
        Me.GroupBox1.Controls.Add(Me.btn8)
        Me.GroupBox1.Controls.Add(Me.btn1)
        Me.GroupBox1.Controls.Add(Me.btn4)
        Me.GroupBox1.Controls.Add(Me.btn7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calcular"
        '
        'txtCalcular
        '
        Me.txtCalcular.Location = New System.Drawing.Point(23, 54)
        Me.txtCalcular.Name = "txtCalcular"
        Me.txtCalcular.Size = New System.Drawing.Size(195, 20)
        Me.txtCalcular.TabIndex = 17
        Me.txtCalcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(224, 140)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 42)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(182, 206)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(36, 32)
        Me.btnSuma.TabIndex = 15
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(182, 168)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(36, 32)
        Me.btnResta.TabIndex = 14
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(182, 130)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(36, 32)
        Me.btnMult.TabIndex = 13
        Me.btnMult.Text = "*"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(182, 92)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(36, 32)
        Me.btnDividir.TabIndex = 12
        Me.btnDividir.Text = "/"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnIgual
        '
        Me.btnIgual.Location = New System.Drawing.Point(130, 206)
        Me.btnIgual.Name = "btnIgual"
        Me.btnIgual.Size = New System.Drawing.Size(36, 32)
        Me.btnIgual.TabIndex = 11
        Me.btnIgual.Text = "="
        Me.btnIgual.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(130, 168)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(36, 32)
        Me.btn3.TabIndex = 10
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(130, 130)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(36, 32)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(130, 92)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(36, 32)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btnpunto
        '
        Me.btnpunto.Location = New System.Drawing.Point(78, 206)
        Me.btnpunto.Name = "btnpunto"
        Me.btnpunto.Size = New System.Drawing.Size(36, 32)
        Me.btnpunto.TabIndex = 7
        Me.btnpunto.Text = "."
        Me.btnpunto.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(23, 206)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(36, 32)
        Me.btn0.TabIndex = 6
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(78, 168)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(36, 32)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(78, 130)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(36, 32)
        Me.btn5.TabIndex = 4
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(78, 92)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(36, 32)
        Me.btn8.TabIndex = 3
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(23, 168)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(36, 32)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(23, 130)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(36, 32)
        Me.btn4.TabIndex = 1
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(23, 92)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(36, 32)
        Me.btn7.TabIndex = 0
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Operaciones)
        Me.GroupBox2.Location = New System.Drawing.Point(332, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Historial"
        '
        'Operaciones
        '
        Me.Operaciones.FormattingEnabled = True
        Me.Operaciones.Location = New System.Drawing.Point(22, 29)
        Me.Operaciones.Name = "Operaciones"
        Me.Operaciones.Size = New System.Drawing.Size(173, 238)
        Me.Operaciones.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(471, 338)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(558, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegresarAlMenúToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegresarAlMenúToolStripMenuItem
        '
        Me.RegresarAlMenúToolStripMenuItem.Name = "RegresarAlMenúToolStripMenuItem"
        Me.RegresarAlMenúToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.RegresarAlMenúToolStripMenuItem.Text = "Regresar al Menú"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 369)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnIgual As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnpunto As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents txtCalcular As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Operaciones As ListBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
