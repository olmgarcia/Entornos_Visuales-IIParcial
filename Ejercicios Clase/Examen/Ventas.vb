Imports System.ComponentModel

Public Class Ventas
    Dim conexion As conexionFactura = New conexionFactura()
    Dim dt As New DataTable

    Private Sub DTG_RegistroVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTG_RegistroVenta.CellContentClick
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        TxtCodigoCliente.Enabled = False
        llenarCampos(e)
    End Sub
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        MostrarDatos()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Public Sub MostrarDatos()
        Try
            dt = conexion.consultaVenta
            If dt.Rows.Count <> 0 Then
                DTG_RegistroVenta.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroVenta.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = DTG_RegistroVenta.Rows(e.RowIndex)
            TxtCodigoCliente.Text = dtg.Cells(0).Value.ToString()
            TxtNombre.Text = dtg.Cells(1).Value.ToString()
            TxtApellido.Text = dtg.Cells(2).Value.ToString()
            cmbCodigoVenta.Text = dtg.Cells(3).Value.ToString()
            cmbCodigoProducto.Text = dtg.Cells(4).Value.ToString()
            MskFecha.Text = dtg.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub Limpiar()
        TxtCodigoCliente.Enabled = True
        TxtCodigoCliente.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        conexion.conexion.Close()
        'cmbSexo.Items.Clear()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren And TxtCodigoCliente.Text <> String.Empty And TxtNombre.Text <> String.Empty And TxtApellido.Text <> String.Empty And cmbCodigoVenta.Text <> String.Empty And cmbCodigoProducto.Text <> String.Empty Then
                MessageBox.Show("Datos Registrados Correctamente", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If (conexion.VentaValidar(TxtCodigoCliente.Text) = False) Then
                MsgBox(conexion.insertaVenta(TxtCodigoCliente.Text, TxtNombre.Text, TxtApellido.Text, cmbCodigoVenta.Text, cmbCodigoProducto.Text))
                conexion.conexion.Close()
                Limpiar()
                MostrarDatos()
                TxtCodigoCliente.Focus()
            Else
                MsgBox("Estudiante ya existe", MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try

            Dim modificar As String = "nombre='" + TxtNombre.Text + "', Apellido='" + TxtApellido.Text + "', codigoVenta='" + cmbCodigoVenta.Text + "', codigoProducto='" + cmbCodigoProducto.Text + "'"
            If (conexion.modificarVenta("factura.Venta", modificar, " codigo=" + TxtCodigoCliente.Text)) Then
                MessageBox.Show("Actualizado")
                MostrarDatos()
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
            If (conexion.eliminarVenta("factura.Venta", "codigo=" + TxtCodigoCliente.Text)) Then
                MessageBox.Show("Eliminado")
                MostrarDatos()
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

    Private Sub mostrarBusquedaVenta()
        Try
            dt = conexion.buscarfacturaVenta("codigo like '%" + TxtCodigoCliente.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DTG_RegistroVenta.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroVenta.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        mostrarBusquedaVenta()
    End Sub


End Class