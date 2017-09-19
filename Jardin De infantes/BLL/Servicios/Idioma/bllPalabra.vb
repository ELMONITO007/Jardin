Imports DAL
Public Class bllPalabra
    Public Function ListarPalabras() As DataTable

        Dim dt As New DataTable
        Dim dal As New dalPalabra
        Dim cadena As String = "select Palabra from palabra"
        dt = dal.Leer(cadena)



        '         "declare @id int declare @Idioma int
        '	select @id=ID_Palabra from Palabra where Palabra='Aceptar'
        'select @Idioma =ID_Idioma from Idioma where Idioma='FR-fr'
        'insert into Traduccion (Palabra,ID_Idioma,ID_Palabra)values ('Francecito',@Idioma,@id) "

        Return dt
    End Function
End Class
