Public Class Patente
    Inherits Composite
    Sub New()

    End Sub
    Sub New(_Nombre As String, _descripcion As String, _activo As String)
        nombre = _Nombre
        descripcion = _descripcion
        activo = _activo

    End Sub
    Public Function getDescipcion() As String
        Return descripcion
    End Function

End Class
