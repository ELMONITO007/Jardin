Imports BLL
Imports EE

Imports System.Globalization
Imports System.Threading
Public Class iuCambiarIdioma
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
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIdioma.SelectedIndexChanged

    End Sub

    Private Sub iuCambiarIdioma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unBll As New bllIdioma
        cbIdioma.DataSource = unBll.listaIdiomaString
        cambiaridioma()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        SingletonIdioma.intance.CambiarIdioma(cbIdioma.Text)
        cambiaridioma()
        Me.Close()
    End Sub
End Class