Public Class Bitacora
    Private Property _fecha As DateTime
    Private Property _descripcion As EventoBitacora

    Sub New(unaFecha As DateTime, unEvento As EventoBitacora)
        _fecha = unaFecha
        _descripcion = unEvento

    End Sub
    Public Function getFecha() As DateTime
        Return _fecha
    End Function
    Public Function getDescripcion() As String
        Return _descripcion.getDesripcion


    End Function

End Class
