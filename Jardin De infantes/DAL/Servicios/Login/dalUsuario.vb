Imports EE

Imports System.Data.SqlClient
Imports MP
Public Class dalUsurio(Of usuario)
    Inherits DAL(Of usuario)

    Private db As Conexion
    Private _cmd As IDbCommand
    Sub New()

        db = New Conexion
    End Sub
    Public Overrides Sub IdatosCompleto_Modificar(HT As Hashtable, sp As String)
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
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

    Public Overrides Sub IdatosCompleto_Eliminar(HT As Hashtable, sp As String)

        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
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

    Public Overrides Sub IdatosCompleto_Agregar(HT As Hashtable, sp As String)

        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
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

    Public Function IdatosCompleto_BuscarIdioma(HT As Hashtable) As List(Of Idioma)
        Try
            Dim cmd As SqlCommand = db.CrearComando


            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_VerIdiomaUsuario"
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
            Next
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()
            Dim mpp As New mppIdioma
            Return mpp.listar(dt)

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
        db.cerrarConexion()
    End Function

    Public Overrides Function IdatosCompleto_Listar() As List(Of usuario)
        Throw New NotImplementedException()
    End Function

    Public Overrides Function IdatosCompleto_Buscar(HT As Hashtable, sp As String) As List(Of usuario)

    End Function

    Public Function BuscarUsuario(ht As Hashtable, sp As String) As DataTable
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
    Public Function VerSiExisteUsuario(HT As Hashtable, sp As String) As Boolean
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
            For Each item As String In HT.Keys
                cmd.Parameters.AddWithValue(item, HT(item))
            Next
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True

            End If


        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return Nothing
        End Try
        db.cerrarConexion()
    End Function

    Public Function Leer(sp As String) As DataTable
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = sp
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
