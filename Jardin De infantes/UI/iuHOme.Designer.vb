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
        Me.mtGestionIntitucional = New MetroFramework.Controls.MetroTile()
        Me.mtServicios = New MetroFramework.Controls.MetroTile()
        Me.mtGestionPersonal = New MetroFramework.Controls.MetroTile()
        Me.mtInfra = New MetroFramework.Controls.MetroTile()
        Me.mtGestionVentas = New MetroFramework.Controls.MetroTile()
        Me.mtAlumnos = New MetroFramework.Controls.MetroTile()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.lblUsuario = New DevComponents.DotNetBar.LabelX()
        Me.SuspendLayout()
        '
        'mtGestionIntitucional
        '
        Me.mtGestionIntitucional.ActiveControl = Nothing
        Me.mtGestionIntitucional.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtGestionIntitucional.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtGestionIntitucional.Location = New System.Drawing.Point(634, 105)
        Me.mtGestionIntitucional.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtGestionIntitucional.Name = "mtGestionIntitucional"
        Me.mtGestionIntitucional.Size = New System.Drawing.Size(283, 185)
        Me.mtGestionIntitucional.Style = MetroFramework.MetroColorStyle.White
        Me.mtGestionIntitucional.TabIndex = 18
        Me.mtGestionIntitucional.Tag = "Gestion intitucional"
        Me.mtGestionIntitucional.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtGestionIntitucional.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtGestionIntitucional.TileImage = Global.UI.My.Resources.Resources.intit1
        Me.mtGestionIntitucional.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtGestionIntitucional.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtGestionIntitucional.UseSelectable = True
        Me.mtGestionIntitucional.UseTileImage = True
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
        Me.mtServicios.Tag = "Servicios"
        Me.mtServicios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtServicios.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtServicios.TileImage = Global.UI.My.Resources.Resources.conf1
        Me.mtServicios.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtServicios.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtServicios.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtServicios.UseSelectable = True
        Me.mtServicios.UseTileImage = True
        '
        'mtGestionPersonal
        '
        Me.mtGestionPersonal.ActiveControl = Nothing
        Me.mtGestionPersonal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtGestionPersonal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtGestionPersonal.Location = New System.Drawing.Point(330, 301)
        Me.mtGestionPersonal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtGestionPersonal.Name = "mtGestionPersonal"
        Me.mtGestionPersonal.Size = New System.Drawing.Size(283, 185)
        Me.mtGestionPersonal.Style = MetroFramework.MetroColorStyle.White
        Me.mtGestionPersonal.TabIndex = 16
        Me.mtGestionPersonal.Tag = "Gestion de personal"
        Me.mtGestionPersonal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtGestionPersonal.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtGestionPersonal.TileImage = Global.UI.My.Resources.Resources.person1
        Me.mtGestionPersonal.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtGestionPersonal.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtGestionPersonal.UseSelectable = True
        Me.mtGestionPersonal.UseTileImage = True
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
        Me.mtInfra.Style = MetroFramework.MetroColorStyle.White
        Me.mtInfra.TabIndex = 15
        Me.mtInfra.Tag = "Gestion de Infra"
        Me.mtInfra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtInfra.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtInfra.TileImage = Global.UI.My.Resources.Resources.infra1
        Me.mtInfra.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtInfra.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtInfra.UseSelectable = True
        Me.mtInfra.UseTileImage = True
        '
        'mtGestionVentas
        '
        Me.mtGestionVentas.ActiveControl = Nothing
        Me.mtGestionVentas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtGestionVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtGestionVentas.Location = New System.Drawing.Point(24, 301)
        Me.mtGestionVentas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtGestionVentas.Name = "mtGestionVentas"
        Me.mtGestionVentas.Size = New System.Drawing.Size(283, 185)
        Me.mtGestionVentas.Style = MetroFramework.MetroColorStyle.White
        Me.mtGestionVentas.TabIndex = 14
        Me.mtGestionVentas.Tag = "Gestion de Ventas"
        Me.mtGestionVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtGestionVentas.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtGestionVentas.TileImage = Global.UI.My.Resources.Resources.ventas1
        Me.mtGestionVentas.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtGestionVentas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtGestionVentas.UseSelectable = True
        Me.mtGestionVentas.UseTileImage = True
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
        Me.mtAlumnos.Style = MetroFramework.MetroColorStyle.White
        Me.mtAlumnos.TabIndex = 13
        Me.mtAlumnos.Tag = "Gestion de Alumnos"
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
        Me.Controls.Add(Me.mtGestionIntitucional)
        Me.Controls.Add(Me.mtServicios)
        Me.Controls.Add(Me.mtGestionPersonal)
        Me.Controls.Add(Me.mtInfra)
        Me.Controls.Add(Me.mtGestionVentas)
        Me.Controls.Add(Me.mtAlumnos)
        Me.Name = "iuHOme"
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mtAlumnos As MetroFramework.Controls.MetroTile
    Friend WithEvents mtGestionVentas As MetroFramework.Controls.MetroTile
    Friend WithEvents mtInfra As MetroFramework.Controls.MetroTile
    Friend WithEvents mtGestionPersonal As MetroFramework.Controls.MetroTile
    Friend WithEvents mtServicios As MetroFramework.Controls.MetroTile
    Friend WithEvents mtGestionIntitucional As MetroFramework.Controls.MetroTile
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelX
End Class
