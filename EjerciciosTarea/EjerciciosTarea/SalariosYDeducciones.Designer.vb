<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalariosYDeducciones
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDeducido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSueldoNeto = New System.Windows.Forms.TextBox()
        Me.chk25 = New System.Windows.Forms.CheckBox()
        Me.chk20 = New System.Windows.Forms.CheckBox()
        Me.chk15 = New System.Windows.Forms.CheckBox()
        Me.chkExento = New System.Windows.Forms.CheckBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegresarAlMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSueldo)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles del Empleado"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(123, 120)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 4
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sueldo"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(87, 76)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 32)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(194, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDeducido)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtSueldoNeto)
        Me.GroupBox2.Controls.Add(Me.chk25)
        Me.GroupBox2.Controls.Add(Me.chk20)
        Me.GroupBox2.Controls.Add(Me.chk15)
        Me.GroupBox2.Controls.Add(Me.chkExento)
        Me.GroupBox2.Location = New System.Drawing.Point(345, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 161)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deducciones"
        '
        'txtDeducido
        '
        Me.txtDeducido.Location = New System.Drawing.Point(148, 55)
        Me.txtDeducido.Name = "txtDeducido"
        Me.txtDeducido.ReadOnly = True
        Me.txtDeducido.Size = New System.Drawing.Size(100, 20)
        Me.txtDeducido.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(153, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Deducido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sueldo Neto Recibido"
        '
        'txtSueldoNeto
        '
        Me.txtSueldoNeto.Location = New System.Drawing.Point(148, 126)
        Me.txtSueldoNeto.Name = "txtSueldoNeto"
        Me.txtSueldoNeto.ReadOnly = True
        Me.txtSueldoNeto.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldoNeto.TabIndex = 4
        '
        'chk25
        '
        Me.chk25.AutoSize = True
        Me.chk25.Location = New System.Drawing.Point(24, 130)
        Me.chk25.Name = "chk25"
        Me.chk25.Size = New System.Drawing.Size(46, 17)
        Me.chk25.TabIndex = 3
        Me.chk25.Text = "25%"
        Me.chk25.UseVisualStyleBackColor = True
        '
        'chk20
        '
        Me.chk20.AutoSize = True
        Me.chk20.Location = New System.Drawing.Point(24, 98)
        Me.chk20.Name = "chk20"
        Me.chk20.Size = New System.Drawing.Size(46, 17)
        Me.chk20.TabIndex = 2
        Me.chk20.Text = "20%"
        Me.chk20.UseVisualStyleBackColor = True
        '
        'chk15
        '
        Me.chk15.AutoSize = True
        Me.chk15.Location = New System.Drawing.Point(24, 66)
        Me.chk15.Name = "chk15"
        Me.chk15.Size = New System.Drawing.Size(46, 17)
        Me.chk15.TabIndex = 1
        Me.chk15.Text = "15%"
        Me.chk15.UseVisualStyleBackColor = True
        '
        'chkExento
        '
        Me.chkExento.AutoSize = True
        Me.chkExento.Location = New System.Drawing.Point(24, 34)
        Me.chkExento.Name = "chkExento"
        Me.chkExento.Size = New System.Drawing.Size(59, 17)
        Me.chkExento.TabIndex = 0
        Me.chkExento.Text = "Exento"
        Me.chkExento.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(545, 227)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 227)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 3
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
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 4
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
        'SalariosYDeducciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 270)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SalariosYDeducciones"
        Me.Text = "SalariosYDeducciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSueldoNeto As TextBox
    Friend WithEvents chk25 As CheckBox
    Friend WithEvents chk20 As CheckBox
    Friend WithEvents chk15 As CheckBox
    Friend WithEvents chkExento As CheckBox
    Friend WithEvents txtDeducido As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegresarAlMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
