Public MustInherit Class Personas
    Inherits IDentificador

    Protected Property nombre As String
    Protected Property apellido As String
    Protected Property dni As Integer
    Protected Property direccion As String
    Protected Property digitoVerificadorH As String
    Protected Property unTIpoPersona As TipoPersona


    Public Function getID() As Integer
        Return Me.id
    End Function
    Public Sub setID(_id As Integer)
        Me.id = _id
    End Sub

    Public Function obtenerTodoJunto() As String
        Dim cadena As String = id & Me.nombre & Me.apellido & Me.direccion & Me.dni & Me.unTIpoPersona.obtenerID
        Return cadena

    End Function
    Public Function getNombre() As String
        Return nombre
    End Function
    Public Function getApellido() As String
        Return apellido

    End Function
    Public Function getDni() As Integer
        Return dni
    End Function
    Public Function getDVH() As String
        Return digitoVerificadorH
    End Function

    Public Function getTipoPErsona() As Integer
        Return unTIpoPersona.obtenerID
    End Function

    Public Function getDireccion() As String
        Return direccion
    End Function
    Public Sub setDVH(dvh As String)
        digitoVerificadorH = dvh
    End Sub
End Class
