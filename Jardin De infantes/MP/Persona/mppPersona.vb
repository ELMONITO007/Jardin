Imports EE

Public Class mppPersona
    Public Function listar() As String
        Dim cadena As String = "select Legajo,Nombre,Apellido,DNI,Direccion,DigitoVerificadorH  from Persona"
        Return cadena
    End Function

    Public Function altaPersona(unaPersona As Personas) As String


        Dim cadena As String = "insert into Persona(Nombre,Apellido,Direccion,DNI,ID_Tipo_Persona)values('" & unaPersona.getNombre & "','" & unaPersona.getApellido & "','" & unaPersona.getDireccion & "'," & unaPersona.getDni & "," & unaPersona.getTipoPErsona & ")"
        Return cadena
    End Function


    Public Function BuscarPErsona(unaPersona As Personas) As String
        Dim cadena As String = "select Legajo as ID,Nombre,Apellido,DNI,Direccion,Descripcion from Persona as p join TipoPersona as tp on p.ID_Tipo_Persona=tp.ID_Tipo_Persona where dni=" & unaPersona.getDni
        Return cadena
    End Function
    Public Function EscribirDVH(unaPersona As Personas) As String
        Dim cadena As String = "update Persona set DigitoVerificadorH='" & unaPersona.getDVH & "' where DNI=" & unaPersona.getDni
        Return cadena
    End Function
End Class
