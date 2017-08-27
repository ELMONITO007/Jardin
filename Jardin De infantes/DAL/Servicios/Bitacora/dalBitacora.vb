Imports DAL

Public Class dalBitacora(Of dalEventoBitacora)
    Inherits DAL(Of dalEventoBitacora)

    Private db As Conexion
    Private _cmd As IDbCommand


    Sub New()
        db = New Conexion

    End Sub

    Public Overrides Sub IdatosCompleto_Modificar(HT As Hashtable)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IdatosCompleto_Eliminar(HT As Hashtable)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub IdatosCompleto_Agregar(HT As Hashtable)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function IdatosCompleto_Buscar(ID As Integer) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IdatosCompleto_Listar() As List(Of dalEventoBitacora)
        'Try

        '    Dim cmd As IDbCommand = db.CrearComando
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.CommandText = "AgregarBitacora"
        '    db.RealizarCommit()


        'Catch ex As Exception
        '    db.RealizarRollBack()
        'End Try
        Return Nothing
    End Function
End Class
