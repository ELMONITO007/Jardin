<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuGestionAlumnoHome
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mtABMAlumnos = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mtABMAlumnos
        '
        Me.mtABMAlumnos.ActiveControl = Nothing
        Me.mtABMAlumnos.AutoSize = True
        Me.mtABMAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtABMAlumnos.Location = New System.Drawing.Point(23, 63)
        Me.mtABMAlumnos.Name = "mtABMAlumnos"
        Me.mtABMAlumnos.Size = New System.Drawing.Size(189, 120)
        Me.mtABMAlumnos.Style = MetroFramework.MetroColorStyle.White
        Me.mtABMAlumnos.TabIndex = 14
        Me.mtABMAlumnos.Tag = "Gestion de Alumnos"
        Me.mtABMAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtABMAlumnos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtABMAlumnos.TileImage = Global.UI.My.Resources.Resources.rsz_images1
        Me.mtABMAlumnos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtABMAlumnos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtABMAlumnos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtABMAlumnos.UseSelectable = True
        Me.mtABMAlumnos.UseTileImage = True
        '
        'iuGestionAlumnoHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 466)
        Me.Controls.Add(Me.mtABMAlumnos)
        Me.Name = "iuGestionAlumnoHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtABMAlumnos As MetroFramework.Controls.MetroTile
End Class
