<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validaciones
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Descripción"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(113, 53)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(155, 20)
        Me.txtProducto.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(113, 98)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(78, 20)
        Me.txtPrecio.TabIndex = 6
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(113, 141)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(78, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 188)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(155, 68)
        Me.txtDescripcion.TabIndex = 8
        '
        'btnValidar
        '
        Me.btnValidar.Location = New System.Drawing.Point(12, 267)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(75, 23)
        Me.btnValidar.TabIndex = 9
        Me.btnValidar.Text = "Validar"
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 302)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Validaciones"
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents toolTip As ToolTip
End Class
