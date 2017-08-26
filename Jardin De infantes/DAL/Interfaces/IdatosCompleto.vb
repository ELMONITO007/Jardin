Public Interface IdatosCompleto

    Function Buscar(ID As Integer) As DataTable
    Function Listar() As DataTable
    Sub Modificar(HT As Hashtable)
    Sub Eliminar(HT As Hashtable)
    Sub Agregar(HT As Hashtable)

End Interface
