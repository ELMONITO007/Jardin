namespace IU
{
    partial class iuCrearIdioma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtIdioma = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregarIdioma = new MetroFramework.Controls.MetroButton();
            this.dgvTraduccion = new MetroFramework.Controls.MetroGrid();
            this.Traduccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTraduccion = new MetroFramework.Controls.MetroButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 103);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Tag = "Idioma";
            this.metroLabel1.Text = "Idioma";
            // 
            // txtIdioma
            // 
            this.txtIdioma.Lines = new string[0];
            this.txtIdioma.Location = new System.Drawing.Point(132, 98);
            this.txtIdioma.MaxLength = 32767;
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.PasswordChar = '\0';
            this.txtIdioma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdioma.SelectedText = "";
            this.txtIdioma.Size = new System.Drawing.Size(122, 23);
            this.txtIdioma.TabIndex = 1;
            this.txtIdioma.UseSelectable = true;
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.Location = new System.Drawing.Point(46, 171);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarIdioma.TabIndex = 2;
            this.btnAgregarIdioma.Tag = "Agregar";
            this.btnAgregarIdioma.Text = "Agregar";
            this.btnAgregarIdioma.UseSelectable = true;
            this.btnAgregarIdioma.Click += new System.EventHandler(this.btnAgregarIdioma_Click);
            // 
            // dgvTraduccion
            // 
            this.dgvTraduccion.AllowUserToDeleteRows = false;
            this.dgvTraduccion.AllowUserToOrderColumns = true;
            this.dgvTraduccion.AllowUserToResizeRows = false;
            this.dgvTraduccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTraduccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTraduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraduccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Traduccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraduccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraduccion.EnableHeadersVisualStyles = false;
            this.dgvTraduccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTraduccion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTraduccion.Location = new System.Drawing.Point(352, 42);
            this.dgvTraduccion.Name = "dgvTraduccion";
            this.dgvTraduccion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTraduccion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTraduccion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTraduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraduccion.Size = new System.Drawing.Size(324, 316);
            this.dgvTraduccion.TabIndex = 3;
            // 
            // Traduccion
            // 
            this.Traduccion.HeaderText = "Traduccion";
            this.Traduccion.Name = "Traduccion";
            // 
            // btnAgregarTraduccion
            // 
            this.btnAgregarTraduccion.Location = new System.Drawing.Point(461, 404);
            this.btnAgregarTraduccion.Name = "btnAgregarTraduccion";
            this.btnAgregarTraduccion.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarTraduccion.TabIndex = 4;
            this.btnAgregarTraduccion.Tag = "Agregar";
            this.btnAgregarTraduccion.Text = "Agregar";
            this.btnAgregarTraduccion.UseSelectable = true;
            this.btnAgregarTraduccion.Click += new System.EventHandler(this.btnAgregarTraduccion_Click);
            // 
            // iuCrearIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarTraduccion);
            this.Controls.Add(this.dgvTraduccion);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.metroLabel1);
            this.helpProvider1.SetHelpKeyword(this, "Crear idioma");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "iuCrearIdioma";
            this.helpProvider1.SetShowHelp(this, true);
            this.Load += new System.EventHandler(this.iuCrearIdioma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraduccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtIdioma;
        private MetroFramework.Controls.MetroButton btnAgregarIdioma;
        private MetroFramework.Controls.MetroGrid dgvTraduccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Traduccion;
        private MetroFramework.Controls.MetroButton btnAgregarTraduccion;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}