Public Class Usuario
    Private Property nombreUsuario As String
    Private Property contraseña As String
    Private Property intentosFallido As Integer
    Private Property logueado As Boolean
    Private Property digitoVerificadorH As String
    Private Property bloqueado As Boolean
    Private Property idioma As Idioma
    Private Property persona As Persona


    Sub New()

    End Sub

    Sub New(_nombreUsuario As String, _contraseña As String, _intentosFallido As Integer, _logueado As Boolean, _digitoVerificadorH As String, _bloqueado As Boolean, _idioma As Idioma, _persona As Persona)
        nombreUsuario = _nombreUsuario
        contraseña = _contraseña
        intentosFallido = _intentosFallido
        logueado = _logueado
        digitoVerificadorH = _digitoVerificadorH
        bloqueado = _bloqueado
        idioma = _idioma
        persona = _persona
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

    Public Function getCOntrasenia() As String
        Return contraseña
    End Function
    Public Function getBLoqueado() As Boolean
        Return bloqueado
    End Function


    Public Function getObtenerTodoJunto() As String
        Return nombreUsuario + contraseña + intentosFallido + logueado + bloqueado
    End Function
    Public Function getDVH() As String
        Return digitoVerificadorH
    End Function
    Public Function getPersona() As Persona
        Return persona
    End Function
    Public Function getNombreUsuario() As String
        Return nombreUsuario
    End Function
End Class
