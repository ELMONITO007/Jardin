Imports EE
Imports MP
Imports DAL
Public Class bllUsuario
    Public Sub ModificarIdioma(unUsuario As Usuario)
        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dal As New dalUsurio(Of Usuario)
        ht = mpp.ModificarIdioma(unUsuario)
        dal.IdatosCompleto_Modificar(ht, "p_CambiarIdiomaUsuario")

    End Sub
End Class
