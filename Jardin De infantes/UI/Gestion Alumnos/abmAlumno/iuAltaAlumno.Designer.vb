<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuAltaAlumno
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
        Me.lblFichasIncripcion = New MetroFramework.Controls.MetroLabel()
        Me.lblUsuario = New MetroFramework.Controls.MetroLabel()
        Me.lblAltaPersona = New MetroFramework.Controls.MetroLabel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbPaso1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPaso1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFichasIncripcion
        '
        Me.lblFichasIncripcion.AutoSize = True
        Me.lblFichasIncripcion.Location = New System.Drawing.Point(545, 244)
        Me.lblFichasIncripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFichasIncripcion.Name = "lblFichasIncripcion"
        Me.lblFichasIncripcion.Size = New System.Drawing.Size(104, 19)
        Me.lblFichasIncripcion.TabIndex = 37
        Me.lblFichasIncripcion.Tag = "Fichas Incripcion"
        Me.lblFichasIncripcion.Text = "Fichas Incripcion"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(335, 244)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(80, 19)
        Me.lblUsuario.TabIndex = 35
        Me.lblUsuario.Tag = "Nombre de usuario"
        Me.lblUsuario.Text = "Alta Usuario"
        '
        'lblAltaPersona
        '
        Me.lblAltaPersona.AutoSize = True
        Me.lblAltaPersona.Location = New System.Drawing.Point(91, 244)
        Me.lblAltaPersona.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAltaPersona.Name = "lblAltaPersona"
        Me.lblAltaPersona.Size = New System.Drawing.Size(82, 19)
        Me.lblAltaPersona.TabIndex = 32
        Me.lblAltaPersona.Tag = "Alta Persona"
        Me.lblAltaPersona.Text = "Alta Persona"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.UI.My.Resources.Resources.paso_3
        Me.PictureBox2.Location = New System.Drawing.Point(488, 34)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(205, 207)
        Me.PictureBox2.TabIndex = 43
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UI.My.Resources.Resources.paso2
        Me.PictureBox1.Location = New System.Drawing.Point(261, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 207)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'pbPaso1
        '
        Me.pbPaso1.Image = Global.UI.My.Resources.Resources.paso1
        Me.pbPaso1.Location = New System.Drawing.Point(35, 34)
        Me.pbPaso1.Name = "pbPaso1"
        Me.pbPaso1.Size = New System.Drawing.Size(205, 207)
        Me.pbPaso1.TabIndex = 41
        Me.pbPaso1.TabStop = False
        '
        'iuAltaAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 284)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbPaso1)
        Me.Controls.Add(Me.lblFichasIncripcion)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblAltaPersona)
        Me.Name = "iuAltaAlumno"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPaso1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFichasIncripcion As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblUsuario As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAltaPersona As MetroFramework.Controls.MetroLabel
    Friend WithEvents pbPaso1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
