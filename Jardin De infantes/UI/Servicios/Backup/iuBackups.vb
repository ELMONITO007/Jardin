Imports EE
Imports BLL

Imports System.Globalization
Imports System.Threading


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
        dgvBackup.Columns(3).Visible = False

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

        Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
        Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        Threading.Thread.CurrentThread.CurrentCulture = culturaObj

    End Sub

    Private Sub dgvBackup_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBackup.CellContentClick
        If cbRecuperarBakup.Checked = True Then
            txtnombreArchivo.Text = dgvBackup.CurrentRow.Cells(1).Value.ToString
        End If

    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbRecuperarBakup.CheckedChanged
        If cbRecuperarBakup.Checked = True Then
            btnRestaurarBackup.Visible = True
            dgvBackup.Visible = True
        Else
            btnRestaurarBackup.Visible = False
            dgvBackup.Visible = False
        End If
    End Sub
End Class