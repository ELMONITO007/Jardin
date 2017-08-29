Imports EE
Public Class mppIdioma
    Inherits MPP(Of Idioma)

    Public Overrides Function Agregar(unObjeto As Idioma) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As Idioma) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Idioma)
        Dim listaIdiomas As New List(Of Idioma)
        For Each item As DataRow In dt.Rows
            Dim Idioma As String = CStr(item("Idioma"))

            Dim unIdioma As New Idioma(Idioma)

            listaIdiomas.Add(unIdioma)

        Next
        Return listaIdiomas
    End Function
End Class
