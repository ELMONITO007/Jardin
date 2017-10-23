Imports BLL
Imports EE
Imports System.Globalization
Imports System.Threading
Public Class iuPersona

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Dim bll As New bllpersonas
        dgvTodosLosusuario.DataSource = ""
        dgvTodosLosusuario.DataSource = bll.Listar

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim unaPersona As New Persona(dgvTodosLosusuario.CurrentRow.Cells(0).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(1).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(2).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(3).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(4).Value.ToString, dgvTodosLosusuario.CurrentRow.Cells(5).Value.ToString)
        iuABM.unaPersona = unaPersona
        Me.Close()

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



                Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
                Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
                Threading.Thread.CurrentThread.CurrentCulture = culturaObj


            Next
        Next
    End Sub
    Private Sub iuPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
    End Sub
End Class