Imports BLL
Imports EE

Public Class iuServiciosHome


    Sub cambiaridioma()

        Dim unbllTraducir As New bllTraduccion


        Dim unTraducir As New Traduccion(sessionManager.intance.getUsuario.getUnIdioma)
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
    End Sub
    Private Sub iuServiciosHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()

    End Sub
End Class