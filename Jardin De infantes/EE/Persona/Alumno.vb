Public Class Alumno
    Inherits Personas

    Sub New(_nombre As String, _apellido As String)
        nombre = _nombre
        apellido = _apellido
    End Sub

    Sub New()

    End Sub
    Sub New(_legajo As Integer, _nombre As String, _apellido As String, _dni As Integer, _direccion As String, _digitoVerificadorH As String)


        nombre = _nombre
        apellido = _apellido
        dni = _dni
        direccion = _direccion
        digitoVerificadorH = _digitoVerificadorH

    End Sub
    Sub New(_legajo As Integer, _nombre As String, _apellido As String, _dni As Integer, _direccion As String, _digitoVerificadorH As String, unTipo As TipoPersona)


        nombre = _nombre
        apellido = _apellido
        dni = _dni
        direccion = _direccion
        digitoVerificadorH = _digitoVerificadorH
        unTIpoPersona = unTipo
    End Sub


End Class
