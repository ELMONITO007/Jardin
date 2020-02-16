namespace IU
{
    partial class BK_Index 
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
            this.cbRecuperarBakup = new MetroFramework.Controls.MetroCheckBox();
            this.lblEtiquta = new MetroFramework.Controls.MetroLabel();
            this.txtnombreArchivo = new MetroFramework.Controls.MetroTextBox();
            this.btnRestaurarBackup = new MetroFramework.Controls.MetroButton();
            this.btnCrearBackup = new MetroFramework.Controls.MetroButton();
            this.dgvBackup = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRecuperarBakup
            // 
            this.cbRecuperarBakup.AutoSize = true;
            this.cbRecuperarBakup.Location = new System.Drawing.Point(543, 134);
            this.cbRecuperarBakup.Margin = new System.Windows.Forms.Padding(2);
            this.cbRecuperarBakup.Name = "cbRecuperarBakup";
            this.cbRecuperarBakup.Size = new System.Drawing.Size(118, 15);
            this.cbRecuperarBakup.TabIndex = 115;
            this.cbRecuperarBakup.Tag = "Recuperar Backup";
            this.cbRecuperarBakup.Text = "Recuperar Backup";
            this.cbRecuperarBakup.UseSelectable = true;
            // 
            // lblEtiquta
            // 
            this.lblEtiquta.AutoSize = true;
            this.lblEtiquta.Location = new System.Drawing.Point(202, 134);
            this.lblEtiquta.Name = "lblEtiquta";
            this.lblEtiquta.Size = new System.Drawing.Size(129, 19);
            this.lblEtiquta.TabIndex = 114;
            this.lblEtiquta.Tag = "Nombre del Archivo";
            this.lblEtiquta.Text = "Nombre del Archivo";
            // 
            // txtnombreArchivo
            // 
            this.txtnombreArchivo.Lines = new string[0];
            this.txtnombreArchivo.Location = new System.Drawing.Point(351, 134);
            this.txtnombreArchivo.MaxLength = 32767;
            this.txtnombreArchivo.Name = "txtnombreArchivo";
            this.txtnombreArchivo.PasswordChar = '\0';
            this.txtnombreArchivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnombreArchivo.SelectedText = "";
            this.txtnombreArchivo.Size = new System.Drawing.Size(173, 23);
            this.txtnombreArchivo.TabIndex = 113;
            this.txtnombreArchivo.UseSelectable = true;
            // 
            // btnRestaurarBackup
            // 
            this.helpProvider1.SetHelpKeyword(this.btnRestaurarBackup, "Recuperar backup");
            this.helpProvider1.SetHelpNavigator(this.btnRestaurarBackup, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnRestaurarBackup.Location = new System.Drawing.Point(601, 78);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.helpProvider1.SetShowHelp(this.btnRestaurarBackup, true);
            this.btnRestaurarBackup.Size = new System.Drawing.Size(126, 43);
            this.btnRestaurarBackup.TabIndex = 112;
            this.btnRestaurarBackup.Tag = "Recuperar Backup";
            this.btnRestaurarBackup.Text = "Restaurar Backup";
            this.btnRestaurarBackup.UseSelectable = true;
            this.btnRestaurarBackup.Visible = false;
            this.btnRestaurarBackup.Click += new System.EventHandler(this.btnRestaurarBackup_Click);
            // 
            // btnCrearBackup
            // 
            this.helpProvider1.SetHelpKeyword(this.btnCrearBackup, "Crear backup");
            this.helpProvider1.SetHelpNavigator(this.btnCrearBackup, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.btnCrearBackup.Location = new System.Drawing.Point(66, 78);
            this.btnCrearBackup.Name = "btnCrearBackup";
            this.helpProvider1.SetShowHelp(this.btnCrearBackup, true);
            this.btnCrearBackup.Size = new System.Drawing.Size(126, 43);
            this.btnCrearBackup.TabIndex = 111;
            this.btnCrearBackup.Tag = "Crear Backup";
            this.btnCrearBackup.Text = "Crear Backup";
            this.btnCrearBackup.UseSelectable = true;
            this.btnCrearBackup.Click += new System.EventHandler(this.btnCrearBackup_Click);
            // 
            // dgvBackup
            // 
            this.dgvBackup.AllowUserToAddRows = false;
            this.dgvBackup.AllowUserToDeleteRows = false;
            this.dgvBackup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBackup.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBackup.Location = new System.Drawing.Point(96, 214);
            this.dgvBackup.Name = "dgvBackup";
            this.dgvBackup.ReadOnly = true;
            this.dgvBackup.Size = new System.Drawing.Size(506, 150);
            this.dgvBackup.TabIndex = 116;
            // 
            // BK_Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 401);
            this.Controls.Add(this.dgvBackup);
            this.Controls.Add(this.cbRecuperarBakup);
            this.Controls.Add(this.lblEtiquta);
            this.Controls.Add(this.txtnombreArchivo);
            this.Controls.Add(this.btnRestaurarBackup);
            this.Controls.Add(this.btnCrearBackup);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "Gestión de Backup");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BK_Index";
            this.helpProvider1.SetShowHelp(this, true);
            this.Load += new System.EventHandler(this.BK_Index_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBackup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal MetroFramework.Controls.MetroCheckBox cbRecuperarBakup;
        internal MetroFramework.Controls.MetroLabel lblEtiquta;
        internal MetroFramework.Controls.MetroTextBox txtnombreArchivo;
        internal MetroFramework.Controls.MetroButton btnRestaurarBackup;
        internal MetroFramework.Controls.MetroButton btnCrearBackup;
        private System.Windows.Forms.DataGridView dgvBackup;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}