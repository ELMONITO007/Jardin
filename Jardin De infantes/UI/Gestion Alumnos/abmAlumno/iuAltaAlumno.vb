Public Class iuAltaAlumno
    Private Sub btnAlta_Click(sender As Object, e As EventArgs)
        Dim frm As New iuABMpersona
        frm.ShowDialog()

    End Sub

    Private Sub pbPaso1_Click(sender As Object, e As EventArgs) Handles pbPaso1.Click
        Dim frm As New iuABMpersona
        frm.tipoPersona = "Alumno"
        frm.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim frm As New iuAltaAlumnoFichas
        frm.ShowDialog()

    End Sub
End Class