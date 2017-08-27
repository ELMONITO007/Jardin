Public Class EventoBitacora
    Private Property descripcion As String
    Private Property codigo As Integer
    Sub New()


    End Sub


    Sub New(_descripcion As String, _codigo As Integer)
        descripcion = _descripcion
        codigo = _codigo

    End Sub
    Public Function getDesripcion()

        Return descripcion

    End Function

    Public Function getCodigo()
        Return codigo
    End Function

End Class
