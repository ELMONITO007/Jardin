<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuIdioma
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
        Me.mtAgregarIdioma = New MetroFramework.Controls.MetroTile()
        Me.mtCambiarIdioma = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mtAgregarIdioma
        '
        Me.mtAgregarIdioma.ActiveControl = Nothing
        Me.mtAgregarIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtAgregarIdioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtAgregarIdioma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtAgregarIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.mtAgregarIdioma.Location = New System.Drawing.Point(336, 42)
        Me.mtAgregarIdioma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtAgregarIdioma.Name = "mtAgregarIdioma"
        Me.mtAgregarIdioma.Size = New System.Drawing.Size(283, 185)
        Me.mtAgregarIdioma.Style = MetroFramework.MetroColorStyle.White
        Me.mtAgregarIdioma.TabIndex = 24
        Me.mtAgregarIdioma.Tag = "Alta de Idioma"
        Me.mtAgregarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtAgregarIdioma.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtAgregarIdioma.TileImage = Global.UI.My.Resources.Resources.AgregarIdioma1
        Me.mtAgregarIdioma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtAgregarIdioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtAgregarIdioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtAgregarIdioma.UseSelectable = True
        Me.mtAgregarIdioma.UseTileImage = True
        '
        'mtCambiarIdioma
        '
        Me.mtCambiarIdioma.ActiveControl = Nothing
        Me.mtCambiarIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtCambiarIdioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtCambiarIdioma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtCambiarIdioma.Location = New System.Drawing.Point(11, 42)
        Me.mtCambiarIdioma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtCambiarIdioma.Name = "mtCambiarIdioma"
        Me.mtCambiarIdioma.Size = New System.Drawing.Size(283, 185)
        Me.mtCambiarIdioma.Style = MetroFramework.MetroColorStyle.White
        Me.mtCambiarIdioma.TabIndex = 23
        Me.mtCambiarIdioma.Tag = "Cambiar Idioma"
        Me.mtCambiarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtCambiarIdioma.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtCambiarIdioma.TileImage = Global.UI.My.Resources.Resources.Cambiarcontraseña1
        Me.mtCambiarIdioma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtCambiarIdioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtCambiarIdioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtCambiarIdioma.UseSelectable = True
        Me.mtCambiarIdioma.UseTileImage = True
        '
        'iuIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 315)
        Me.Controls.Add(Me.mtAgregarIdioma)
        Me.Controls.Add(Me.mtCambiarIdioma)
        Me.Name = "iuIdioma"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtCambiarIdioma As MetroFramework.Controls.MetroTile
    Friend WithEvents mtAgregarIdioma As MetroFramework.Controls.MetroTile
End Class
