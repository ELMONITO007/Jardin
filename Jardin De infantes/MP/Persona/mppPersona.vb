Imports EE

Public Class mppPersona
    Public Function listar() As String
        Dim cadena As String = "select Legajo,Nombre,Apellido,DNI,Direccion,DigitoVerificadorH  from Persona"
        Return cadena
    End Function

    Public Function altaPersona(unaPersona As Personas) As String
        Dim cadena As String = "insert into Persona(Nombre,Apellido,Direccion,DNI,ID_Tipo_Persona)values('" & unaPersona.getNombre & "','" & unaPersona.getApellido & "','" & unaPersona.getDireccion & "'," & unaPersona.getDni & "," & unaPersona.getTipoPErsona.getID & ")"
        Return cadena
    End Function

End Class
