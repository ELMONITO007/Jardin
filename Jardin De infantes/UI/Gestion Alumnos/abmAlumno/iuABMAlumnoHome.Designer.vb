<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuABMAlumnoHome
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
        Me.mtAltaAlumnos = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mtAltaAlumnos
        '
        Me.mtAltaAlumnos.ActiveControl = Nothing
        Me.mtAltaAlumnos.AutoSize = True
        Me.mtAltaAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtAltaAlumnos.Location = New System.Drawing.Point(35, 53)
        Me.mtAltaAlumnos.Name = "mtAltaAlumnos"
        Me.mtAltaAlumnos.Size = New System.Drawing.Size(189, 120)
        Me.mtAltaAlumnos.Style = MetroFramework.MetroColorStyle.White
        Me.mtAltaAlumnos.TabIndex = 15
        Me.mtAltaAlumnos.Tag = "Alta"
        Me.mtAltaAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtAltaAlumnos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtAltaAlumnos.TileImage = Global.UI.My.Resources.Resources.rsz_alta
        Me.mtAltaAlumnos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtAltaAlumnos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtAltaAlumnos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtAltaAlumnos.UseSelectable = True
        Me.mtAltaAlumnos.UseTileImage = True
        '
        'iuABMAlumnoHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 374)
        Me.Controls.Add(Me.mtAltaAlumnos)
        Me.Name = "iuABMAlumnoHome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtAltaAlumnos As MetroFramework.Controls.MetroTile
End Class
