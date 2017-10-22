Imports DAL
Imports EE
Imports MP

Public Class bllTipoPersona

    Public Function obtenerTipoPersona(tipo As String) As TipoPersona
        Dim dal As New dalPersona
        Dim mpp As New mpTipopersona
        Dim dt As New DataTable
        Dim id As Integer = 0
        dt = dal.leer(mpp.obtenerTipoPersona(tipo))
        For Each item As DataRow In dt.Rows
            id = CInt(item("ID"))
        Next
        Dim unTipoDePersona As New TipoPersona(tipo)
        unTipoDePersona.setID(id)

        Return unTipoDePersona
    End Function

End Class

