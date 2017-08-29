Imports EE
Imports DAL

Public Class bllIdioma
    Public Function ListarIdiomas() As List(Of Idioma)
        Dim dal As New dalIdioma
        Return dal.IdatosCompleto_Listar

    End Function


End Class
