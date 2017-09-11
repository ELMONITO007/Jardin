<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuBiatacora
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabBitacora = New MetroFramework.Controls.MetroTabControl()
        Me.tabVertodos = New MetroFramework.Controls.MetroTabPage()
        Me.btnVerTodos = New MetroFramework.Controls.MetroButton()
        Me.dgvVerTodos = New MetroFramework.Controls.MetroGrid()
        Me.tabVerPorUsuario = New MetroFramework.Controls.MetroTabPage()
        Me.dgvPorUsuario = New MetroFramework.Controls.MetroGrid()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.tabVerPorEvento = New MetroFramework.Controls.MetroTabPage()
        Me.btnBuscarEvento = New MetroFramework.Controls.MetroButton()
        Me.txtEvento = New MetroFramework.Controls.MetroComboBox()
        Me.dgvPorEvento = New MetroFramework.Controls.MetroGrid()
        Me.tabBitacora.SuspendLayout()
        Me.tabVertodos.SuspendLayout()
        CType(Me.dgvVerTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVerPorUsuario.SuspendLayout()
        CType(Me.dgvPorUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVerPorEvento.SuspendLayout()
        CType(Me.dgvPorEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBitacora
        '
        Me.tabBitacora.Controls.Add(Me.tabVertodos)
        Me.tabBitacora.Controls.Add(Me.tabVerPorUsuario)
        Me.tabBitacora.Controls.Add(Me.tabVerPorEvento)
        Me.tabBitacora.Location = New System.Drawing.Point(23, 36)
        Me.tabBitacora.Name = "tabBitacora"
        Me.tabBitacora.SelectedIndex = 2
        Me.tabBitacora.Size = New System.Drawing.Size(871, 457)
        Me.tabBitacora.TabIndex = 1
        Me.tabBitacora.Tag = ""
        Me.tabBitacora.UseSelectable = True
        '
        'tabVertodos
        '
        Me.tabVertodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabVertodos.Controls.Add(Me.btnVerTodos)
        Me.tabVertodos.Controls.Add(Me.dgvVerTodos)
        Me.tabVertodos.HorizontalScrollbarBarColor = True
        Me.tabVertodos.HorizontalScrollbarHighlightOnWheel = False
        Me.tabVertodos.HorizontalScrollbarSize = 10
        Me.tabVertodos.Location = New System.Drawing.Point(4, 38)
        Me.tabVertodos.Name = "tabVertodos"
        Me.tabVertodos.Size = New System.Drawing.Size(863, 415)
        Me.tabVertodos.TabIndex = 0
        Me.tabVertodos.Tag = "Ver todos"
        Me.tabVertodos.Text = "Ver todos"
        Me.tabVertodos.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tabVertodos.VerticalScrollbarBarColor = True
        Me.tabVertodos.VerticalScrollbarHighlightOnWheel = False
        Me.tabVertodos.VerticalScrollbarSize = 10
        '
        'btnVerTodos
        '
        Me.btnVerTodos.Location = New System.Drawing.Point(381, 17)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(146, 25)
        Me.btnVerTodos.TabIndex = 17
        Me.btnVerTodos.Tag = "Ver todos"
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.UseSelectable = True
        '
        'dgvVerTodos
        '
        Me.dgvVerTodos.AllowUserToResizeRows = False
        Me.dgvVerTodos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvVerTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvVerTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvVerTodos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVerTodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVerTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVerTodos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVerTodos.EnableHeadersVisualStyles = False
        Me.dgvVerTodos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvVerTodos.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvVerTodos.Location = New System.Drawing.Point(12, 71)
        Me.dgvVerTodos.Name = "dgvVerTodos"
        Me.dgvVerTodos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVerTodos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVerTodos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVerTodos.RowTemplate.Height = 28
        Me.dgvVerTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVerTodos.Size = New System.Drawing.Size(831, 320)
        Me.dgvVerTodos.TabIndex = 16
        '
        'tabVerPorUsuario
        '
        Me.tabVerPorUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabVerPorUsuario.Controls.Add(Me.dgvPorUsuario)
        Me.tabVerPorUsuario.Controls.Add(Me.btnBuscar)
        Me.tabVerPorUsuario.HorizontalScrollbarBarColor = True
        Me.tabVerPorUsuario.HorizontalScrollbarHighlightOnWheel = False
        Me.tabVerPorUsuario.HorizontalScrollbarSize = 10
        Me.tabVerPorUsuario.Location = New System.Drawing.Point(4, 38)
        Me.tabVerPorUsuario.Name = "tabVerPorUsuario"
        Me.tabVerPorUsuario.Size = New System.Drawing.Size(863, 415)
        Me.tabVerPorUsuario.TabIndex = 1
        Me.tabVerPorUsuario.Tag = "Ver por usuario"
        Me.tabVerPorUsuario.Text = "Ver por usuario"
        Me.tabVerPorUsuario.VerticalScrollbarBarColor = True
        Me.tabVerPorUsuario.VerticalScrollbarHighlightOnWheel = False
        Me.tabVerPorUsuario.VerticalScrollbarSize = 10
        '
        'dgvPorUsuario
        '
        Me.dgvPorUsuario.AllowUserToResizeRows = False
        Me.dgvPorUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPorUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPorUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPorUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPorUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPorUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPorUsuario.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPorUsuario.EnableHeadersVisualStyles = False
        Me.dgvPorUsuario.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvPorUsuario.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPorUsuario.Location = New System.Drawing.Point(29, 63)
        Me.dgvPorUsuario.Name = "dgvPorUsuario"
        Me.dgvPorUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPorUsuario.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPorUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPorUsuario.RowTemplate.Height = 28
        Me.dgvPorUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPorUsuario.Size = New System.Drawing.Size(787, 333)
        Me.dgvPorUsuario.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(331, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(127, 31)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Tag = "Buscar"
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseSelectable = True
        '
        'tabVerPorEvento
        '
        Me.tabVerPorEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tabVerPorEvento.Controls.Add(Me.btnBuscarEvento)
        Me.tabVerPorEvento.Controls.Add(Me.txtEvento)
        Me.tabVerPorEvento.Controls.Add(Me.dgvPorEvento)
        Me.tabVerPorEvento.HorizontalScrollbarBarColor = True
        Me.tabVerPorEvento.HorizontalScrollbarHighlightOnWheel = False
        Me.tabVerPorEvento.HorizontalScrollbarSize = 10
        Me.tabVerPorEvento.Location = New System.Drawing.Point(4, 38)
        Me.tabVerPorEvento.Name = "tabVerPorEvento"
        Me.tabVerPorEvento.Size = New System.Drawing.Size(863, 415)
        Me.tabVerPorEvento.TabIndex = 2
        Me.tabVerPorEvento.Tag = "Ver por evento"
        Me.tabVerPorEvento.Text = "Ver por evento"
        Me.tabVerPorEvento.VerticalScrollbarBarColor = True
        Me.tabVerPorEvento.VerticalScrollbarHighlightOnWheel = False
        Me.tabVerPorEvento.VerticalScrollbarSize = 10
        '
        'btnBuscarEvento
        '
        Me.btnBuscarEvento.Location = New System.Drawing.Point(363, 18)
        Me.btnBuscarEvento.Name = "btnBuscarEvento"
        Me.btnBuscarEvento.Size = New System.Drawing.Size(93, 31)
        Me.btnBuscarEvento.TabIndex = 2
        Me.btnBuscarEvento.Tag = "Buscar"
        Me.btnBuscarEvento.Text = "Buscar"
        Me.btnBuscarEvento.UseSelectable = True
        '
        'txtEvento
        '
        Me.txtEvento.FormattingEnabled = True
        Me.txtEvento.ItemHeight = 23
        Me.txtEvento.Location = New System.Drawing.Point(504, 20)
        Me.txtEvento.Name = "txtEvento"
        Me.txtEvento.Size = New System.Drawing.Size(353, 29)
        Me.txtEvento.TabIndex = 4
        Me.txtEvento.UseSelectable = True
        '
        'dgvPorEvento
        '
        Me.dgvPorEvento.AllowUserToResizeRows = False
        Me.dgvPorEvento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPorEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPorEvento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPorEvento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPorEvento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPorEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPorEvento.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPorEvento.EnableHeadersVisualStyles = False
        Me.dgvPorEvento.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgvPorEvento.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPorEvento.Location = New System.Drawing.Point(8, 66)
        Me.dgvPorEvento.Name = "dgvPorEvento"
        Me.dgvPorEvento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPorEvento.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvPorEvento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPorEvento.RowTemplate.Height = 28
        Me.dgvPorEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPorEvento.Size = New System.Drawing.Size(848, 324)
        Me.dgvPorEvento.TabIndex = 3
        '
        'iuBiatacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 507)
        Me.Controls.Add(Me.tabBitacora)
        Me.Name = "iuBiatacora"
        Me.tabBitacora.ResumeLayout(False)
        Me.tabVertodos.ResumeLayout(False)
        CType(Me.dgvVerTodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVerPorUsuario.ResumeLayout(False)
        CType(Me.dgvPorUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVerPorEvento.ResumeLayout(False)
        CType(Me.dgvPorEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabBitacora As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabVertodos As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabVerPorUsuario As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabVerPorEvento As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvVerTodos As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnVerTodos As MetroFramework.Controls.MetroButton
    Friend WithEvents dgvPorUsuario As MetroFramework.Controls.MetroGrid
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscarEvento As MetroFramework.Controls.MetroButton
    Friend WithEvents txtEvento As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dgvPorEvento As MetroFramework.Controls.MetroGrid
End Class
