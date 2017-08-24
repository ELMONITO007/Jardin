Public Class DigitoVerificadorH
    Private Property valorRecibido As String
    Private Property valorHasheado As String
    Sub New(valorInicial As String)
        valorRecibido = valorInicial
    End Sub
    Sub New(valorInicial As String, valorConHash As String)
        valorRecibido = valorInicial
        valorHasheado = valorConHash

    End Sub

    Public Function GenerarDigitoVerificadorH() As String
        Dim hashear As New EncriptarSHA5(valorRecibido)
        Return hashear.Hashear

    End Function

    Public Function VerificadorDigitoVerificadorH() As Boolean
        Dim hashear As New EncriptarSHA256(valorRecibido)
        Dim valorInicialHasheado As String = hashear.Hashear
        If valorInicialHasheado = valorHasheado Then
            Return True
        ElseIf valorInicialHasheado <> valorHasheado Then
            Return False

        End If

    End Function


End Class
