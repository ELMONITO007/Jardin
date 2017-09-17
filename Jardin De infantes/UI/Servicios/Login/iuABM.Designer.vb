<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuABM
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtLegajo = New MetroFramework.Controls.MetroTextBox()
        Me.lblPersona = New MetroFramework.Controls.MetroLabel()
        Me.dgvABMUsuario = New MetroFramework.Controls.MetroGrid()
        Me.btnAlta = New MetroFramework.Controls.MetroButton()
        Me.btnBaja = New MetroFramework.Controls.MetroButton()
        Me.btnModificat = New MetroFramework.Controls.MetroButton()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.lblUsuario = New MetroFramework.Controls.MetroLabel()
        Me.txtContraseña = New MetroFramework.Controls.MetroTextBox()
        Me.lblContraseña = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtLegajo.Enabled = False
        Me.txtLegajo.Lines = New String(-1) {}
        Me.txtLegajo.Location = New System.Drawing.Point(126, 174)
        Me.txtLegajo.MaxLength = 32767
        Me.txtLegajo.Name = "txtLegajo"
        Me.txtLegajo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLegajo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLegajo.SelectedText = ""
        Me.txtLegajo.SelectionLength = 0
        Me.txtLegajo.SelectionStart = 0
        Me.txtLegajo.ShortcutsEnabled = True
        Me.txtLegajo.Size = New System.Drawing.Size(168, 29)
        Me.txtLegajo.TabIndex = 22
        Me.txtLegajo.UseSelectable = True
        Me.txtLegajo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLegajo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPersona
        '
        Me.lblPersona.AutoSize = True
        Me.lblPersona.Location = New System.Drawing.Point(12, 178)
        Me.lblPersona.Name = "lblPersona"
        Me.lblPersona.Size = New System.Drawing.Size(48, 19)
        Me.lblPersona.TabIndex = 21
        Me.lblPersona.Tag = "Legajo"
        Me.lblPersona.Text = "Legajo"
        '
        'dgvABMUsuario
        '
        Me.dgvABMUsuario.AllowUserToResizeRows = False
        Me.dgvABMUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvABMUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvABMUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvABMUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvABMUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvABMUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvABMUsuario.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvABMUsuario.EnableHeadersVisualStyles = False
        Me.dgvABMUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvABMUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvABMUsuario.Location = New System.Drawing.Point(486, 148)
        Me.dgvABMUsuario.Name = "dgvABMUsuario"
        Me.dgvABMUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvABMUsuario.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvABMUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvABMUsuario.RowTemplate.Height = 28
        Me.dgvABMUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvABMUsuario.Size = New System.Drawing.Size(367, 277)
        Me.dgvABMUsuario.TabIndex = 20
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(59, 49)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(108, 54)
        Me.btnAlta.TabIndex = 17
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseSelectable = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(224, 49)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(108, 54)
        Me.btnBaja.TabIndex = 23
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseSelectable = True
        '
        'btnModificat
        '
        Me.btnModificat.Location = New System.Drawing.Point(390, 49)
        Me.btnModificat.Name = "btnModificat"
        Me.btnModificat.Size = New System.Drawing.Size(108, 54)
        Me.btnModificat.TabIndex = 24
        Me.btnModificat.Text = "Modificar"
        Me.btnModificat.UseSelectable = True
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(126, 214)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(168, 29)
        Me.txtUsuario.TabIndex = 26
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(12, 218)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(53, 19)
        Me.lblUsuario.TabIndex = 25
        Me.lblUsuario.Tag = "Nombre de usuario"
        Me.lblUsuario.Text = "Usuario"
        '
        'txtContraseña
        '
        '
        '
        '
        Me.txtContraseña.CustomButton.Image = Nothing
        Me.txtContraseña.CustomButton.Location = New System.Drawing.Point(140, 1)
        Me.txtContraseña.CustomButton.Name = ""
        Me.txtContraseña.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtContraseña.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtContraseña.CustomButton.TabIndex = 1
        Me.txtContraseña.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtContraseña.CustomButton.UseSelectable = True
        Me.txtContraseña.CustomButton.Visible = False
        Me.txtContraseña.Lines = New String(-1) {}
        Me.txtContraseña.Location = New System.Drawing.Point(126, 259)
        Me.txtContraseña.MaxLength = 32767
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtContraseña.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtContraseña.SelectedText = ""
        Me.txtContraseña.SelectionLength = 0
        Me.txtContraseña.SelectionStart = 0
        Me.txtContraseña.ShortcutsEnabled = True
        Me.txtContraseña.Size = New System.Drawing.Size(168, 29)
        Me.txtContraseña.TabIndex = 28
        Me.txtContraseña.UseSelectable = True
        Me.txtContraseña.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtContraseña.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(12, 263)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(75, 19)
        Me.lblContraseña.TabIndex = 27
        Me.lblContraseña.Tag = "Contraseña"
        Me.lblContraseña.Text = "Contraseña"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(321, 178)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(93, 22)
        Me.MetroButton1.TabIndex = 29
        Me.MetroButton1.Tag = "Buscar"
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.UseSelectable = True
        '
        'iuABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 448)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnModificat)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.txtLegajo)
        Me.Controls.Add(Me.lblPersona)
        Me.Controls.Add(Me.dgvABMUsuario)
        Me.Controls.Add(Me.btnAlta)
        Me.Name = "iuABM"
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLegajo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPersona As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvABMUsuario As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnAlta As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBaja As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificat As MetroFramework.Controls.MetroButton
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUsuario As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtContraseña As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblContraseña As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
