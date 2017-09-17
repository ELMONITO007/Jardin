Imports BLL
Imports EE
Public Class iuPersona

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Dim bll As New bllPersona
        dgvTodosLosusuario.DataSource = ""
        dgvTodosLosusuario.DataSource = bll.Listar

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim unaPersona As New Persona(dgvTodosLosusuario.CurrentRow.Cells(0).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(1).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(2).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(3).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(4).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(5).Value.ToString)
        iuABM.unaPersona = unaPersona
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

                    End If
                End If





            Next
        Next
    End Sub
    Private Sub iuPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
    End Sub
End Class