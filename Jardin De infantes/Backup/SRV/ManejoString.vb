Public Class ManejoString
    Public Shared Function UnirPalabras(palabra1 As String, palabra2 As String, Cantidad1 As Integer, cantidad2 As Integer) As String
        Dim resultado As String
        Dim palabra1Cortada As String
        Dim palabra2Cortada As String
        If palabra1.Length >= Cantidad1 Then
            palabra1Cortada = palabra1.Substring(0, Cantidad1)
        Else
            palabra1Cortada = palabra1
        End If

        If palabra2.Length >= cantidad2 Then
            palabra2Cortada = palabra2.Substring(0, cantidad2)
        Else
            palabra2Cortada = palabra2
        End If
        resultado = palabra1Cortada & palabra2Cortada
        Return resultado
    End Function

End Class
