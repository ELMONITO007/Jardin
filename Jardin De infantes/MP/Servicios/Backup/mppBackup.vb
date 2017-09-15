Public Class mppBackup
    Public Function obtenerString(dt As DataTable) As String
        Dim resultado As String = ""
        For Each item As DataRow In dt.Rows
            resultado = CStr(item("DVH"))
        Next
        Return resultado
    End Function
End Class
