Public Class FichaEnfermedades
    Private Property unaPersona As Persona
    Private Property Tuvo_Enfermedades As Boolean
    Private Property Hepatitis_A As Boolean
    Private Property Hepatitis_B As Boolean
    Private Property Diabetes As Boolean
    Private Property Asma As Boolean
    Private Property Hipertension As Boolean
    Private Property Observaciones As String
    Sub New()

    End Sub


    Sub New(_unaPersona As Persona, _Tuvo_Enfermedades As Boolean, _Hepatitis_A As Boolean, _Hepatitis_B As Boolean, _Diabetes As Boolean, _Asma As Boolean, _Hipertensiona As Boolean, _Observaciones As String)
        unaPersona = _unaPersona
        Tuvo_Enfermedades = _Tuvo_Enfermedades
        Hepatitis_A = _Hepatitis_A
        Hepatitis_B = _Hepatitis_B
        Diabetes = _Diabetes
        Asma = _Asma
        Hipertension = _Hipertensiona
        Observaciones = _Observaciones

    End Sub


    Public Function getTuvo_Enfermedades() As Boolean
        Return Tuvo_Enfermedades
    End Function

    Public Function getHepatitis_A() As Boolean
        Return Hepatitis_A
    End Function
    Public Function getHepatitis_B() As Boolean
        Return Hepatitis_B
    End Function

    Public Function getDiabetes() As Boolean
        Return Diabetes
    End Function
    Public Function getAsma() As Boolean
        Return Asma
    End Function

    Public Function getHipertension() As Boolean
        Return Hipertension
    End Function
    Public Function getObservaciones() As String
        Return Observaciones
    End Function

    Public Function getId() As Integer
        Return unaPersona.getID
    End Function
End Class
