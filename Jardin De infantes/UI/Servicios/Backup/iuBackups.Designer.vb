<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuBackups
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBackup = New MetroFramework.Controls.MetroGrid()
        Me.btnCrearBackup = New MetroFramework.Controls.MetroButton()
        Me.btnRestaurarBackup = New MetroFramework.Controls.MetroButton()
        Me.lblEtiquta = New MetroFramework.Controls.MetroLabel()
        Me.txtnombreArchivo = New MetroFramework.Controls.MetroTextBox()
        CType(Me.dgvBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBackup
        '
        Me.dgvBackup.AllowUserToAddRows = False
        Me.dgvBackup.AllowUserToDeleteRows = False
        Me.dgvBackup.AllowUserToOrderColumns = True
        Me.dgvBackup.AllowUserToResizeRows = False
        Me.dgvBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvBackup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvBackup.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBackup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvBackup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvBackup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBackup.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBackup.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvBackup.EnableHeadersVisualStyles = False
        Me.dgvBackup.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvBackup.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvBackup.Location = New System.Drawing.Point(66, 237)
        Me.dgvBackup.MultiSelect = False
        Me.dgvBackup.Name = "dgvBackup"
        Me.dgvBackup.ReadOnly = True
        Me.dgvBackup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBackup.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvBackup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvBackup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBackup.Size = New System.Drawing.Size(669, 193)
        Me.dgvBackup.TabIndex = 104
        Me.dgvBackup.Visible = False
        '
        'btnCrearBackup
        '
        Me.btnCrearBackup.Location = New System.Drawing.Point(66, 135)
        Me.btnCrearBackup.Name = "btnCrearBackup"
        Me.btnCrearBackup.Size = New System.Drawing.Size(126, 43)
        Me.btnCrearBackup.TabIndex = 105
        Me.btnCrearBackup.Tag = "Crear Backup"
        Me.btnCrearBackup.Text = "Crear Backup"
        Me.btnCrearBackup.UseSelectable = True
        '
        'btnRestaurarBackup
        '
        Me.btnRestaurarBackup.Location = New System.Drawing.Point(601, 135)
        Me.btnRestaurarBackup.Name = "btnRestaurarBackup"
        Me.btnRestaurarBackup.Size = New System.Drawing.Size(126, 43)
        Me.btnRestaurarBackup.TabIndex = 106
        Me.btnRestaurarBackup.Tag = "Restaurar Backup"
        Me.btnRestaurarBackup.Text = "Restaurar Backup"
        Me.btnRestaurarBackup.UseSelectable = True
        '
        'lblEtiquta
        '
        Me.lblEtiquta.AutoSize = True
        Me.lblEtiquta.Location = New System.Drawing.Point(202, 192)
        Me.lblEtiquta.Name = "lblEtiquta"
        Me.lblEtiquta.Size = New System.Drawing.Size(129, 19)
        Me.lblEtiquta.TabIndex = 108
        Me.lblEtiquta.Tag = "Nombre del Archivo"
        Me.lblEtiquta.Text = "Nombre del Archivo"
        '
        'txtnombreArchivo
        '
        '
        '
        '
        Me.txtnombreArchivo.CustomButton.Image = Nothing
        Me.txtnombreArchivo.CustomButton.Location = New System.Drawing.Point(151, 1)
        Me.txtnombreArchivo.CustomButton.Name = ""
        Me.txtnombreArchivo.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtnombreArchivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtnombreArchivo.CustomButton.TabIndex = 1
        Me.txtnombreArchivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtnombreArchivo.CustomButton.UseSelectable = True
        Me.txtnombreArchivo.CustomButton.Visible = False
        Me.txtnombreArchivo.Lines = New String(-1) {}
        Me.txtnombreArchivo.Location = New System.Drawing.Point(351, 192)
        Me.txtnombreArchivo.MaxLength = 32767
        Me.txtnombreArchivo.Name = "txtnombreArchivo"
        Me.txtnombreArchivo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombreArchivo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnombreArchivo.SelectedText = ""
        Me.txtnombreArchivo.SelectionLength = 0
        Me.txtnombreArchivo.SelectionStart = 0
        Me.txtnombreArchivo.ShortcutsEnabled = True
        Me.txtnombreArchivo.Size = New System.Drawing.Size(173, 23)
        Me.txtnombreArchivo.TabIndex = 107
        Me.txtnombreArchivo.UseSelectable = True
        Me.txtnombreArchivo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtnombreArchivo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'iuBackups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 442)
        Me.Controls.Add(Me.lblEtiquta)
        Me.Controls.Add(Me.txtnombreArchivo)
        Me.Controls.Add(Me.btnRestaurarBackup)
        Me.Controls.Add(Me.btnCrearBackup)
        Me.Controls.Add(Me.dgvBackup)
        Me.Name = "iuBackups"
        CType(Me.dgvBackup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvBackup As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnCrearBackup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRestaurarBackup As MetroFramework.Controls.MetroButton
    Friend WithEvents lblEtiquta As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtnombreArchivo As MetroFramework.Controls.MetroTextBox
End Class
