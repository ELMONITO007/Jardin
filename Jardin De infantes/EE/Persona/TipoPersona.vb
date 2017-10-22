Public Class TipoPersona
    Inherits IDentificador
    Private Property descripcion As String

    Sub New()

    End Sub
    Sub New(_descripcion As String)

        descripcion = _descripcion
    End Sub

    Private Function GetDescripcion() As String
        Return descripcion
    End Function

End Class
