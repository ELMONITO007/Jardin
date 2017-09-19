Imports EE
Imports System.Data.SqlClient
Imports MP
Public Class dalIdioma

    Private db As Conexion
    Private _cmd As IDbCommand

    Sub New()
        db = New Conexion

    End Sub
    Public Sub Escribir(cadena As String)
        Try

            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = cadena

            cmd.ExecuteNonQuery()

            db.RealizarCommit()

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")

        End Try

    End Sub



    Public Function IdatosCompleto_Listar() As List(Of Idioma)

        Try
            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_ListarIdioma"
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()
            Dim mapear As New mppIdioma
            Dim listaIdiomas As New List(Of Idioma)
            listaIdiomas = mapear.listar(dt)
            Return listaIdiomas
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error al ver Idiomas")
            Return Nothing
        End Try
    End Function


End Class
