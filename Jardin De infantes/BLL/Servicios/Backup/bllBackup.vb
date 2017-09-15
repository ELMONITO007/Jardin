Imports DAL
Imports EE
Imports MP
Public Class bllBackup

    Public Function listarTodo() As DataTable
        Dim dal As New dalBackup
        Dim cadena As String = "select Path,NombreArchivo,Fecha,DigitoVerificadorH from dbo.Backups"
        Return dal.Leer(cadena)

    End Function

    Public Function generarDigitoVerificador(unBackup As Backup) As String
        Dim dal As New dalBackup
        Dim cadena As String = "select CONVERT(nvarchar(max),ID_Backup)+CONVERT (nvarchar(max),Fecha)+CONVERT(nvarchar(max),Path),convert(nvarchar(max),NombreArchivo) as DVH from backups where fecha=" & unBackup.getFecha
        Dim dt As DataTable = dal.Leer(cadena)
        Dim mp As New mppBackup
        Dim generarDVH As New DigitoVerificadorH(mp.obtenerString(dt))
        Return generarDVH.GenerarDigitoVerificadorH

    End Function
    Public Sub altaBackup(unBackup As Backup)
        Dim dalALta As New dalBackup
        Dim cadena As String = "insert into Backups(Fecha,Path,NombreArchivo)values (" & unBackup.getFecha & "," & unBackup.getPath & ")"
        dalALta.Escribir(cadena)
        Dim altaDVH As New dalBackup
        Dim cadenaDVH As String = "insert into Backups(DigitoVerificadorH)values(" & generarDigitoVerificador(unBackup) & ")where fecha=" & unBackup.getFecha
        altaDVH.Escribir(cadenaDVH)
        crearBackup(unBackup)
    End Sub

    Public Sub crearBackup(unBackup As Backup)
        Try
            Dim dalALta As New dalBackup
            Dim cadena As String = "backup database JardinInfantes to disk=" & unBackup.getPath & "\" & unBackup.getNombre & ".bak"
            dalALta.Escribir(cadena)
            Dim agregarBitacora As New bllBitacora
            agregarBitacora.altaBitacora("Generar Backup", "Se generar un Backup")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al generar el backup")
        End Try

    End Sub

    Public Sub RestaurarBakcup(unBackup As Backup)

        Try
            Dim dalALta As New dalBackup
            Dim cadena As String = "Retore database JardinInfantes from disk=" & unBackup.getPath & "\" & unBackup.getNombre & ".bak"
            dalALta.Escribir(cadena)
            Dim agregarBitacora As New bllBitacora
            agregarBitacora.altaBitacora("Restaurar Backup", "Se restaura un Backup")
            MsgBox("Se restauro el vackup correctamente", MsgBoxStyle.Information, "Recuperar Backup")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al restaurar el backup")
        End Try
    End Sub
End Class
