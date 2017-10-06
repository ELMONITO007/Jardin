Public Class Persona
    Inherits IDentificador

    Protected Property legajo As Integer
    Protected Property nombre As String
    Protected Property apellido As String
    Protected Property dni As Integer
    Protected Property direccion As String
    Protected Property digitoVerificadorH As String
    Sub New(_nombre As String, _apellido As String)
        nombre = _nombre
        apellido = _apellido
    End Sub

    Sub New()

    End Sub
    Sub New(_legajo As Integer, _nombre As String, _apellido As String, _dni As Integer, _direccion As String, _digitoVerificadorH As String)

        legajo = _legajo
        nombre = _nombre
        apellido = _apellido
        dni = _dni
        direccion = _direccion
        digitoVerificadorH = _digitoVerificadorH

    End Sub
    Public Function getNombre() As String
        Return nombre
    End Function
    Public Function getApellido() As String
        Return apellido

    End Function
    Public Function getDni() As Integer
        Return dni
    End Function
    Public Function getLegajo() As Integer
        Return legajo

    End Function


End Class
