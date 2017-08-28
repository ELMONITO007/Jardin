Public Class Persona
    Protected Property legajo As Integer
    Protected Property nombre As String
    Protected Property apellido As String
    Protected Property dni As Integer
    Protected Property direccion As String
    Protected Property digitoVerificadorH As String


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
End Class
