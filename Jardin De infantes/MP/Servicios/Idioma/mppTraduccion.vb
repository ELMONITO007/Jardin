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
            Dim traducir As String = CStr(item("Palabra"))
            Dim referencia As String = CStr(item("Referencia"))
            Dim unaTraduccion As New Traduccion(traducir, referencia)
            ht.Add(referencia, traducir)


        Next

        Return ht
    End Function

End Class
