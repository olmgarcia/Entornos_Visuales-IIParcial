<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuClases
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuClases))
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMinimizar = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.TimerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TimerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelBarraTitulo.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.Blue
        Me.PanelBarraTitulo.Controls.Add(Me.BtnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1300, 40)
        Me.PanelBarraTitulo.TabIndex = 1
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), System.Drawing.Image)
        Me.BtnRestaurar.Location = New System.Drawing.Point(1214, 6)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.BtnRestaurar.TabIndex = 5
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(1183, 15)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.TabIndex = 4
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(1214, 6)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMaximizar.TabIndex = 3
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(1245, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.TabIndex = 2
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Gray
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.BtnPagos)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.BtnEmpleados)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.BtnCompras)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.BtnClientes)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.BtnVentas)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.BtnProductos)
        Me.PanelMenu.Controls.Add(Me.BtnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 510)
        Me.PanelMenu.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Blue
        Me.Panel6.Location = New System.Drawing.Point(0, 365)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 13
        '
        'BtnPagos
        '
        Me.BtnPagos.FlatAppearance.BorderSize = 0
        Me.BtnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagos.ForeColor = System.Drawing.Color.White
        Me.BtnPagos.Image = CType(resources.GetObject("BtnPagos.Image"), System.Drawing.Image)
        Me.BtnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagos.Location = New System.Drawing.Point(0, 365)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Size = New System.Drawing.Size(220, 50)
        Me.BtnPagos.TabIndex = 12
        Me.BtnPagos.Text = "Pagos"
        Me.BtnPagos.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Blue
        Me.Panel5.Location = New System.Drawing.Point(0, 309)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 11
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.FlatAppearance.BorderSize = 0
        Me.BtnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.ForeColor = System.Drawing.Color.White
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.Location = New System.Drawing.Point(0, 309)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(220, 50)
        Me.BtnEmpleados.TabIndex = 10
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Blue
        Me.Panel4.Location = New System.Drawing.Point(0, 253)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 9
        '
        'BtnCompras
        '
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.ForeColor = System.Drawing.Color.White
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(0, 253)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(220, 50)
        Me.BtnCompras.TabIndex = 8
        Me.BtnCompras.Text = "Compras"
        Me.BtnCompras.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Blue
        Me.Panel3.Location = New System.Drawing.Point(0, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 7
        '
        'BtnClientes
        '
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.Color.White
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(0, 197)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(220, 50)
        Me.BtnClientes.TabIndex = 6
        Me.BtnClientes.Text = "Clientes"
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Blue
        Me.Panel2.Location = New System.Drawing.Point(0, 141)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 5
        '
        'BtnVentas
        '
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.Color.White
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 141)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(220, 50)
        Me.BtnVentas.TabIndex = 4
        Me.BtnVentas.Text = "Ventas"
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Location = New System.Drawing.Point(0, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 3
        '
        'BtnProductos
        '
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.Color.White
        Me.BtnProductos.Image = CType(resources.GetObject("BtnProductos.Image"), System.Drawing.Image)
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 85)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(220, 50)
        Me.BtnProductos.TabIndex = 1
        Me.BtnProductos.Text = "Productos"
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(185, 6)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(32, 32)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.TabStop = False
        '
        'TimerOcultarMenu
        '
        Me.TimerOcultarMenu.Interval = 15
        '
        'MenuClases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 550)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuClases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuClases"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMinimizar As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnPagos As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnCompras As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnVentas As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnProductos As Button
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents TimerMostrarMenu As Timer
    Friend WithEvents TimerOcultarMenu As Timer
End Class
