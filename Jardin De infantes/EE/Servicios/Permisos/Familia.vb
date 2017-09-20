Public Class Familia
    Inherits Composite
    Private lista As New List(Of Composite)
    Sub New(_Nombre As String, _descripcion As String, _activo As String)
        nombre = _Nombre
        descripcion = _descripcion
        activo = _activo

    End Sub
    Sub New(_lista As List(Of Composite))
        lista = _lista

    End Sub
    Sub New()

    End Sub

    Public Function getLista() As List(Of Composite)
        Return lista
    End Function
    Public Sub setNombre(unNombre As String)
        nombre = unNombre

    End Sub

    Public Function getDescipcion() As String
        Return descripcion
    End Function
    Public Sub AgregarLista(unComposite As Composite)
        lista.Add(unComposite)
    End Sub
End Class
