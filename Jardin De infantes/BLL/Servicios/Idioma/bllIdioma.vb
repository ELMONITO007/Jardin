Imports EE
Imports DAL
Imports MP

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


    Public Function UsuarioIdioma(unUsuario As Usuario) As Idioma
        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dalIdioma As New dalUsurio(Of Usuario)
        Dim ListaIdioma As New List(Of Idioma)
        ht = mpp.Buscar(unUsuario)
        ListaIdioma = dalIdioma.IdatosCompleto_BuscarIdioma(ht)
        Dim item As New Idioma

        For Each item In ListaIdioma
            item = ListaIdioma.Item(0)

        Next
        Return item





    End Function

End Class
