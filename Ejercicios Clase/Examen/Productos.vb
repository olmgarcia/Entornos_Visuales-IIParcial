Imports System.ComponentModel

Public Class Productos

    Dim conexion As conexionFactura = New conexionFactura()
    Dim dt As New DataTable

    Private Sub DTG_RegistroVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTG_RegistroProducto.CellContentClick
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        TxtIdProducto.Enabled = False
        llenarCamposProducto(e)
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        MostrarDatosProducto()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Public Sub MostrarDatosProducto()
        Try
            dt = conexion.consultaVenta
            If dt.Rows.Count <> 0 Then
                DTG_RegistroProducto.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroProducto.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarCamposProducto(e As DataGridViewCellEventArgs)
        Try
            Dim dtg As DataGridViewRow = DTG_RegistroProducto.Rows(e.RowIndex)
            TxtIdProducto.Text = dtg.Cells(0).Value.ToString()
            TxtNombreProducto.Text = dtg.Cells(1).Value.ToString()
            TxtDescripcionProducto.Text = dtg.Cells(2).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Try
            If Me.ValidateChildren And TxtIdProducto.Text <> String.Empty And TxtNombreProducto.Text <> String.Empty And TxtDescripcionProducto.Text <> String.Empty Then
                MessageBox.Show("Datos Registrados Correctamente", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                MessageBox.Show("Ingrese correctamente algunos Datos remarcados", "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If (conexion.ProductoValidar(TxtIdProducto.Text) = False) Then
                MsgBox(conexion.insertaProducto(TxtIdProducto.Text, TxtNombreProducto.Text, TxtDescripcionProducto.Text))
                conexion.conexion.Close()
                Limpiar()
                MostrarDatosProducto()
                TxtIdProducto.Focus()
            Else
                MsgBox("Estudiante ya existe", MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error en la operación: " & ex.Message)
        End Try
    End Sub

    Public Sub Limpiar()
        TxtIdProducto.Enabled = True
        TxtIdProducto.Clear()
        TxtNombreProducto.Clear()
        TxtDescripcionProducto.Clear()
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
    Private Sub mostrarBusquedaProducto()
        Try
            dt = conexion.buscarfacturaVenta("codigo like '%" + TxtIdProducto.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DTG_RegistroProducto.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_RegistroProducto.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        mostrarBusquedaProducto()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try

            Dim modificar As String = "nombreProducto='" + TxtNombreProducto.Text + "', descripcionProducto='" + TxtDescripcionProducto.Text + "'"
            If (conexion.modificarVenta("factura.producto", modificar, " producto=" + TxtIdProducto.Text)) Then
                MessageBox.Show("Actualizado")
                MostrarDatosProducto()
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
            If (conexion.eliminarVenta("factura.producto", "idProducto=" + TxtIdProducto.Text)) Then
                MessageBox.Show("Eliminado")
                MostrarDatosProducto()
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

    Private Sub TxtIdProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtIdProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Producto")
        End If
    End Sub

    Private Sub TxtNombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtNombreProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un Nombre Producto")
        End If
    End Sub

    Private Sub TxtDescripcionProducto_Validating(sender As Object, e As CancelEventArgs) Handles TxtDescripcionProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese una Descripcion")
        End If
    End Sub
End Class