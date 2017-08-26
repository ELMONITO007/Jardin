Imports System.Data.SqlClient
Public Class dalEventoBitacora
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
        Throw New NotImplementedException()
    End Sub

    Public Overrides Function Buscar(ID As Integer) As DataTable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Listar() As DataTable

        Try
            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_VerEventoBitacora"
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()
            db.cerrarConexion()
            Return dt

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al ver la bitacora")
            Return Nothing
        End Try
    End Function
End Class
