Public Class EventoBitacora
    Private Property descripcion As String

    Sub New()


    End Sub


    Sub New(_descripcion As String)
        descripcion = _descripcion


    End Sub
    Public Function getDesripcion()

        Return descripcion

    End Function


End Class
