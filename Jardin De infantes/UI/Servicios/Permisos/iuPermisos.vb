Imports EE
Imports BLL

Public Class iuPermisos
    Private Sub iuPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarArbol()
        llenarFamilia()
        llenarPAtente()

    End Sub
    Sub llenarArbol()
        tvwPermisos.Nodes.Clear()
        Dim bllf As New bllFamilia
        Dim nodo As Integer = 0
        Dim familias As New List(Of String)
        familias = bllf.obtenerFamilia

        For Each item As String In familias
            Dim dt As New DataTable
            Dim bllp As New bllFamilia
            Dim unaFamilia As New Familia(item, "", 1)
            dt = bllp.obtenerPatente(unaFamilia)
            tvwPermisos.Nodes.Add(unaFamilia.getNombre)
            For Each fila As DataRow In dt.Rows
                tvwPermisos.Nodes(nodo).Nodes.Add(CStr(fila("Nombre")))
            Next
            nodo = nodo + 1

        Next
    End Sub
    Sub llenarFamilia()
        Dim bllp As New bllFamilia

        dgvFamilia.DataSource = ""
        dgvFamilia.DataSource = bllp.obtenerFamiliadt

        dgvAsignarFamilia.DataSource = ""
        dgvAsignarFamilia.DataSource = bllp.obtenerFamiliadt
    End Sub
    Sub llenarPAtente()
        Dim bll As New bllPatente
        dgvPAtente.DataSource = ""
        dgvPAtente.DataSource = bll.listaPatente
        dgvAsignarPAtente.DataSource = ""
        dgvAsignarPAtente.DataSource = bll.listaPatente

    End Sub

    Private Sub btnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        Dim bll As New bllFamilia
        Dim unaFamilia As New Familia(txtFamilia.Text, txtDescripcion.Text, 1)
        If bll.AltaFamilia(unaFamilia) = True Then
            MsgBox("Se agrego un rol nuevo", vbInformation + vbOKOnly, "Roles")
        Else
            MsgBox("Error al agregar rol", vbAbort + vbOKOnly, "Roles")
        End If
        llenarFamilia()

        llenarArbol()
    End Sub

    Private Sub btnAltaPermiso_Click(sender As Object, e As EventArgs) Handles btnAltaPermiso.Click
        Dim bll As New bllPatente
        Dim unaPAtente As New Patente(txtPermiso.Text, txtDescripcionPermiso.Text, 1)
        If bll.AltaFamilia(unaPAtente) = True Then
            MsgBox("Se agrego un permiso nuevo", vbInformation + vbOKOnly, "Permisos")
        Else
            MsgBox("Error al agregar permiso", vbAbort + vbOKOnly, "Permisos")
        End If
        llenarPAtente()

        llenarArbol()
    End Sub

    Private Sub mtbPatenteFamilia_Click(sender As Object, e As EventArgs) Handles mtbPatenteFamilia.Click

    End Sub

    Private Sub dgvAsignarFamilia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsignarFamilia.CellContentClick
        txtAsignarRol.Text = dgvAsignarFamilia.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub dgvAsignarPAtente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsignarPAtente.CellContentClick
        txtAsignarPErmiso.Text = dgvAsignarPAtente.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub btnPatenteFamilia_Click(sender As Object, e As EventArgs) Handles btnPatenteFamilia.Click
        Dim bll As New bllFamilia
        Dim unaFamilia As New Familia(txtAsignarRol.Text, "", 1)
        'Dim unaPatente As New Patente(txtAsignarPErmiso.Text, "", 1)
        If bll.AsignarPatetenAFamilia(unaFamilia, txtAsignarPErmiso.Text) = True Then
            MsgBox("Se asigna a la familia: " & unaFamilia.getNombre & ", La patente: " & txtAsignarPErmiso.Text, vbInformation + vbOKOnly, "Asignar Permisos a Roles")
        Else
            MsgBox("No se hicieron cambios", vbAbort + vbOKOnly, "Error")
        End If

        llenarArbol()

    End Sub
End Class