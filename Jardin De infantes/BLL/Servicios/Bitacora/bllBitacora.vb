Imports EE
Imports DAL
Imports MP
Public Class bllBitacora
    Public Function listarTodo() As DataTable
        Dim dal As New dalBitacora(Of Bitacora)
        Dim mp As New mppBitacora
        Return dal.leer("gb_VerBitacoraCompleto")



    End Function
    Public Function listarPorUsuario(unUsuario As String) As DataTable
        Try
            Dim dal As New dalBitacora(Of Bitacora)
            Dim mp As New mppUsuario
            Dim dt As New DataTable
            Dim ht As New Hashtable
            ht = mp.BuuscarUnUsuario(unUsuario)

            Return dal.Buscar(ht, "gb_VerBitacoraPorUsuario")
        Catch ex As Exception
            MsgBox("No selecciono ningun usuario", vbAbort, "Error")
        End Try




    End Function


    Public Function listarPorEvento(unEvento As String) As DataTable

        Dim dal As New dalBitacora(Of Bitacora)
        Dim mp As New mppBitacora
        Dim elEvento As New EventoBitacora(unEvento)
        Dim ht As New Hashtable
        ht = mp.buscarPorEvento(elEvento)

        Return dal.Buscar(ht, "gb_VerBitacoraPorEvento")



    End Function
End Class
