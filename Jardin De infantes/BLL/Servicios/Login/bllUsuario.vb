Imports EE
Imports MP
Imports DAL
Public Class bllUsuario
    Dim usuario As New Usuario

    Public Sub ModificarIdioma(unIdioma As Idioma, unusuario As Usuario)
        unusuario.ModificarIdioma(unIdioma)
        Dim mpp As New mppUsuario
        Dim ht As New Hashtable
        Dim dal As New dalUsurio(Of Usuario)
        ht = mpp.ModificarIdioma(unusuario)
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
        For Each usuario In Lista
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

    Public Function VerificarContraseña(contreseña As String) As Boolean
        Dim a As String = encriptarCOntraseña(contreseña)
        Dim b As String = usuario.getCOntrasenia
        If encriptarCOntraseña(contreseña) = usuario.getCOntrasenia Then
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

    Public Function obtenerUsuario(nombreUsuario As String) As Usuario
        Dim dal As New dalUsurio(Of Usuario)
        Dim ht As New Hashtable
        Dim mpp As New mppUsuario
        Dim dt As New DataTable
        Dim lista As New List(Of Usuario)

        ht = mpp.BuuscarUnUsuario(nombreUsuario)
        dt = dal.BuscarUsuario(ht, "sp_VerUsuario")
        lista = mpp.listar(dt)
        For Each unUsuario In lista
            usuario = lista.Item(0)
        Next
        Return usuario

    End Function
    Public Function obtenerDatoDVH(unUsuario As Usuario) As String
        Dim dal As New dalUsurio(Of Usuario)
        Dim ht As New Hashtable
        Dim mpp As New mppUsuario
        Dim dt As New DataTable


        ht = mpp.BuuscarUnUsuario(unUsuario.getNombreUsuario)
        dt = dal.BuscarUsuario(ht, "dv_Usuario")
        Return mpp.obtenerString(dt)

    End Function
    Public Function verificarDVH(unUsuario As Usuario) As Boolean
        Dim hash As New DigitoVerificadorH(obtenerDatoDVH(unUsuario), sessionManager.intance.getUsuario.getDVH)
        Return hash.VerificadorDigitoVerificadorH


    End Function
    Public Sub ModificarDVH(unUsuario As Usuario)
        Dim ValorAHashear As String = obtenerDatoDVH(unUsuario)
        Dim dal As New dalUsurio(Of Usuario)
        Dim ht As New Hashtable
        Dim mpp As New mppUsuario
        Dim encriptar As New EncriptarSHA5(ValorAHashear)
        unUsuario.ModificarDVH(encriptar.Hashear)

        ht = mpp.ModificarDVH(unUsuario)
        dal.IdatosCompleto_Modificar(ht, "dv_ModificarDVH")



    End Sub

    Public Function VerificarCompletoUsuario(contraseña As String, nombreUsuario As String, idioma As String) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(nombreUsuario)





        'Dim digitoVerificador As Boolean = verificarDigitoVerificadorH(unUsuario)
        If existeusuario = False Then
            Return False
            Exit Function
        Else
            Dim unUsuario As New Usuario(nombreUsuario)
            Dim unIdioma As New Idioma(idioma)
            ModificarIdioma(unIdioma, unUsuario)
            ModificarDVH(unUsuario)
            sessionManager.intance.login(obtenerUsuario(nombreUsuario))

            If VerificarContraseña(contraseña) = True Then
                If verificarDVH(sessionManager.intance.getUsuario) = True Then


                    Return True
                Else
                    sessionManager.intance.Logout()

                End If
            Else
                sessionManager.intance.Logout()
                Return False
            End If

        End If
        'If existeusuario = True And ContraseñaCorrecta = True And digitoVerificador = True Then
        '    Return True
        'Else
        '    Return False
        'End If


    End Function


End Class
