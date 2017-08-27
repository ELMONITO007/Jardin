Public Class Usuario
    Private Property nombreUsuario As String
    Private Property contraseña As String
    Private Property intentosFallido As Integer
    Private Property logueado As Boolean
    Private Property digitoVerificadorH As String
    Private Property bloqueado As Boolean

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


End Class
