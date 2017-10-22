Imports System.Globalization
Imports BLL
Imports EE


Public Class iuABMpersona
    Public Shared tipoPersona As String
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



                Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
                Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
                Threading.Thread.CurrentThread.CurrentCulture = culturaObj


            Next
        Next
    End Sub
    Private Sub iuABMpersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

    End Sub
End Class