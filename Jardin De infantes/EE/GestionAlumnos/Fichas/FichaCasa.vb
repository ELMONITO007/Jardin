Public Class FichaCasa
    Private Property unaPersona As Persona
    Private Property Vive_Casa As Boolean
    Private Property Vive_Departamento As Boolean
    Private Property Vive_Barrio_Cerrado As Boolean
    Private Property Tiene_Habitacion_Propia As Boolean
    Private Property Tiene_Patio As Boolean


    Sub New()

    End Sub


    Sub New(_unaPersona As Persona, _Vive_Casa As Boolean, _Vive_Departamento As Boolean, _Vive_Barrio_Cerrado As Boolean, _Tiene_Habitacion_Propia As Boolean, _Tiene_Patioa As Boolean)
        unaPersona = _unaPersona
        Vive_Casa = _Vive_Casa
        Vive_Departamento = _Vive_Departamento
        Vive_Barrio_Cerrado = _Vive_Barrio_Cerrado
        Tiene_Habitacion_Propia = _Tiene_Habitacion_Propia
        Tiene_Patio = _Tiene_Patio
    End Sub


    Public Function getVive_Casa() As Boolean
        Return Vive_Casa
    End Function

    Public Function getVive_Departamento() As Boolean
        Return Vive_Departamento
    End Function
    Public Function getVive_Barrio_Cerrado() As Boolean
        Return Vive_Barrio_Cerrado
    End Function

    Public Function getTiene_Habitacion_Propia() As Boolean
        Return Tiene_Habitacion_Propia
    End Function
    Public Function getTiene_Patio() As Boolean
        Return Tiene_Patio
    End Function



    Public Function getId() As Integer
        Return unaPersona.getID
    End Function
End Class
