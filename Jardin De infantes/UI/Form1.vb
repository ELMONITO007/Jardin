Imports BLL
Imports EE
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eventos As New bllEventoBitacora
        Dim ListaEventos As New List(Of EventoBitacora)
        ListaEventos = eventos.ListarEventos()
        dgv.DataSource = ListaEventos



    End Sub
End Class
