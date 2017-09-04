Public Interface IdatosCompleto(Of T)

    Function Buscar(HT As Hashtable, sp As String) As List(Of T)
    Function Listar() As List(Of T)
    Sub Modificar(HT As Hashtable, sp As String)
    Sub Eliminar(HT As Hashtable, sp As String)
    Sub Agregar(HT As Hashtable, sp As String)

End Interface
