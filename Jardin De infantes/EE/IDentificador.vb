Public MustInherit Class IDentificador
    Shared Property id As Integer

    Public Sub setID(unId As Integer)
        id = unId

    End Sub

    Public Function getID() As Integer
        Return id
    End Function
End Class
