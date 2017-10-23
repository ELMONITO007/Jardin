Public Class TipoPersona
    Inherits IDentificador
    Private Property descripcion As String

    Sub New()

    End Sub
    Public Sub setId(unId As Integer)
        Me.id = unId
    End Sub
    Sub New(_descripcion As String)

        descripcion = _descripcion
    End Sub

    Public Function GetDescripcion() As String
        Return descripcion
    End Function

    Public Sub setDescripcion(_descripcion As String)
        descripcion = _descripcion
    End Sub
    Public Function obtenerID() As Integer
        Dim IDe As Integer = Me.id
        Return IDe

    End Function
End Class
