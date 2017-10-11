Public Class Telefono
    Inherits IDentificador
    Private Property codigoPais As Integer
    Private Property numero As Integer
    Private Property descripcion As String
    Private Property digitoVerificadoH As String


    Sub New()

    End Sub
    Sub New(_codigoPais As Integer, _numero As Integer, _descripcion As String, _DVH As String)
        codigoPais = _codigoPais
        numero = _numero
        descripcion = _descripcion


    End Sub
    Public Function getCodigoPais() As Integer
        Return codigoPais
    End Function
    Public Function getNumero() As Integer
        Return numero
    End Function
    Public Function getDescripcion() As String
        Return descripcion
    End Function


End Class
