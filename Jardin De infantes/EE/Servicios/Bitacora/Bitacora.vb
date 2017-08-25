Public Class Bitacora
    Private Property fecha As DateTime
    Private Property descripcion As EventoBitacora

    Sub New(unaFecha As DateTime, unEvento As EventoBitacora)
        fecha = unaFecha
        descripcion = unEvento

    End Sub


End Class
