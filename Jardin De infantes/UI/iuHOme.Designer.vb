<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class iuHOme
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MetroTile5 = New MetroFramework.Controls.MetroTile()
        Me.mtServicios = New MetroFramework.Controls.MetroTile()
        Me.MetroTile3 = New MetroFramework.Controls.MetroTile()
        Me.mtInfra = New MetroFramework.Controls.MetroTile()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.mtAlumnos = New MetroFramework.Controls.MetroTile()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblUsuario = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'MetroTile5
        '
        Me.MetroTile5.ActiveControl = Nothing
        Me.MetroTile5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MetroTile5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile5.Location = New System.Drawing.Point(634, 105)
        Me.MetroTile5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTile5.Name = "MetroTile5"
        Me.MetroTile5.Size = New System.Drawing.Size(283, 185)
        Me.MetroTile5.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTile5.TabIndex = 18
        Me.MetroTile5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile5.TileImage = Global.UI.My.Resources.Resources.rsz_images
        Me.MetroTile5.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTile5.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile5.UseSelectable = True
        Me.MetroTile5.UseTileImage = True
        '
        'mtServicios
        '
        Me.mtServicios.ActiveControl = Nothing
        Me.mtServicios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.mtServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtServicios.Location = New System.Drawing.Point(633, 301)
        Me.mtServicios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtServicios.Name = "mtServicios"
        Me.mtServicios.Size = New System.Drawing.Size(283, 185)
        Me.mtServicios.Style = MetroFramework.MetroColorStyle.White
        Me.mtServicios.TabIndex = 17
        Me.mtServicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtServicios.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtServicios.TileImage = Global.UI.My.Resources.Resources.conf1
        Me.mtServicios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtServicios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtServicios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtServicios.UseSelectable = True
        Me.mtServicios.UseTileImage = True
        '
        'MetroTile3
        '
        Me.MetroTile3.ActiveControl = Nothing
        Me.MetroTile3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MetroTile3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile3.Location = New System.Drawing.Point(330, 301)
        Me.MetroTile3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTile3.Name = "MetroTile3"
        Me.MetroTile3.Size = New System.Drawing.Size(283, 185)
        Me.MetroTile3.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTile3.TabIndex = 16
        Me.MetroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile3.TileImage = Global.UI.My.Resources.Resources.rsz_images
        Me.MetroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile3.UseSelectable = True
        Me.MetroTile3.UseTileImage = True
        '
        'mtInfra
        '
        Me.mtInfra.ActiveControl = Nothing
        Me.mtInfra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtInfra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtInfra.Location = New System.Drawing.Point(330, 106)
        Me.mtInfra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtInfra.Name = "mtInfra"
        Me.mtInfra.Size = New System.Drawing.Size(283, 185)
        Me.mtInfra.Style = MetroFramework.MetroColorStyle.Lime
        Me.mtInfra.TabIndex = 15
        Me.mtInfra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtInfra.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtInfra.TileImage = Global.UI.My.Resources.Resources.rsz_infra
        Me.mtInfra.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtInfra.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtInfra.UseSelectable = True
        Me.mtInfra.UseTileImage = True
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MetroTile1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroTile1.Location = New System.Drawing.Point(24, 301)
        Me.MetroTile1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(283, 185)
        Me.MetroTile1.Style = MetroFramework.MetroColorStyle.Lime
        Me.MetroTile1.TabIndex = 14
        Me.MetroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTile1.TileImage = Global.UI.My.Resources.Resources.rsz_images
        Me.MetroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MetroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile1.UseSelectable = True
        Me.MetroTile1.UseTileImage = True
        '
        'mtAlumnos
        '
        Me.mtAlumnos.ActiveControl = Nothing
        Me.mtAlumnos.AutoSize = True
        Me.mtAlumnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtAlumnos.Location = New System.Drawing.Point(24, 106)
        Me.mtAlumnos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtAlumnos.Name = "mtAlumnos"
        Me.mtAlumnos.Size = New System.Drawing.Size(283, 185)
        Me.mtAlumnos.Style = MetroFramework.MetroColorStyle.Lime
        Me.mtAlumnos.TabIndex = 13
        Me.mtAlumnos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtAlumnos.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtAlumnos.TileImage = Global.UI.My.Resources.Resources.rsz_images1
        Me.mtAlumnos.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtAlumnos.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtAlumnos.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtAlumnos.UseSelectable = True
        Me.mtAlumnos.UseTileImage = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(808, 16)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(109, 31)
        Me.btnCerrarSesion.TabIndex = 19
        Me.btnCerrarSesion.Tag = "Cerrar Sesion"
        Me.btnCerrarSesion.Text = "Deslogueo"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        '
        '
        '
        Me.lblUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUsuario.Location = New System.Drawing.Point(624, 18)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(129, 29)
        Me.lblUsuario.TabIndex = 20
        '
        'iuHOme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackImage = Global.UI.My.Resources.Resources.color_violeta
        Me.BackLocation = MetroFramework.Forms.BackLocation.TopRight
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1007, 637)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.MetroTile5)
        Me.Controls.Add(Me.mtServicios)
        Me.Controls.Add(Me.MetroTile3)
        Me.Controls.Add(Me.mtInfra)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.mtAlumnos)
        Me.Name = "iuHOme"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtAlumnos As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtInfra As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile3 As MetroFramework.Controls.MetroTile
    Friend WithEvents mtServicios As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTile5 As MetroFramework.Controls.MetroTile
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelX
End Class
