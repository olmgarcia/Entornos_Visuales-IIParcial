﻿Public Class ArreglosVectores
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False


    Private Sub BtnGenerarCompu_Click(sender As Object, e As EventArgs) Handles BtnGenerarCompu.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"
        For i = 0 To (computadoras.Length - 1) Step 1
            CmbGenerarCompu.Items.Add(computadoras(i))
        Next
    End Sub
    Private Sub ArreglosVectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGenerarPrecios_Click(sender As Object, e As EventArgs) Handles BtnGenerarPrecios.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            CmbGenerarPrecios.Items.Add(precio(i))
        Next
    End Sub

    Private Sub BtnSolicitar_Click(sender As Object, e As EventArgs) Handles BtnSolicitar.Click
        Dim cant As Integer
        Dim comp() As String
        'Asignar tamaño
        cant = Val(TxtCantCompu.Text)
        ReDim comp(cant)
        'Solicitar la informacion
        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la pc", "Ingreso")
        Next
        'Mostrar la informacion
        For j = 0 To (comp.Length - 1) Step 1
            CmbSolicitar.Items.Add(comp(j))
        Next
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        CmbGenerarCompu.Items.Clear()
        CmbGenerarPrecios.Items.Clear()
    End Sub
End Class