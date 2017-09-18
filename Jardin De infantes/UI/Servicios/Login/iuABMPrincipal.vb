Imports BLL
Imports EE

Public Class iuABMPrincipal
    Private Sub iuABMPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()

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

    Private Sub mtAlta_Click(sender As Object, e As EventArgs) Handles mtAlta.Click
        Dim frm As New iuABM
        frm.btnBaja.Visible = False
        frm.btnModificat.Visible = False
        frm.btnModificat.Enabled = False
        frm.btnBaja.Enabled = False
        frm.Text = "Alta de usuario"
        frm.ShowDialog()


    End Sub

    Private Sub mtBaja_Click(sender As Object, e As EventArgs) Handles mtBaja.Click
        Dim frm As New iuABM
        frm.btnAlta.Visible = False
        frm.btnModificat.Visible = False
        frm.btnModificat.Enabled = False
        frm.btnAlta.Enabled = False
        frm.txtContraseña.Visible = False
        frm.lblContraseña.Visible = False
        frm.dgvABMUsuario.Visible = False
        frm.Text = "Baja de usuario"
        frm.ShowDialog()

    End Sub

    Private Sub mtModificar_Click(sender As Object, e As EventArgs) Handles mtModificar.Click
        Dim frm As New iuABM
        frm.btnAlta.Visible = False
        frm.btnBaja.Visible = False
        frm.btnBaja.Enabled = False
        frm.btnAlta.Enabled = False
        frm.dgvABMUsuario.Visible = False
        frm.Text = "Modificar usuario"
        frm.ShowDialog()

    End Sub
End Class