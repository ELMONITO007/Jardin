Imports EE
Public Class mppBitacora
    Inherits MPP(Of Bitacora)

    Public Overrides Function Agregar(unaBitacora As Bitacora) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Evento", unaBitacora.getDescripcion)
            .Add("@Fecha", unaBitacora.getFecha)
        End With

        Return ht
    End Function

    Public Overrides Function Modificar(unObjeto As Bitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(ID As Integer) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(ID As Integer) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@ID", ID)

        End With

        Return ht
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Bitacora)
        Throw New NotImplementedException()
    End Function
End Class
