Imports EE
Public Class mppEventoBitacora
    Inherits MPP(Of EventoBitacora)

    Public Overrides Function Agregar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(unObjeto As EventoBitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of EventoBitacora)
        Dim listaEventosBitacora As New List(Of EventoBitacora)
        For Each item As DataRow In dt.Rows
            Dim ID As String = CStr(item("ID_Evento"))
            Dim evento As String = CStr(item("Evento"))
            Dim unevento As New EventoBitacora(evento, CInt(ID))

            listaEventosBitacora.Add(unevento)

        Next
        Return listaEventosBitacora
    End Function






End Class
