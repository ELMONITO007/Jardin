Public Class Bitacora
    Private Property fecha As DateTime

    Private Property evento As EventoBitacora
    Private Property usuario As Usuario
    Private Property descripcion As String
    Private Property digitoVerificadorHorizontal As String
    Sub New()

    End Sub
    Sub New(unUsuario As Usuario, unaFecha As DateTime, unEvento As EventoBitacora, unaDescripcion As String, unDigitoVerificadorHorizontal As String)
        fecha = unaFecha
        descripcion = unaDescripcion
        evento = unEvento
        digitoVerificadorHorizontal = unDigitoVerificadorHorizontal
        usuario = unUsuario
    End Sub
    Public Sub modificarDVH(undvh As String)
        digitoVerificadorHorizontal = undvh
    End Sub
    Public Function getFecha() As DateTime
        Return _fecha
    End Function
    Public Function getDescripcion() As String
        Return descripcion

    End Function
    Public Function getNombreUsuario() As String
        Return usuario.getNombreUsuario
    End Function

    Public Function getEvento() As String
        Return evento.getDesripcion
    End Function
    Public Function getDVH() As String
        Return digitoVerificadorHorizontal
    End Function
End Class
