Imports BLL
Imports EE
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eventos As New bllIdioma
        Dim ListaEventos As New List(Of Idioma)
        ListaEventos = eventos.ListarIdiomas()
        dgv.DataSource = ListaEventos
        For Each item As Idioma In ListaEventos
            ComboBox1.Items.Add(item.getIdioma())


        Next




    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
