Imports EE
Imports MP
Imports DAL
Public Class bllUsuario


    Dim usuario As New Usuario


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

    Public Function obtenerListaUsuario() As DataTable
        Dim mpp As New mppUsuario
        Dim DT As New DataTable
        Dim dal As New dalUsurio(Of Usuario)
        DT = dal.Leer("gu_ListarUsuarios")
        Return DT

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

    Public Function verificarDVH(unUsuario As Usuario) As Boolean
        Dim hash As New DigitoVerificadorH(unUsuario.getObtenerTodoJunto, sessionManager.intance.getUsuario.getDVH)
        Return hash.VerificadorDigitoVerificadorH


    End Function
    Public Sub ModificarDVH(unUsuario As Usuario)
        Try
            Dim ValorAHashear As String = unUsuario.getObtenerTodoJunto
            Dim dal As New dalUsurio(Of Usuario)
            Dim ht As New Hashtable
            Dim mpp As New mppUsuario
            Dim encriptar As New EncriptarSHA5(ValorAHashear)
            unUsuario.ModificarDVH(encriptar.Hashear)

            ht = mpp.ModificarDVH(unUsuario)
            dal.IdatosCompleto_Modificar(ht, "dv_ModificarDVH")
        Catch ex As Exception
            MsgBox(ex.Message,, "Error")
        End Try




    End Sub



    Public Function VerificarCompletoUsuario(contraseña As String, nombreUsuario As String, idioma As String) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(nombreUsuario)

        Dim unabllBitacora As bllBitacora




        'Dim digitoVerificador As Boolean = verificarDigitoVerificadorH(unUsuario)
        If existeusuario = False Then
            Return False
            Exit Function
        Else

            Dim unUsuario As New Usuario(nombreUsuario)

            sessionManager.intance.login(obtenerUsuario(nombreUsuario))

            If sessionManager.intance.getUsuario.getHabilitado = True Then
                If VerificarContraseña(contraseña) = True Then
                    unabllBitacora = New bllBitacora
                    unabllBitacora.altaBitacora("Login", "Se logueo Correctamente")
                    If verificarDVH(sessionManager.intance.getUsuario) = True Then


                        Return True
                    Else
                        unabllBitacora = New bllBitacora
                        unabllBitacora.altaBitacora("Error Digito Verificador Horizontal", "error en la consistencia de datos al loguearse")

                        sessionManager.intance.Logout()
                        Return False
                    End If
                Else
                    unabllBitacora = New bllBitacora
                    unabllBitacora.altaBitacora("Contraseña incorrecta", "Se ha ingresado mal la contraseña")
                    unabllBitacora.altaBitacora("Contraseña incorrecta", "Ha ingresado una contraseña erronea")
                    sessionManager.intance.Logout()
                    Return False
                End If
            End If

            If VerificarContraseña(contraseña) = True Then
                unabllBitacora = New bllBitacora
                unabllBitacora.altaBitacora("Login", "Se logueo Correctamente")
                If verificarDVH(sessionManager.intance.getUsuario) = True Then


                    Return True
                Else
                    unabllBitacora = New bllBitacora
                    unabllBitacora.altaBitacora("Error Digito Verificador Horizontal", "error en la consistencia de datos al loguearse")

                    sessionManager.intance.Logout()
                    Return False
                End If
            Else
                unabllBitacora = New bllBitacora
                unabllBitacora.altaBitacora("Contraseña incorrecta", "Se ha ingresado mal la contraseña")
                unabllBitacora.altaBitacora("Contraseña incorrecta", "Ha ingresado una contraseña erronea")
                sessionManager.intance.Logout()
                Return False
            End If

        End If


    End Function


    Public Function altaUsuario(unUsuario As Usuario) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(unUsuario.getNombreUsuario)
        If existeusuario = False Then
            unUsuario.setContraseña(encriptarCOntraseña(unUsuario.getCOntrasenia))
            Dim mpp As New mppUsuario
            Dim dal As New dalUsurio(Of Usuario)
            dal.IdatosCompleto_Agregar(mpp.Agregar(unUsuario), "gu_AltaUsuario")
            ModificarDVH(unUsuario)


            Return True
        Else
            Return False
        End If


    End Function


    Public Function BajaUsuario(unUsuario As Usuario) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(unUsuario.getNombreUsuario)

        If existeusuario = True Then

            Dim mpp As New mppUsuario
            Dim dal As New dalUsurio(Of Usuario)
            dal.IdatosCompleto_Eliminar(mpp.Eliminar(unUsuario), "gu_EliminarUsuario")


            Dim unaBitacora As New bllBitacora()
            unaBitacora.altaBitacora("Baja Usuario", "Se dio de baja")

            Return True
        Else
            Return False
        End If

    End Function

    Public Function ModificarUsuario(unUsuario As Usuario) As Boolean
        Dim existeusuario As Boolean = VerificarUsuario(unUsuario.getNombreUsuario)
        Try
            If existeusuario = True Then
                unUsuario.setContraseña(encriptarCOntraseña(unUsuario.getCOntrasenia))
                Dim mpp As New mppUsuario
                Dim unadal As New dalUsurio(Of Usuario)
                unadal.IdatosCompleto_Modificar(mpp.Modificar(unUsuario), "gu_ModificarUsuario")
                ModificarDVH(unUsuario)

                Dim unaBitacora As New bllBitacora()
                unaBitacora.altaBitacora("Modificar Usuario", "Se Modifico")
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message,, "Error")
        End Try

    End Function

End Class
