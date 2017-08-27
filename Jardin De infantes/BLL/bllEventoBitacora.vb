Imports EE
Imports DAL
Public Class bllEventoBitacora
    Public Function ListarEventos() As List(Of EventoBitacora)
        Dim dal As New dalEventoBitacora
        Dim listaEventos As New List(Of EventoBitacora)
        listaEventos = dal.IdatosCompleto_Listar
        Return listaEventos


    End Function
    'Public Function ListarEventos() As DataTable
    '    Dim dal As New dalEventoBitacora
    '    Return dal.Listar

    'End Function
End Class
