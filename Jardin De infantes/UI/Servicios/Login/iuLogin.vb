﻿Imports BLL
Imports EE
Imports MetroFramework
Public Class iuLogin
    Dim idioma As String


    'Sub BuscarIdioma()
    '    Dim bllIdioma As New bllIdioma
    '    Dim unIdioma As New Idioma()
    '    unIdioma = bllIdioma.UsuarioIdioma(unUsuario)
    '    idioma = unIdioma.getIdioma
    'End Sub

    'Sub cambiaridioma()

    '    Dim unbllTraducir As New bllTraduccion

    '    Dim unIdioma As New Idioma(idioma)
    '    Dim unTraducir As New Traduccion(unIdioma)
    '    Dim ht As New Hashtable
    '    ht = unbllTraducir.ListarPalabrasTraducidas(unTraducir)
    '    For Each item As DictionaryEntry In ht
    '        For Each controlcito In Me.Controls

    '            If controlcito.Name = item.Key Then
    '                controlcito.Text = item.Value

    '            End If




    '        Next
    '    Next
    'End Sub

    Sub cambiaIdiomaForm()

        Dim unbllTraducir As New bllTraduccion

        Dim unIdioma As New Idioma(txtIdioma.Text)
        Dim unTraducir As New Traduccion(unIdioma)
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
    Private Sub iuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unBll As New bllIdioma
        txtIdioma.DataSource = unBll.listaIdiomaString






    End Sub

    Private Sub txtIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtIdioma.SelectedIndexChanged
        cambiaIdiomaForm()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim unbllusuario As New bllUsuario

        If unbllusuario.VerificarCompletoUsuario(txtPassword.Text, txtUsuario.Text) = True Then
            Dim unIdioma As New Idioma(txtIdioma.Text)
            unbllusuario.ModificarIdioma(unIdioma)

            MsgBox("Bienvenido " & sessionManager.intance.getUsuario.getPersona.getNombre)
        Else
            MetroMessageBox.Show(Me, "Usuario o Contraseña invalidas", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub
End Class