Imports EE
Imports MetroFramework
Public Class CrearPersona

    Public Sub crearALumno(_dni As Integer, _apellido As String, _nombre As String, _direccion As String)
        Dim resultado As Boolean
        Dim unTipodePersona As New TipoPersona()
        Dim bllTP As New bllTipoPersona()
        unTipodePersona = bllTP.obtenerTipoPersona("Alumno")
        unTipodePersona.setDescripcion("Alumno")

        Dim unAlumno As New Alumno(0, _nombre, _apellido, _dni, _direccion, "", unTipodePersona)
        Dim bll As New bllpersonas

        resultado = bll.alta(unAlumno)



        If resultado = True Then
            MsgBox("Se agrego al Alumno " & _nombre & " " & _apellido, vbInformation + vbOKOnly, "Alta Alumno")
        Else
            MsgBox("El alumno " & _nombre & " " & _apellido & " ya existe", vbObjectError + vbOKOnly, "Alta Alumno")
        End If

    End Sub

End Class