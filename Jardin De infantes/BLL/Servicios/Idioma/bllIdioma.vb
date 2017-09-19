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


    Public Function VerificarIdioma(unIdioma As Idioma) As Boolean
        Dim lista As New List(Of String)
        lista = listaIdiomaString()
        Dim resultado As Boolean = True
        For Each item As String In lista
            If item = unIdioma.getIdioma Then

                resultado = False
                Exit For
            End If
        Next
        Return resultado

    End Function

    Public Function AltaIdioma(unIdioma As Idioma) As Boolean
        If VerificarIdioma(unIdioma) = True Then

            Dim dll As New dalIdioma
            Dim cadena As String = "insert into Idioma(Idioma)values('" & unIdioma.getIdioma & "')"
            dll.Escribir(cadena)

            Return True
        Else
            Return False
        End If



    End Function

End Class
