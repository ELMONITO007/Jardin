Public NotInheritable Class sessionManager

    Private Sub New()

    End Sub
    Private Shared _intance As sessionManager = Nothing

    Public Shared ReadOnly Property intance() As sessionManager
        Get
            If _intance Is Nothing Then
                _intance = New sessionManager
            End If
            Return _intance
        End Get
    End Property

    Private Property usuario As Usuario
    Public Sub login(user As Usuario)
        _usuario = user
    End Sub
    Public Function getUsuario() As Usuario
        Return usuario
    End Function

    Public Sub Logout()
        usuario = Nothing
    End Sub
End Class
