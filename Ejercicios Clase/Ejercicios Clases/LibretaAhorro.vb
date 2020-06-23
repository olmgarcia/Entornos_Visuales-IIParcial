Public Class LibretaAhorro

    Private monto As Double
    Private Sub activarControles()
        TxtIdentidad.Enabled = False
        TxtNombreUsuario.Enabled = False
        TxtEdad.Enabled = False
        TxtPais.Enabled = False
        TxtCiudad.Enabled = False
        TxtMonto.Enabled = False
        BtnAperturarCuenta.Enabled = False
        BtnRetirar.Enabled = True
        BtnDepositar.Enabled = True
    End Sub

    Private Sub desactivarControles()
        TxtIdentidad.Enabled = True
        TxtNombreUsuario.Enabled = True
        TxtEdad.Enabled = True
        TxtPais.Enabled = True
        TxtCiudad.Enabled = True
        TxtMonto.Enabled = True
        BtnAperturarCuenta.Enabled = True
        BtnRetirar.Enabled = False
        BtnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        TxtIdentidad.Clear()
        TxtNombreUsuario.Clear()
        TxtEdad.Clear()
        TxtPais.Clear()
        TxtCiudad.Clear()
        TxtSaldoTotal.Clear()
        TxtMonto.Clear()
        LstDepositos.Items.Clear()
        LstRetiros.Items.Clear()
    End Sub

    Private Sub mostrarSaldo()
        TxtSaldoTotal.Text = monto
    End Sub

    Private Sub LibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub BtnAperturarCuenta_Click(sender As Object, e As EventArgs) Handles BtnAperturarCuenta.Click
        Dim cliente, identidad As String

        identidad = Val(TxtIdentidad.Text)
        cliente = TxtNombreUsuario.Text
        monto = Val(TxtMonto.Text)
        If (monto > 0) Then
            activarControles()
        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function leer(mensaje As String) As Double
        Dim cantidad As String
        cantidad = Val(InputBox("Ingrese monto a " + mensaje, "Gestión de Ahorros", "0", 100, 0))
        Return cantidad
    End Function

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        limpiar()
    End Sub

    Private Sub BtnDepositar_Click(sender As Object, e As EventArgs) Handles BtnDepositar.Click
        Dim deposito As Double
        deposito = leer("Depositar")
        monto += deposito
        LstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub BtnRetirar_Click(sender As Object, e As EventArgs) Handles BtnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If (retiro > monto) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retiro
            LstRetiros.Items.Add(retiro)
            mostrarSaldo()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class