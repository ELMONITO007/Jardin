Public NotInheritable Class SingletonIdioma
    Private Sub New()


    End Sub


    Private Shared _intance As SingletonIdioma = Nothing

    Public Shared ReadOnly Property intance() As SingletonIdioma
        Get
            If _intance Is Nothing Then
                _intance = New SingletonIdioma
            End If
            Return _intance
        End Get
    End Property

    Private Property unIdioma As Idioma
    Public Sub NuevoIdioma(lenguaje As Idioma)
        _unIdioma = lenguaje
    End Sub
    Public Function getUsuario() As Idioma
        Return unIdioma
    End Function
    Public Sub CambiarIdioma(NuevoIdioma As String)
        unIdioma.CambiarIdioma(NuevoIdioma)

    End Sub
    Public Sub BorrarIdioma()
        unIdioma = Nothing
    End Sub
End Class
