Public Class mppTipoPersona
    Public Function obtenerListaTipoPersona() As String
        Return "select ID_Tipo_Persona as ID,Descripcion from TipoPersona"
    End Function

End Class
