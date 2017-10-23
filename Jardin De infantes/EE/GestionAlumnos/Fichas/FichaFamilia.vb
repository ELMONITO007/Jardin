Public Class FichaFamilia
    Private Property unaPersona As Persona
    Private Property padreSeparados As Boolean
    Private Property hermanos As Boolean
    Private Property vive_Abuela As Boolean
    Private Property tieneTIos As Boolean
    Private Property papaTrabaja As Boolean
    Private Property MamaTrabaja As Boolean

    Sub New()

    End Sub


    Sub New(_unaPersona As Persona, _padreSeparados As Boolean, _hermanos As Boolean, _vive_Abuela As Boolean, _tieneTIos As Boolean, _papaTrabaja As Boolean, _mamaTrabaja As Boolean)
        unaPersona = _unaPersona
        padreSeparados = _padreSeparados
        hermanos = _hermanos
        vive_Abuela = _vive_Abuela
        tieneTIos = _tieneTIos
        papaTrabaja = _papaTrabaja
        MamaTrabaja = _mamaTrabaja
    End Sub


    Public Function getPadresSeparadas() As Boolean
        Return padreSeparados
    End Function

    Public Function getHermanos() As Boolean
        Return hermanos
    End Function
    Public Function getViveAbuela() As Boolean
        Return vive_Abuela
    End Function

    Public Function getTieneTios() As Boolean
        Return tieneTIos
    End Function
    Public Function getPapaTrabaja() As Boolean
        Return papaTrabaja
    End Function

    Public Function getMamaTrabaja() As Boolean
        Return MamaTrabaja
    End Function

    Public Function getId() As Integer
        Return unaPersona.getID
    End Function
End Class
