Public MustInherit Class eeEncriptado
    Protected Property valorInicial
    Protected Property ValorEncriptado

    Public MustOverride Function Hashear() As String
End Class
