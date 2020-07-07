'Imports System.Data
Imports System.Data.SqlClient
'Imports System.Windows.Forms

Public Class conexionFactura
    Public conexionfactura As SqlConnection = New SqlConnection("Data Source=DESKTOP-HD05D0Q;Initial Catalog=Tienda;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexionfactura.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexionfactura.Close()
        End Try
    End Sub

    Public Function consulta() As DataTable
        Try
            conexionfactura.Open()

            Dim cmd As New SqlCommand("consultaFactura", conexionfactura)
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

    Function insertarF(ByVal codigoCliente As String, ByVal Nombre As String, ByVal Apellido As String, ByVal direccion As String, ByVal codigoVenta As String) As String
        Dim mensaje As String = "Cliente almacenado"
        Try
            comando = New SqlCommand("Insert into factura.venta(codigocliente,nombre,pellido,direccion,codigoClase) values ('" & codigoCliente & "','" & Nombre & "','" & Apellido & "','" & direccion & "',,'" & codigoVenta & "')", conexionfactura)
            comando.ExecuteNonQuery()
        Catch ex As Exception
            mensaje = "No se inserto por: " + ex.ToString
        End Try
        Return mensaje
    End Function
End Class
