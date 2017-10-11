Imports EE

Public Class mppTelefono
    Public Function altaTelefono(unTelefono As Telefono) As String
        Dim cadena As String = "insert into Telefono (Codigo_Pais,Numero,Descripcion)values (" & unTelefono.getDescripcion & "," & unTelefono.getNumero & "," & unTelefono.getDescripcion & ")"
        Return cadena
    End Function

    Public Function obtenerUnTelefono(unTelefono As Telefono) As String
        Dim cadena As String = "select ID_Telefono as ID,Codigo_Pais,Numero,Descripcion from Telefono where Codigo_Pais=" & unTelefono.getCodigoPais & " and numero=" & unTelefono.getNumero
        Return cadena
    End Function

End Class
