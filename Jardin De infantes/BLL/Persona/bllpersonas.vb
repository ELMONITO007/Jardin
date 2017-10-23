Imports EE
Imports DAL
Imports MP

Public Class bllpersonas
    Inherits bllABM(Of Personas)

    Public Overrides Function alta(unObjeto As Personas) As Boolean

        Dim dt As New DataTable
        dt = Obtener(unObjeto)
        If dt.Rows.Count = 0 Then
            Dim dal As New dalPersona
            Dim mp As New mppPersona
            dal.Escribir(mp.altaPersona(unObjeto))
            ObtenerDigitoVerificador(unObjeto)
            Return True
        Else
            Return False
        End If



    End Function


    Public Overrides Function Obtener(unObjeto As Personas) As DataTable
        Dim dal As New dalPersona
        Dim mp As New mppPersona
        Return dal.leer(mp.BuscarPErsona(unObjeto))

    End Function

    Public Overrides Function Listar() As DataTable
        Dim dal As New dalPersona
        Dim mp As New mppPersona
        Return dal.leer(mp.listar)
    End Function

    Public Overrides Function Baja(unObjeto As Personas) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Modificar(unObjeto As Personas) As Boolean
        Throw New NotImplementedException()
    End Function

    Public Sub ObtenerDigitoVerificador(unObjeto As Personas)
        Dim dal As New dalPersona
        Dim mp As New mppPersona
        Dim dt As New DataTable
        dt = dal.leer(mp.BuscarPErsona(unObjeto))
        For Each item As DataRow In dt.Rows
            unObjeto.setID(CInt(item("ID")))
            Exit For
        Next
        Dim dvh As New DigitoVerificadorH(unObjeto.obtenerTodoJunto)
        unObjeto.setDVH(dvh.GenerarDigitoVerificadorH)
        Dim dal2 As New dalPersona
        dal.Escribir(mp.EscribirDVH(unObjeto))

    End Sub
End Class
