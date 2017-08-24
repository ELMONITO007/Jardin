Imports System.Security.Cryptography
Public Class EncriptarSHA5
    Inherits eeEncriptado
    Sub New(_ValorInicial As String)
        Me.valorInicial = _ValorInicial
        Me.ValorEncriptado = ""

    End Sub

    Public Overrides Function Hashear() As String

        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(Me.valorInicial)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            Me.ValorEncriptado &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
        Return ValorEncriptado
    End Function
End Class
