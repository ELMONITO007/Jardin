Public MustInherit Class bllABM(Of T)
    Public MustOverride Sub alta(unObjeto As T)
    Public MustOverride Sub Baja(unObjeto As T)
    Public MustOverride Sub Modificar(unObjeto As T)
    Public MustOverride Function Obtener(unObjeto As T) As DataTable

    Public MustOverride Function Listar() As DataTable



End Class
