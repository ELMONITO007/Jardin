Imports EE
Imports DAL
Imports MP
Public Class bllFamilia

    Public Function obtenerFamilia() As List(Of String)
        Dim dal As New dalFamilia
        Dim dt As New DataTable
        'Dim todosFamilias As New Familia
        dt = dal.Leer("select c.Nombre from CompositeFamilia as cf join Composite as c on cf.ID_CompositeFamilia=c.ID_Composite where ID_CompositePatente is null  and Activo=1")
        Dim mpp As New mppFamilia
        'For Each item As String In mpp.listarFamilas(dt)
        '    Dim unaFamilia As New Familia(item, "", 1)
        '    todosFamilias.AgregarLista(unaFamilia)
        'Next


        'Dim unaFamilia As New Familia(mpp.listarFamilas(dt))
        Return mpp.listarFamilas(dt)

    End Function

    Public Function obtenerPatente(unaFamilia As Familia)
        Dim dal As New dalFamilia
        Dim dt As New DataTable
        dt = dal.Leer(" select c.Nombre,c.Descripcion from CompositeFamilia as cf join Composite as c on cf.ID_CompositePatente=c.ID_Composite join Composite as c2 on c2.ID_Composite=cf.ID_CompositeFamilia where c.Activo=1 and c2.Nombre='" & unaFamilia.getNombre & "'")
        Return dt

    End Function

    Public Function obtenerFamiliadt() As DataTable
        Dim dal As New dalFamilia
        Dim dt As New DataTable

        dt = dal.Leer("select c.Nombre,c.Descripcion from CompositeFamilia as cf join Composite as c on cf.ID_CompositeFamilia=c.ID_Composite where ID_CompositePatente is null  and Activo=1")

        Return dt

    End Function

    Public Function AltaFamilia(unaFamilia As Familia) As Boolean
        Try
            Dim dal As New dalFamilia
            dal.Escribir("insert into Composite(Nombre,Descripcion,Activo)values('" & unaFamilia.getNombre & "','" & unaFamilia.getDescipcion & "',1)
insert into CompositeFamilia(ID_CompositeFamilia,ID_CompositePatente)values ((select ID_Composite from Composite where Nombre='" & unaFamilia.getNombre & "'),null)")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function AsignarPatetenAFamilia(unaFamilia As Familia, unaPatente As String) As Boolean
        Try
            Dim dal As New dalFamilia
            Dim cadena As String = "insert into CompositeFamilia(ID_CompositeFamilia,ID_CompositePatente)values ((select ID_Composite from Composite where Nombre='" & unaFamilia.getNombre & "'),(select ID_Composite from Composite where Nombre='" & unaPatente & "'))"
            dal.Escribir("insert into CompositeFamilia(ID_CompositeFamilia,ID_CompositePatente)values ((select ID_Composite from Composite where Nombre='" & unaFamilia.getNombre & "'),(select ID_Composite from Composite where Nombre='" & unaPatente & "'))")

            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function agregarFamiliaUSuario(unUSuario As Usuario, unCOmponente As Composite)
        Try
            Dim dal As New dalFamilia
            dal.Escribir("insert into UsuarioFamilia(ID_Permiso,ID_Usuario)values ((select  cf.ID_Permiso from CompositeFamilia as cf join Composite as c on c.ID_Composite=cf.ID_CompositeFamilia where c.nombre='" & unCOmponente.getNombre & "' and ID_CompositePatente is null
),(select ID_Usuario from Usuario where NombreUsuario='" & unUSuario.getNombreUsuario & "'))")
            Dim bll As New bllBitacora
            bll.altaBitacora("AsignarPErmiso", "se asigno permisos a: " & unUSuario.getNombreUsuario)

            Return True
        Catch ex As Exception

            Return False
        End Try



    End Function

    Public Function obtenerDondePuedeEntrar() As DataTable
        Try
            Dim dal As New dalFamilia
            Dim dt As New DataTable
            Dim cadena As String = "select c.nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite=cf.ID_CompositePatente join Composite as c2 on c2.ID_Composite=cf.ID_CompositeFamilia where c2.Nombre=(select c1.Nombre from UsuarioFamilia as uf join Usuario as u on uf.ID_Usuario=u.ID_Usuario join CompositeFamilia as cf on cf.ID_Permiso=uf.ID_Permiso join Composite as c1 on c1.ID_Composite=cf.ID_CompositeFamilia where NombreUsuario='" & sessionManager.intance.getUsuario.getNombreUsuario & "')"
            dt = dal.Leer(cadena)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
