<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormulaCuadratica
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValorA = New System.Windows.Forms.TextBox()
        Me.txtValorB = New System.Windows.Forms.TextBox()
        Me.txtValorC = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarAlMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Valor de A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Valor de B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Valor de C"
        '
        'txtValorA
        '
        Me.txtValorA.Location = New System.Drawing.Point(113, 47)
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(100, 20)
        Me.txtValorA.TabIndex = 3
        '
        'txtValorB
        '
        Me.txtValorB.Location = New System.Drawing.Point(113, 85)
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(100, 20)
        Me.txtValorB.TabIndex = 4
        '
        'txtValorC
        '
        Me.txtValorC.Location = New System.Drawing.Point(113, 123)
        Me.txtValorC.Name = "txtValorC"
        Me.txtValorC.Size = New System.Drawing.Size(100, 20)
        Me.txtValorC.TabIndex = 5
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(90, 161)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(113, 200)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.ReadOnly = True
        Me.txtX1.Size = New System.Drawing.Size(100, 20)
        Me.txtX1.TabIndex = 7
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(113, 242)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.ReadOnly = True
        Me.txtX2.Size = New System.Drawing.Size(100, 20)
        Me.txtX2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "X1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "X2"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(167, 277)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(11, 277)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(255, 24)
        Me.MenuStrip1.TabIndex = 13
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
        'FormulaCuadratica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 315)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtValorC)
        Me.Controls.Add(Me.txtValorB)
        Me.Controls.Add(Me.txtValorA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormulaCuadratica"
        Me.Text = "FormulaCuadratica"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValorA As TextBox
    Friend WithEvents txtValorB As TextBox
    Friend WithEvents txtValorC As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
