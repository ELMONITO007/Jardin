Imports EE
Public Class mppUsuario
    Inherits MPP(Of Usuario)

    Public Overrides Function Agregar(unObjeto As Usuario) As Hashtable

    End Function

    Public Overrides Function Modificar(unObjeto As Usuario) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Usuario)
        Throw New NotImplementedException()
    End Function
End Class
