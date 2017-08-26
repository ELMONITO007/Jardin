Imports EE
Public Class mppEventoBitacora
    Inherits MPP(Of EventoBitacora)

    Public Overrides Function Agregar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of EventoBitacora)
        Throw New NotImplementedException()
    End Function
End Class
