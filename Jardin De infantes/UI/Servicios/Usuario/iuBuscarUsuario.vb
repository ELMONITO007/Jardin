Imports BLL
Imports EE

Public Class iuBuscarUsuario
    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Dim unbll As New bllUsuario
        dgvTodosLosusuario.DataSource = ""
        dgvTodosLosusuario.DataSource = unbll.obtenerListaUsuario
        iuBiatacora.text = dgvTodosLosusuario.CurrentRow.Cells(0).Value.ToString
    End Sub
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
                        Exit For
                    End If
                End If





            Next
        Next
    End Sub
    Private Sub iuBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
    End Sub
End Class