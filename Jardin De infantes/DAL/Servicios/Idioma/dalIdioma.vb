Imports EE
Imports System.Data.SqlClient
Imports MP
Public Class dalIdioma
    Inherits DAL(Of Idioma)

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


    Public Overrides Function IdatosCompleto_Listar() As List(Of Idioma)

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

    Public Overrides Function IdatosCompleto_Buscar(HT As Hashtable) As List(Of Idioma)
        Throw New NotImplementedException()
    End Function
End Class
