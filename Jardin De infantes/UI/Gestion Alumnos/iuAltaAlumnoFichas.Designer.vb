<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iuAltaAlumnoFichas
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.mtFichaMedica = New MetroFramework.Controls.MetroTabPage()
        Me.mtFichaCasa = New MetroFramework.Controls.MetroTabPage()
        Me.mtFichaFamilia = New MetroFramework.Controls.MetroTabPage()
        Me.btnRegistraFicha = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbAlergias = New MetroFramework.Controls.MetroToggle()
        Me.lblTieneAlergias = New MetroFramework.Controls.MetroLabel()
        Me.lblAlergiaMedicamento = New MetroFramework.Controls.MetroLabel()
        Me.cbMedicamento = New MetroFramework.Controls.MetroToggle()
        Me.lblAlergiaALimento = New MetroFramework.Controls.MetroLabel()
        Me.cbAlimento = New MetroFramework.Controls.MetroToggle()
        Me.lblCualesMedicamento = New MetroFramework.Controls.MetroLabel()
        Me.lblCualesAlimento = New MetroFramework.Controls.MetroLabel()
        Me.txtCualesMedicamento = New MetroFramework.Controls.MetroTextBox()
        Me.txtCualesALimentos = New MetroFramework.Controls.MetroTextBox()
        Me.lblAlergiaElementos = New MetroFramework.Controls.MetroLabel()
        Me.cbElemento = New MetroFramework.Controls.MetroToggle()
        Me.txtCualesElementos = New MetroFramework.Controls.MetroTextBox()
        Me.lblCualesElementos = New MetroFramework.Controls.MetroLabel()
        Me.txtOtrosAlergias = New MetroFramework.Controls.MetroTextBox()
        Me.lblOtros = New MetroFramework.Controls.MetroLabel()
        Me.txtOtrasEnfermedades = New MetroFramework.Controls.MetroTextBox()
        Me.lblOtrasEnfermedades = New MetroFramework.Controls.MetroLabel()
        Me.lblHipertension = New MetroFramework.Controls.MetroLabel()
        Me.cbHipertension = New MetroFramework.Controls.MetroToggle()
        Me.lblDiabetes = New MetroFramework.Controls.MetroLabel()
        Me.cbDiabetes = New MetroFramework.Controls.MetroToggle()
        Me.lblHepatitisA = New MetroFramework.Controls.MetroLabel()
        Me.cbHepatitisA = New MetroFramework.Controls.MetroToggle()
        Me.lblEnfermedades = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.cbEnfermedades = New MetroFramework.Controls.MetroToggle()
        Me.lblHepatitisB = New MetroFramework.Controls.MetroLabel()
        Me.cbHepatitisB = New MetroFramework.Controls.MetroToggle()
        Me.lblAsma = New MetroFramework.Controls.MetroLabel()
        Me.cbAsma = New MetroFramework.Controls.MetroToggle()
        Me.lblObraSocial = New MetroFramework.Controls.MetroLabel()
        Me.cbObraSocial = New MetroFramework.Controls.MetroToggle()
        Me.txtObraSocial = New MetroFramework.Controls.MetroTextBox()
        Me.lblCualObraSocial = New MetroFramework.Controls.MetroLabel()
        Me.txtNumeroTelefonoOS = New MetroFramework.Controls.MetroTextBox()
        Me.lblTelefono = New MetroFramework.Controls.MetroLabel()
        Me.txtNumeroSocioOS = New MetroFramework.Controls.MetroTextBox()
        Me.lblNumeroSocio = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cbHabitacion = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbCountry = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cbDepartamento = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.cbCasa = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.cbPatio = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.cbPapaTrabaja = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbViveTio = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbViveAbuela = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.cbHermanos = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.cbPadresSeparados = New MetroFramework.Controls.MetroToggle()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.cbMamaTrabaja = New MetroFramework.Controls.MetroToggle()
        Me.MetroTabControl1.SuspendLayout()
        Me.mtFichaMedica.SuspendLayout()
        Me.mtFichaCasa.SuspendLayout()
        Me.mtFichaFamilia.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.mtFichaMedica)
        Me.MetroTabControl1.Controls.Add(Me.mtFichaCasa)
        Me.MetroTabControl1.Controls.Add(Me.mtFichaFamilia)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 36)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(828, 418)
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.UseSelectable = True
        '
        'mtFichaMedica
        '
        Me.mtFichaMedica.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mtFichaMedica.Controls.Add(Me.txtNumeroSocioOS)
        Me.mtFichaMedica.Controls.Add(Me.lblNumeroSocio)
        Me.mtFichaMedica.Controls.Add(Me.txtNumeroTelefonoOS)
        Me.mtFichaMedica.Controls.Add(Me.lblTelefono)
        Me.mtFichaMedica.Controls.Add(Me.txtObraSocial)
        Me.mtFichaMedica.Controls.Add(Me.lblCualObraSocial)
        Me.mtFichaMedica.Controls.Add(Me.lblObraSocial)
        Me.mtFichaMedica.Controls.Add(Me.cbObraSocial)
        Me.mtFichaMedica.Controls.Add(Me.lblAsma)
        Me.mtFichaMedica.Controls.Add(Me.cbAsma)
        Me.mtFichaMedica.Controls.Add(Me.lblHepatitisB)
        Me.mtFichaMedica.Controls.Add(Me.cbHepatitisB)
        Me.mtFichaMedica.Controls.Add(Me.txtOtrasEnfermedades)
        Me.mtFichaMedica.Controls.Add(Me.lblOtrasEnfermedades)
        Me.mtFichaMedica.Controls.Add(Me.lblHipertension)
        Me.mtFichaMedica.Controls.Add(Me.cbHipertension)
        Me.mtFichaMedica.Controls.Add(Me.lblDiabetes)
        Me.mtFichaMedica.Controls.Add(Me.cbDiabetes)
        Me.mtFichaMedica.Controls.Add(Me.lblHepatitisA)
        Me.mtFichaMedica.Controls.Add(Me.cbHepatitisA)
        Me.mtFichaMedica.Controls.Add(Me.lblEnfermedades)
        Me.mtFichaMedica.Controls.Add(Me.MetroLabel10)
        Me.mtFichaMedica.Controls.Add(Me.cbEnfermedades)
        Me.mtFichaMedica.Controls.Add(Me.txtOtrosAlergias)
        Me.mtFichaMedica.Controls.Add(Me.lblOtros)
        Me.mtFichaMedica.Controls.Add(Me.txtCualesElementos)
        Me.mtFichaMedica.Controls.Add(Me.lblCualesElementos)
        Me.mtFichaMedica.Controls.Add(Me.lblAlergiaElementos)
        Me.mtFichaMedica.Controls.Add(Me.cbElemento)
        Me.mtFichaMedica.Controls.Add(Me.txtCualesALimentos)
        Me.mtFichaMedica.Controls.Add(Me.txtCualesMedicamento)
        Me.mtFichaMedica.Controls.Add(Me.lblCualesAlimento)
        Me.mtFichaMedica.Controls.Add(Me.lblCualesMedicamento)
        Me.mtFichaMedica.Controls.Add(Me.lblAlergiaALimento)
        Me.mtFichaMedica.Controls.Add(Me.cbAlimento)
        Me.mtFichaMedica.Controls.Add(Me.lblAlergiaMedicamento)
        Me.mtFichaMedica.Controls.Add(Me.cbMedicamento)
        Me.mtFichaMedica.Controls.Add(Me.lblTieneAlergias)
        Me.mtFichaMedica.Controls.Add(Me.MetroLabel1)
        Me.mtFichaMedica.Controls.Add(Me.cbAlergias)
        Me.mtFichaMedica.HorizontalScrollbarBarColor = True
        Me.mtFichaMedica.HorizontalScrollbarHighlightOnWheel = False
        Me.mtFichaMedica.HorizontalScrollbarSize = 10
        Me.mtFichaMedica.Location = New System.Drawing.Point(4, 38)
        Me.mtFichaMedica.Name = "mtFichaMedica"
        Me.mtFichaMedica.Size = New System.Drawing.Size(820, 376)
        Me.mtFichaMedica.TabIndex = 0
        Me.mtFichaMedica.Tag = "Ficha Medica"
        Me.mtFichaMedica.Text = "Ficha Medica"
        Me.mtFichaMedica.VerticalScrollbarBarColor = True
        Me.mtFichaMedica.VerticalScrollbarHighlightOnWheel = False
        Me.mtFichaMedica.VerticalScrollbarSize = 10
        '
        'mtFichaCasa
        '
        Me.mtFichaCasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel12)
        Me.mtFichaCasa.Controls.Add(Me.cbPatio)
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel4)
        Me.mtFichaCasa.Controls.Add(Me.cbHabitacion)
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel7)
        Me.mtFichaCasa.Controls.Add(Me.cbCountry)
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel8)
        Me.mtFichaCasa.Controls.Add(Me.cbDepartamento)
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel9)
        Me.mtFichaCasa.Controls.Add(Me.MetroLabel11)
        Me.mtFichaCasa.Controls.Add(Me.cbCasa)
        Me.mtFichaCasa.HorizontalScrollbarBarColor = True
        Me.mtFichaCasa.HorizontalScrollbarHighlightOnWheel = False
        Me.mtFichaCasa.HorizontalScrollbarSize = 10
        Me.mtFichaCasa.Location = New System.Drawing.Point(4, 38)
        Me.mtFichaCasa.Name = "mtFichaCasa"
        Me.mtFichaCasa.Size = New System.Drawing.Size(820, 376)
        Me.mtFichaCasa.TabIndex = 1
        Me.mtFichaCasa.Tag = "Ficha Casa"
        Me.mtFichaCasa.Text = "Ficha Casa"
        Me.mtFichaCasa.VerticalScrollbarBarColor = True
        Me.mtFichaCasa.VerticalScrollbarHighlightOnWheel = False
        Me.mtFichaCasa.VerticalScrollbarSize = 10
        '
        'mtFichaFamilia
        '
        Me.mtFichaFamilia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel15)
        Me.mtFichaFamilia.Controls.Add(Me.cbMamaTrabaja)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel2)
        Me.mtFichaFamilia.Controls.Add(Me.cbPapaTrabaja)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel3)
        Me.mtFichaFamilia.Controls.Add(Me.cbViveTio)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel5)
        Me.mtFichaFamilia.Controls.Add(Me.cbViveAbuela)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel6)
        Me.mtFichaFamilia.Controls.Add(Me.cbHermanos)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel13)
        Me.mtFichaFamilia.Controls.Add(Me.MetroLabel14)
        Me.mtFichaFamilia.Controls.Add(Me.cbPadresSeparados)
        Me.mtFichaFamilia.HorizontalScrollbarBarColor = True
        Me.mtFichaFamilia.HorizontalScrollbarHighlightOnWheel = False
        Me.mtFichaFamilia.HorizontalScrollbarSize = 10
        Me.mtFichaFamilia.Location = New System.Drawing.Point(4, 38)
        Me.mtFichaFamilia.Name = "mtFichaFamilia"
        Me.mtFichaFamilia.Size = New System.Drawing.Size(820, 376)
        Me.mtFichaFamilia.TabIndex = 2
        Me.mtFichaFamilia.Tag = "Ficha Familia"
        Me.mtFichaFamilia.Text = "Ficha Familia"
        Me.mtFichaFamilia.VerticalScrollbarBarColor = True
        Me.mtFichaFamilia.VerticalScrollbarHighlightOnWheel = False
        Me.mtFichaFamilia.VerticalScrollbarSize = 10
        '
        'btnRegistraFicha
        '
        Me.btnRegistraFicha.BackgroundImage = Global.UI.My.Resources.Resources.bitacora
        Me.btnRegistraFicha.Location = New System.Drawing.Point(857, 74)
        Me.btnRegistraFicha.Name = "btnRegistraFicha"
        Me.btnRegistraFicha.Size = New System.Drawing.Size(174, 113)
        Me.btnRegistraFicha.TabIndex = 2
        Me.btnRegistraFicha.Tag = "Registrar Ficha"
        Me.btnRegistraFicha.Text = "Registrar Ficha"
        Me.btnRegistraFicha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRegistraFicha.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(261, 222)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel1.TabIndex = 2
        '
        'cbAlergias
        '
        Me.cbAlergias.AutoSize = True
        Me.cbAlergias.Location = New System.Drawing.Point(163, 42)
        Me.cbAlergias.Name = "cbAlergias"
        Me.cbAlergias.Size = New System.Drawing.Size(80, 17)
        Me.cbAlergias.TabIndex = 3
        Me.cbAlergias.Text = "Off"
        Me.cbAlergias.UseSelectable = True
        '
        'lblTieneAlergias
        '
        Me.lblTieneAlergias.AutoSize = True
        Me.lblTieneAlergias.Location = New System.Drawing.Point(26, 40)
        Me.lblTieneAlergias.Name = "lblTieneAlergias"
        Me.lblTieneAlergias.Size = New System.Drawing.Size(91, 19)
        Me.lblTieneAlergias.TabIndex = 4
        Me.lblTieneAlergias.Tag = "Tiene Alergias"
        Me.lblTieneAlergias.Text = "Tiene Alergias"
        '
        'lblAlergiaMedicamento
        '
        Me.lblAlergiaMedicamento.AutoSize = True
        Me.lblAlergiaMedicamento.Location = New System.Drawing.Point(26, 81)
        Me.lblAlergiaMedicamento.Name = "lblAlergiaMedicamento"
        Me.lblAlergiaMedicamento.Size = New System.Drawing.Size(136, 19)
        Me.lblAlergiaMedicamento.TabIndex = 6
        Me.lblAlergiaMedicamento.Tag = "Alergia Medicamento"
        Me.lblAlergiaMedicamento.Text = "Alergia Medicamento"
        '
        'cbMedicamento
        '
        Me.cbMedicamento.AutoSize = True
        Me.cbMedicamento.Location = New System.Drawing.Point(163, 81)
        Me.cbMedicamento.Name = "cbMedicamento"
        Me.cbMedicamento.Size = New System.Drawing.Size(80, 17)
        Me.cbMedicamento.TabIndex = 5
        Me.cbMedicamento.Text = "Off"
        Me.cbMedicamento.UseSelectable = True
        '
        'lblAlergiaALimento
        '
        Me.lblAlergiaALimento.AutoSize = True
        Me.lblAlergiaALimento.Location = New System.Drawing.Point(26, 156)
        Me.lblAlergiaALimento.Name = "lblAlergiaALimento"
        Me.lblAlergiaALimento.Size = New System.Drawing.Size(108, 19)
        Me.lblAlergiaALimento.TabIndex = 8
        Me.lblAlergiaALimento.Tag = "Alergia Alimento"
        Me.lblAlergiaALimento.Text = "Alergia Alimento"
        '
        'cbAlimento
        '
        Me.cbAlimento.AutoSize = True
        Me.cbAlimento.Location = New System.Drawing.Point(163, 158)
        Me.cbAlimento.Name = "cbAlimento"
        Me.cbAlimento.Size = New System.Drawing.Size(80, 17)
        Me.cbAlimento.TabIndex = 7
        Me.cbAlimento.Text = "Off"
        Me.cbAlimento.UseSelectable = True
        '
        'lblCualesMedicamento
        '
        Me.lblCualesMedicamento.AutoSize = True
        Me.lblCualesMedicamento.Location = New System.Drawing.Point(26, 118)
        Me.lblCualesMedicamento.Name = "lblCualesMedicamento"
        Me.lblCualesMedicamento.Size = New System.Drawing.Size(47, 19)
        Me.lblCualesMedicamento.TabIndex = 10
        Me.lblCualesMedicamento.Tag = "Cuales"
        Me.lblCualesMedicamento.Text = "Cuales"
        '
        'lblCualesAlimento
        '
        Me.lblCualesAlimento.AutoSize = True
        Me.lblCualesAlimento.Location = New System.Drawing.Point(26, 194)
        Me.lblCualesAlimento.Name = "lblCualesAlimento"
        Me.lblCualesAlimento.Size = New System.Drawing.Size(47, 19)
        Me.lblCualesAlimento.TabIndex = 11
        Me.lblCualesAlimento.Tag = "Cuales"
        Me.lblCualesAlimento.Text = "Cuales"
        '
        'txtCualesMedicamento
        '
        '
        '
        '
        Me.txtCualesMedicamento.CustomButton.Image = Nothing
        Me.txtCualesMedicamento.CustomButton.Location = New System.Drawing.Point(144, 2)
        Me.txtCualesMedicamento.CustomButton.Name = ""
        Me.txtCualesMedicamento.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCualesMedicamento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCualesMedicamento.CustomButton.TabIndex = 1
        Me.txtCualesMedicamento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCualesMedicamento.CustomButton.UseSelectable = True
        Me.txtCualesMedicamento.CustomButton.Visible = False
        Me.txtCualesMedicamento.Lines = New String(-1) {}
        Me.txtCualesMedicamento.Location = New System.Drawing.Point(79, 118)
        Me.txtCualesMedicamento.MaxLength = 32767
        Me.txtCualesMedicamento.Name = "txtCualesMedicamento"
        Me.txtCualesMedicamento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCualesMedicamento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCualesMedicamento.SelectedText = ""
        Me.txtCualesMedicamento.SelectionLength = 0
        Me.txtCualesMedicamento.SelectionStart = 0
        Me.txtCualesMedicamento.ShortcutsEnabled = True
        Me.txtCualesMedicamento.Size = New System.Drawing.Size(164, 22)
        Me.txtCualesMedicamento.TabIndex = 13
        Me.txtCualesMedicamento.UseSelectable = True
        Me.txtCualesMedicamento.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCualesMedicamento.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCualesALimentos
        '
        '
        '
        '
        Me.txtCualesALimentos.CustomButton.Image = Nothing
        Me.txtCualesALimentos.CustomButton.Location = New System.Drawing.Point(144, 2)
        Me.txtCualesALimentos.CustomButton.Name = ""
        Me.txtCualesALimentos.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCualesALimentos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCualesALimentos.CustomButton.TabIndex = 1
        Me.txtCualesALimentos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCualesALimentos.CustomButton.UseSelectable = True
        Me.txtCualesALimentos.CustomButton.Visible = False
        Me.txtCualesALimentos.Lines = New String(-1) {}
        Me.txtCualesALimentos.Location = New System.Drawing.Point(79, 191)
        Me.txtCualesALimentos.MaxLength = 32767
        Me.txtCualesALimentos.Name = "txtCualesALimentos"
        Me.txtCualesALimentos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCualesALimentos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCualesALimentos.SelectedText = ""
        Me.txtCualesALimentos.SelectionLength = 0
        Me.txtCualesALimentos.SelectionStart = 0
        Me.txtCualesALimentos.ShortcutsEnabled = True
        Me.txtCualesALimentos.Size = New System.Drawing.Size(164, 22)
        Me.txtCualesALimentos.TabIndex = 14
        Me.txtCualesALimentos.UseSelectable = True
        Me.txtCualesALimentos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCualesALimentos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblAlergiaElementos
        '
        Me.lblAlergiaElementos.AutoSize = True
        Me.lblAlergiaElementos.Location = New System.Drawing.Point(26, 231)
        Me.lblAlergiaElementos.Name = "lblAlergiaElementos"
        Me.lblAlergiaElementos.Size = New System.Drawing.Size(115, 19)
        Me.lblAlergiaElementos.TabIndex = 16
        Me.lblAlergiaElementos.Tag = "Alergia Elementos"
        Me.lblAlergiaElementos.Text = "Alergia Elementos"
        '
        'cbElemento
        '
        Me.cbElemento.AutoSize = True
        Me.cbElemento.Location = New System.Drawing.Point(163, 233)
        Me.cbElemento.Name = "cbElemento"
        Me.cbElemento.Size = New System.Drawing.Size(80, 17)
        Me.cbElemento.TabIndex = 15
        Me.cbElemento.Text = "Off"
        Me.cbElemento.UseSelectable = True
        '
        'txtCualesElementos
        '
        '
        '
        '
        Me.txtCualesElementos.CustomButton.Image = Nothing
        Me.txtCualesElementos.CustomButton.Location = New System.Drawing.Point(144, 2)
        Me.txtCualesElementos.CustomButton.Name = ""
        Me.txtCualesElementos.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtCualesElementos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCualesElementos.CustomButton.TabIndex = 1
        Me.txtCualesElementos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCualesElementos.CustomButton.UseSelectable = True
        Me.txtCualesElementos.CustomButton.Visible = False
        Me.txtCualesElementos.Lines = New String(-1) {}
        Me.txtCualesElementos.Location = New System.Drawing.Point(79, 265)
        Me.txtCualesElementos.MaxLength = 32767
        Me.txtCualesElementos.Name = "txtCualesElementos"
        Me.txtCualesElementos.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCualesElementos.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCualesElementos.SelectedText = ""
        Me.txtCualesElementos.SelectionLength = 0
        Me.txtCualesElementos.SelectionStart = 0
        Me.txtCualesElementos.ShortcutsEnabled = True
        Me.txtCualesElementos.Size = New System.Drawing.Size(164, 22)
        Me.txtCualesElementos.TabIndex = 18
        Me.txtCualesElementos.UseSelectable = True
        Me.txtCualesElementos.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCualesElementos.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCualesElementos
        '
        Me.lblCualesElementos.AutoSize = True
        Me.lblCualesElementos.Location = New System.Drawing.Point(26, 268)
        Me.lblCualesElementos.Name = "lblCualesElementos"
        Me.lblCualesElementos.Size = New System.Drawing.Size(47, 19)
        Me.lblCualesElementos.TabIndex = 17
        Me.lblCualesElementos.Tag = "Cuales"
        Me.lblCualesElementos.Text = "Cuales"
        '
        'txtOtrosAlergias
        '
        '
        '
        '
        Me.txtOtrosAlergias.CustomButton.Image = Nothing
        Me.txtOtrosAlergias.CustomButton.Location = New System.Drawing.Point(144, 2)
        Me.txtOtrosAlergias.CustomButton.Name = ""
        Me.txtOtrosAlergias.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtOtrosAlergias.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOtrosAlergias.CustomButton.TabIndex = 1
        Me.txtOtrosAlergias.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOtrosAlergias.CustomButton.UseSelectable = True
        Me.txtOtrosAlergias.CustomButton.Visible = False
        Me.txtOtrosAlergias.Lines = New String(-1) {}
        Me.txtOtrosAlergias.Location = New System.Drawing.Point(79, 309)
        Me.txtOtrosAlergias.MaxLength = 32767
        Me.txtOtrosAlergias.Name = "txtOtrosAlergias"
        Me.txtOtrosAlergias.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtrosAlergias.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOtrosAlergias.SelectedText = ""
        Me.txtOtrosAlergias.SelectionLength = 0
        Me.txtOtrosAlergias.SelectionStart = 0
        Me.txtOtrosAlergias.ShortcutsEnabled = True
        Me.txtOtrosAlergias.Size = New System.Drawing.Size(164, 22)
        Me.txtOtrosAlergias.TabIndex = 20
        Me.txtOtrosAlergias.UseSelectable = True
        Me.txtOtrosAlergias.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOtrosAlergias.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblOtros
        '
        Me.lblOtros.AutoSize = True
        Me.lblOtros.Location = New System.Drawing.Point(26, 312)
        Me.lblOtros.Name = "lblOtros"
        Me.lblOtros.Size = New System.Drawing.Size(42, 19)
        Me.lblOtros.TabIndex = 19
        Me.lblOtros.Tag = "Otros"
        Me.lblOtros.Text = "Otros"
        '
        'txtOtrasEnfermedades
        '
        '
        '
        '
        Me.txtOtrasEnfermedades.CustomButton.Image = Nothing
        Me.txtOtrasEnfermedades.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.txtOtrasEnfermedades.CustomButton.Name = ""
        Me.txtOtrasEnfermedades.CustomButton.Size = New System.Drawing.Size(91, 91)
        Me.txtOtrasEnfermedades.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOtrasEnfermedades.CustomButton.TabIndex = 1
        Me.txtOtrasEnfermedades.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOtrasEnfermedades.CustomButton.UseSelectable = True
        Me.txtOtrasEnfermedades.CustomButton.Visible = False
        Me.txtOtrasEnfermedades.Lines = New String(-1) {}
        Me.txtOtrasEnfermedades.Location = New System.Drawing.Point(386, 268)
        Me.txtOtrasEnfermedades.MaxLength = 32767
        Me.txtOtrasEnfermedades.Multiline = True
        Me.txtOtrasEnfermedades.Name = "txtOtrasEnfermedades"
        Me.txtOtrasEnfermedades.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtrasEnfermedades.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOtrasEnfermedades.SelectedText = ""
        Me.txtOtrasEnfermedades.SelectionLength = 0
        Me.txtOtrasEnfermedades.SelectionStart = 0
        Me.txtOtrasEnfermedades.ShortcutsEnabled = True
        Me.txtOtrasEnfermedades.Size = New System.Drawing.Size(182, 93)
        Me.txtOtrasEnfermedades.TabIndex = 37
        Me.txtOtrasEnfermedades.UseSelectable = True
        Me.txtOtrasEnfermedades.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOtrasEnfermedades.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblOtrasEnfermedades
        '
        Me.lblOtrasEnfermedades.AutoSize = True
        Me.lblOtrasEnfermedades.Location = New System.Drawing.Point(333, 271)
        Me.lblOtrasEnfermedades.Name = "lblOtrasEnfermedades"
        Me.lblOtrasEnfermedades.Size = New System.Drawing.Size(42, 19)
        Me.lblOtrasEnfermedades.TabIndex = 36
        Me.lblOtrasEnfermedades.Tag = "Otros"
        Me.lblOtrasEnfermedades.Text = "Otros"
        '
        'lblHipertension
        '
        Me.lblHipertension.AutoSize = True
        Me.lblHipertension.Location = New System.Drawing.Point(333, 231)
        Me.lblHipertension.Name = "lblHipertension"
        Me.lblHipertension.Size = New System.Drawing.Size(83, 19)
        Me.lblHipertension.TabIndex = 33
        Me.lblHipertension.Tag = "Hipertension"
        Me.lblHipertension.Text = "Hipertension"
        '
        'cbHipertension
        '
        Me.cbHipertension.AutoSize = True
        Me.cbHipertension.Location = New System.Drawing.Point(470, 233)
        Me.cbHipertension.Name = "cbHipertension"
        Me.cbHipertension.Size = New System.Drawing.Size(80, 17)
        Me.cbHipertension.TabIndex = 32
        Me.cbHipertension.Text = "Off"
        Me.cbHipertension.UseSelectable = True
        '
        'lblDiabetes
        '
        Me.lblDiabetes.AutoSize = True
        Me.lblDiabetes.Location = New System.Drawing.Point(333, 156)
        Me.lblDiabetes.Name = "lblDiabetes"
        Me.lblDiabetes.Size = New System.Drawing.Size(59, 19)
        Me.lblDiabetes.TabIndex = 27
        Me.lblDiabetes.Tag = "Diabetes"
        Me.lblDiabetes.Text = "Diabetes"
        '
        'cbDiabetes
        '
        Me.cbDiabetes.AutoSize = True
        Me.cbDiabetes.Location = New System.Drawing.Point(470, 158)
        Me.cbDiabetes.Name = "cbDiabetes"
        Me.cbDiabetes.Size = New System.Drawing.Size(80, 17)
        Me.cbDiabetes.TabIndex = 26
        Me.cbDiabetes.Text = "Off"
        Me.cbDiabetes.UseSelectable = True
        '
        'lblHepatitisA
        '
        Me.lblHepatitisA.AutoSize = True
        Me.lblHepatitisA.Location = New System.Drawing.Point(333, 81)
        Me.lblHepatitisA.Name = "lblHepatitisA"
        Me.lblHepatitisA.Size = New System.Drawing.Size(72, 19)
        Me.lblHepatitisA.TabIndex = 25
        Me.lblHepatitisA.Tag = "Hepatitis A"
        Me.lblHepatitisA.Text = "Hepatitis A"
        '
        'cbHepatitisA
        '
        Me.cbHepatitisA.AutoSize = True
        Me.cbHepatitisA.Location = New System.Drawing.Point(470, 81)
        Me.cbHepatitisA.Name = "cbHepatitisA"
        Me.cbHepatitisA.Size = New System.Drawing.Size(80, 17)
        Me.cbHepatitisA.TabIndex = 24
        Me.cbHepatitisA.Text = "Off"
        Me.cbHepatitisA.UseSelectable = True
        '
        'lblEnfermedades
        '
        Me.lblEnfermedades.AutoSize = True
        Me.lblEnfermedades.Location = New System.Drawing.Point(333, 40)
        Me.lblEnfermedades.Name = "lblEnfermedades"
        Me.lblEnfermedades.Size = New System.Drawing.Size(123, 19)
        Me.lblEnfermedades.TabIndex = 23
        Me.lblEnfermedades.Tag = "Tuvo enfermedades"
        Me.lblEnfermedades.Text = "Tuvo enfermedades"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(568, 222)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel10.TabIndex = 21
        '
        'cbEnfermedades
        '
        Me.cbEnfermedades.AutoSize = True
        Me.cbEnfermedades.Location = New System.Drawing.Point(470, 42)
        Me.cbEnfermedades.Name = "cbEnfermedades"
        Me.cbEnfermedades.Size = New System.Drawing.Size(80, 17)
        Me.cbEnfermedades.TabIndex = 22
        Me.cbEnfermedades.Text = "Off"
        Me.cbEnfermedades.UseSelectable = True
        '
        'lblHepatitisB
        '
        Me.lblHepatitisB.AutoSize = True
        Me.lblHepatitisB.Location = New System.Drawing.Point(333, 118)
        Me.lblHepatitisB.Name = "lblHepatitisB"
        Me.lblHepatitisB.Size = New System.Drawing.Size(71, 19)
        Me.lblHepatitisB.TabIndex = 39
        Me.lblHepatitisB.Tag = "Hepatitis B"
        Me.lblHepatitisB.Text = "Hepatitis B"
        '
        'cbHepatitisB
        '
        Me.cbHepatitisB.AutoSize = True
        Me.cbHepatitisB.Location = New System.Drawing.Point(470, 120)
        Me.cbHepatitisB.Name = "cbHepatitisB"
        Me.cbHepatitisB.Size = New System.Drawing.Size(80, 17)
        Me.cbHepatitisB.TabIndex = 38
        Me.cbHepatitisB.Text = "Off"
        Me.cbHepatitisB.UseSelectable = True
        '
        'lblAsma
        '
        Me.lblAsma.AutoSize = True
        Me.lblAsma.Location = New System.Drawing.Point(333, 194)
        Me.lblAsma.Name = "lblAsma"
        Me.lblAsma.Size = New System.Drawing.Size(42, 19)
        Me.lblAsma.TabIndex = 41
        Me.lblAsma.Tag = "Asma"
        Me.lblAsma.Text = "Asma"
        '
        'cbAsma
        '
        Me.cbAsma.AutoSize = True
        Me.cbAsma.Location = New System.Drawing.Point(470, 196)
        Me.cbAsma.Name = "cbAsma"
        Me.cbAsma.Size = New System.Drawing.Size(80, 17)
        Me.cbAsma.TabIndex = 40
        Me.cbAsma.Text = "Off"
        Me.cbAsma.UseSelectable = True
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Location = New System.Drawing.Point(591, 42)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(123, 19)
        Me.lblObraSocial.TabIndex = 43
        Me.lblObraSocial.Tag = "Tuvo enfermedades"
        Me.lblObraSocial.Text = "Tuvo enfermedades"
        '
        'cbObraSocial
        '
        Me.cbObraSocial.AutoSize = True
        Me.cbObraSocial.Location = New System.Drawing.Point(728, 44)
        Me.cbObraSocial.Name = "cbObraSocial"
        Me.cbObraSocial.Size = New System.Drawing.Size(80, 17)
        Me.cbObraSocial.TabIndex = 42
        Me.cbObraSocial.Text = "Off"
        Me.cbObraSocial.UseSelectable = True
        '
        'txtObraSocial
        '
        '
        '
        '
        Me.txtObraSocial.CustomButton.Image = Nothing
        Me.txtObraSocial.CustomButton.Location = New System.Drawing.Point(133, 2)
        Me.txtObraSocial.CustomButton.Name = ""
        Me.txtObraSocial.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtObraSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObraSocial.CustomButton.TabIndex = 1
        Me.txtObraSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObraSocial.CustomButton.UseSelectable = True
        Me.txtObraSocial.CustomButton.Visible = False
        Me.txtObraSocial.Lines = New String(-1) {}
        Me.txtObraSocial.Location = New System.Drawing.Point(655, 76)
        Me.txtObraSocial.MaxLength = 32767
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObraSocial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObraSocial.SelectedText = ""
        Me.txtObraSocial.SelectionLength = 0
        Me.txtObraSocial.SelectionStart = 0
        Me.txtObraSocial.ShortcutsEnabled = True
        Me.txtObraSocial.Size = New System.Drawing.Size(153, 22)
        Me.txtObraSocial.TabIndex = 45
        Me.txtObraSocial.UseSelectable = True
        Me.txtObraSocial.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObraSocial.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblCualObraSocial
        '
        Me.lblCualObraSocial.AutoSize = True
        Me.lblCualObraSocial.Location = New System.Drawing.Point(591, 76)
        Me.lblCualObraSocial.Name = "lblCualObraSocial"
        Me.lblCualObraSocial.Size = New System.Drawing.Size(35, 19)
        Me.lblCualObraSocial.TabIndex = 44
        Me.lblCualObraSocial.Tag = "Cual"
        Me.lblCualObraSocial.Text = "Cual"
        '
        'txtNumeroTelefonoOS
        '
        '
        '
        '
        Me.txtNumeroTelefonoOS.CustomButton.Image = Nothing
        Me.txtNumeroTelefonoOS.CustomButton.Location = New System.Drawing.Point(133, 2)
        Me.txtNumeroTelefonoOS.CustomButton.Name = ""
        Me.txtNumeroTelefonoOS.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNumeroTelefonoOS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumeroTelefonoOS.CustomButton.TabIndex = 1
        Me.txtNumeroTelefonoOS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumeroTelefonoOS.CustomButton.UseSelectable = True
        Me.txtNumeroTelefonoOS.CustomButton.Visible = False
        Me.txtNumeroTelefonoOS.Lines = New String(-1) {}
        Me.txtNumeroTelefonoOS.Location = New System.Drawing.Point(655, 118)
        Me.txtNumeroTelefonoOS.MaxLength = 32767
        Me.txtNumeroTelefonoOS.Name = "txtNumeroTelefonoOS"
        Me.txtNumeroTelefonoOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroTelefonoOS.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroTelefonoOS.SelectedText = ""
        Me.txtNumeroTelefonoOS.SelectionLength = 0
        Me.txtNumeroTelefonoOS.SelectionStart = 0
        Me.txtNumeroTelefonoOS.ShortcutsEnabled = True
        Me.txtNumeroTelefonoOS.Size = New System.Drawing.Size(153, 22)
        Me.txtNumeroTelefonoOS.TabIndex = 47
        Me.txtNumeroTelefonoOS.UseSelectable = True
        Me.txtNumeroTelefonoOS.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumeroTelefonoOS.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(591, 118)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(58, 19)
        Me.lblTelefono.TabIndex = 46
        Me.lblTelefono.Tag = "Cuales"
        Me.lblTelefono.Text = "Telefono"
        '
        'txtNumeroSocioOS
        '
        '
        '
        '
        Me.txtNumeroSocioOS.CustomButton.Image = Nothing
        Me.txtNumeroSocioOS.CustomButton.Location = New System.Drawing.Point(133, 2)
        Me.txtNumeroSocioOS.CustomButton.Name = ""
        Me.txtNumeroSocioOS.CustomButton.Size = New System.Drawing.Size(17, 17)
        Me.txtNumeroSocioOS.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNumeroSocioOS.CustomButton.TabIndex = 1
        Me.txtNumeroSocioOS.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNumeroSocioOS.CustomButton.UseSelectable = True
        Me.txtNumeroSocioOS.CustomButton.Visible = False
        Me.txtNumeroSocioOS.Lines = New String(-1) {}
        Me.txtNumeroSocioOS.Location = New System.Drawing.Point(655, 158)
        Me.txtNumeroSocioOS.MaxLength = 32767
        Me.txtNumeroSocioOS.Name = "txtNumeroSocioOS"
        Me.txtNumeroSocioOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroSocioOS.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroSocioOS.SelectedText = ""
        Me.txtNumeroSocioOS.SelectionLength = 0
        Me.txtNumeroSocioOS.SelectionStart = 0
        Me.txtNumeroSocioOS.ShortcutsEnabled = True
        Me.txtNumeroSocioOS.Size = New System.Drawing.Size(153, 22)
        Me.txtNumeroSocioOS.TabIndex = 49
        Me.txtNumeroSocioOS.UseSelectable = True
        Me.txtNumeroSocioOS.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNumeroSocioOS.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblNumeroSocio
        '
        Me.lblNumeroSocio.AutoSize = True
        Me.lblNumeroSocio.Location = New System.Drawing.Point(591, 158)
        Me.lblNumeroSocio.Name = "lblNumeroSocio"
        Me.lblNumeroSocio.Size = New System.Drawing.Size(61, 19)
        Me.lblNumeroSocio.TabIndex = 48
        Me.lblNumeroSocio.Tag = "Cuales"
        Me.lblNumeroSocio.Text = "Nº Socio"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(15, 145)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel4.TabIndex = 33
        Me.MetroLabel4.Tag = "Habitacion Propia"
        Me.MetroLabel4.Text = "Habitacion Propia"
        '
        'cbHabitacion
        '
        Me.cbHabitacion.AutoSize = True
        Me.cbHabitacion.Location = New System.Drawing.Point(152, 147)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(80, 17)
        Me.cbHabitacion.TabIndex = 32
        Me.cbHabitacion.Text = "Off"
        Me.cbHabitacion.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(15, 104)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel7.TabIndex = 27
        Me.MetroLabel7.Tag = "Vive Country"
        Me.MetroLabel7.Text = "Vive Country"
        '
        'cbCountry
        '
        Me.cbCountry.AutoSize = True
        Me.cbCountry.Location = New System.Drawing.Point(152, 106)
        Me.cbCountry.Name = "cbCountry"
        Me.cbCountry.Size = New System.Drawing.Size(80, 17)
        Me.cbCountry.TabIndex = 26
        Me.cbCountry.Text = "Off"
        Me.cbCountry.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(15, 62)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel8.TabIndex = 25
        Me.MetroLabel8.Tag = "Vive Departamento"
        Me.MetroLabel8.Text = "Vive Departamento"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.AutoSize = True
        Me.cbDepartamento.Location = New System.Drawing.Point(152, 62)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(80, 17)
        Me.cbDepartamento.TabIndex = 24
        Me.cbDepartamento.Text = "Off"
        Me.cbDepartamento.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(15, 21)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel9.TabIndex = 23
        Me.MetroLabel9.Tag = "Vive Casa"
        Me.MetroLabel9.Text = "Vive Casa"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(250, 203)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel11.TabIndex = 21
        '
        'cbCasa
        '
        Me.cbCasa.AutoSize = True
        Me.cbCasa.Location = New System.Drawing.Point(152, 23)
        Me.cbCasa.Name = "cbCasa"
        Me.cbCasa.Size = New System.Drawing.Size(80, 17)
        Me.cbCasa.TabIndex = 22
        Me.cbCasa.Text = "Off"
        Me.cbCasa.UseSelectable = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(15, 184)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel12.TabIndex = 39
        Me.MetroLabel12.Tag = "Patio"
        Me.MetroLabel12.Text = "Patio"
        '
        'cbPatio
        '
        Me.cbPatio.AutoSize = True
        Me.cbPatio.Location = New System.Drawing.Point(152, 186)
        Me.cbPatio.Name = "cbPatio"
        Me.cbPatio.Size = New System.Drawing.Size(80, 17)
        Me.cbPatio.TabIndex = 38
        Me.cbPatio.Text = "Off"
        Me.cbPatio.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(16, 195)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel2.TabIndex = 50
        Me.MetroLabel2.Tag = "Papa Trabaja"
        Me.MetroLabel2.Text = "Papa Trabaja"
        '
        'cbPapaTrabaja
        '
        Me.cbPapaTrabaja.AutoSize = True
        Me.cbPapaTrabaja.Location = New System.Drawing.Point(153, 197)
        Me.cbPapaTrabaja.Name = "cbPapaTrabaja"
        Me.cbPapaTrabaja.Size = New System.Drawing.Size(80, 17)
        Me.cbPapaTrabaja.TabIndex = 49
        Me.cbPapaTrabaja.Text = "Off"
        Me.cbPapaTrabaja.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 156)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel3.TabIndex = 48
        Me.MetroLabel3.Tag = "Vive con Tio"
        Me.MetroLabel3.Text = "Vive con Tio"
        '
        'cbViveTio
        '
        Me.cbViveTio.AutoSize = True
        Me.cbViveTio.Location = New System.Drawing.Point(153, 158)
        Me.cbViveTio.Name = "cbViveTio"
        Me.cbViveTio.Size = New System.Drawing.Size(80, 17)
        Me.cbViveTio.TabIndex = 47
        Me.cbViveTio.Text = "Off"
        Me.cbViveTio.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(16, 115)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel5.TabIndex = 46
        Me.MetroLabel5.Tag = "Vive con Abuela"
        Me.MetroLabel5.Text = "Vive con Abuela"
        '
        'cbViveAbuela
        '
        Me.cbViveAbuela.AutoSize = True
        Me.cbViveAbuela.Location = New System.Drawing.Point(153, 117)
        Me.cbViveAbuela.Name = "cbViveAbuela"
        Me.cbViveAbuela.Size = New System.Drawing.Size(80, 17)
        Me.cbViveAbuela.TabIndex = 45
        Me.cbViveAbuela.Text = "Off"
        Me.cbViveAbuela.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(16, 73)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel6.TabIndex = 44
        Me.MetroLabel6.Tag = "Hermanos"
        Me.MetroLabel6.Text = "Hermanos"
        '
        'cbHermanos
        '
        Me.cbHermanos.AutoSize = True
        Me.cbHermanos.Location = New System.Drawing.Point(153, 73)
        Me.cbHermanos.Name = "cbHermanos"
        Me.cbHermanos.Size = New System.Drawing.Size(80, 17)
        Me.cbHermanos.TabIndex = 43
        Me.cbHermanos.Text = "Off"
        Me.cbHermanos.UseSelectable = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(16, 32)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel13.TabIndex = 42
        Me.MetroLabel13.Tag = "Padres separados"
        Me.MetroLabel13.Text = "Padres separados"
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(251, 214)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(0, 0)
        Me.MetroLabel14.TabIndex = 40
        '
        'cbPadresSeparados
        '
        Me.cbPadresSeparados.AutoSize = True
        Me.cbPadresSeparados.Location = New System.Drawing.Point(153, 34)
        Me.cbPadresSeparados.Name = "cbPadresSeparados"
        Me.cbPadresSeparados.Size = New System.Drawing.Size(80, 17)
        Me.cbPadresSeparados.TabIndex = 41
        Me.cbPadresSeparados.Text = "Off"
        Me.cbPadresSeparados.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(16, 237)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel15.TabIndex = 52
        Me.MetroLabel15.Tag = "Mama Trabaja"
        Me.MetroLabel15.Text = "Mama Trabaja"
        '
        'cbMamaTrabaja
        '
        Me.cbMamaTrabaja.AutoSize = True
        Me.cbMamaTrabaja.Location = New System.Drawing.Point(153, 239)
        Me.cbMamaTrabaja.Name = "cbMamaTrabaja"
        Me.cbMamaTrabaja.Size = New System.Drawing.Size(80, 17)
        Me.cbMamaTrabaja.TabIndex = 51
        Me.cbMamaTrabaja.Text = "Off"
        Me.cbMamaTrabaja.UseSelectable = True
        '
        'iuAltaAlumnoFichas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 456)
        Me.Controls.Add(Me.btnRegistraFicha)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "iuAltaAlumnoFichas"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.mtFichaMedica.ResumeLayout(False)
        Me.mtFichaMedica.PerformLayout()
        Me.mtFichaCasa.ResumeLayout(False)
        Me.mtFichaCasa.PerformLayout()
        Me.mtFichaFamilia.ResumeLayout(False)
        Me.mtFichaFamilia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents mtFichaMedica As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtFichaCasa As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtFichaFamilia As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnRegistraFicha As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNumeroSocioOS As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblNumeroSocio As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumeroTelefonoOS As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblTelefono As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObraSocial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCualObraSocial As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblObraSocial As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbObraSocial As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblAsma As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbAsma As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblHepatitisB As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHepatitisB As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtOtrasEnfermedades As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblOtrasEnfermedades As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHipertension As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHipertension As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblDiabetes As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbDiabetes As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblHepatitisA As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHepatitisA As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblEnfermedades As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbEnfermedades As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtOtrosAlergias As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblOtros As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCualesElementos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCualesElementos As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAlergiaElementos As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbElemento As MetroFramework.Controls.MetroToggle
    Friend WithEvents txtCualesALimentos As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCualesMedicamento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblCualesAlimento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblCualesMedicamento As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAlergiaALimento As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbAlimento As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblAlergiaMedicamento As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbMedicamento As MetroFramework.Controls.MetroToggle
    Friend WithEvents lblTieneAlergias As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbAlergias As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbPatio As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHabitacion As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCountry As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbDepartamento As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbCasa As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbMamaTrabaja As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbPapaTrabaja As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbViveTio As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbViveAbuela As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbHermanos As MetroFramework.Controls.MetroToggle
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbPadresSeparados As MetroFramework.Controls.MetroToggle
End Class
