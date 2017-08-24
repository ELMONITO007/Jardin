Public Class DigitoVerificadoV
    Private Property digitos As List(Of String)
    Private Property nombreTabla As String
    Private Property digitoHasheado As String

    Sub New(listaDigitos As List(Of String), tabla As String)
        digitos = listaDigitos
        nombreTabla = tabla
    End Sub

    Sub New()

    End Sub

End Class
