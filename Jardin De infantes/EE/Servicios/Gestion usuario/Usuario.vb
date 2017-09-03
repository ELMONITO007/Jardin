Public Class Usuario
    Private Property nombreUsuario As String
    Private Property contraseña As String
    Private Property intentosFallido As Integer
    Private Property logueado As Boolean
    Private Property digitoVerificadorH As String
    Private Property bloqueado As Boolean
    Private Property idioma As Idioma

    Sub New()

    End Sub
    Sub New(_nombreUsuario As String, _contraseña As String, _intentosFallido As Integer, _logueado As Boolean, _digitoVerificadorH As String, _bloqueado As Boolean)
        nombreUsuario = _nombreUsuario
        contraseña = _contraseña
        intentosFallido = _intentosFallido
        logueado = _logueado
        digitoVerificadorH = _digitoVerificadorH
        bloqueado = _bloqueado
    End Sub
    Sub New(_nombreUsuario As String, _idiomas As Idioma)
        nombreUsuario = _nombreUsuario
        idioma = _idiomas
    End Sub

    Sub New(_nombreUsuario As String)
        nombreUsuario = _nombreUsuario
    End Sub
    Public Function getUsuario() As String
        Return nombreUsuario
    End Function
    Public Function getIdiomas() As String
        Return idioma.getIdioma
    End Function


End Class
