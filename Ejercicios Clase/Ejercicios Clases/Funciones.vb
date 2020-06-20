Public Class Funciones
    Private nComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Integer
    Private encuentra As Integer = 0
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        cantComputadoras = Val(TxtCantCompu.Text)
        ReDim Preserve nComputadoras(cantComputadoras, 3)
        '3x3= comienza a contar desde 0
        For i As Integer = 0 To cantComputadoras - 1 Step 1
            nComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            nComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            nComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            nComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
        Next
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim marca As String
        marca = TxtMarca.Text
        For i As Integer = 0 To cantComputadoras Step 1
            If (nComputadoras(i, 0) = marca) Then
                TxtModelo.Text = nComputadoras(i, 1)
                TxtPrecio.Text = nComputadoras(i, 2)
                TxtCantidad.Text = nComputadoras(i, 3)
                index = i
                BtnVender.Enabled = True
                encuentra = 1
            End If
        Next
        If (encuentra = 0) Then
            MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BtnVender.Enabled = False
        End If
    End Sub

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click
        Dim cantVender, stock As Integer
        cantVender = Val(TxtCantVender.Text)
        stock = Val(TxtCantidad.Text)
        If (cantVender <= stock) Then
            nComputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Funciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnVender.Enabled = False
        TxtPrecio.Enabled = False
        TxtCantidad.Enabled = False
        TxtModelo.Enabled = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtCantCompu.Clear()
        TxtMarca.Clear()
        TxtModelo.Clear()
        TxtPrecio.Clear()
        TxtCantidad.Clear()
        TxtCantVender.Clear()
    End Sub
End Class