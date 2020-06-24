<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BolsaSolidaria
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MaskIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.TxtDepartamento = New System.Windows.Forms.TextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtMunicipio = New System.Windows.Forms.TextBox()
        Me.TxtIntegrantes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbEntrega = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmbBolsaSolidaria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGReportes = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskIdentidad)
        Me.GroupBox1.Controls.Add(Me.TxtDepartamento)
        Me.GroupBox1.Controls.Add(Me.TxtApellidos)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtMunicipio)
        Me.GroupBox1.Controls.Add(Me.TxtIntegrantes)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNombres)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'MaskIdentidad
        '
        Me.MaskIdentidad.Location = New System.Drawing.Point(199, 22)
        Me.MaskIdentidad.Mask = "9999-9999-99999"
        Me.MaskIdentidad.Name = "MaskIdentidad"
        Me.MaskIdentidad.Size = New System.Drawing.Size(160, 25)
        Me.MaskIdentidad.TabIndex = 14
        Me.MaskIdentidad.ValidatingType = GetType(Integer)
        '
        'TxtDepartamento
        '
        Me.TxtDepartamento.Location = New System.Drawing.Point(202, 232)
        Me.TxtDepartamento.Name = "TxtDepartamento"
        Me.TxtDepartamento.Size = New System.Drawing.Size(172, 25)
        Me.TxtDepartamento.TabIndex = 13
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(202, 106)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(172, 25)
        Me.TxtApellidos.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 17)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Departamento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Apellidos"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(202, 149)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(212, 25)
        Me.TxtDireccion.TabIndex = 7
        '
        'TxtMunicipio
        '
        Me.TxtMunicipio.Location = New System.Drawing.Point(202, 191)
        Me.TxtMunicipio.Name = "TxtMunicipio"
        Me.TxtMunicipio.Size = New System.Drawing.Size(172, 25)
        Me.TxtMunicipio.TabIndex = 11
        '
        'TxtIntegrantes
        '
        Me.TxtIntegrantes.Location = New System.Drawing.Point(202, 272)
        Me.TxtIntegrantes.Name = "TxtIntegrantes"
        Me.TxtIntegrantes.Size = New System.Drawing.Size(50, 25)
        Me.TxtIntegrantes.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Municipio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Integrantes de la Familia"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion"
        '
        'TxtNombres
        '
        Me.TxtNombres.Location = New System.Drawing.Point(202, 65)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(172, 25)
        Me.TxtNombres.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identidad"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbEntrega)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CmbEstado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(30, 350)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 113)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado"
        '
        'CmbEntrega
        '
        Me.CmbEntrega.FormattingEnabled = True
        Me.CmbEntrega.Items.AddRange(New Object() {"Indique una opcion", "Si", "No"})
        Me.CmbEntrega.Location = New System.Drawing.Point(210, 74)
        Me.CmbEntrega.Name = "CmbEntrega"
        Me.CmbEntrega.Size = New System.Drawing.Size(86, 25)
        Me.CmbEntrega.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Entrega de Bolsa Solidaria"
        '
        'CmbEstado
        '
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Items.AddRange(New Object() {"Seleccione una Opcion", "Estable", "Pobresa", "Pobresa Extrema"})
        Me.CmbEstado.Location = New System.Drawing.Point(210, 31)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(167, 25)
        Me.CmbEstado.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Situacion Economica"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmbBolsaSolidaria)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(30, 481)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 86)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Bolsa"
        '
        'CmbBolsaSolidaria
        '
        Me.CmbBolsaSolidaria.Enabled = False
        Me.CmbBolsaSolidaria.FormattingEnabled = True
        Me.CmbBolsaSolidaria.Items.AddRange(New Object() {"Indique una opcion", "Basica", "Regular", "Moderado"})
        Me.CmbBolsaSolidaria.Location = New System.Drawing.Point(210, 33)
        Me.CmbBolsaSolidaria.Name = "CmbBolsaSolidaria"
        Me.CmbBolsaSolidaria.Size = New System.Drawing.Size(167, 25)
        Me.CmbBolsaSolidaria.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 17)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Tipo Bolsa Solidaria"
        '
        'DGReportes
        '
        Me.DGReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReportes.Location = New System.Drawing.Point(514, 49)
        Me.DGReportes.Name = "DGReportes"
        Me.DGReportes.Size = New System.Drawing.Size(773, 363)
        Me.DGReportes.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 22)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Registro"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(525, 481)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(105, 48)
        Me.BtnAgregar.TabIndex = 5
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Location = New System.Drawing.Point(699, 481)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(105, 48)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(865, 481)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(105, 48)
        Me.BtnSalir.TabIndex = 7
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'BolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1299, 579)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGReportes)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BolsaSolidaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtIntegrantes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CmbEntrega As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DGReportes As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents CmbBolsaSolidaria As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtDepartamento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtMunicipio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents MaskIdentidad As MaskedTextBox
End Class
