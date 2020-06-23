<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LibretaAhorro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPais = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnAperturarCuenta = New System.Windows.Forms.Button()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnRetirar = New System.Windows.Forms.Button()
        Me.BtnDepositar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LstRetiros = New System.Windows.Forms.ListBox()
        Me.LstDepositos = New System.Windows.Forms.ListBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtCiudad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtPais)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtEdad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BtnAperturarCuenta)
        Me.GroupBox1.Controls.Add(Me.TxtMonto)
        Me.GroupBox1.Controls.Add(Me.TxtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 377)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Informacion"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Location = New System.Drawing.Point(142, 40)
        Me.TxtIdentidad.MaxLength = 13
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(178, 20)
        Me.TxtIdentidad.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Identidad"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.Location = New System.Drawing.Point(141, 212)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.Size = New System.Drawing.Size(119, 20)
        Me.TxtCiudad.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ciudad"
        '
        'TxtPais
        '
        Me.TxtPais.Location = New System.Drawing.Point(141, 169)
        Me.TxtPais.Name = "TxtPais"
        Me.TxtPais.Size = New System.Drawing.Size(119, 20)
        Me.TxtPais.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pais"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(142, 125)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(119, 20)
        Me.TxtEdad.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 125)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Edad"
        '
        'BtnAperturarCuenta
        '
        Me.BtnAperturarCuenta.Location = New System.Drawing.Point(129, 304)
        Me.BtnAperturarCuenta.Name = "BtnAperturarCuenta"
        Me.BtnAperturarCuenta.Size = New System.Drawing.Size(102, 40)
        Me.BtnAperturarCuenta.TabIndex = 4
        Me.BtnAperturarCuenta.Text = "Aperturar Cuenta"
        Me.BtnAperturarCuenta.UseVisualStyleBackColor = True
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(142, 256)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(119, 20)
        Me.TxtMonto.TabIndex = 3
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(142, 82)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(178, 20)
        Me.TxtNombreUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Monto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Usuario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BtnRetirar)
        Me.GroupBox2.Controls.Add(Me.BtnDepositar)
        Me.GroupBox2.Location = New System.Drawing.Point(431, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Operaciones"
        '
        'BtnRetirar
        '
        Me.BtnRetirar.Location = New System.Drawing.Point(242, 48)
        Me.BtnRetirar.Name = "BtnRetirar"
        Me.BtnRetirar.Size = New System.Drawing.Size(102, 54)
        Me.BtnRetirar.TabIndex = 1
        Me.BtnRetirar.Text = "Retirar"
        Me.BtnRetirar.UseVisualStyleBackColor = True
        '
        'BtnDepositar
        '
        Me.BtnDepositar.Location = New System.Drawing.Point(72, 48)
        Me.BtnDepositar.Name = "BtnDepositar"
        Me.BtnDepositar.Size = New System.Drawing.Size(102, 54)
        Me.BtnDepositar.TabIndex = 0
        Me.BtnDepositar.Text = "Depositar"
        Me.BtnDepositar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtSaldoTotal)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.LstRetiros)
        Me.GroupBox3.Controls.Add(Me.LstDepositos)
        Me.GroupBox3.Location = New System.Drawing.Point(431, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 235)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial"
        '
        'TxtSaldoTotal
        '
        Me.TxtSaldoTotal.Location = New System.Drawing.Point(125, 195)
        Me.TxtSaldoTotal.Name = "TxtSaldoTotal"
        Me.TxtSaldoTotal.Size = New System.Drawing.Size(119, 20)
        Me.TxtSaldoTotal.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Saldo Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Retiros"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Depositos"
        '
        'LstRetiros
        '
        Me.LstRetiros.FormattingEnabled = True
        Me.LstRetiros.Location = New System.Drawing.Point(225, 60)
        Me.LstRetiros.Name = "LstRetiros"
        Me.LstRetiros.Size = New System.Drawing.Size(138, 108)
        Me.LstRetiros.TabIndex = 1
        '
        'LstDepositos
        '
        Me.LstDepositos.FormattingEnabled = True
        Me.LstDepositos.Location = New System.Drawing.Point(47, 60)
        Me.LstDepositos.Name = "LstDepositos"
        Me.LstDepositos.Size = New System.Drawing.Size(137, 108)
        Me.LstDepositos.TabIndex = 0
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(503, 458)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(88, 36)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(693, 458)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(88, 36)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LibretaAhorro
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
        Me.Name = "LibretaAhorro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LibretaAhorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnRetirar As Button
    Friend WithEvents BtnDepositar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LstRetiros As ListBox
    Friend WithEvents LstDepositos As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TxtSaldoTotal As TextBox
    Friend WithEvents BtnAperturarCuenta As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPais As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtCiudad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label9 As Label
End Class
