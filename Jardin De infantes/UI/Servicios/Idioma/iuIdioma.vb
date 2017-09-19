Imports BLL
Imports EE

Imports System.Globalization
Imports System.Threading

Public Class iuIdioma

    Sub cambiaridioma()

        Dim unbllTraducir As New bllTraduccion


        Dim unTraducir As New Traduccion(SingletonIdioma.intance.getUsuario)
        Dim ht As New Hashtable
        ht = unbllTraducir.ListarPalabrasTraducidas(unTraducir)
        For Each item As DictionaryEntry In ht
            For Each controlcito As Control In Me.Controls
                If controlcito.Tag Is Nothing Then
                Else
                    If controlcito.Tag.Equals(item.Key) Then
                        controlcito.Text = item.Value

                    End If
                End If





            Next
        Next
        Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
        Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        Threading.Thread.CurrentThread.CurrentCulture = culturaObj
    End Sub
    Private Sub mtCambiarIdioma_Click(sender As Object, e As EventArgs) Handles mtCambiarIdioma.Click
        Dim unIdioma As New iuCambiarIdioma
        unIdioma.ShowDialog()
        cambiaridioma()


    End Sub

    Private Sub mtAgregarIdioma_Click(sender As Object, e As EventArgs) Handles mtAgregarIdioma.Click
        Dim frm As New iuAltaIdioma
        frm.ShowDialog()

    End Sub

    Private Sub iuIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()

    End Sub
End Class