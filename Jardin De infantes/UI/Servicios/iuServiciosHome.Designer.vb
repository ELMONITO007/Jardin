<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuServiciosHome
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
        Me.mtIdioma = New MetroFramework.Controls.MetroTile()
        Me.mtPermiso = New MetroFramework.Controls.MetroTile()
        Me.mtBackup = New MetroFramework.Controls.MetroTile()
        Me.mtUsuario = New MetroFramework.Controls.MetroTile()
        Me.mtServicios = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mtIdioma
        '
        Me.mtIdioma.ActiveControl = Nothing
        Me.mtIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtIdioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtIdioma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtIdioma.Location = New System.Drawing.Point(610, 161)
        Me.mtIdioma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtIdioma.Name = "mtIdioma"
        Me.mtIdioma.Size = New System.Drawing.Size(283, 185)
        Me.mtIdioma.Style = MetroFramework.MetroColorStyle.White
        Me.mtIdioma.TabIndex = 22
        Me.mtIdioma.Tag = "Gestion de Idiomas"
        Me.mtIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtIdioma.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtIdioma.TileImage = Global.UI.My.Resources.Resources.idioma1
        Me.mtIdioma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtIdioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtIdioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtIdioma.UseSelectable = True
        Me.mtIdioma.UseTileImage = True
        '
        'mtPermiso
        '
        Me.mtPermiso.ActiveControl = Nothing
        Me.mtPermiso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtPermiso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtPermiso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtPermiso.Location = New System.Drawing.Point(313, 248)
        Me.mtPermiso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtPermiso.Name = "mtPermiso"
        Me.mtPermiso.Size = New System.Drawing.Size(283, 185)
        Me.mtPermiso.Style = MetroFramework.MetroColorStyle.White
        Me.mtPermiso.TabIndex = 21
        Me.mtPermiso.Tag = "Gestion de Permisos"
        Me.mtPermiso.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtPermiso.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtPermiso.TileImage = Global.UI.My.Resources.Resources.permisos1
        Me.mtPermiso.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtPermiso.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtPermiso.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtPermiso.UseSelectable = True
        Me.mtPermiso.UseTileImage = True
        '
        'mtBackup
        '
        Me.mtBackup.ActiveControl = Nothing
        Me.mtBackup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtBackup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtBackup.Location = New System.Drawing.Point(315, 47)
        Me.mtBackup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtBackup.Name = "mtBackup"
        Me.mtBackup.Size = New System.Drawing.Size(283, 185)
        Me.mtBackup.Style = MetroFramework.MetroColorStyle.White
        Me.mtBackup.TabIndex = 20
        Me.mtBackup.Tag = "Gestion de Backup"
        Me.mtBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtBackup.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtBackup.TileImage = Global.UI.My.Resources.Resources.bk1
        Me.mtBackup.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtBackup.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtBackup.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtBackup.UseSelectable = True
        Me.mtBackup.UseTileImage = True
        '
        'mtUsuario
        '
        Me.mtUsuario.ActiveControl = Nothing
        Me.mtUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtUsuario.Location = New System.Drawing.Point(0, 250)
        Me.mtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtUsuario.Name = "mtUsuario"
        Me.mtUsuario.Size = New System.Drawing.Size(283, 185)
        Me.mtUsuario.Style = MetroFramework.MetroColorStyle.White
        Me.mtUsuario.TabIndex = 19
        Me.mtUsuario.Tag = "Gestion de Usuarios"
        Me.mtUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtUsuario.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtUsuario.TileImage = Global.UI.My.Resources.Resources.usuario11
        Me.mtUsuario.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtUsuario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtUsuario.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtUsuario.UseSelectable = True
        Me.mtUsuario.UseStyleColors = True
        Me.mtUsuario.UseTileImage = True
        '
        'mtServicios
        '
        Me.mtServicios.ActiveControl = Nothing
        Me.mtServicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtServicios.Location = New System.Drawing.Point(3, 45)
        Me.mtServicios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtServicios.Name = "mtServicios"
        Me.mtServicios.Size = New System.Drawing.Size(283, 185)
        Me.mtServicios.Style = MetroFramework.MetroColorStyle.White
        Me.mtServicios.TabIndex = 18
        Me.mtServicios.Tag = "Gestion de Bitacora"
        Me.mtServicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtServicios.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtServicios.TileImage = Global.UI.My.Resources.Resources.bitacora
        Me.mtServicios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtServicios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtServicios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtServicios.UseSelectable = True
        Me.mtServicios.UseTileImage = True
        '
        'iuServiciosHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 494)
        Me.Controls.Add(Me.mtIdioma)
        Me.Controls.Add(Me.mtPermiso)
        Me.Controls.Add(Me.mtBackup)
        Me.Controls.Add(Me.mtUsuario)
        Me.Controls.Add(Me.mtServicios)
        Me.Name = "iuServiciosHome"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mtServicios As MetroFramework.Controls.MetroTile
    Friend WithEvents mtUsuario As MetroFramework.Controls.MetroTile
    Friend WithEvents mtBackup As MetroFramework.Controls.MetroTile
    Friend WithEvents mtPermiso As MetroFramework.Controls.MetroTile
    Friend WithEvents mtIdioma As MetroFramework.Controls.MetroTile
End Class
