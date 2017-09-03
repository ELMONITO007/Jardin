Imports BLL
Imports EE
Imports MetroFramework
Public Class iuLogin
    Sub cambiaIdiomaForm()

    End Sub

    Sub cambiaIdioma()

        Dim unbllTraducir As New bllTraduccion

        Dim unIdioma As New Idioma(txtIdioma.Text)
        Dim unTraducir As New Traduccion(unIdioma)
        Dim ht As New Hashtable
        ht = unbllTraducir.ListarPalabrasTraducidas(unTraducir)
        For Each item As DictionaryEntry In ht
            For Each controlcito In Me.Controls

                If controlcito.Name = item.Key Then
                    controlcito.Text = item.Value

                End If




            Next
        Next
    End Sub
    Private Sub iuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unBll As New bllIdioma
        txtIdioma.DataSource = unBll.listaIdiomaString
        cambiaIdioma()




    End Sub

    Private Sub txtIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtIdioma.SelectedIndexChanged
        cambiaIdioma()
    End Sub
End Class