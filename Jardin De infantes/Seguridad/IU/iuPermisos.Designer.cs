namespace IU
{
    partial class iuPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBitacora = new MetroFramework.Controls.MetroTabControl();
            this.tabVerPorUsuario = new MetroFramework.Controls.MetroTabPage();
            this.btnAgregarPermiso = new System.Windows.Forms.Button();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.lbListaRoles = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoles = new System.Windows.Forms.TextBox();
            this.lblFamiliaAgregar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFamiliaAgregar = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPatente = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVerControlDeCambios = new MetroFramework.Controls.MetroTabPage();
            this.lbFamiliaPAtente = new System.Windows.Forms.TextBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFamilia = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbModulos = new System.Windows.Forms.ListBox();
            this.btnAgregarRolUsuario = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbRolesDelUsuario = new System.Windows.Forms.ListBox();
            this.lbUsuariosListaFamilia = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbMostrarUsuario = new MetroFramework.Controls.MetroComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtnombre = new MetroFramework.Controls.MetroTextBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtTipo = new MetroFramework.Controls.MetroComboBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.tabBitacora.SuspendLayout();
            this.tabVerPorUsuario.SuspendLayout();
            this.tabVerControlDeCambios.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBitacora
            // 
            this.tabBitacora.Controls.Add(this.tabVerPorUsuario);
            this.tabBitacora.Controls.Add(this.tabVerControlDeCambios);
            this.tabBitacora.Controls.Add(this.metroTabPage1);
            this.tabBitacora.Controls.Add(this.metroTabPage2);
            this.tabBitacora.Location = new System.Drawing.Point(4, 30);
            this.tabBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.SelectedIndex = 3;
            this.tabBitacora.Size = new System.Drawing.Size(799, 319);
            this.tabBitacora.TabIndex = 10;
            this.tabBitacora.Tag = "";
            this.tabBitacora.UseSelectable = true;
            // 
            // tabVerPorUsuario
            // 
            this.tabVerPorUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabVerPorUsuario.Controls.Add(this.btnAgregarPermiso);
            this.tabVerPorUsuario.Controls.Add(this.btnAgregarRol);
            this.tabVerPorUsuario.Controls.Add(this.lbListaRoles);
            this.tabVerPorUsuario.Controls.Add(this.label5);
            this.tabVerPorUsuario.Controls.Add(this.txtRoles);
            this.tabVerPorUsuario.Controls.Add(this.lblFamiliaAgregar);
            this.tabVerPorUsuario.Controls.Add(this.label6);
            this.tabVerPorUsuario.Controls.Add(this.lbFamiliaAgregar);
            this.tabVerPorUsuario.Controls.Add(this.label4);
            this.tabVerPorUsuario.Controls.Add(this.lbPatente);
            this.tabVerPorUsuario.Controls.Add(this.label1);
            this.helpProvider1.SetHelpKeyword(this.tabVerPorUsuario, "Agregar roles");
            this.helpProvider1.SetHelpNavigator(this.tabVerPorUsuario, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVerPorUsuario.HorizontalScrollbarBarColor = true;
            this.tabVerPorUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVerPorUsuario.HorizontalScrollbarSize = 6;
            this.tabVerPorUsuario.Location = new System.Drawing.Point(4, 38);
            this.tabVerPorUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tabVerPorUsuario.Name = "tabVerPorUsuario";
            this.helpProvider1.SetShowHelp(this.tabVerPorUsuario, true);
            this.tabVerPorUsuario.Size = new System.Drawing.Size(791, 277);
            this.tabVerPorUsuario.TabIndex = 1;
            this.tabVerPorUsuario.Tag = "Agregar roles";
            this.tabVerPorUsuario.Text = "Agregar Roles";
            this.tabVerPorUsuario.VerticalScrollbarBarColor = true;
            this.tabVerPorUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.tabVerPorUsuario.VerticalScrollbarSize = 7;
            this.tabVerPorUsuario.Click += new System.EventHandler(this.tabVerPorUsuario_Click);
            // 
            // btnAgregarPermiso
            // 
            this.btnAgregarPermiso.Location = new System.Drawing.Point(294, 185);
            this.btnAgregarPermiso.Name = "btnAgregarPermiso";
            this.btnAgregarPermiso.Size = new System.Drawing.Size(120, 23);
            this.btnAgregarPermiso.TabIndex = 21;
            this.btnAgregarPermiso.Text = "Agregar Permiso";
            this.btnAgregarPermiso.UseVisualStyleBackColor = true;
            this.btnAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Location = new System.Drawing.Point(158, 185);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRol.TabIndex = 20;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbListaRoles
            // 
            this.lbListaRoles.FormattingEnabled = true;
            this.lbListaRoles.Location = new System.Drawing.Point(146, 67);
            this.lbListaRoles.Name = "lbListaRoles";
            this.lbListaRoles.Size = new System.Drawing.Size(120, 95);
            this.lbListaRoles.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lista de Roles";
            // 
            // txtRoles
            // 
            this.txtRoles.Location = new System.Drawing.Point(499, 44);
            this.txtRoles.Multiline = true;
            this.txtRoles.Name = "txtRoles";
            this.txtRoles.Size = new System.Drawing.Size(178, 209);
            this.txtRoles.TabIndex = 17;
            // 
            // lblFamiliaAgregar
            // 
            this.lblFamiliaAgregar.AutoSize = true;
            this.lblFamiliaAgregar.Location = new System.Drawing.Point(594, 14);
            this.lblFamiliaAgregar.Name = "lblFamiliaAgregar";
            this.lblFamiliaAgregar.Size = new System.Drawing.Size(0, 13);
            this.lblFamiliaAgregar.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Roles de la familia";
            // 
            // lbFamiliaAgregar
            // 
            this.lbFamiliaAgregar.FormattingEnabled = true;
            this.lbFamiliaAgregar.Location = new System.Drawing.Point(4, 67);
            this.lbFamiliaAgregar.Name = "lbFamiliaAgregar";
            this.lbFamiliaAgregar.Size = new System.Drawing.Size(120, 95);
            this.lbFamiliaAgregar.TabIndex = 14;
            this.lbFamiliaAgregar.SelectedIndexChanged += new System.EventHandler(this.lbFamiliaAgregar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rol";
            // 
            // lbPatente
            // 
            this.lbPatente.FormattingEnabled = true;
            this.lbPatente.Location = new System.Drawing.Point(294, 67);
            this.lbPatente.Name = "lbPatente";
            this.lbPatente.Size = new System.Drawing.Size(120, 95);
            this.lbPatente.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Permiso";
            // 
            // tabVerControlDeCambios
            // 
            this.tabVerControlDeCambios.Controls.Add(this.lbFamiliaPAtente);
            this.tabVerControlDeCambios.Controls.Add(this.lblRoles);
            this.tabVerControlDeCambios.Controls.Add(this.label3);
            this.tabVerControlDeCambios.Controls.Add(this.lbFamilia);
            this.tabVerControlDeCambios.Controls.Add(this.label2);
            this.helpProvider1.SetHelpKeyword(this.tabVerControlDeCambios, "Ver roles");
            this.helpProvider1.SetHelpNavigator(this.tabVerControlDeCambios, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVerControlDeCambios.HorizontalScrollbarBarColor = true;
            this.tabVerControlDeCambios.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVerControlDeCambios.HorizontalScrollbarSize = 10;
            this.tabVerControlDeCambios.Location = new System.Drawing.Point(4, 38);
            this.tabVerControlDeCambios.Name = "tabVerControlDeCambios";
            this.helpProvider1.SetShowHelp(this.tabVerControlDeCambios, true);
            this.tabVerControlDeCambios.Size = new System.Drawing.Size(791, 277);
            this.tabVerControlDeCambios.TabIndex = 3;
            this.tabVerControlDeCambios.Tag = "Ver roles";
            this.tabVerControlDeCambios.Text = "Ver Roles";
            this.tabVerControlDeCambios.VerticalScrollbarBarColor = true;
            this.tabVerControlDeCambios.VerticalScrollbarHighlightOnWheel = false;
            this.tabVerControlDeCambios.VerticalScrollbarSize = 10;
            this.tabVerControlDeCambios.Click += new System.EventHandler(this.tabVerControlDeCambios_Click);
            // 
            // lbFamiliaPAtente
            // 
            this.lbFamiliaPAtente.Location = new System.Drawing.Point(206, 38);
            this.lbFamiliaPAtente.Multiline = true;
            this.lbFamiliaPAtente.Name = "lbFamiliaPAtente";
            this.lbFamiliaPAtente.Size = new System.Drawing.Size(178, 209);
            this.lbFamiliaPAtente.TabIndex = 12;
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Location = new System.Drawing.Point(313, 11);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(0, 13);
            this.lblRoles.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Roles de la familia";
            // 
            // lbFamilia
            // 
            this.lbFamilia.FormattingEnabled = true;
            this.lbFamilia.Location = new System.Drawing.Point(14, 56);
            this.lbFamilia.Name = "lbFamilia";
            this.lbFamilia.Size = new System.Drawing.Size(120, 95);
            this.lbFamilia.TabIndex = 9;
            this.lbFamilia.SelectedIndexChanged += new System.EventHandler(this.lbFamilia_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Familia";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.lbModulos);
            this.metroTabPage1.Controls.Add(this.btnAgregarRolUsuario);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.lbRolesDelUsuario);
            this.metroTabPage1.Controls.Add(this.lbUsuariosListaFamilia);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.cbMostrarUsuario);
            this.helpProvider1.SetHelpKeyword(this.metroTabPage1, "Asignar permisos");
            this.helpProvider1.SetHelpNavigator(this.metroTabPage1, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.helpProvider1.SetShowHelp(this.metroTabPage1, true);
            this.metroTabPage1.Size = new System.Drawing.Size(791, 277);
            this.metroTabPage1.TabIndex = 4;
            this.metroTabPage1.Text = "Asignar permisos";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(658, 12);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(60, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Modulos";
            // 
            // lbModulos
            // 
            this.lbModulos.FormattingEnabled = true;
            this.lbModulos.Location = new System.Drawing.Point(663, 34);
            this.lbModulos.Name = "lbModulos";
            this.lbModulos.Size = new System.Drawing.Size(120, 95);
            this.lbModulos.TabIndex = 15;
            // 
            // btnAgregarRolUsuario
            // 
            this.btnAgregarRolUsuario.Location = new System.Drawing.Point(303, 135);
            this.btnAgregarRolUsuario.Name = "btnAgregarRolUsuario";
            this.btnAgregarRolUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarRolUsuario.TabIndex = 14;
            this.btnAgregarRolUsuario.Tag = "Agregar";
            this.btnAgregarRolUsuario.Text = "Agregar";
            this.btnAgregarRolUsuario.UseSelectable = true;
            this.btnAgregarRolUsuario.Click += new System.EventHandler(this.btnAgregarRolUsuario_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(505, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Roles del usuario";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(303, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Roles";
            // 
            // lbRolesDelUsuario
            // 
            this.lbRolesDelUsuario.FormattingEnabled = true;
            this.lbRolesDelUsuario.Location = new System.Drawing.Point(505, 34);
            this.lbRolesDelUsuario.Name = "lbRolesDelUsuario";
            this.lbRolesDelUsuario.Size = new System.Drawing.Size(120, 95);
            this.lbRolesDelUsuario.TabIndex = 11;
            // 
            // lbUsuariosListaFamilia
            // 
            this.lbUsuariosListaFamilia.FormattingEnabled = true;
            this.lbUsuariosListaFamilia.Location = new System.Drawing.Point(303, 34);
            this.lbUsuariosListaFamilia.Name = "lbUsuariosListaFamilia";
            this.lbUsuariosListaFamilia.Size = new System.Drawing.Size(120, 95);
            this.lbUsuariosListaFamilia.TabIndex = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuario";
            // 
            // cbMostrarUsuario
            // 
            this.cbMostrarUsuario.FormattingEnabled = true;
            this.cbMostrarUsuario.ItemHeight = 23;
            this.cbMostrarUsuario.Location = new System.Drawing.Point(109, 24);
            this.cbMostrarUsuario.Name = "cbMostrarUsuario";
            this.cbMostrarUsuario.Size = new System.Drawing.Size(121, 29);
            this.cbMostrarUsuario.TabIndex = 2;
            this.cbMostrarUsuario.UseSelectable = true;
            this.cbMostrarUsuario.SelectedIndexChanged += new System.EventHandler(this.cbMostrarUsuario_SelectedIndexChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnAgregar);
            this.metroTabPage2.Controls.Add(this.txtTipo);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.Controls.Add(this.txtDescripcion);
            this.metroTabPage2.Controls.Add(this.txtnombre);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(791, 277);
            this.metroTabPage2.TabIndex = 5;
            this.metroTabPage2.Text = "Agregar Permisos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // txtnombre
            // 
            this.txtnombre.Lines = new string[0];
            this.txtnombre.Location = new System.Drawing.Point(223, 57);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnombre.SelectedText = "";
            this.txtnombre.Size = new System.Drawing.Size(97, 23);
            this.txtnombre.TabIndex = 2;
            this.txtnombre.UseSelectable = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(223, 110);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.Size = new System.Drawing.Size(315, 23);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 61);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(59, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Nombre";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(38, 114);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Descripcion";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(38, 189);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Tipo ";
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.ItemHeight = 23;
            this.txtTipo.Items.AddRange(new object[] {
            "Permiso",
            "Rol"});
            this.txtTipo.Location = new System.Drawing.Point(223, 179);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(121, 29);
            this.txtTipo.TabIndex = 7;
            this.txtTipo.UseSelectable = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(586, 203);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 40);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Tag = "Agregar";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // iuPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.tabBitacora);
            this.helpProvider1.SetHelpKeyword(this, "Pantalla principal de gestión de permiso");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "iuPermisos";
            this.helpProvider1.SetShowHelp(this, true);
            this.Load += new System.EventHandler(this.iuPermisos_Load);
            this.tabBitacora.ResumeLayout(false);
            this.tabVerPorUsuario.ResumeLayout(false);
            this.tabVerPorUsuario.PerformLayout();
            this.tabVerControlDeCambios.ResumeLayout(false);
            this.tabVerControlDeCambios.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal MetroFramework.Controls.MetroTabControl tabBitacora;
        internal MetroFramework.Controls.MetroTabPage tabVerPorUsuario;
        private MetroFramework.Controls.MetroTabPage tabVerControlDeCambios;
        private System.Windows.Forms.ListBox lbFamilia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbFamiliaPAtente;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbFamiliaAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoles;
        private System.Windows.Forms.Label lblFamiliaAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbListaRoles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Button btnAgregarPermiso;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.ListBox lbUsuariosListaFamilia;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbMostrarUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ListBox lbRolesDelUsuario;
        private MetroFramework.Controls.MetroButton btnAgregarRolUsuario;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.ListBox lbModulos;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private MetroFramework.Controls.MetroComboBox txtTipo;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private MetroFramework.Controls.MetroTextBox txtnombre;
    }
}