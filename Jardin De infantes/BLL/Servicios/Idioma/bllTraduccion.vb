Imports EE
Imports DAL
Imports MP
Public Class bllTraduccion
    Public Function ListarPalabrasTraducidas(unaTraduccion As Traduccion) As Hashtable
        Dim ht As New Hashtable
        Dim maperHT As New Hashtable
        Dim maper As New mppTraduccion
        Dim dal As New dalTraduccion(Of Traduccion)
        maperHT = maper.Buscar(unaTraduccion)
        ht = dal.IdatosCompletoHT_Buscar(maperHT)




        Return ht
    End Function


    Public Function AgregarTraduccion(lista As List(Of Traduccion)) As Boolean
        For Each item As Traduccion In lista
            Dim dal As New dalTraduccion(Of Traduccion)
            Dim cadena = "declare @id int declare @Idioma int select @id=ID_Palabra from Palabra where Palabra='" & item.getPalabra.getPalabra & "'select @Idioma =ID_Idioma from Idioma where Idioma='" & item.getIdioma & "' insert into Traduccion (Palabra,ID_Idioma,ID_Palabra)values ('" & item.getTraduccion & "',@Idioma,@id)"
            dal.Escribir(cadena)
        Next


    End Function



End Class
