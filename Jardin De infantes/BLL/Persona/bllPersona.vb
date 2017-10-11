Imports EE
Imports DAL
Imports MP

Public Class bllPersona
    Inherits bllABM(Of Persona)

    Public Overrides Sub alta(unObjeto As Persona)
        Dim unaDal As New dalPersona

    End Sub

    Public Overrides Sub Baja(unObjeto As Persona)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Modificar(unObjeto As Persona)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function Obtener(unObjeto As Persona) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Listar() As DataTable
        Dim dal As New dalPersona
        Dim mpp As New mppPersona
        Return dal.leer(mpp.listar)
    End Function
End Class
