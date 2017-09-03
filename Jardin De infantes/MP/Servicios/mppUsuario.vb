Imports EE
Public Class mppUsuario
    Inherits MPP(Of Usuario)

    Public Overrides Function Agregar(unObjeto As Usuario) As Hashtable

    End Function

    Public Overrides Function Modificar(unObjeto As Usuario) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(unObjeto As Usuario) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(unObjeto As Usuario) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Usuario", unObjeto.getUsuario)
        End With
        Return ht
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Usuario)
        Throw New NotImplementedException()
    End Function

    Public Function ModificarIdioma(dt As Usuario) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Usuario", dt.getUsuario)
            .Add("@idioma", dt.getIdiomas)
        End With

        Return ht
    End Function
End Class
