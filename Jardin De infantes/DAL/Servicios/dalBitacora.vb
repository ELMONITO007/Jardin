Public Class dalBitacora
    Inherits DAL
    Private db As Conexion
    Private _cmd As IDbCommand


    Sub New()
        db = New Conexion

    End Sub


    Public Overrides Sub Modificar(HT As Hashtable)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Eliminar(HT As Hashtable)
        Throw New NotImplementedException()
    End Sub

    Public Overrides Sub Agregar(HT As Hashtable)
        Try
            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "AgregarBitacora"


        Catch ex As Exception

        End Try


    End Sub

    Public Overrides Function Buscar(ID As Integer) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Listar() As DataTable
        Throw New NotImplementedException()
    End Function
End Class
