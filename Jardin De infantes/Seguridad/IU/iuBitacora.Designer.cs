namespace IU
{
    partial class iuBitacora
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabBitacora = new MetroFramework.Controls.MetroTabControl();
            this.tabVertodos = new MetroFramework.Controls.MetroTabPage();
            this.btnVerTodos = new MetroFramework.Controls.MetroButton();
            this.dgvVerTodos = new MetroFramework.Controls.MetroGrid();
            this.tabVerPorUsuario = new MetroFramework.Controls.MetroTabPage();
            this.txtBuscarUSuario = new MetroFramework.Controls.MetroComboBox();
            this.dgvPorUsuario = new MetroFramework.Controls.MetroGrid();
            this.btnBuscar = new MetroFramework.Controls.MetroButton();
            this.tabVerPorEvento = new MetroFramework.Controls.MetroTabPage();
            this.btnBuscarEvento = new MetroFramework.Controls.MetroButton();
            this.txtEvento = new MetroFramework.Controls.MetroComboBox();
            this.dgvPorEvento = new MetroFramework.Controls.MetroGrid();
            this.tabVerControlDeCambios = new MetroFramework.Controls.MetroTabPage();
            this.btnBuscarControlCambios = new MetroFramework.Controls.MetroButton();
            this.cbBuscarUsuarioCambios = new MetroFramework.Controls.MetroComboBox();
            this.dgvVerControlDeCambios = new MetroFramework.Controls.MetroGrid();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabBitacora.SuspendLayout();
            this.tabVertodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTodos)).BeginInit();
            this.tabVerPorUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorUsuario)).BeginInit();
            this.tabVerPorEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorEvento)).BeginInit();
            this.tabVerControlDeCambios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerControlDeCambios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBitacora
            // 
            this.tabBitacora.Controls.Add(this.tabVertodos);
            this.tabBitacora.Controls.Add(this.tabVerPorUsuario);
            this.tabBitacora.Controls.Add(this.tabVerPorEvento);
            this.tabBitacora.Controls.Add(this.tabVerControlDeCambios);
            this.helpProvider1.SetHelpKeyword(this.tabBitacora, "Gestion de Bitacora");
            this.helpProvider1.SetHelpNavigator(this.tabBitacora, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabBitacora.Location = new System.Drawing.Point(4, 46);
            this.tabBitacora.Margin = new System.Windows.Forms.Padding(2);
            this.tabBitacora.Name = "tabBitacora";
            this.tabBitacora.SelectedIndex = 0;
            this.helpProvider1.SetShowHelp(this.tabBitacora, true);
            this.tabBitacora.Size = new System.Drawing.Size(774, 319);
            this.tabBitacora.TabIndex = 2;
            this.tabBitacora.Tag = "";
            this.tabBitacora.UseSelectable = true;
            // 
            // tabVertodos
            // 
            this.tabVertodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabVertodos.Controls.Add(this.btnVerTodos);
            this.tabVertodos.Controls.Add(this.dgvVerTodos);
            this.helpProvider1.SetHelpKeyword(this.tabVertodos, "Pantalla ver todos Bitacora");
            this.helpProvider1.SetHelpNavigator(this.tabVertodos, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVertodos.HorizontalScrollbarBarColor = true;
            this.tabVertodos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVertodos.HorizontalScrollbarSize = 6;
            this.tabVertodos.Location = new System.Drawing.Point(4, 38);
            this.tabVertodos.Margin = new System.Windows.Forms.Padding(2);
            this.tabVertodos.Name = "tabVertodos";
            this.helpProvider1.SetShowHelp(this.tabVertodos, true);
            this.tabVertodos.Size = new System.Drawing.Size(766, 277);
            this.tabVertodos.TabIndex = 0;
            this.tabVertodos.Tag = "Ver todos";
            this.tabVertodos.Text = "Ver todos";
            this.tabVertodos.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabVertodos.VerticalScrollbarBarColor = true;
            this.tabVertodos.VerticalScrollbarHighlightOnWheel = false;
            this.tabVertodos.VerticalScrollbarSize = 7;
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(254, 11);
            this.btnVerTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(97, 16);
            this.btnVerTodos.TabIndex = 17;
            this.btnVerTodos.Tag = "Ver todos";
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseSelectable = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // dgvVerTodos
            // 
            this.dgvVerTodos.AllowUserToResizeRows = false;
            this.dgvVerTodos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVerTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVerTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVerTodos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTodos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvVerTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerTodos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvVerTodos.EnableHeadersVisualStyles = false;
            this.dgvVerTodos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVerTodos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVerTodos.Location = new System.Drawing.Point(8, 46);
            this.dgvVerTodos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVerTodos.Name = "dgvVerTodos";
            this.dgvVerTodos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerTodos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvVerTodos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVerTodos.RowTemplate.Height = 28;
            this.dgvVerTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerTodos.Size = new System.Drawing.Size(554, 208);
            this.dgvVerTodos.TabIndex = 16;
            // 
            // tabVerPorUsuario
            // 
            this.tabVerPorUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabVerPorUsuario.Controls.Add(this.txtBuscarUSuario);
            this.tabVerPorUsuario.Controls.Add(this.dgvPorUsuario);
            this.tabVerPorUsuario.Controls.Add(this.btnBuscar);
            this.helpProvider1.SetHelpKeyword(this.tabVerPorUsuario, "Pantalla ver por usuario Bitacora");
            this.helpProvider1.SetHelpNavigator(this.tabVerPorUsuario, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVerPorUsuario.HorizontalScrollbarBarColor = true;
            this.tabVerPorUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVerPorUsuario.HorizontalScrollbarSize = 6;
            this.tabVerPorUsuario.Location = new System.Drawing.Point(4, 38);
            this.tabVerPorUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tabVerPorUsuario.Name = "tabVerPorUsuario";
            this.helpProvider1.SetShowHelp(this.tabVerPorUsuario, true);
            this.tabVerPorUsuario.Size = new System.Drawing.Size(766, 277);
            this.tabVerPorUsuario.TabIndex = 1;
            this.tabVerPorUsuario.Tag = "Ver por usuario";
            this.tabVerPorUsuario.Text = "Ver por usuario";
            this.tabVerPorUsuario.VerticalScrollbarBarColor = true;
            this.tabVerPorUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.tabVerPorUsuario.VerticalScrollbarSize = 7;
            // 
            // txtBuscarUSuario
            // 
            this.txtBuscarUSuario.FormattingEnabled = true;
            this.txtBuscarUSuario.ItemHeight = 23;
            this.txtBuscarUSuario.Location = new System.Drawing.Point(319, 10);
            this.txtBuscarUSuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarUSuario.Name = "txtBuscarUSuario";
            this.txtBuscarUSuario.Size = new System.Drawing.Size(237, 29);
            this.txtBuscarUSuario.TabIndex = 5;
            this.txtBuscarUSuario.UseSelectable = true;
            this.txtBuscarUSuario.SelectedIndexChanged += new System.EventHandler(this.txtBuscarUSuario_SelectedIndexChanged);
            // 
            // dgvPorUsuario
            // 
            this.dgvPorUsuario.AllowUserToResizeRows = false;
            this.dgvPorUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPorUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPorUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPorUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPorUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorUsuario.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPorUsuario.EnableHeadersVisualStyles = false;
            this.dgvPorUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPorUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPorUsuario.Location = new System.Drawing.Point(19, 41);
            this.dgvPorUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPorUsuario.Name = "dgvPorUsuario";
            this.dgvPorUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPorUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPorUsuario.RowTemplate.Height = 28;
            this.dgvPorUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorUsuario.Size = new System.Drawing.Size(525, 216);
            this.dgvPorUsuario.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(221, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 20);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Tag = "Buscar";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseSelectable = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabVerPorEvento
            // 
            this.tabVerPorEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabVerPorEvento.Controls.Add(this.btnBuscarEvento);
            this.tabVerPorEvento.Controls.Add(this.txtEvento);
            this.tabVerPorEvento.Controls.Add(this.dgvPorEvento);
            this.helpProvider1.SetHelpKeyword(this.tabVerPorEvento, "Pantalla ver por evento Bitacora");
            this.helpProvider1.SetHelpNavigator(this.tabVerPorEvento, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVerPorEvento.HorizontalScrollbarBarColor = true;
            this.tabVerPorEvento.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVerPorEvento.HorizontalScrollbarSize = 6;
            this.tabVerPorEvento.Location = new System.Drawing.Point(4, 38);
            this.tabVerPorEvento.Margin = new System.Windows.Forms.Padding(2);
            this.tabVerPorEvento.Name = "tabVerPorEvento";
            this.helpProvider1.SetShowHelp(this.tabVerPorEvento, true);
            this.tabVerPorEvento.Size = new System.Drawing.Size(766, 277);
            this.tabVerPorEvento.TabIndex = 2;
            this.tabVerPorEvento.Tag = "Ver por evento";
            this.tabVerPorEvento.Text = "Ver por evento";
            this.tabVerPorEvento.VerticalScrollbarBarColor = true;
            this.tabVerPorEvento.VerticalScrollbarHighlightOnWheel = false;
            this.tabVerPorEvento.VerticalScrollbarSize = 7;
            this.tabVerPorEvento.Click += new System.EventHandler(this.tabVerPorEvento_Click);
            // 
            // btnBuscarEvento
            // 
            this.btnBuscarEvento.Location = new System.Drawing.Point(242, 12);
            this.btnBuscarEvento.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEvento.Name = "btnBuscarEvento";
            this.btnBuscarEvento.Size = new System.Drawing.Size(62, 20);
            this.btnBuscarEvento.TabIndex = 2;
            this.btnBuscarEvento.Tag = "Buscar";
            this.btnBuscarEvento.Text = "Buscar";
            this.btnBuscarEvento.UseSelectable = true;
            this.btnBuscarEvento.Click += new System.EventHandler(this.btnBuscarEvento_Click);
            // 
            // txtEvento
            // 
            this.txtEvento.FormattingEnabled = true;
            this.txtEvento.ItemHeight = 23;
            this.txtEvento.Location = new System.Drawing.Point(336, 13);
            this.txtEvento.Margin = new System.Windows.Forms.Padding(2);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(237, 29);
            this.txtEvento.TabIndex = 4;
            this.txtEvento.UseSelectable = true;
            this.txtEvento.SelectedIndexChanged += new System.EventHandler(this.txtEvento_SelectedIndexChanged);
            // 
            // dgvPorEvento
            // 
            this.dgvPorEvento.AllowUserToResizeRows = false;
            this.dgvPorEvento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPorEvento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPorEvento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPorEvento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorEvento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPorEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPorEvento.DefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPorEvento.EnableHeadersVisualStyles = false;
            this.dgvPorEvento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPorEvento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPorEvento.Location = new System.Drawing.Point(5, 43);
            this.dgvPorEvento.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPorEvento.Name = "dgvPorEvento";
            this.dgvPorEvento.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPorEvento.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPorEvento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPorEvento.RowTemplate.Height = 28;
            this.dgvPorEvento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPorEvento.Size = new System.Drawing.Size(565, 211);
            this.dgvPorEvento.TabIndex = 3;
            // 
            // tabVerControlDeCambios
            // 
            this.tabVerControlDeCambios.Controls.Add(this.btnBuscarControlCambios);
            this.tabVerControlDeCambios.Controls.Add(this.cbBuscarUsuarioCambios);
            this.tabVerControlDeCambios.Controls.Add(this.dgvVerControlDeCambios);
            this.helpProvider1.SetHelpKeyword(this.tabVerControlDeCambios, "Pantalla gestión de cambios Bitacora");
            this.helpProvider1.SetHelpNavigator(this.tabVerControlDeCambios, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabVerControlDeCambios.HorizontalScrollbarBarColor = true;
            this.tabVerControlDeCambios.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVerControlDeCambios.HorizontalScrollbarSize = 10;
            this.tabVerControlDeCambios.Location = new System.Drawing.Point(4, 38);
            this.tabVerControlDeCambios.Name = "tabVerControlDeCambios";
            this.helpProvider1.SetShowHelp(this.tabVerControlDeCambios, true);
            this.tabVerControlDeCambios.Size = new System.Drawing.Size(766, 277);
            this.tabVerControlDeCambios.TabIndex = 3;
            this.tabVerControlDeCambios.Tag = "Ver control de cambios";
            this.tabVerControlDeCambios.Text = "Ver control de cambios";
            this.tabVerControlDeCambios.VerticalScrollbarBarColor = true;
            this.tabVerControlDeCambios.VerticalScrollbarHighlightOnWheel = false;
            this.tabVerControlDeCambios.VerticalScrollbarSize = 10;
            this.tabVerControlDeCambios.Click += new System.EventHandler(this.tabVerControlDeCambios_Click);
            // 
            // btnBuscarControlCambios
            // 
            this.btnBuscarControlCambios.Location = new System.Drawing.Point(14, 21);
            this.btnBuscarControlCambios.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarControlCambios.Name = "btnBuscarControlCambios";
            this.btnBuscarControlCambios.Size = new System.Drawing.Size(62, 20);
            this.btnBuscarControlCambios.TabIndex = 5;
            this.btnBuscarControlCambios.Tag = "Buscar";
            this.btnBuscarControlCambios.Text = "Buscar";
            this.btnBuscarControlCambios.UseSelectable = true;
            this.btnBuscarControlCambios.Click += new System.EventHandler(this.btnBuscarControlCambios_Click);
            // 
            // cbBuscarUsuarioCambios
            // 
            this.cbBuscarUsuarioCambios.FormattingEnabled = true;
            this.cbBuscarUsuarioCambios.ItemHeight = 23;
            this.cbBuscarUsuarioCambios.Location = new System.Drawing.Point(231, 12);
            this.cbBuscarUsuarioCambios.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuscarUsuarioCambios.Name = "cbBuscarUsuarioCambios";
            this.cbBuscarUsuarioCambios.Size = new System.Drawing.Size(237, 29);
            this.cbBuscarUsuarioCambios.TabIndex = 7;
            this.cbBuscarUsuarioCambios.UseSelectable = true;
            this.cbBuscarUsuarioCambios.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // dgvVerControlDeCambios
            // 
            this.dgvVerControlDeCambios.AllowUserToResizeRows = false;
            this.dgvVerControlDeCambios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVerControlDeCambios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVerControlDeCambios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVerControlDeCambios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerControlDeCambios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvVerControlDeCambios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerControlDeCambios.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvVerControlDeCambios.EnableHeadersVisualStyles = false;
            this.dgvVerControlDeCambios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvVerControlDeCambios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvVerControlDeCambios.Location = new System.Drawing.Point(2, 51);
            this.dgvVerControlDeCambios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVerControlDeCambios.Name = "dgvVerControlDeCambios";
            this.dgvVerControlDeCambios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerControlDeCambios.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvVerControlDeCambios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvVerControlDeCambios.RowTemplate.Height = 28;
            this.dgvVerControlDeCambios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerControlDeCambios.Size = new System.Drawing.Size(565, 211);
            this.dgvVerControlDeCambios.TabIndex = 6;
            // 
            // iuBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.tabBitacora);
            this.helpProvider1.SetHelpKeyword(this, "Gestion de Bitacora");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "iuBitacora";
            this.helpProvider1.SetShowHelp(this, true);
            this.Load += new System.EventHandler(this.iuBitacora_Load);
            this.tabBitacora.ResumeLayout(false);
            this.tabVertodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerTodos)).EndInit();
            this.tabVerPorUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorUsuario)).EndInit();
            this.tabVerPorEvento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPorEvento)).EndInit();
            this.tabVerControlDeCambios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerControlDeCambios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTabControl tabBitacora;
        internal MetroFramework.Controls.MetroTabPage tabVertodos;
        internal MetroFramework.Controls.MetroButton btnVerTodos;
        internal MetroFramework.Controls.MetroGrid dgvVerTodos;
        internal MetroFramework.Controls.MetroTabPage tabVerPorUsuario;
        internal MetroFramework.Controls.MetroGrid dgvPorUsuario;
        internal MetroFramework.Controls.MetroButton btnBuscar;
        internal MetroFramework.Controls.MetroTabPage tabVerPorEvento;
        internal MetroFramework.Controls.MetroButton btnBuscarEvento;
        internal MetroFramework.Controls.MetroComboBox txtEvento;
        internal MetroFramework.Controls.MetroGrid dgvPorEvento;
        internal MetroFramework.Controls.MetroComboBox txtBuscarUSuario;
        private MetroFramework.Controls.MetroTabPage tabVerControlDeCambios;
        internal MetroFramework.Controls.MetroButton btnBuscarControlCambios;
        internal MetroFramework.Controls.MetroComboBox cbBuscarUsuarioCambios;
        internal MetroFramework.Controls.MetroGrid dgvVerControlDeCambios;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}