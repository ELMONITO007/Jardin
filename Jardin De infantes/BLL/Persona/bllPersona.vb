Imports EE
Imports DAL
Imports MP

Public Class bllPersona
    Inherits bllABM(Of Persona)

    Public Overrides Function alta(unObjeto As Persona) As Boolean
        Dim unaDal As New dalPersona
        Dim unaBll As New bllPersona



    End Function



    Public Overrides Function Listar() As DataTable

    End Function

    Public Overrides Function Baja(unObjeto As Persona) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As Persona) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Obtener(unObjeto As Persona) As DataTable
        Throw New NotImplementedException()
    End Function

End Class
