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
        usuario = user
    End Sub

    Public Sub Logout()
        usuario = Nothing
    End Sub
End Class
