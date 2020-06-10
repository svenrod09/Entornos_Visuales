<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresoPruebas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ingresoPruebas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkRecuperado = New System.Windows.Forms.CheckBox()
        Me.chkFallecido = New System.Windows.Forms.CheckBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkNegativo = New System.Windows.Forms.CheckBox()
        Me.chkPositivo = New System.Windows.Forms.CheckBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.cmbDepartamentos = New System.Windows.Forms.ComboBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFallecidos = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtActivos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRecuperados = New System.Windows.Forms.TextBox()
        Me.txtCasosPositivos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbDepartamento1 = New System.Windows.Forms.ComboBox()
        Me.Cerrar = New System.Windows.Forms.PictureBox()
        Me.Limpiar = New System.Windows.Forms.PictureBox()
        Me.Guardar = New System.Windows.Forms.PictureBox()
        Me.Buscar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Limpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guardar)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.chkRecuperado)
        Me.GroupBox1.Controls.Add(Me.chkFallecido)
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chkNegativo)
        Me.GroupBox1.Controls.Add(Me.chkPositivo)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.cmbDepartamentos)
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 431)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 299)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(175, 71)
        Me.txtDescripcion.TabIndex = 17
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 13)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Descripción del Paciente "
        '
        'chkRecuperado
        '
        Me.chkRecuperado.AutoSize = True
        Me.chkRecuperado.Enabled = False
        Me.chkRecuperado.Location = New System.Drawing.Point(154, 259)
        Me.chkRecuperado.Name = "chkRecuperado"
        Me.chkRecuperado.Size = New System.Drawing.Size(85, 17)
        Me.chkRecuperado.TabIndex = 15
        Me.chkRecuperado.Text = "Recuperado"
        Me.chkRecuperado.UseVisualStyleBackColor = True
        '
        'chkFallecido
        '
        Me.chkFallecido.AutoSize = True
        Me.chkFallecido.Enabled = False
        Me.chkFallecido.Location = New System.Drawing.Point(237, 230)
        Me.chkFallecido.Name = "chkFallecido"
        Me.chkFallecido.Size = New System.Drawing.Size(68, 17)
        Me.chkFallecido.TabIndex = 13
        Me.chkFallecido.Text = "Fallecido"
        Me.chkFallecido.UseVisualStyleBackColor = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Enabled = False
        Me.chkActivo.Location = New System.Drawing.Point(154, 229)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 12
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Estado del Paciente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Resultado Prueba"
        '
        'chkNegativo
        '
        Me.chkNegativo.AutoSize = True
        Me.chkNegativo.Location = New System.Drawing.Point(237, 196)
        Me.chkNegativo.Name = "chkNegativo"
        Me.chkNegativo.Size = New System.Drawing.Size(69, 17)
        Me.chkNegativo.TabIndex = 9
        Me.chkNegativo.Text = "Negativo"
        Me.chkNegativo.UseVisualStyleBackColor = True
        '
        'chkPositivo
        '
        Me.chkPositivo.AutoSize = True
        Me.chkPositivo.Location = New System.Drawing.Point(154, 196)
        Me.chkPositivo.Name = "chkPositivo"
        Me.chkPositivo.Size = New System.Drawing.Size(63, 17)
        Me.chkPositivo.TabIndex = 8
        Me.chkPositivo.Text = "Positivo"
        Me.chkPositivo.UseVisualStyleBackColor = True
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(131, 151)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(184, 20)
        Me.txtMunicipio.TabIndex = 7
        '
        'cmbDepartamentos
        '
        Me.cmbDepartamentos.FormattingEnabled = True
        Me.cmbDepartamentos.Items.AddRange(New Object() {"Islas de la Bahía", "Cortés", "Atlántida", "Colón", "Gracias a Dios", "Copán", "Santa Bárbara", "Yoro", "Olancho", "Ocotepeque", "Lempira", "Intibucá", "Comayagua", "Francisco Morazán", "El Paraíso", "La Paz", "Valle", "Choluteca"})
        Me.cmbDepartamentos.Location = New System.Drawing.Point(131, 110)
        Me.cmbDepartamentos.Name = "cmbDepartamentos"
        Me.cmbDepartamentos.Size = New System.Drawing.Size(161, 21)
        Me.cmbDepartamentos.TabIndex = 6
        Me.cmbDepartamentos.Text = "Seleccione un Departamento"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(131, 72)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(58, 20)
        Me.txtEdad.TabIndex = 5
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(131, 33)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(184, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Buscar)
        Me.GroupBox2.Controls.Add(Me.txtFallecidos)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtActivos)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtRecuperados)
        Me.GroupBox2.Controls.Add(Me.txtCasosPositivos)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbDepartamento1)
        Me.GroupBox2.Location = New System.Drawing.Point(380, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 431)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte por Departamento"
        '
        'txtFallecidos
        '
        Me.txtFallecidos.Location = New System.Drawing.Point(179, 342)
        Me.txtFallecidos.Name = "txtFallecidos"
        Me.txtFallecidos.ReadOnly = True
        Me.txtFallecidos.Size = New System.Drawing.Size(100, 20)
        Me.txtFallecidos.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(62, 345)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Fallecidos"
        '
        'txtActivos
        '
        Me.txtActivos.Location = New System.Drawing.Point(179, 295)
        Me.txtActivos.Name = "txtActivos"
        Me.txtActivos.ReadOnly = True
        Me.txtActivos.Size = New System.Drawing.Size(100, 20)
        Me.txtActivos.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(62, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Activos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(62, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Recuperados"
        '
        'txtRecuperados
        '
        Me.txtRecuperados.Location = New System.Drawing.Point(179, 247)
        Me.txtRecuperados.Name = "txtRecuperados"
        Me.txtRecuperados.ReadOnly = True
        Me.txtRecuperados.Size = New System.Drawing.Size(100, 20)
        Me.txtRecuperados.TabIndex = 19
        '
        'txtCasosPositivos
        '
        Me.txtCasosPositivos.Location = New System.Drawing.Point(179, 197)
        Me.txtCasosPositivos.Name = "txtCasosPositivos"
        Me.txtCasosPositivos.ReadOnly = True
        Me.txtCasosPositivos.Size = New System.Drawing.Size(100, 20)
        Me.txtCasosPositivos.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Casos Positivos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Departamento"
        '
        'cmbDepartamento1
        '
        Me.cmbDepartamento1.FormattingEnabled = True
        Me.cmbDepartamento1.Items.AddRange(New Object() {"Islas de la Bahía", "Cortés", "Atlántida", "Colón", "Gracias a Dios", "Copán", "Santa Bárbara", "Yoro", "Olancho", "Ocotepeque", "Lempira", "Intibucá", "Comayagua", "Francisco Morazán", "El Paraíso", "La Paz", "Valle", "Choluteca"})
        Me.cmbDepartamento1.Location = New System.Drawing.Point(140, 45)
        Me.cmbDepartamento1.Name = "cmbDepartamento1"
        Me.cmbDepartamento1.Size = New System.Drawing.Size(161, 21)
        Me.cmbDepartamento1.TabIndex = 16
        Me.cmbDepartamento1.Text = "Seleccione un Departamento"
        '
        'Cerrar
        '
        Me.Cerrar.BackgroundImage = CType(resources.GetObject("Cerrar.BackgroundImage"), System.Drawing.Image)
        Me.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar.Location = New System.Drawing.Point(599, 449)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(122, 41)
        Me.Cerrar.TabIndex = 27
        Me.Cerrar.TabStop = False
        '
        'Limpiar
        '
        Me.Limpiar.BackgroundImage = CType(resources.GetObject("Limpiar.BackgroundImage"), System.Drawing.Image)
        Me.Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Limpiar.Location = New System.Drawing.Point(6, 444)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(64, 46)
        Me.Limpiar.TabIndex = 28
        Me.Limpiar.TabStop = False
        '
        'Guardar
        '
        Me.Guardar.BackgroundImage = CType(resources.GetObject("Guardar.BackgroundImage"), System.Drawing.Image)
        Me.Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guardar.Location = New System.Drawing.Point(140, 375)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(60, 50)
        Me.Guardar.TabIndex = 18
        Me.Guardar.TabStop = False
        '
        'Buscar
        '
        Me.Buscar.BackgroundImage = CType(resources.GetObject("Buscar.BackgroundImage"), System.Drawing.Image)
        Me.Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Buscar.Location = New System.Drawing.Point(150, 93)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(64, 61)
        Me.Buscar.TabIndex = 27
        Me.Buscar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(19, 337)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(19, 243)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(19, 292)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(19, 195)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(33, 28)
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        '
        'ingresoPruebas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(725, 493)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Cerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ingresoPruebas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ingresoPruebas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Limpiar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkFallecido As CheckBox
    Friend WithEvents chkActivo As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkNegativo As CheckBox
    Friend WithEvents chkPositivo As CheckBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents cmbDepartamentos As ComboBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbDepartamento1 As ComboBox
    Friend WithEvents chkRecuperado As CheckBox
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents toolTip As ToolTip
    Friend WithEvents txtFallecidos As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtActivos As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRecuperados As TextBox
    Friend WithEvents txtCasosPositivos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Cerrar As PictureBox
    Friend WithEvents Limpiar As PictureBox
    Friend WithEvents Guardar As PictureBox
    Friend WithEvents Buscar As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
