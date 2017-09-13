
Public Class DigitoVerificadoV
    Private Property digitos As List(Of String)
    Private Property nombreTabla As String
    Private Property digitosSinHash As String
    Private Property digitoHasheado As String

    Sub New(listaDigitos As List(Of String), tabla As String)
        digitos = listaDigitos
        nombreTabla = tabla

        For Each item As String In digitos
            digitosSinHash = digitosSinHash & item
        Next
        Dim unHash As New EncriptarSHA5(digitosSinHash)
        digitoHasheado = unHash.Hashear

    End Sub
    Public Function getDigitoHash() As String
        Return digitoHasheado
    End Function

    Sub New()

    End Sub


End Class
