<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuCambiarIdioma
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
        Me.cbIdioma = New MetroFramework.Controls.MetroComboBox()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbIdioma
        '
        Me.cbIdioma.FormattingEnabled = True
        Me.cbIdioma.ItemHeight = 23
        Me.cbIdioma.Location = New System.Drawing.Point(23, 82)
        Me.cbIdioma.Name = "cbIdioma"
        Me.cbIdioma.Size = New System.Drawing.Size(121, 29)
        Me.cbIdioma.TabIndex = 3
        Me.cbIdioma.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(50, 170)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Tag = "Modificar"
        Me.btnModificar.UseSelectable = True
        '
        'iuCambiarIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 273)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.cbIdioma)
        Me.Name = "iuCambiarIdioma"
        Me.Text = "Cambio de Idioma"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbIdioma As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
End Class
