Imports EE

Public Class dalBitacora(Of bitacora)
    Inherits DAL(Of bitacora)

    Private db As Conexion
    Private _cmd As IDbCommand


    Sub New()
        db = New Conexion

    End Sub

    Public Overrides Sub IdatosCompleto_Modificar(HT As Hashtable, sp As String)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IdatosCompleto_Eliminar(HT As Hashtable, sp As String)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IdatosCompleto_Agregar(HT As Hashtable, sp As String)
        Throw New NotImplementedException()
    End Sub


    Public Overrides Function IdatosCompleto_Listar() As List(Of bitacora)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IdatosCompleto_Buscar(HT As Hashtable, sp As String) As List(Of bitacora)
        Throw New NotImplementedException()
    End Function
End Class
