Imports EE
Public Class mppEventoBitacora
    Public Function ListarBitacoras(dt As DataTable) As List(Of String)
        Dim lista As New List(Of String)
        For Each item As DataRow In dt.Rows
            lista.Add(CStr(item("Evento")))

        Next


        Return lista

    End Function






End Class
