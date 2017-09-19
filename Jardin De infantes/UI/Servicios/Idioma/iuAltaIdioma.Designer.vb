<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuAltaIdioma
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBaja = New MetroFramework.Controls.MetroButton()
        Me.txtLegajo = New MetroFramework.Controls.MetroTextBox()
        Me.lblIdioma = New MetroFramework.Controls.MetroLabel()
        Me.dgvABMUsuario = New MetroFramework.Controls.MetroGrid()
        Me.btnAltaTraduccion = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(92, 18)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(108, 54)
        Me.btnBaja.TabIndex = 34
        Me.btnBaja.Tag = "Alta"
        Me.btnBaja.Text = "Alta"
        Me.btnBaja.UseSelectable = True
        '
        'txtLegajo
        '
        '
        '
        '
        Me.txtLegajo.CustomButton.Image = Nothing
        Me.txtLegajo.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtLegajo.CustomButton.Name = ""
        Me.txtLegajo.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtLegajo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLegajo.CustomButton.TabIndex = 1
        Me.txtLegajo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLegajo.CustomButton.UseSelectable = True
        Me.txtLegajo.CustomButton.Visible = False
        Me.txtLegajo.Lines = New String(-1) {}
        Me.txtLegajo.Location = New System.Drawing.Point(142, 128)
        Me.txtLegajo.MaxLength = 32767
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLegajo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLegajo.SelectedText = ""
        Me.txtLegajo.SelectionLength = 0
        Me.txtLegajo.SelectionStart = 0
        Me.txtLegajo.ShortcutsEnabled = True
        Me.txtLegajo.Size = New System.Drawing.Size(168, 29)
        Me.txtLegajo.TabIndex = 33
        Me.txtLegajo.UseSelectable = True
        Me.txtLegajo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLegajo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblIdioma
        '
        Me.lblIdioma.AutoSize = True
        Me.lblIdioma.Location = New System.Drawing.Point(28, 132)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(50, 19)
        Me.lblIdioma.TabIndex = 32
        Me.lblIdioma.Tag = "Idioma"
        Me.lblIdioma.Text = "Idioma"
        '
        'dgvABMUsuario
        '
        Me.dgvABMUsuario.AllowUserToResizeRows = False
        Me.dgvABMUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvABMUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvABMUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvABMUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvABMUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvABMUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvABMUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvABMUsuario.EnableHeadersVisualStyles = False
        Me.dgvABMUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvABMUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvABMUsuario.Location = New System.Drawing.Point(316, 63)
        Me.dgvABMUsuario.Name = "dgvABMUsuario"
        Me.dgvABMUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvABMUsuario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvABMUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvABMUsuario.RowTemplate.Height = 28
        Me.dgvABMUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvABMUsuario.Size = New System.Drawing.Size(435, 499)
        Me.dgvABMUsuario.TabIndex = 31
        Me.dgvABMUsuario.Visible = False
        '
        'btnAltaTraduccion
        '
        Me.btnAltaTraduccion.Location = New System.Drawing.Point(92, 222)
        Me.btnAltaTraduccion.Name = "btnAltaTraduccion"
        Me.btnAltaTraduccion.Size = New System.Drawing.Size(108, 54)
        Me.btnAltaTraduccion.TabIndex = 35
        Me.btnAltaTraduccion.Tag = "Alta"
        Me.btnAltaTraduccion.Text = "Alta"
        Me.btnAltaTraduccion.UseSelectable = True
        Me.btnAltaTraduccion.Visible = False
        '
        'iuAltaIdioma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 620)
        Me.Controls.Add(Me.btnAltaTraduccion)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.dgvABMUsuario)
        Me.Name = "iuAltaIdioma"
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBaja As MetroFramework.Controls.MetroButton
    Friend WithEvents txtLegajo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblIdioma As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvABMUsuario As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAltaTraduccion As MetroFramework.Controls.MetroButton
End Class
