<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Estudiante_CRUD
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
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.TxtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTG_Registros = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.cmbCodigoClase = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DTG_Registros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCodigoClase)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CmbSexo)
        Me.GroupBox1.Controls.Add(Me.TxtEdad)
        Me.GroupBox1.Controls.Add(Me.TxtSegundoApellido)
        Me.GroupBox1.Controls.Add(Me.TxtPrimerApellido)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Estudiante"
        '
        'CmbSexo
        '
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Items.AddRange(New Object() {"F", "M"})
        Me.CmbSexo.Location = New System.Drawing.Point(426, 142)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(125, 25)
        Me.CmbSexo.TabIndex = 11
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(426, 96)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(125, 25)
        Me.TxtEdad.TabIndex = 10
        '
        'TxtSegundoApellido
        '
        Me.TxtSegundoApellido.Location = New System.Drawing.Point(426, 40)
        Me.TxtSegundoApellido.Name = "TxtSegundoApellido"
        Me.TxtSegundoApellido.Size = New System.Drawing.Size(125, 25)
        Me.TxtSegundoApellido.TabIndex = 9
        '
        'TxtPrimerApellido
        '
        Me.TxtPrimerApellido.Location = New System.Drawing.Point(135, 167)
        Me.TxtPrimerApellido.Name = "TxtPrimerApellido"
        Me.TxtPrimerApellido.Size = New System.Drawing.Size(125, 25)
        Me.TxtPrimerApellido.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(135, 102)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(125, 25)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(135, 42)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(125, 25)
        Me.TxtCodigo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(307, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Segundo Apelllido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Primer Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTG_Registros)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(847, 260)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro de Estudiantes"
        '
        'DTG_Registros
        '
        Me.DTG_Registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTG_Registros.Location = New System.Drawing.Point(13, 26)
        Me.DTG_Registros.Name = "DTG_Registros"
        Me.DTG_Registros.Size = New System.Drawing.Size(813, 224)
        Me.DTG_Registros.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnBuscar)
        Me.GroupBox3.Controls.Add(Me.BtnSalir)
        Me.GroupBox3.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox3.Controls.Add(Me.BtnEliminar)
        Me.GroupBox3.Controls.Add(Me.BtnModificar)
        Me.GroupBox3.Controls.Add(Me.BtnGuardar)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(647, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 294)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operaciones"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(33, 154)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(158, 37)
        Me.BtnBuscar.TabIndex = 5
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(33, 247)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(158, 37)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(33, 199)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(158, 37)
        Me.BtnLimpiar.TabIndex = 3
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(33, 111)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(158, 37)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(33, 68)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(158, 37)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(33, 24)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(158, 37)
        Me.BtnGuardar.TabIndex = 0
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'cmbCodigoClase
        '
        Me.cmbCodigoClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodigoClase.FormattingEnabled = True
        Me.cmbCodigoClase.Items.AddRange(New Object() {"IF-325", "IF-326"})
        Me.cmbCodigoClase.Location = New System.Drawing.Point(426, 190)
        Me.cmbCodigoClase.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCodigoClase.Name = "cmbCodigoClase"
        Me.cmbCodigoClase.Size = New System.Drawing.Size(125, 25)
        Me.cmbCodigoClase.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(307, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Codigo Clase"
        '
        'Estudiante_CRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 581)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Estudiante_CRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudiante_CRUD"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DTG_Registros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtSegundoApellido As TextBox
    Friend WithEvents TxtPrimerApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DTG_Registros As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents cmbCodigoClase As ComboBox
    Friend WithEvents Label7 As Label
End Class
