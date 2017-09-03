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



End Class
