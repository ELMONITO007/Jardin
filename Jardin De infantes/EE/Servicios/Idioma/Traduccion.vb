Public Class Traduccion
    Private Property traduccion As String
    Private Property referencia As String
    Private Property idioma As Idioma

    Sub New(_traduccion As String, _referencia As String)
        traduccion = _traduccion
        referencia = _referencia

    End Sub

    Sub New(_idiomas As Idioma)
        idioma = _idiomas
    End Sub
    Public Function getTraduccion() As String
        Return traduccion
    End Function

    Public Function getReferencia() As String
        Return referencia
    End Function
    Public Function getIdioma() As String
        Return idioma.getIdioma
    End Function
End Class
