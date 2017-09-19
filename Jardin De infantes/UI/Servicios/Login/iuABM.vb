Imports BLL
Imports EE


Imports System.Globalization
Imports System.Threading

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

        Dim culturaObj As CultureInfo = New CultureInfo(SingletonIdioma.intance.getUsuario.getIdioma)
        Threading.Thread.CurrentThread.CurrentUICulture = culturaObj
        Threading.Thread.CurrentThread.CurrentCulture = culturaObj

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
        Try
            Dim unUsuario As New Usuario(txtUsuario.Text, txtContraseña.Text, 0, 0, "", 0, unaPersona, 1)
            Dim bll As New bllUsuario
            Dim resultado As Boolean = bll.altaUsuario(unUsuario)
            If resultado = True Then
                MsgBox("Se dio de alta correctamente el usuario: " & unUsuario.getNombreUsuario, vbInformation, "Alta usuario")
            Else
                MsgBox("El usuario " & unUsuario.getNombreUsuario & "ya existe", vbCritical, "Alta Usuario")
            End If
            llenarGrilla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub btnBaja_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnModificat_Click(sender As Object, e As EventArgs) Handles btnModificat.Click
        Try
            Dim unUsuario As New Usuario(txtUsuario.Text, txtContraseña.Text, 0, 0, "", 0, unaPersona, 1)
            Dim bll As New bllUsuario

            Dim resultados As Integer = MsgBox("Desea modificar el usuario: " & unUsuario.getNombreUsuario, vbYesNo, "Importante")
            If resultados = vbYes Then


                Dim resultado As Boolean = bll.ModificarUsuario(unUsuario)
                If resultado = True Then
                    MsgBox("Se modifico correctamente el usuario: " & unUsuario.getNombreUsuario, vbInformation, "Modificar usuario")
                Else
                    MsgBox("El usuario " & unUsuario.getNombreUsuario & "no existe", vbCritical, "Modificar Usuario")

                End If
            Else

                MsgBox("Se cancelo la baja", vbInformation, "Modificar Usuario")
            End If


            llenarGrilla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBaja_Click_1(sender As Object, e As EventArgs) Handles btnBaja.Click
        Try
            Dim unUsuario As New Usuario(txtUsuario.Text, txtContraseña.Text, 0, 0, "", 0, unaPersona, 1)
            Dim bll As New bllUsuario

            Dim resultados As Integer = MsgBox("Desea dar de baja el usuario:" & unUsuario.getNombreUsuario, vbYesNo, "Importante")
            If resultados = vbYes Then


                Dim resultado As Boolean = bll.BajaUsuario(unUsuario)
                If resultado = True Then
                    MsgBox("Se dio de baja correctamente el usuario: " & unUsuario.getNombreUsuario, vbInformation, "Baja usuario")
                Else
                    MsgBox("El usuario " & unUsuario.getNombreUsuario & "no existe", vbCritical, "Baja Usuario")

                End If
            Else

                MsgBox("Se cancelo la baja", vbInformation, "Baja Usuario")
            End If


            llenarGrilla()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class