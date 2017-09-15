Public Class Backup

    Private Property Path As String
    Private Property fecha As DateTime
    Private Property digitoVerificadorH As String
    Private Property nombreArchivo As String

    Public Sub New()

    End Sub
    Public Sub New(_Path As String, _fecha As DateTime, _digitoVerificadorH As String, _nombre As String)

        Path = _Path
        fecha = _fecha
        digitoVerificadorH = _digitoVerificadorH
        nombreArchivo = _nombre
    End Sub
    Public Function getPath() As String
        Return Path
    End Function
    Public Function getFecha() As DateTime
        Return fecha
    End Function
    Public Function getNombre() As String
        Return nombreArchivo
    End Function
    Public Sub modificarDVH(unDVH As String)
        digitoVerificadorH = unDVH
    End Sub
End Class
