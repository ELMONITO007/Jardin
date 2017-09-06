
Imports System.Security.Cryptography
Imports System.Text
Public Class EncriptarSHA256
    Inherits eeEncriptado
    Sub New(_valorInicial As String)
        Me.valorInicial = _valorInicial


    End Sub
    Public Overrides Function Hashear() As String
        Dim SHA256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Me.valorInicial)
        Dim hash As Byte() = SHA256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()

        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next

        Return stringBuilder.ToString
    End Function
End Class
