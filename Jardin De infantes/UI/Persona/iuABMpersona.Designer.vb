<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class iuABMpersona
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvABMUsuario = New MetroFramework.Controls.MetroGrid()
        Me.txtDNI = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.lblContraseña = New MetroFramework.Controls.MetroLabel()
        Me.txtApellido = New MetroFramework.Controls.MetroTextBox()
        Me.lblUsuario = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.lblPersona = New MetroFramework.Controls.MetroLabel()
        Me.btnAlta = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnBaja = New MetroFramework.Controls.MetroButton()
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dgvABMUsuario.Location = New System.Drawing.Point(249, 86)
        Me.dgvABMUsuario.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dgvABMUsuario.Size = New System.Drawing.Size(649, 207)
        Me.dgvABMUsuario.TabIndex = 49
        '
        'txtDNI
        '
        '
        '
        '
        Me.txtDNI.CustomButton.Image = Nothing
        Me.txtDNI.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtDNI.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDNI.CustomButton.Name = ""
        Me.txtDNI.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtDNI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDNI.CustomButton.TabIndex = 1
        Me.txtDNI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDNI.CustomButton.UseSelectable = True
        Me.txtDNI.CustomButton.Visible = False
        Me.txtDNI.Lines = New String(-1) {}
        Me.txtDNI.Location = New System.Drawing.Point(82, 182)
        Me.txtDNI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDNI.MaxLength = 32767
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDNI.SelectedText = ""
        Me.txtDNI.SelectionLength = 0
        Me.txtDNI.SelectionStart = 0
        Me.txtDNI.ShortcutsEnabled = True
        Me.txtDNI.Size = New System.Drawing.Size(112, 19)
        Me.txtDNI.TabIndex = 48
        Me.txtDNI.UseSelectable = True
        Me.txtDNI.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDNI.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 184)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel1.TabIndex = 47
        Me.MetroLabel1.Tag = "DNI"
        Me.MetroLabel1.Text = "DNI"
        '
        'txtDireccion
        '
        '
        '
        '
        Me.txtDireccion.CustomButton.Image = Nothing
        Me.txtDireccion.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtDireccion.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.CustomButton.Name = ""
        Me.txtDireccion.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtDireccion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDireccion.CustomButton.TabIndex = 1
        Me.txtDireccion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDireccion.CustomButton.UseSelectable = True
        Me.txtDireccion.CustomButton.Visible = False
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(82, 144)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.SelectionLength = 0
        Me.txtDireccion.SelectionStart = 0
        Me.txtDireccion.ShortcutsEnabled = True
        Me.txtDireccion.Size = New System.Drawing.Size(112, 19)
        Me.txtDireccion.TabIndex = 46
        Me.txtDireccion.UseSelectable = True
        Me.txtDireccion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDireccion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Location = New System.Drawing.Point(6, 146)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(63, 19)
        Me.lblContraseña.TabIndex = 45
        Me.lblContraseña.Tag = "Direccion"
        Me.lblContraseña.Text = "Direccion"
        '
        'txtApellido
        '
        '
        '
        '
        Me.txtApellido.CustomButton.Image = Nothing
        Me.txtApellido.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtApellido.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.CustomButton.Name = ""
        Me.txtApellido.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtApellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApellido.CustomButton.TabIndex = 1
        Me.txtApellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApellido.CustomButton.UseSelectable = True
        Me.txtApellido.CustomButton.Visible = False
        Me.txtApellido.Lines = New String(-1) {}
        Me.txtApellido.Location = New System.Drawing.Point(82, 109)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txtApellido.MaxLength = 32767
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellido.SelectedText = ""
        Me.txtApellido.SelectionLength = 0
        Me.txtApellido.SelectionStart = 0
        Me.txtApellido.ShortcutsEnabled = True
        Me.txtApellido.Size = New System.Drawing.Size(112, 19)
        Me.txtApellido.TabIndex = 44
        Me.txtApellido.UseSelectable = True
        Me.txtApellido.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApellido.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(6, 112)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(58, 19)
        Me.lblUsuario.TabIndex = 43
        Me.lblUsuario.Tag = "Apellido"
        Me.lblUsuario.Text = "Apellido"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtNombre.CustomButton.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(82, 74)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(112, 19)
        Me.txtNombre.TabIndex = 42
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPersona
        '
        Me.lblPersona.AutoSize = True
        Me.lblPersona.Location = New System.Drawing.Point(6, 77)
        Me.lblPersona.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPersona.Name = "lblPersona"
        Me.lblPersona.Size = New System.Drawing.Size(59, 19)
        Me.lblPersona.TabIndex = 41
        Me.lblPersona.Tag = "Nombre"
        Me.lblPersona.Text = "Nombre"
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(286, 23)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(126, 43)
        Me.btnAlta.TabIndex = 107
        Me.btnAlta.Tag = "Alta"
        Me.btnAlta.Text = "Alta"
        Me.btnAlta.UseSelectable = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(447, 23)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(126, 43)
        Me.btnModificar.TabIndex = 108
        Me.btnModificar.Tag = "Modificar"
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseSelectable = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(624, 23)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(126, 43)
        Me.btnBaja.TabIndex = 109
        Me.btnBaja.Tag = "Baja"
        Me.btnBaja.Text = "Baja"
        Me.btnBaja.UseSelectable = True
        '
        'iuABMpersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 563)
        Me.Controls.Add(Me.btnBaja)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.dgvABMUsuario)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblContraseña)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblPersona)
        Me.Name = "iuABMpersona"
        CType(Me.dgvABMUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvABMUsuario As MetroFramework.Controls.MetroGrid
    Friend WithEvents txtDNI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblContraseña As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtApellido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblUsuario As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPersona As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAlta As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBaja As MetroFramework.Controls.MetroButton
End Class
