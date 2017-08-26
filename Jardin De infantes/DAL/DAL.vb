Imports DAL

Public MustInherit Class DAL
    Implements IdatosCompleto

    Public MustOverride Sub Modificar(HT As Hashtable) Implements IdatosCompleto.Modificar


    Public MustOverride Sub Eliminar(HT As Hashtable) Implements IdatosCompleto.Eliminar


    Public MustOverride Sub Agregar(HT As Hashtable) Implements IdatosCompleto.Agregar


    Public MustOverride Function Buscar(ID As Integer) As DataTable Implements IdatosCompleto.Buscar


    Public MustOverride Function Listar() As DataTable Implements IdatosCompleto.Listar

End Class
