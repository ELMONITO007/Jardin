Imports EE
Imports System.Data.SqlClient
Imports MP

Public Class dalBitacora(Of bitacora)


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



    Public Sub Escribir(ht As Hashtable, sp As String)
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In ht.Keys
                cmd.Parameters.AddWithValue(item, ht(item))
            Next
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try
        db.cerrarConexion()
    End Sub

    Public Function Buscar(ht As Hashtable, sp As String) As DataTable
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In ht.Keys
                cmd.Parameters.AddWithValue(item, ht(item))
            Next
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()
            Return dt
        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
        db.cerrarConexion()
    End Function
End Class
