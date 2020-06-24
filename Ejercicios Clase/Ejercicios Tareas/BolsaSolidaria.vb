Imports System.ComponentModel

Public Class BolsaSolidaria
    Private Sub BolsaSolidaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbEstado.SelectedIndex = 0
        CmbEntrega.SelectedIndex = 0
        CmbBolsaSolidaria.SelectedIndex = 0
        llenarColumnas()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim Pos As Integer

        Try
            If Me.ValidateChildren And TxtNombres.Text <> String.Empty And TxtApellidos.Text <> String.Empty And TxtDireccion.Text <> String.Empty Then
                MessageBox.Show("Datos Registrados Correctamente", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If MaskIdentidad.MaskFull = False Then
                MessageBox.Show("El cuadro esta vacio o no esta lleno totalmente")
            ElseIf TxtNombres.Text = "" Then
                MessageBox.Show("Ingrese su Nombre", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtApellidos.Text = "" Then
                MessageBox.Show("Ingrese su Apellido", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtDireccion.Text = "" Then
                MessageBox.Show("Ingrese la Direccion", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtMunicipio.Text = "" Then
                MessageBox.Show("Ingrese el Municipio", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtDepartamento.Text = "" Then
                MessageBox.Show("Ingrese el Departamento", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf TxtIntegrantes.Text = "" Then
                MessageBox.Show("Ingrese la Cantidad de Personas", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CmbEstado.SelectedIndex = 0 Then
                MessageBox.Show("Seleccione el Estado", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf CmbEntrega.SelectedIndex = 0 Then
                MessageBox.Show("Seleccione la Entrega", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Pos = DGReportes.Rows.Count - 1
                DGReportes.Rows.Add()
                DGReportes.Rows(Pos).Cells(0).Value = MaskIdentidad.Text
                DGReportes.Rows(Pos).Cells(1).Value = TxtNombres.Text
                DGReportes.Rows(Pos).Cells(2).Value = TxtApellidos.Text
                DGReportes.Rows(Pos).Cells(3).Value = TxtDireccion.Text
                DGReportes.Rows(Pos).Cells(4).Value = TxtMunicipio.Text
                DGReportes.Rows(Pos).Cells(5).Value = TxtDepartamento.Text
                DGReportes.Rows(Pos).Cells(6).Value = TxtIntegrantes.Text
                DGReportes.Rows(Pos).Cells(7).Value = CmbEstado.SelectedItem
                DGReportes.Rows(Pos).Cells(8).Value = CmbEntrega.SelectedItem
                DGReportes.Rows(Pos).Cells(9).Value = CmbBolsaSolidaria.SelectedItem
            End If
        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message)
        End Try
    End Sub

    Private Sub llenarColumnas()
        DGReportes.Columns.Add("Id", "Identidad")
        DGReportes.Columns.Add("nom", "Nombres")
        DGReportes.Columns.Add("apellido", "Apellidos")
        DGReportes.Columns.Add("direccion", "Direccion")
        DGReportes.Columns.Add("municipio", "Municipio")
        DGReportes.Columns.Add("depart", "Departamento")
        DGReportes.Columns.Add("cant", "Personas")
        DGReportes.Columns.Add("situacion", "Situacion")
        DGReportes.Columns.Add("entrega", "Entregado")
        DGReportes.Columns.Add("tipoBolsa", "Tipo Bolsa")

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer

        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        MaskIdentidad.Clear()
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtDireccion.Clear()
        TxtMunicipio.Clear()
        TxtDepartamento.Clear()
        TxtIntegrantes.Clear()
        CmbEstado.Text = ""
        CmbEntrega.Text = ""
        CmbBolsaSolidaria.Text = ""

    End Sub

    Private Sub CmbEntrega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEntrega.SelectedIndexChanged
        If CmbEntrega.SelectedIndex = 1 Then
            CmbBolsaSolidaria.Enabled = False
        ElseIf CmbEntrega.SelectedIndex = 2 Then
            CmbBolsaSolidaria.Enabled = True
        End If
    End Sub

    Private Sub TxtNombres_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombres.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Nombre")
        End If
    End Sub

    Private Sub TxtApellidos_Validating(sender As Object, e As CancelEventArgs) Handles TxtApellidos.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Apellido")
        End If
    End Sub

    Private Sub TxtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles TxtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese una Direccion")
        End If
    End Sub

    Private Sub TxtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles TxtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Departamento")
        End If
    End Sub

    Private Sub TxtDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles TxtDepartamento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Departamento")
        End If
    End Sub

    Private Sub TxtIntegrantes_Validating(sender As Object, e As CancelEventArgs) Handles TxtIntegrantes.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Seleccione una Opcion")
        End If
    End Sub

    Private Sub TxtNombres_MouseHover(sender As Object, e As EventArgs) Handles TxtNombres.MouseHover
        ToolTip.SetToolTip(TxtNombres, "Ingrese un Nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtApellidos_MouseHover(sender As Object, e As EventArgs) Handles TxtApellidos.MouseHover
        ToolTip.SetToolTip(TxtApellidos, "Ingrese un Apellido")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtDireccion_MouseHover(sender As Object, e As EventArgs) Handles TxtDireccion.MouseHover
        ToolTip.SetToolTip(TxtDireccion, "Ingrese una Direccion")
        ToolTip.ToolTipTitle = "Direccion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles TxtMunicipio.MouseHover
        ToolTip.SetToolTip(TxtMunicipio, "Ingrese un Municipio")
        ToolTip.ToolTipTitle = "Municipio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtDepartamento_MouseHover(sender As Object, e As EventArgs) Handles TxtDepartamento.MouseHover
        ToolTip.SetToolTip(TxtDepartamento, "Ingrese un Departamento")
        ToolTip.ToolTipTitle = "Departamento"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub TxtIntegrantes_MouseHover(sender As Object, e As EventArgs) Handles TxtIntegrantes.MouseHover
        ToolTip.SetToolTip(TxtIntegrantes, "Ingrese un Cantidad")
        ToolTip.ToolTipTitle = "Cantidad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CmbEstado_MouseHover(sender As Object, e As EventArgs) Handles CmbEstado.MouseHover
        ToolTip.SetToolTip(CmbEstado, "Seleccione un Estado")
        ToolTip.ToolTipTitle = "Estado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub CmbEntrega_MouseHover(sender As Object, e As EventArgs) Handles CmbEntrega.MouseHover
        ToolTip.SetToolTip(CmbEntrega, "Seleccione una Entrega")
        ToolTip.ToolTipTitle = "Entrega"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class