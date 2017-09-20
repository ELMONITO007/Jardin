Imports EE
Imports BLL

Public Class iuPermisos
    Private Sub iuPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarArbol()
        llenarFamilia()
        llenarPAtente()
        Dim bllrio As New bllUsuario
        txtElUSuarioFamilia.DataSource = bllrio.obtenerListaUsuario()
        txtElUSuarioFamilia.DisplayMember = "NombreUsuario"
        txtElUSuarioFamilia.ValueMember = "NombreUsuario"
        txtElusuarioRol.DataSource = bllrio.obtenerListaUsuario()
        txtElusuarioRol.DisplayMember = "NombreUsuario"
        txtElusuarioRol.ValueMember = "NombreUsuario"
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
        dgvUSuarioFamilia.DataSource = ""
        dgvUSuarioFamilia.DataSource = bllp.obtenerFamiliadt
    End Sub
    Sub llenarPAtente()
        Dim bll As New bllPatente
        dgvUsuarioPatente.DataSource = ""
        dgvUsuarioPatente.DataSource = bll.listaPatente
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



    Private Sub dgvUsuarioPatente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarioPatente.CellContentClick


        txtUSuarioPatente.Text = dgvAsignarPAtente.CurrentRow.Cells(0).Value.ToString

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim bll As New bllFamilia
        Dim unUsuario As New Usuario(txtElUSuarioFamilia.Text)
        Dim unPermiso As New Patente(txtUSuarioPatente.Text, "", 1)
        If bll.agregarFamiliaUSuario(unUsuario, unPermiso) = True Then
            MsgBox("Se Asigno el permiso: " & unPermiso.getNombre & " al usuario: " & unPermiso.getNombre, vbOKOnly + vbInformation, "Permisos")

        Else
            MsgBox("Error Verifique los dato", vbAbort + vbOKOnly, "Permisos")

        End If

    End Sub



    Private Sub MetroGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarioFamilia.CellContentClick

        txtUsuarioFamilia.Text = dgvUsuarioFamilia.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim bll As New bllFamilia
        Dim unUsuario As New Usuario(txtElusuarioRol.Text)
        Dim unaFamilia As New Familia(txtUsuarioFamilia.Text, "", 1)
        If bll.agregarFamiliaUSuario(unUsuario, unaFamilia) = True Then
            MsgBox("Se Asigno el permiso: " & unaFamilia.getNombre & " al usuario: " & unaFamilia.getNombre, vbOKOnly + vbInformation, "Permisos")

        Else
            MsgBox("Error Verifique los dato", vbAbort + vbOKOnly, "Permisos")
        End If
    End Sub
End Class