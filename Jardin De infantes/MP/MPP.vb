Public MustInherit Class MPP(Of T)

    Public MustOverride Function Agregar(unObjeto As T) As Hashtable
    Public MustOverride Function Modificar(unObjeto As T) As Hashtable
    Public MustOverride Function Eliminar(ID As Integer) As Hashtable
    Public MustOverride Function Buscar(ID As Integer) As Hashtable

End Class
