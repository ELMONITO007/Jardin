Public Class iuHOme
    Private Sub mtAlumnos_Click(sender As Object, e As EventArgs) Handles mtAlumnos.Click

    End Sub

    Private Sub mtAlumnos_MouseMove(sender As Object, e As MouseEventArgs) Handles mtAlumnos.MouseMove
        mtAlumnos.Text = "Gestion de alumnos"

    End Sub

    Private Sub mtAlumnos_MouseLeave(sender As Object, e As EventArgs) Handles mtAlumnos.MouseLeave
        mtAlumnos.Text = ""
    End Sub
End Class