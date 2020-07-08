Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexionFactura

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-HD05D0Q;Initial Catalog=Tienda;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectarVenta()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultaVenta() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultaVenta", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function insertaVenta(ByVal codigoCliente As String, ByVal Nombre As String, ByVal Apellido As String, ByVal direccion As String, ByVal codigoVenta As String) As String
        Dim mensaje As String = "Cliente almacenado"
        Try
            comando = New SqlCommand("Insert into factura.venta(codigocliente,nombre,pellido,direccion,codigoClase) values ('" & codigoCliente & "','" & Nombre & "','" & Apellido & "','" & direccion & "',,'" & codigoVenta & "')", conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
    End Function

    Public Function VentaValidar(ByVal codigo As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.Venta where codigo='" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    Function buscarVenta(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.Venta " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function modificarVenta(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function eliminarVenta(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarV As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarV, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function buscarfacturaVenta(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.Venta " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    '---------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------
    'CRUD Formulario Cliente
    'Cada funcion correspondiente

    Public Sub conectarCliente()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultaCliente() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultaCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function insertaCliente(ByVal idCliente As String, ByVal Nombre As String, ByVal Apellido As String, ByVal direccion As String) As String
        Dim mensaje As String = "Cliente almacenado"
        Try
            comando = New SqlCommand("Insert into factura.cliente(idcliente,nombre,apellido,direccion) values ('" & idCliente & "','" & Nombre & "','" & Apellido & "','" & direccion & "')", conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
    End Function

    Public Function ClienteValidar(ByVal codigo As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.cliente where idccliente='" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    Function buscarCliente(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function modificarCliente(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function eliminarCliente(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarC As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarC, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function buscarFacturaCliente(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    '---------------------------------------------------------------------------------------------------------
    '---------------------------------------------------------------------------------------------------------
    'CRUD Formulario Producto
    'Cada funcion correspondiente

    Public Sub conectarProducto()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function consultaProducto() As DataTable
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("consultaCliente", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                'conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function insertaProducto(ByVal idProducto As String, ByVal nombreProducto As String, ByVal descripcionProducto As String) As String
        Dim mensaje As String = "Cliente almacenado"
        Try
            comando = New SqlCommand("Insert into factura.producto(idProducto,nombreProducto,descripcionProducto) values ('" & idProducto & "','" & nombreProducto & "','" & descripcionProducto & "')", conexion)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
    End Function

    Public Function ProductoValidar(ByVal codigo As String) As Boolean
        Dim resultado As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from factura.producto where idccliente='" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function

    Function buscarProducto(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Function modificarProducto(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
        comando = New SqlCommand(modificarE, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function eliminarProducto(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim eliminarC As String = "delete from " + tabla + " where " + condicion
        comando = New SqlCommand(eliminarC, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
    Function buscarFacturaProducto(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscar As String = "select * from factura.cliente " + " where " + condicion
            Dim cmd As New SqlCommand(buscar, conexion)
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
