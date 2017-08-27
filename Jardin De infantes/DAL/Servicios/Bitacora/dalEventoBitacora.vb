Imports System.Data.SqlClient
Imports DAL
Imports EE
Imports MP

Public Class dalEventoBitacora
    Inherits DAL(Of EventoBitacora)


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

    Public Overrides Function IdatosCompleto_Listar() As List(Of EventoBitacora)
        Try
            Dim listaEventos As New List(Of EventoBitacora)
            Dim cmd As IDbCommand = db.CrearComando
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "p_VerEventoBitacora"
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            db.RealizarCommit()

            Dim mapear As New mppEventoBitacora
            listaEventos = mapear.listar(dt)
            Return listaEventos

        Catch ex As Exception
            db.RealizarRollBack()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al ver la bitacora")
            Return Nothing
        End Try
        db.cerrarConexion()
    End Function




End Class
