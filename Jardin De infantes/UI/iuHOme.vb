Imports EE
Public Class iuHOme
    Private Sub mtAlumnos_Click(sender As Object, e As EventArgs) Handles mtAlumnos.Click
        Dim frServicios As New iuServiciosHome
        frServicios.ShowDialog()
    End Sub

    Private Sub mtAlumnos_MouseMove(sender As Object, e As MouseEventArgs) Handles mtAlumnos.MouseMove
        mtAlumnos.Text = "Gestion de alumnos"

    End Sub

    Private Sub mtAlumnos_MouseLeave(sender As Object, e As EventArgs) Handles mtAlumnos.MouseLeave
        mtAlumnos.Text = ""
    End Sub

    Private Sub mtServicios_Click(sender As Object, e As EventArgs) Handles mtServicios.Click
        Dim frmServicios As New iuServiciosHome
        frmServicios.ShowDialog()
    End Sub

    Private Sub iuHOme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsuario.Text = sessionManager.intance.getUsuario.getPersona.getNombre
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        sessionManager.intance.Logout()
        Dim frmLogin As New iuLogin
        frmLogin.Activate()
        MsgBox("Se cerrara Sesion")
        frmLogin.ShowDialog()

        Me.Close()
      




    End Sub
End Class