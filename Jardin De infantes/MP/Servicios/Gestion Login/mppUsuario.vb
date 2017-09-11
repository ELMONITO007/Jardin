Imports EE
Public Class mppUsuario
    Inherits MPP(Of Usuario)

    Public Overrides Function Agregar(unObjeto As Usuario) As Hashtable

    End Function

    Public Overrides Function Modificar(unObjeto As Usuario) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Eliminar(unObjeto As Usuario) As Hashtable
        Throw New NotImplementedException()
    End Function

    Public Overrides Function Buscar(unObjeto As Usuario) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Usuario", unObjeto.getUsuario)
        End With
        Return ht
    End Function

    Public Overrides Function listar(dt As DataTable) As List(Of Usuario)

        Dim lista As New List(Of Usuario)
        For Each item As DataRow In dt.Rows


            Dim empleado As New Persona(CStr(item("nombre")), CStr(item("nombre")))
            Dim unUsuario = New Usuario(CStr(item("NombreUsuario")), CStr(item("Contraseña")), Integer.Parse(item("IntentosFallidos")), Boolean.Parse(item("Logueado")), CStr(item("DigitoVerificadorH")), Boolean.Parse(item("bloqueado")), empleado)
            lista.Add(unUsuario)
        Next
        Return lista
    End Function


    Public Function BuuscarUnUsuario(NombreUsuario As String) As Hashtable
        Dim ht As New Hashtable
        ht.Add("@NombreUsuario", NombreUsuario)
        Return ht

    End Function

    Public Function obtenerString(dt As DataTable) As String
        Dim resultados As String = ""
        For Each item As DataRow In dt.Rows
            resultados = CStr(item("DGV"))
        Next
        Return resultados
    End Function

    Public Function ModificarDVH(unUsuario As Usuario) As Hashtable
        Dim ht As New Hashtable
        With ht
            .Add("@Usuario", unUsuario.getNombreUsuario)
            .Add("@DVH", unUsuario.getDVH)
        End With
        Return ht
    End Function

    Public Function listarUsuario(dt As DataTable) As List(Of String)
        Dim lista As New List(Of String)
        For Each item As DataRow In dt.Rows

            lista.Add(CStr(item("NombreUsuario")))
        Next

        Return lista
    End Function

End Class
