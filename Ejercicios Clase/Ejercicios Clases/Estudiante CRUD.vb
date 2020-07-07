Public Class Estudiante_CRUD
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable

    Private Sub Estudiante_CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion.conectar()
        MostrarDatos()
        BtnModificar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Public Sub MostrarDatos()
        Try
            'asigna a la variable datatable la consulta realizada a la base de datos y si existen registros los asigna al datagrid'
            'caso contrario no muestra nada en el datagrid
            dt = conexion.consulta
            If dt.Rows.Count <> 0 Then
                DTG_Registros.DataSource = dt
                conexion.conexion.Close()
            Else
                DTG_Registros.DataSource = Nothing
                conexion.conexion.Close()
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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If (conexion.estudianteValidar(TxtCodigo.Text) = False) Then
            MsgBox(conexion.insertarE(TxtCodigo.Text, TxtNombre.Text, TxtPrimerApellido.Text, TxtSegundoApellido.Text, Val(TxtEdad.Text), CmbSexo.Text, TxtCodigo.Text))
            conexion.conexion.Close()
            Limpiar()
            MostrarDatos()
            TxtCodigo.Focus()
        Else
            MsgBox("Estudiante ya existe", MessageBoxIcon.Error)
            conexion.conexion.Close()
        End If
    End Sub

    Public Sub Limpiar()
        TxtCodigo.Enabled = True
        TxtCodigo.Clear()
        TxtNombre.Clear()
        TxtPrimerApellido.Clear()
        TxtSegundoApellido.Clear()
        TxtEdad.Clear()
        BtnEliminar.Enabled = False
        BtnModificar.Enabled = False
        BtnGuardar.Enabled = True
        conexion.conexion.Close()
        'cmbSexo.Items.Clear()

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar() 'Llama el procedimiento limpiar cajas de texto
    End Sub

    Private Sub DTG_Registros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTG_Registros.CellContentClick
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = True
        BtnEliminar.Enabled = True
        TxtCodigo.Enabled = False
        llenarCampos(e)
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        'Rellena los campos en los textbox, asignando de acuerdo a la posicion que se encuentra en el datagrid
        Try
            Dim dtg As DataGridViewRow = DTG_Registros.Rows(e.RowIndex)
            TxtCodigo.Text = dtg.Cells(0).Value.ToString()
            TxtNombre.Text = dtg.Cells(1).Value.ToString()
            TxtPrimerApellido.Text = dtg.Cells(2).Value.ToString()
            TxtSegundoApellido.Text = dtg.Cells(3).Value.ToString()
            TxtEdad.Text = dtg.Cells(4).Value.ToString()
            CmbSexo.Text = dtg.Cells(5).Value.ToString()
            'cmbCodigoClase.Text = dtg.Cells(6).Value.ToString()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Try
            'Ejemplo
            'UPDATE personas.estudiante 
            'set nombre='Olman', primerApellido='Mendez', segundoApellido='Mendez', edad=27, codigoClase='IF-325'
            'WHERE codigo ='36'
            Dim modificar As String =
            "nombre='" + TxtNombre.Text + "', primerApellido='" + TxtPrimerApellido.Text + "', segundoApellido='" + TxtSegundoApellido.Text + "', edad='" + TxtEdad.Text + "', codigoClase='" + TxtCodigo.Text + "'"
            'Se envían 3 parametros;1. tabla,2. el estbalecer los campos que pueden ser modificados,3. la condición
            If (conexion.modificar("personas.estudiante", modificar, " codigo=" + TxtCodigo.Text)) Then
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
            'Ejemplo: delete from personas.estudiante where codigo = 0036 '8836 es txtCodigo'
            'Parametros enviados son la tabla: personas.estudinte, La condicion="codigo=" + txtCodigo.Text
            If (conexion.eliminar("personas.estudiante", "codigo=" + TxtCodigo.Text)) Then
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

    Private Sub mostrarBusqueda()
        'Buscar por codigo ejemplo: select * from personas.estudiante where codigo Like '%88%'
        Try
            'Se envía lo que contiene el txtCodigo como parametro de búsqueda
            ''%" + txtCodigo.Text + "%'"= con un numero que se encuentre de coincidencia este retornará las sugerencias
            'en el datagrid
            dt = conexion.buscarEstudiante("codigo like '%" + TxtCodigo.Text + "%'")
            If dt.Rows.Count <> 0 Then
                DTG_Registros.DataSource = dt 'Rellena el datagrid
                conexion.conexion.Close()
            Else
                DTG_Registros.DataSource = Nothing 'No retorna nada, deja vació el datagrid ya que no existe un codigo
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        mostrarBusqueda()

    End Sub
End Class