Public Class Traduccion
    Private Property traduccion As String
    Private Property referencia As String

    Sub New(_traduccion As String, _referencia As String)
        traduccion = _traduccion
        referencia = _referencia
    End Sub


    Public Function getTraduccion() As String
        Return traduccion
    End Function

    Public Function getReferencia() As String
        Return referencia
    End Function

End Class
