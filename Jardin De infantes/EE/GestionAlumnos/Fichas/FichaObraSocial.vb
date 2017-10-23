Public Class FichaObraSocial
    Private Property unaPersona As Persona
    Private Property Tiene_Obra_Social As Boolean
    Private Property Obra_Social As String
    Private Property Telefono_Emergencia As Integer
    Private Property Numero_Socio As Integer


    Sub New()

    End Sub


    Sub New(_unaPersona As Persona, _Tiene_Obra_Social As Boolean, _Obra_Social As String, _Telefono_Emergencia As Integer, _Numero_Socio As Integer)
        unaPersona = _unaPersona
        Tiene_Obra_Social = _Tiene_Obra_Social
        Obra_Social = _Obra_Social
        Telefono_Emergencia = _Telefono_Emergencia
        Numero_Socio = _Numero_Socio

    End Sub


    Public Function getTiene_Obra_Social() As Boolean
        Return Tiene_Obra_Social
    End Function

    Public Function getObra_Social() As String
        Return Obra_Social
    End Function
    Public Function getTelefono_Emergencia() As Integer
        Return Telefono_Emergencia
    End Function

    Public Function getNumero_Socio() As Integer
        Return Numero_Socio
    End Function


    Public Function getId() As Integer
        Return unaPersona.getID
    End Function
End Class
