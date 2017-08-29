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
        Dim listaBitacora As New List(Of Bitacora)
        For Each item As DataRow In dt.Rows
            Dim ID As String = CStr(item("ID_Evento"))
            Dim evento As String = CStr(item("Evento"))
            'Dim unevento As New Bitacora(evento, CInt(ID))

            'listaBitacora.Add(unevento)

        Next
        Return listaBitacora
    End Function
End Class
