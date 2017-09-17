Imports EE

Public Class mppPersona
    Public Function listar() As String
        Dim cadena As String = "select Legajo,Nombre,Apellido,DNI,Direccion,DigitoVerificadorH  from Persona"
        Return cadena
    End Function


End Class
