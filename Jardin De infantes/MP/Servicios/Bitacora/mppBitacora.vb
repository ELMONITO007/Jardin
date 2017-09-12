Imports EE
Public Class mppBitacora
    Inherits MPP(Of Bitacora)

    Public Overrides Function Agregar(unaBitacora As Bitacora) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@NombreUsuario", unaBitacora.getNombreUsuario)
            .Add("@Evento", unaBitacora.getEvento)
            .Add("@Fecha", unaBitacora.getFecha)
            .Add("@DigitoH", unaBitacora.getDVH)
            .Add("@Descripcion", unaBitacora.getDescripcion)

        End With

        Return ht
    End Function

    Public Overrides Function Modificar(unObjeto As Bitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(unObjeto As Bitacora) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(unObjeto As Bitacora) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Evento", unObjeto.getEvento)

        End With

        Return ht
    End Function

    Public Function buscarPorUsuario(unObjeto As Bitacora) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@NombreUsuario", unObjeto.getNombreUsuario)

        End With

        Return ht
    End Function
    Public Function buscarPorEvento(unObjeto As EventoBitacora) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Evento", unObjeto.getDesripcion)

        End With

        Return ht
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Bitacora)
        Dim listaBitacora As New List(Of Bitacora)
        For Each item As DataRow In dt.Rows


            Dim fecha As DateTime = DateTime.Parse(item("Fecha"))
            Dim DVH As String = (CStr(item("DigitoVerificadorH")))
            Dim unaDescripcion As String = (CStr(item("Descripcion")))
            Dim unaPersona As New Persona(CStr(item("Nombre")), CStr(item("Apellido")))
            Dim usuario As New Usuario(CStr(item("nombreUsuario")), unaPersona)
            Dim unEvento As New EventoBitacora(CStr(item("Evento")))


            Dim unaBitacora As New Bitacora(usuario, fecha, unEvento, unaDescripcion, DVH)

            listaBitacora.Add(unaBitacora)

        Next
        Return listaBitacora
    End Function
End Class
