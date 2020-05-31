<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaTextoMessage
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
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtIngresar = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbSuma = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbResta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMult = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDiv = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubFormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Formulario3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opcion2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProviderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIngresar)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 71)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar valor"
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(6, 30)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 23)
        Me.btnIngresar.TabIndex = 0
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'txtIngresar
        '
        Me.txtIngresar.Location = New System.Drawing.Point(103, 32)
        Me.txtIngresar.Name = "txtIngresar"
        Me.txtIngresar.Size = New System.Drawing.Size(100, 20)
        Me.txtIngresar.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnCalcular)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(302, 59)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(38, 19)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 0
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(128, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbDiv)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cmbMult)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbResta)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbSuma)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 219)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(302, 172)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Resultado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Suma"
        '
        'cmbSuma
        '
        Me.cmbSuma.FormattingEnabled = True
        Me.cmbSuma.Location = New System.Drawing.Point(6, 57)
        Me.cmbSuma.Name = "cmbSuma"
        Me.cmbSuma.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuma.TabIndex = 1
        Me.cmbSuma.Text = "Mostrar Suma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Resta"
        '
        'cmbResta
        '
        Me.cmbResta.FormattingEnabled = True
        Me.cmbResta.Location = New System.Drawing.Point(160, 57)
        Me.cmbResta.Name = "cmbResta"
        Me.cmbResta.Size = New System.Drawing.Size(121, 21)
        Me.cmbResta.TabIndex = 3
        Me.cmbResta.Text = "Mostrar Resta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Multiplicación"
        '
        'cmbMult
        '
        Me.cmbMult.FormattingEnabled = True
        Me.cmbMult.Location = New System.Drawing.Point(6, 131)
        Me.cmbMult.Name = "cmbMult"
        Me.cmbMult.Size = New System.Drawing.Size(121, 21)
        Me.cmbMult.TabIndex = 5
        Me.cmbMult.Text = "Mostrar Multiplicación"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Divsión"
        '
        'cmbDiv
        '
        Me.cmbDiv.FormattingEnabled = True
        Me.cmbDiv.Location = New System.Drawing.Point(160, 131)
        Me.cmbDiv.Name = "cmbDiv"
        Me.cmbDiv.Size = New System.Drawing.Size(121, 21)
        Me.cmbDiv.TabIndex = 7
        Me.cmbDiv.Text = "Mostrar División"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.Opcion2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(327, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.Formulario2ToolStripMenuItem, Me.Formulario3ToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'Formulario2ToolStripMenuItem
        '
        Me.Formulario2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubFormularioToolStripMenuItem})
        Me.Formulario2ToolStripMenuItem.Name = "Formulario2ToolStripMenuItem"
        Me.Formulario2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Formulario2ToolStripMenuItem.Text = "Formulario 2"
        '
        'SubFormularioToolStripMenuItem
        '
        Me.SubFormularioToolStripMenuItem.Name = "SubFormularioToolStripMenuItem"
        Me.SubFormularioToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SubFormularioToolStripMenuItem.Text = "Sub Formulario"
        '
        'Formulario3ToolStripMenuItem
        '
        Me.Formulario3ToolStripMenuItem.Name = "Formulario3ToolStripMenuItem"
        Me.Formulario3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Formulario3ToolStripMenuItem.Text = "Formulario 3"
        '
        'Opcion2ToolStripMenuItem
        '
        Me.Opcion2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ValidacionesToolStripMenuItem})
        Me.Opcion2ToolStripMenuItem.Name = "Opcion2ToolStripMenuItem"
        Me.Opcion2ToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.Opcion2ToolStripMenuItem.Text = "Opcion 2"
        '
        'ValidacionesToolStripMenuItem
        '
        Me.ValidacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorProviderToolStripMenuItem, Me.CondicionalesToolStripMenuItem})
        Me.ValidacionesToolStripMenuItem.Name = "ValidacionesToolStripMenuItem"
        Me.ValidacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ValidacionesToolStripMenuItem.Text = "Validaciones"
        '
        'ErrorProviderToolStripMenuItem
        '
        Me.ErrorProviderToolStripMenuItem.Name = "ErrorProviderToolStripMenuItem"
        Me.ErrorProviderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ErrorProviderToolStripMenuItem.Text = "Error Provider"
        '
        'CondicionalesToolStripMenuItem
        '
        Me.CondicionalesToolStripMenuItem.Name = "CondicionalesToolStripMenuItem"
        Me.CondicionalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CondicionalesToolStripMenuItem.Text = "Condicionales"
        '
        'EntradaTextoMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 411)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EntradaTextoMessage"
        Me.Text = "EntradaTextoMessage"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtIngresar As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbDiv As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMult As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbResta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSuma As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SubFormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Formulario3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Opcion2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProviderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondicionalesToolStripMenuItem As ToolStripMenuItem
End Class
