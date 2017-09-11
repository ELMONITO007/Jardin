Imports DAL
Imports MP
Public Class bllEventoBitacoras


    Public Function listarTodo() As List(Of String)
        Dim dal As New dalEventoBitacora
        Dim dt As New DataTable
        Dim mp As New mppEventoBitacora
        dt = dal.leer("gb_VerEventoBitacora")

        Return mp.ListarBitacoras(dt)



    End Function
End Class
