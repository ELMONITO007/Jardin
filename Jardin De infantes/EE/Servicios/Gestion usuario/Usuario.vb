Public Class Usuario
    Inherits IDentificador

    Private Property nombreUsuario As String
    Private Property contraseña As String
    Private Property intentosFallido As Integer
    Private Property logueado As Boolean
    Private Property digitoVerificadorH As String
    Private Property bloqueado As Boolean
    Private Property habilitado As Boolean
    Private Property persona As Persona


    Sub New()

    End Sub
    Sub New(_nombreUsuario As String, _persona As Persona)
        nombreUsuario = _nombreUsuario
        persona = _persona
    End Sub
    Sub New(_nombreUsuario As String, _contraseña As String, _intentosFallido As Integer, _logueado As Boolean, _digitoVerificadorH As String, _bloqueado As Boolean, _persona As Persona, _habilitado As Boolean)
        nombreUsuario = _nombreUsuario
        contraseña = _contraseña
        intentosFallido = _intentosFallido
        logueado = _logueado
        digitoVerificadorH = _digitoVerificadorH
        bloqueado = _bloqueado
        habilitado = _habilitado
        persona = _persona
    End Sub


    Sub New(_nombreUsuario As String)
        nombreUsuario = _nombreUsuario
    End Sub
    Public Sub setContraseña(unaContraseña As String)
        contraseña = unaContraseña
    End Sub
    Public Function getUsuario() As String
        Return nombreUsuario
    End Function



    Public Function getCOntrasenia() As String
        Return contraseña
    End Function
    Public Function getBLoqueado() As Boolean
        Return bloqueado
    End Function


    Public Sub ModificarDVH(DVH As String)
        digitoVerificadorH = DVH
    End Sub
    Public Function getObtenerTodoJunto() As String
        Return CStr(id) & nombreUsuario & contraseña & CStr(intentosFallido) & CStr(logueado) & CStr(persona.getID) & CStr(bloqueado) & CStr(habilitado)
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
    Public Function getHabilitado() As Boolean
        Return habilitado
    End Function
    Public Function getID() As Integer
        Return Me.id
    End Function
    Public Sub setID(_id As Integer)
        Me.id = _id
    End Sub
End Class
