Imports EE
Imports BLL
Public Class iuBackups
    Private Sub btnCrearBackup_Click(sender As Object, e As EventArgs) Handles btnCrearBackup.Click
        Dim cadenaPath As String
        Dim myFileDialog As New FolderBrowserDialog()
        With myFileDialog


            .ShowDialog()
        End With
        cadenaPath = myFileDialog.SelectedPath.ToString
        Dim unBakcup As New Backup(cadenaPath, DateTime.Now, "", txtnombreArchivo.Text)
        Dim bllback As New bllBackup
        bllback.altaBackup(unBakcup)
        listarBackup()

    End Sub

    Sub listarBackup()
        Dim unBakcup As New bllBackup
        dgvBackup.DataSource = ""
        dgvBackup.DataSource = unBakcup.listarTodo


    End Sub

    Private Sub iuBackups_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
        listarBackup()
    End Sub

    Private Sub btnRestaurarBackup_Click(sender As Object, e As EventArgs) Handles btnRestaurarBackup.Click
        Dim unBackup As New Backup(dgvBackup.CurrentRow.Cells(0).Value.ToString, DateTime.Parse(dgvBackup.CurrentRow.Cells(2).Value.ToString), "", dgvBackup.CurrentRow.Cells(1).Value.ToString)
        Dim bllback As New bllBackup
        bllback.RestaurarBakcup(unBackup)

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
End Class