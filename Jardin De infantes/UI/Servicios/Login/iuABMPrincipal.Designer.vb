<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class iuABMPrincipal
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
        Me.mtModificar = New MetroFramework.Controls.MetroTile()
        Me.mtBaja = New MetroFramework.Controls.MetroTile()
        Me.mtAlta = New MetroFramework.Controls.MetroTile()
        Me.SuspendLayout()
        '
        'mtModificar
        '
        Me.mtModificar.ActiveControl = Nothing
        Me.mtModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtModificar.Location = New System.Drawing.Point(628, 100)
        Me.mtModificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtModificar.Name = "mtModificar"
        Me.mtModificar.Size = New System.Drawing.Size(300, 185)
        Me.mtModificar.Style = MetroFramework.MetroColorStyle.White
        Me.mtModificar.TabIndex = 21
        Me.mtModificar.Tag = "Modificar"
        Me.mtModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtModificar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtModificar.TileImage = Global.UI.My.Resources.Resources.update1
        Me.mtModificar.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtModificar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtModificar.UseSelectable = True
        Me.mtModificar.UseTileImage = True
        '
        'mtBaja
        '
        Me.mtBaja.ActiveControl = Nothing
        Me.mtBaja.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mtBaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtBaja.Location = New System.Drawing.Point(313, 101)
        Me.mtBaja.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtBaja.Name = "mtBaja"
        Me.mtBaja.Size = New System.Drawing.Size(307, 185)
        Me.mtBaja.Style = MetroFramework.MetroColorStyle.White
        Me.mtBaja.TabIndex = 20
        Me.mtBaja.Tag = "Baja"
        Me.mtBaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtBaja.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtBaja.TileImage = Global.UI.My.Resources.Resources.baja1
        Me.mtBaja.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtBaja.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtBaja.UseSelectable = True
        Me.mtBaja.UseTileImage = True
        '
        'mtAlta
        '
        Me.mtAlta.ActiveControl = Nothing
        Me.mtAlta.AutoSize = True
        Me.mtAlta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mtAlta.Location = New System.Drawing.Point(2, 101)
        Me.mtAlta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mtAlta.Name = "mtAlta"
        Me.mtAlta.Size = New System.Drawing.Size(303, 185)
        Me.mtAlta.Style = MetroFramework.MetroColorStyle.White
        Me.mtAlta.TabIndex = 19
        Me.mtAlta.Tag = "Alta"
        Me.mtAlta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.mtAlta.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.mtAlta.TileImage = Global.UI.My.Resources.Resources.alta1
        Me.mtAlta.TileImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.mtAlta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.mtAlta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.mtAlta.UseSelectable = True
        Me.mtAlta.UseTileImage = True
        '
        'iuABMPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 386)
        Me.Controls.Add(Me.mtModificar)
        Me.Controls.Add(Me.mtBaja)
        Me.Controls.Add(Me.mtAlta)
        Me.Name = "iuABMPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtModificar As MetroFramework.Controls.MetroTile
    Friend WithEvents mtBaja As MetroFramework.Controls.MetroTile
    Friend WithEvents mtAlta As MetroFramework.Controls.MetroTile
End Class
