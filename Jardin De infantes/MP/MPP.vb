Public MustInherit Class MPP(Of T)

    Public MustOverride Function Agregar(unObjeto As T) As Hashtable
    Public MustOverride Function Modificar(unObjeto As T) As Hashtable
    Public MustOverride Function Eliminar(unObjeto As T) As Hashtable
    Public MustOverride Function Buscar(unObjeto As T) As Hashtable
    Public MustOverride Function listar(dt As DataTable) As List(Of T)
End Class
