Public Class TelefonoAlumno
    Private Property unaPersona As Persona
    Private Property unTelefono As List(Of Telefono)

    Public Sub AgregarTelefono(unNuevoTelefono As Telefono)
        unTelefono.Add(unNuevoTelefono)
    End Sub
    Sub New()

    End Sub


    Sub New(laPersona As Persona)
        unaPersona = laPersona
    End Sub
End Class
