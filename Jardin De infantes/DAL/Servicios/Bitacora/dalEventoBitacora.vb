Imports System.Data.SqlClient
Imports DAL
Imports EE
Imports MP

Public Class dalEventoBitacora

    Private db As Conexion
    Private _cmd As IDbCommand


    Sub New()
        db = New Conexion

    End Sub
    Public Function leer(sp As String) As DataTable
        Try
            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()



            Return dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al ver Idiomas")
            Return Nothing
        End Try
    End Function





End Class
