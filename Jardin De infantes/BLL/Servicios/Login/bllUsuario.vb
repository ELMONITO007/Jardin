Imports EE
Imports MP
Imports DAL
Public Class bllUsuario
    Dim usuario As Usuario

    Public Sub ModificarIdioma(unUsuario As Usuario)
        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dal As New dalUsurio(Of Usuario)
        ht = mpp.ModificarIdioma(unUsuario)
        dal.IdatosCompleto_Modificar(ht, "p_CambiarIdiomaUsuario")

    End Sub
    Public Function BuscarUsuario(nombreUsuario As String) As Usuario

        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dal As New dalUsurio(Of Usuario)
        Dim Lista As New List(Of Usuario)
        ht = mpp.BuuscarUnUsuario(nombreUsuario)
        Lista = dal.IdatosCompleto_Buscar(ht, "sp_VerUsuario")
        Dim _usuario As New Usuario
        For Each _usuario In Lista
            _usuario = Lista.Item(0)

        Next
        Return _usuario


    End Function



    Public Function VerificarUsuario(NombreUsuario As String) As Boolean
        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dal As New dalUsurio(Of Usuario)

        ht = mpp.BuuscarUnUsuario(NombreUsuario)

        Return dal.VerSiExisteUsuario(ht, "sp_VerUsuario")
    End Function


    Public Function encriptarCOntraseña(contraseña As String) As String
        Dim encriptar As New EncriptarSHA256(contraseña)
        Return encriptar.Hashear()
    End Function

    Public Function VerificarContraseña(contreseña As String, unUsuario As Usuario) As Boolean
        If contreseña = unUsuario.getCOntrasenia Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function VerificarBLoqueado(unUsuario As Usuario) As Boolean
        If unUsuario.getBLoqueado = True Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function verificarDigitoVerificadorH(unUsuario As Usuario) As Boolean
        Dim DVH As New DigitoVerificadorH(unUsuario.getObtenerTodoJunto, unUsuario.getDVH)
        Return DVH.VerificadorDigitoVerificadorH



    End Function



    Public Function VerificarCompletoUsuario(contraseña As String, nombreUsuario As String) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(nombreUsuario)



        'Dim Contraseñaencriptada As String = encriptarCOntraseña(contraseña)
        'Dim ContraseñaCorrecta As Boolean = VerificarContraseña(Contraseñaencriptada, unUsuario)
        'Dim digitoVerificador As Boolean = verificarDigitoVerificadorH(unUsuario)
        If existeusuario = False Then
            Return False
            Exit Function
        Else

            Return True


        End If
        'If existeusuario = True And ContraseñaCorrecta = True And digitoVerificador = True Then
        '    Return True
        'Else
        '    Return False
        'End If


    End Function


End Class
