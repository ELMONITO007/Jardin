Imports EE
Public Class mppTraduccion
    Inherits MPP(Of Traduccion)

    Public Overrides Function Agregar(unObjeto As Traduccion) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As Traduccion) As Hashtable

    End Function

    Public Overrides Function Eliminar(unObjeto As Traduccion) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(unObjeto As Traduccion) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Idioma", unObjeto.getIdioma)
        End With

        Return ht

    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Traduccion)
        Throw New NotImplementedException()
    End Function

    Public Function listarHT(dt As DataTable) As Hashtable
        Dim ht As New Hashtable
        For Each item As DataRow In dt.Rows
            Dim tag As String = CStr(item("tag"))
            Dim traduccion As String = CStr(item("traduccion"))

            ht.Add(tag, traduccion)


        Next

        Return ht
    End Function

End Class
