<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArreglosVectores
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
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.CmbGenerarPrecios = New System.Windows.Forms.ComboBox()
        Me.CmbGenerarCompu = New System.Windows.Forms.ComboBox()
        Me.BtnGenerarPrecios = New System.Windows.Forms.Button()
        Me.BtnGenerarCompu = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbSolicitar = New System.Windows.Forms.ComboBox()
        Me.BtnSolicitar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCantCompu = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.CmbGenerarPrecios)
        Me.GroupBox1.Controls.Add(Me.CmbGenerarCompu)
        Me.GroupBox1.Controls.Add(Me.BtnGenerarPrecios)
        Me.GroupBox1.Controls.Add(Me.BtnGenerarCompu)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 236)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(143, 166)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(96, 43)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'CmbGenerarPrecios
        '
        Me.CmbGenerarPrecios.FormattingEnabled = True
        Me.CmbGenerarPrecios.Location = New System.Drawing.Point(208, 126)
        Me.CmbGenerarPrecios.Name = "CmbGenerarPrecios"
        Me.CmbGenerarPrecios.Size = New System.Drawing.Size(140, 21)
        Me.CmbGenerarPrecios.TabIndex = 3
        '
        'CmbGenerarCompu
        '
        Me.CmbGenerarCompu.FormattingEnabled = True
        Me.CmbGenerarCompu.Location = New System.Drawing.Point(23, 126)
        Me.CmbGenerarCompu.Name = "CmbGenerarCompu"
        Me.CmbGenerarCompu.Size = New System.Drawing.Size(140, 21)
        Me.CmbGenerarCompu.TabIndex = 2
        '
        'BtnGenerarPrecios
        '
        Me.BtnGenerarPrecios.Location = New System.Drawing.Point(222, 31)
        Me.BtnGenerarPrecios.Name = "BtnGenerarPrecios"
        Me.BtnGenerarPrecios.Size = New System.Drawing.Size(107, 61)
        Me.BtnGenerarPrecios.TabIndex = 1
        Me.BtnGenerarPrecios.Text = "Generar Precios"
        Me.BtnGenerarPrecios.UseVisualStyleBackColor = True
        '
        'BtnGenerarCompu
        '
        Me.BtnGenerarCompu.Location = New System.Drawing.Point(34, 31)
        Me.BtnGenerarCompu.Name = "BtnGenerarCompu"
        Me.BtnGenerarCompu.Size = New System.Drawing.Size(107, 61)
        Me.BtnGenerarCompu.TabIndex = 0
        Me.BtnGenerarCompu.Text = "Generar Computadoras"
        Me.BtnGenerarCompu.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCantCompu)
        Me.GroupBox2.Controls.Add(Me.CmbSolicitar)
        Me.GroupBox2.Controls.Add(Me.BtnSolicitar)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 299)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(383, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'CmbSolicitar
        '
        Me.CmbSolicitar.FormattingEnabled = True
        Me.CmbSolicitar.Location = New System.Drawing.Point(119, 149)
        Me.CmbSolicitar.Name = "CmbSolicitar"
        Me.CmbSolicitar.Size = New System.Drawing.Size(140, 21)
        Me.CmbSolicitar.TabIndex = 7
        '
        'BtnSolicitar
        '
        Me.BtnSolicitar.Location = New System.Drawing.Point(138, 85)
        Me.BtnSolicitar.Name = "BtnSolicitar"
        Me.BtnSolicitar.Size = New System.Drawing.Size(96, 43)
        Me.BtnSolicitar.TabIndex = 6
        Me.BtnSolicitar.Text = "Solicitar"
        Me.BtnSolicitar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cantidad de Computadoras"
        '
        'TxtCantCompu
        '
        Me.TxtCantCompu.Location = New System.Drawing.Point(194, 42)
        Me.TxtCantCompu.Name = "TxtCantCompu"
        Me.TxtCantCompu.Size = New System.Drawing.Size(158, 20)
        Me.TxtCantCompu.TabIndex = 8
        '
        'ArreglosVectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 560)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArreglosVectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ArreglosVectores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbGenerarPrecios As ComboBox
    Friend WithEvents CmbGenerarCompu As ComboBox
    Friend WithEvents BtnGenerarPrecios As Button
    Friend WithEvents BtnGenerarCompu As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSolicitar As Button
    Friend WithEvents CmbSolicitar As ComboBox
    Friend WithEvents TxtCantCompu As TextBox
End Class
