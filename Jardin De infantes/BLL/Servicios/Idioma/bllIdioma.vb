Imports EE
Imports DAL

Public Class bllIdioma
    Public Function ListarIdiomas() As List(Of Idioma)
        Dim dal As New dalIdioma
        Return dal.IdatosCompleto_Listar

    End Function

    Public Function listaIdiomaString() As List(Of String)
        Dim listaCompleta As New List(Of String)
        Dim listaCompletaObjeto As New List(Of Idioma)
        listaCompletaObjeto = ListarIdiomas()

        For Each item As Idioma In listaCompletaObjeto
            listaCompleta.Add(item.getIdioma)

        Next

        Return listaCompleta
    End Function
End Class
