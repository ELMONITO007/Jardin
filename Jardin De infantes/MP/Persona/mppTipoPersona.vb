Imports EE

Public Class mpTipopersona
    Public Function obtenerTipoPersona(tipo As String) As String

        Dim cadena As String = "select ID_Tipo_Persona as ID from TipoPersona where Descripcion='" & tipo & "'"
        Return cadena
    End Function
End Class

