Imports DAL
Imports EE
Public Class bllPatente

    Public Function AltaFamilia(unaPatente As Patente) As Boolean
        Try
            Dim dal As New dalFamilia
            dal.Escribir("insert into Composite(Nombre,Descripcion,Activo)values('" & unaPatente.getNombre & "','" & unaPatente.getDescipcion & "',1)
 insert into CompositeFamilia(ID_CompositeFamilia,ID_CompositePatente)values (null,(select ID_Composite from Composite where Nombre='" & unaPatente.getNombre & "')) ")
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function listaPatente() As DataTable
        Dim dal As New dalFamilia
        Return dal.Leer("select distinct c.Nombre,c.Descripcion from CompositeFamilia as cf join Composite as c on cf.ID_CompositePatente=c.ID_Composite where not( ID_CompositePatente is null)  and Activo=1")
    End Function
End Class
