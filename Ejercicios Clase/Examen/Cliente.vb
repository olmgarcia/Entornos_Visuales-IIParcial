Imports System.ComponentModel

Public Class Cliente
    Dim conexion As conexionFactura = New conexionFactura()
    Dim dt As New DataTable

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        MostrarDatosCliente()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub DTG_RegistroCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTG_RegistroCliente.CellContentClick
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        TxtIdCliente.Enabled = False
        llenarCamposCliente(e)
    End Sub

    Public Sub MostrarDatosCliente()
        Try
            dt = conexion.consultaVenta
            If dt.Rows.Count <> 0 Then
                DTG_RegistroCliente.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroCliente.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarCamposCliente(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = DTG_RegistroCliente.Rows(e.RowIndex)
            TxtIdCliente.Text = dtg.Cells(0).Value.ToString()
            TxtNombre.Text = dtg.Cells(1).Value.ToString()
            TxtApellido.Text = dtg.Cells(2).Value.ToString()
            TxtDireccion.Text = dtg.Cells(3).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren And TxtIdCliente.Text <> String.Empty And TxtNombre.Text <> String.Empty And TxtApellido.Text <> String.Empty And TxtDireccion.Text <> String.Empty Then
                MessageBox.Show("Datos Registrados Correctamente", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If (conexion.ClienteValidar(TxtIdCliente.Text) = False) Then
                MsgBox(conexion.insertaCliente(TxtIdCliente.Text, TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text))
                conexion.conexion.Close()
                Limpiar()
                MostrarDatosCliente()
                TxtIdCliente.Focus()
            Else
                MsgBox("Estudiante ya existe", MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message)
        End Try
    End Sub

    Public Sub Limpiar()
        TxtIdCliente.Enabled = True
        TxtIdCliente.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        conexion.conexion.Close()
        'cmbSexo.Items.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer

        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try

            Dim modificar As String = "nombre='" + TxtNombre.Text + "', Apellido='" + TxtApellido.Text + "', direccion='"
            If (conexion.modificarVenta("factura.cliente", modificar, " codigo=" + TxtIdCliente.Text)) Then
                MessageBox.Show("Actualizado")
                MostrarDatosCliente()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If (conexion.eliminarVenta("factura.cliente", "codigo=" + TxtIdCliente.Text)) Then
                MessageBox.Show("Eliminado")
                MostrarDatosCliente()
                Limpiar()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al Eliminar")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrarBusquedaCliente()
        Try
            dt = conexion.buscarfacturaVenta("codigo like '%" + TxtIdCliente.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DTG_RegistroCliente.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroCliente.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        mostrarBusquedaCliente()
    End Sub

    Private Sub TxtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles TxtIdCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un ID")
        End If
    End Sub

    Private Sub TxtNombre_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Nombre")
        End If
    End Sub

    Private Sub TxtApellido_Validating(sender As Object, e As CancelEventArgs) Handles TxtApellido.Validating
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

End Class