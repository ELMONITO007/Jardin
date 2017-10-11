Imports DAL
Imports MP
Public Class blltipoPersona
    Public Function ObtenerTipoPersona() As DataTable
        Dim dt As New DataTable
        Dim dal As New dalTipoPersona
        Dim mp As New mppTipoPersona
        dt = dal.leer(mp.obtenerListaTipoPersona)
        Return dt
    End Function
End Class
