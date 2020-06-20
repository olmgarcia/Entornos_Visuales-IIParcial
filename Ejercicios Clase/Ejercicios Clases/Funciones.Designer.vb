<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.TxtCantCompu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.TxtCantVender = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnRegistrar)
        Me.GroupBox1.Controls.Add(Me.TxtCantCompu)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(141, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Location = New System.Drawing.Point(139, 80)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(122, 37)
        Me.BtnRegistrar.TabIndex = 2
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'TxtCantCompu
        '
        Me.TxtCantCompu.Location = New System.Drawing.Point(172, 39)
        Me.TxtCantCompu.Name = "TxtCantCompu"
        Me.TxtCantCompu.Size = New System.Drawing.Size(134, 20)
        Me.TxtCantCompu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cantidad Computadoras"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnBuscar)
        Me.GroupBox2.Controls.Add(Me.TxtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TxtPrecio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtModelo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMarca)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(141, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 187)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(262, 26)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(101, 37)
        Me.BtnBuscar.TabIndex = 9
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(93, 140)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(118, 20)
        Me.TxtCantidad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Cantidad"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(93, 98)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(118, 20)
        Me.TxtPrecio.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Precio"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(93, 59)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(118, 20)
        Me.TxtModelo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modelo"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(93, 19)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(118, 20)
        Me.TxtMarca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnVender)
        Me.GroupBox3.Controls.Add(Me.TxtCantVender)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(141, 386)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(384, 123)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'BtnVender
        '
        Me.BtnVender.Location = New System.Drawing.Point(144, 66)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(101, 37)
        Me.BtnVender.TabIndex = 10
        Me.BtnVender.Text = "Vender"
        Me.BtnVender.UseVisualStyleBackColor = True
        '
        'TxtCantVender
        '
        Me.TxtCantVender.Location = New System.Drawing.Point(144, 30)
        Me.TxtCantVender.Name = "TxtCantVender"
        Me.TxtCantVender.Size = New System.Drawing.Size(118, 20)
        Me.TxtCantVender.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cantidad a Vender"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(542, 462)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(101, 37)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(542, 399)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(101, 37)
        Me.BtnLimpiar.TabIndex = 12
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'Funciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 521)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Funciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents TxtCantCompu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantVender As TextBox
    Friend WithEvents BtnVender As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
End Class
