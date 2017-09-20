﻿Imports System.Configuration
Imports System.Data.SqlClient
Public Class dalFamilia
    Private db As Conexion
    Private _cmd As IDbCommand
    Sub New()

        db = New Conexion
    End Sub

    Public Function Leer(cadena As String) As DataTable
        Try
            Dim cmd As SqlCommand = db.CrearComando

            cmd.CommandType = CommandType.Text
            cmd.CommandText = cadena
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
