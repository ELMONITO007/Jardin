
Imports System.Data.SqlClient
Imports System.Configuration



Public Class Conexion
    Private _transaccion As IDbTransaction
    Private _conexion As IDbConnection
    Public Sub New()
        _conexion = New SqlConnection(ConfigurationManager.ConnectionStrings("Notebook").ConnectionString)
        _conexion.Open()

        _transaccion = _conexion.BeginTransaction()


    End Sub
    Public Sub abrirconexion()
        _conexion.Open()
    End Sub
    Public Function CrearComando() As IDbCommand
        Dim cmd As New SqlCommand
        cmd = _conexion.CreateCommand
        cmd.Transaction = _transaccion
        Return cmd

    End Function

    Public Sub RealizarCommit()
        _transaccion.Commit()

    End Sub

    Public Sub RealizarRollBack()
        '_transaccion.Rollback()

    End Sub

    Public Sub cerrarConexion()
        _conexion.Close()

    End Sub
End Class


