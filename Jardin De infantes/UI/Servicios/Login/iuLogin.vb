﻿Imports BLL
Imports EE
Imports MetroFramework

Imports System.Globalization
Imports System.Threading


Public Class iuLogin
    Dim idioma As String



    Sub cambiaIdiomaForm()

        Dim unbllTraducir As New bllTraduccion
        Dim unIdioma As New Idioma(txtIdioma.Text)
        SingletonIdioma.intance.NuevoIdioma(unIdioma)
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
    Sub CambiarCultura()

        Dim culturaObj As CultureInfo = New CultureInfo(txtIdioma.Text)
        Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        Threading.Thread.CurrentThread.CurrentCulture = culturaObj
    End Sub
    Private Sub iuLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim unBll As New bllIdioma
        txtIdioma.DataSource = unBll.listaIdiomaString
        cambiaIdiomaForm()
        CambiarCultura()





    End Sub

    Private Sub txtIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtIdioma.SelectedIndexChanged
        cambiaIdiomaForm()
        CambiarCultura()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim unbllusuario As New bllUsuario

        If unbllusuario.VerificarCompletoUsuario(txtPassword.Text, txtUsuario.Text, txtIdioma.Text) = True Then



            MsgBox("Bienvenido " & sessionManager.intance.getUsuario.getPersona.getNombre, , "")
            Dim frmPrincipa As New iuHOme

            frmPrincipa.ShowDialog()
            Me.Close()

        Else
            MetroMessageBox.Show(Me, "Usuario o Contraseña invalidas", "Error en el login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If




    End Sub

    Private Sub lblUsuario_Click(sender As Object, e As EventArgs) Handles lblUsuario.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class