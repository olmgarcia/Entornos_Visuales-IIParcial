Public Class MenuPrincipal
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        BtnRestaurar.Visible = False
        BtnMaximizar.Visible = True
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub AbrirFormularioEnPanel(ByVal Formhijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then Me.PanelContenedor.Controls.RemoveAt(0)
        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub
    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnVentas_Click(sender As Object, e As EventArgs) Handles BtnVentas.Click
        AbrirFormularioEnPanel(Ventas)
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        AbrirFormularioEnPanel(Cliente)
    End Sub

    Private Sub PanelContenedor_Paint_1(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub
End Class