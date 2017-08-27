Public Interface IdatosCompleto(Of T)

    Function Buscar(ID As Integer) As DataTable
    Function Listar() As List(Of T)
    Sub Modificar(HT As Hashtable)
    Sub Eliminar(HT As Hashtable)
    Sub Agregar(HT As Hashtable)

End Interface
