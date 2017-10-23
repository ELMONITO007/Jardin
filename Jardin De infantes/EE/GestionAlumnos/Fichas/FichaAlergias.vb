Public Class FichaAlergias
    Private Property unaPersona As Persona
    Private Property Tiene_Alergia As Boolean
    Private Property Alergia_Medicamentos As Boolean
    Private Property Cuales_Alergias_Medicamentos As String
    Private Property Alergia_Alimento As Boolean
    Private Property Cuales_Alergias_Alimento As String
    Private Property Alergia_Elementos As Boolean
    Private Property Cuales_Alergias_Elementos As String
    Private Property Otras_Alergias As String

    Sub New()

    End Sub


    Sub New(_unaPersona As Persona, _Tiene_Alergia As Boolean, _Alergia_Medicamentos As Boolean, _Cuales_Alergias_Medicamentos As String, _Alergia_Alimento As Boolean, _Cuales_Alergias_Alimento As String, _Alergia_Elementos As Boolean, _Cuales_Alergias_Elementos As String, _Otras_Alergias As String)
        unaPersona = _unaPersona
        Tiene_Alergia = _Tiene_Alergia
        Alergia_Alimento = _Alergia_Alimento
        Cuales_Alergias_Alimento = _Cuales_Alergias_Alimento
        Alergia_Medicamentos = _Alergia_Medicamentos
        Cuales_Alergias_Medicamentos = _Cuales_Alergias_Medicamentos
        Cuales_Alergias_Elementos = _Cuales_Alergias_Elementos
        Alergia_Elementos = _Alergia_Elementos


    End Sub

    Public Function getTiene_Alergia() As Boolean
        Return Tiene_Alergia
    End Function
    Public Function getAlergia_Alimento() As Boolean
        Return Alergia_Alimento
    End Function

    Public Function getCuales_Alergias_Alimento() As String
        Return Cuales_Alergias_Alimento
    End Function
    Public Function getAlergia_Medicamentos() As Boolean
        Return Alergia_Medicamentos
    End Function
    Public Function getAlergia_Elementos() As Boolean
        Return Alergia_Elementos
    End Function




    Public Function getCuales_Alergias_Elementos() As String
        Return Cuales_Alergias_Elementos
    End Function


    Public Function getCuales_Alergias_Medicamentos() As String
        Return Cuales_Alergias_Medicamentos
    End Function

    Public Function getId() As Integer
        Return unaPersona.getID
    End Function
End Class
