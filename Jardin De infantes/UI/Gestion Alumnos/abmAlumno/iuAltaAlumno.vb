Public Class iuAltaAlumno
    Private Sub btnAlta_Click(sender As Object, e As EventArgs)
        Dim frm As New iuABMpersona
        frm.ShowDialog()

    End Sub

    Private Sub pbPaso1_Click(sender As Object, e As EventArgs) Handles pbPaso1.Click
        Dim frm As New iuABMpersona
        frm.ShowDialog()
    End Sub
End Class