Imports EE
Imports BLL
Public Class iuAltaIdioma
    Private Sub btnBaja_Click(sender As Object, e As EventArgs) Handles btnBaja.Click
        If txtLegajo.Text = "" Then
            MsgBox("Complete el Idioma", vbOK, "Error")
        Else
            Dim unIdioma As New Idioma(txtLegajo.Text)
            Dim bll As New bllIdioma
            If bll.AltaIdioma(unIdioma) = True Then
                MsgBox("Ahora tradusca las palabras en el cuadro", vbOK, "Traducir")
                dgvABMUsuario.Visible = True
                Dim palabra As New bllPalabra
                dgvABMUsuario.DataSource = ""
                dgvABMUsuario.DataSource = palabra.ListarPalabras
                dgvABMUsuario.Columns.Add("Traduccion", "Traduccion")
                btnBaja.Visible = False
                btnAltaTraduccion.Visible = True

            Else
                MsgBox("El idioma ya existe", vbExclamation + vbOK, "Error")
            End If
        End If


    End Sub

    Private Sub btnAltaTraduccion_Click(sender As Object, e As EventArgs) Handles btnAltaTraduccion.Click
        Dim LISTA As New List(Of Traduccion)

        For Each item As DataGridViewRow In dgvABMUsuario.Rows
            If item.Cells(0).Value = Nothing Or item.Cells(1).Value = Nothing Then
            Else
                Dim unaPalabra As New Palabra(item.Cells(0).Value.ToString)
                Dim unIdioma As New Idioma(txtLegajo.Text)
                Dim unaTraduccion As New Traduccion(item.Cells(1).Value.ToString, unIdioma, unaPalabra)
                LISTA.Add(unaTraduccion)
            End If

        Next

        Dim bll As New bllTraduccion
        If bll.AgregarTraduccion(LISTA) = True Then

            MsgBox("Se agrego las traducciones", vbInformation + vbOKOnly, "Traduccion")
        Else
            MsgBox("Error en la traduccion", vbCritical + vbOKOnly, "Error")
        End If

        btnBaja.Visible = True
        btnAltaTraduccion.Visible = False
    End Sub
End Class