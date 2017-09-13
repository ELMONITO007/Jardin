Imports System.Data.SqlClient

Public Class dalDigitoVerificadorV

    Private db As Conexion
    Private _cmd As IDbCommand


    Sub New()
        db = New Conexion

    End Sub


    Public Function leer(cadena As String) As DataTable
        Try

            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.Text
            cmd.CommandText = cadena
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()



            Return dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error ")
            Return Nothing
        End Try

    End Function



    Public Sub Escribir(cadena As String)
        Try

            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = cadena

            cmd.ExecuteNonQuery()

            db.RealizarCommit()

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub
End Class
