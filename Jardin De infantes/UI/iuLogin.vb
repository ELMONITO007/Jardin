Imports BLL
Imports EE
Imports MetroFramework
Public Class iuLogin


    Private Sub iuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unBll As New bllIdioma
        txtIdioma.DataSource = unBll.listaIdiomaString
        MessageBox.Show(txtIdioma.Name)

    End Sub
End Class