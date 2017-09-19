
Imports System.Data.SqlClient
Imports MP
Public Class dalTraduccion(Of Traduccion)
    Inherits DAL(Of Traduccion)

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

    Public Function IdatosCompletoHT_Buscar(HT As Hashtable) As Hashtable
        Try

            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_ListarPalabrasPorIdioma"
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
            Next
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()

            Dim mapear As New mppTraduccion
            Return mapear.listarHT(dt)

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
        db.cerrarConexion()
    End Function

    Public Overrides Function IdatosCompleto_Listar() As List(Of Traduccion)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IdatosCompleto_Buscar(HT As Hashtable, sp As String) As List(Of Traduccion)
        Throw New NotImplementedException()
    End Function

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
End Class
