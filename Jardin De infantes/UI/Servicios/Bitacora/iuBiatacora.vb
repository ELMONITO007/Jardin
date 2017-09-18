Imports BLL
Imports EE
Imports MetroFramework
Public Class iuBiatacora
    Private Sub btnVerTodos_Click(sender As Object, e As EventArgs) Handles btnVerTodos.Click
        Dim unaBll As New bllBitacora
        dgvVerTodos.DataSource = ""
        dgvVerTodos.DataSource = unaBll.listarTodo
        dgvVerTodos.Columns(7).Visible = False


    End Sub
    Public Shared texto As String



    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim frmBuscar As New iuBuscarUsuario
        frmBuscar.ShowDialog()
        Dim unabll As New bllBitacora
        dgvPorUsuario.DataSource = ""
        dgvPorUsuario.DataSource = unabll.listarPorUsuario(texto)
    End Sub





    Private Sub btnBuscarEvento_Click(sender As Object, e As EventArgs) Handles btnBuscarEvento.Click
        Dim unabll As New bllBitacora
        If txtEvento.Text = "" Then
            MetroMessageBox.Show(Me, "Seleccione el Evento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dgvPorEvento.DataSource = ""
            dgvPorEvento.DataSource = unabll.listarPorEvento(txtEvento.Text)
        End If
    End Sub
    Sub cambiaridioma()

        Dim unbllTraducir As New bllTraduccion


        Dim unTraducir As New Traduccion(SingletonIdioma.intance.getUsuario)
        Dim ht As New Hashtable
        ht = unbllTraducir.ListarPalabrasTraducidas(unTraducir)
        For Each item As DictionaryEntry In ht
            For Each controlcito As Control In Me.tabBitacora.Controls
                If controlcito.Tag Is Nothing Then
                Else
                    If controlcito.Tag.Equals(item.Key) Then
                        controlcito.Text = item.Value

                    End If
                End If





            Next
        Next
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
    Private Sub iuBiatacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unabll As New bllEventoBitacoras
        txtEvento.DataSource = unabll.listarTodo
        cambiaridioma()

    End Sub

    Private Sub tabVerPorEvento_Click(sender As Object, e As EventArgs) Handles tabVerPorEvento.Click

    End Sub
End Class