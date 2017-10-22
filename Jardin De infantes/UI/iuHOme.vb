﻿Imports BLL
Imports EE

Imports System.Globalization
Imports System.Threading

Public Class iuHOme
    Sub cambiaridioma()

        Dim unbllTraducir As New bllTraduccion

        Dim unBllFamilia As New bllFamilia
        DataGridView1.DataSource = unBllFamilia.obtenerDondePuedeEntrar()


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
    Private Sub mtAlumnos_Click(sender As Object, e As EventArgs) Handles mtAlumnos.Click
        Dim frga As New iuGestionAlumnoHome
        frga.ShowDialog()

    End Sub



    Private Sub mtServicios_Click(sender As Object, e As EventArgs) Handles mtServicios.Click
        Dim frmServicios As New iuServiciosHome
        frmServicios.ShowDialog()
        cambiaridioma()
    End Sub

    Private Sub iuHOme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = sessionManager.intance.getUsuario.getPersona.getNombre
        cambiaridioma()

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        sessionManager.intance.Logout()
        Dim frmLogin As New iuLogin

        MsgBox("Se cerrara Sesion")

        Me.Close()









    End Sub
End Class