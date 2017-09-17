Imports BLL
Imports EE

Public Class iuABM
    Public Shared legajo As Integer
    Public Shared unaPersona As New Persona
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
    Private Sub iuABM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiaridioma()
        llenarGrilla()
    End Sub
    Sub llenarGrilla()
        Dim bll As New bllUsuario
        dgvABMUsuario.DataSource = Nothing
        dgvABMUsuario.DataSource = bll.obtenerListaUsuario
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frm As New iuPersona
        frm.ShowDialog()

        Try
            txtLegajo.Text = unaPersona.getLegajo
            txtUsuario.Text = ManejoString.UnirPalabras(unaPersona.getApellido, unaPersona.getNombre, 5, 3)

        Catch ex As Exception
            MsgBox("No se busco ningun usuario")
        End Try


    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click

    End Sub
End Class