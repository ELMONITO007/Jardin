Imports EE

Public Class mppFamilia
    'Cuando el datatable pasa a la row 2 copia el objeto de la lista de la posicion 1 a la posicion 0
    'Public Function listarFamilas(dt As DataTable) As List(Of Composite)
    '    Dim listar As New List(Of Composite)

    '    For Each item As DataRow In dt.Rows

    '        Dim lafamilia As New Familia()
    '        lafamilia.setNombre(CStr(item("Nombre")))
    '        listar.Add(lafamilia)

    '    Next

    '    Return listar

    'End Function

    Public Function listarFamilas(dt As DataTable) As List(Of String)
        Dim listar As New List(Of String)

        For Each item As DataRow In dt.Rows

            Dim lafamilia As New Familia()

            listar.Add(CStr(item("Nombre")))

        Next

        Return listar

    End Function
End Class
