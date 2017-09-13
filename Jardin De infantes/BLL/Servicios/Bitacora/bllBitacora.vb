Imports EE
Imports DAL
Imports MP
Public Class bllBitacora

    Public Function generarDVH(unaBItacora As Bitacora) As String
        Dim dal As New dalBitacora(Of Bitacora)
        Dim mp As New mppBitacora
        Dim dt As New DataTable
        Dim ht As New Hashtable
        Dim digitoSinHash As String

        ht = mp.obtenerDatoDVH(unaBItacora)
        dt = dal.Buscar(ht, "dv_Bitacora")
        digitoSinHash = mp.obtenerString(dt)
        Dim generarDigitoH As New DigitoVerificadorH(digitoSinHash)
        Return generarDigitoH.GenerarDigitoVerificadorH


    End Function

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
            Return Nothing
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
    Public Sub altaBitacora(unEvento As String, descripcion As String)
        Dim unEventoBitacora As New EventoBitacora(unEvento)
        Dim dal As dalBitacora(Of Bitacora)
        Dim mp As New mppBitacora
        Dim ht As New Hashtable
        Dim unaBItacora As New Bitacora(sessionManager.intance.getUsuario, DateTime.Now, unEventoBitacora, descripcion, "")
        ht = mp.Agregar(unaBItacora)
        dal = New dalBitacora(Of Bitacora)
        dal.Escribir(ht, "gb_AltaBitacora")
        unaBItacora.modificarDVH(generarDVH(unaBItacora))
        ht = mp.AgregarDVH(unaBItacora)
        dal = New dalBitacora(Of Bitacora)
        dal.Escribir(ht, "gb_ModificarDVH")
    End Sub
End Class
