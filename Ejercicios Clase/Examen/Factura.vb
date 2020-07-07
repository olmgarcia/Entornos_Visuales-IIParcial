Public Class Factura
    Dim conexionFactura As conexion = New conexion()
    Dim dt As New DataTable
    Private Sub Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        MostrarDatos()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub
    Public Sub MostrarDatos()
        Try
            dt = conexionFactura.consulta
            If dt.Rows.Count <> 0 Then
                DTG_RegistroVenta.DataSource = dt
                conexionFactura.conexion.Close()
            Else
                DTG_RegistroVenta.DataSource = Nothing
                conexionFactura.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim opcion As Integer

        opcion = MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub llenarCamposFactura(e As DataGridViewCellEventArgs)

        Try
            Dim dtg As DataGridViewRow = DTG_RegistroVenta.Rows(e.RowIndex)
            TxtCodigoCliente.Text = dtg.Cells(0).Value.ToString()
            TxtNombre.Text = dtg.Cells(1).Value.ToString()
            TxtApellido.Text = dtg.Cells(2).Value.ToString()
            TxtDireccion.Text = dtg.Cells(3).Value.ToString()
            cmbCodigoVenta.Text = dtg.Cells(4).Value.ToString()
            cmbCodigoProducto.Text = dtg.Cells(5).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DTG_RegistroVenta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTG_RegistroVenta.CellContentClick
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
        TxtCodigoCliente.Enabled = False
        llenarCamposFactura(e)
    End Sub


    Public Sub Limpiar()
        TxtCodigoCliente.Enabled = True
        TxtCodigoCliente.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        conexionFactura.conexion.Close()
        'cmbSexo.Items.Clear()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (conexionFactura.estudianteValidar(TxtCodigoCliente.Text) = False) Then
            MsgBox(conexionFactura.insertarF(TxtCodigoCliente.Text, TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, cmbCodigoVenta.Text, cmbCodigoProducto.Text))
            conexionFactura.conexion.Close()
            Limpiar()
            MostrarDatos()
            TxtCodigoCliente.Focus()
        Else
            MsgBox("Cliente ya existe", MessageBoxIcon.Error)
            conexionFactura.conexion.Close()
        End If
    End Sub
End Class