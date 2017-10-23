Public MustInherit Class bllABM(Of T)
    Public MustOverride Function alta(unObjeto As T) As Boolean
    Public MustOverride Function Baja(unObjeto As T) As Boolean
    Public MustOverride Function Modificar(unObjeto As T) As Boolean
    Public MustOverride Function Obtener(unObjeto As T) As DataTable

    Public MustOverride Function Listar() As DataTable



End Class
