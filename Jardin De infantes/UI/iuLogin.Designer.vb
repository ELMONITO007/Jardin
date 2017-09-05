<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuLogin
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
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.txtUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.lblUsuario = New DevComponents.DotNetBar.LabelX()
        Me.txtIdioma = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.lblContrasenia = New DevComponents.DotNetBar.LabelX()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnAceptar = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancelar = New DevComponents.DotNetBar.ButtonX()
        Me.LayoutControl1 = New DevComponents.DotNetBar.Layout.LayoutControl()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(0, 0)
        Me.ButtonX1.TabIndex = 0
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Location = New System.Drawing.Point(0, 0)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(0, 0)
        Me.ButtonX2.TabIndex = 0
        '
        'AdvTree1
        '
        Me.AdvTree1.AllowDrop = True
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.Location = New System.Drawing.Point(0, 0)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(0, 0)
        Me.AdvTree1.TabIndex = 0
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.Border.Class = "TextBoxBorder"
        Me.txtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsuario.Location = New System.Drawing.Point(259, 125)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PreventEnterBeep = True
        Me.txtUsuario.Size = New System.Drawing.Size(150, 26)
        Me.txtUsuario.TabIndex = 0
        '
        'lblUsuario
        '
        '
        '
        '
        Me.lblUsuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft YaHei", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(40, 125)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(112, 35)
        Me.lblUsuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuari"
        '
        'txtIdioma
        '
        Me.txtIdioma.DisplayMember = "Text"
        Me.txtIdioma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.txtIdioma.FormattingEnabled = True
        Me.txtIdioma.ItemHeight = 14
        Me.txtIdioma.Location = New System.Drawing.Point(240, 79)
        Me.txtIdioma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIdioma.Name = "txtIdioma"
        Me.txtIdioma.Size = New System.Drawing.Size(180, 20)
        Me.txtIdioma.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtIdioma.TabIndex = 2
        '
        'lblContrasenia
        '
        '
        '
        '
        Me.lblContrasenia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblContrasenia.Location = New System.Drawing.Point(40, 208)
        Me.lblContrasenia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(112, 35)
        Me.lblContrasenia.TabIndex = 4
        Me.lblContrasenia.Text = "Contraseñ"
        '
        'txtPassword
        '
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.Location = New System.Drawing.Point(259, 212)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PreventEnterBeep = True
        Me.txtPassword.Size = New System.Drawing.Size(150, 26)
        Me.txtPassword.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnAceptar.Location = New System.Drawing.Point(23, 315)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(112, 35)
        Me.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Acepta"
        '
        'btnCancelar
        '
        Me.btnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnCancelar.Location = New System.Drawing.Point(243, 315)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 35)
        Me.btnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2013
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancel"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.TabIndex = 0
        '
        'iuLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 371)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtIdioma)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iuLogin"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Private WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Private WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents txtUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents lblUsuario As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtIdioma As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents lblContrasenia As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnAceptar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancelar As DevComponents.DotNetBar.ButtonX
    Private WithEvents LayoutControl1 As DevComponents.DotNetBar.Layout.LayoutControl
End Class
