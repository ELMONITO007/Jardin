namespace IU
{
    partial class iuIdioma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iuIdioma));
            this.mtAgregarIdioma = new MetroFramework.Controls.MetroTile();
            this.mtCambiarIdioma = new MetroFramework.Controls.MetroTile();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // mtAgregarIdioma
            // 
            this.mtAgregarIdioma.ActiveControl = null;
            this.mtAgregarIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtAgregarIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mtAgregarIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtAgregarIdioma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mtAgregarIdioma.Location = new System.Drawing.Point(240, 31);
            this.mtAgregarIdioma.Name = "mtAgregarIdioma";
            this.mtAgregarIdioma.Size = new System.Drawing.Size(189, 120);
            this.mtAgregarIdioma.Style = MetroFramework.MetroColorStyle.White;
            this.mtAgregarIdioma.TabIndex = 26;
            this.mtAgregarIdioma.Tag = "Alta de Idioma";
            this.mtAgregarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtAgregarIdioma.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtAgregarIdioma.TileImage = ((System.Drawing.Image)(resources.GetObject("mtAgregarIdioma.TileImage")));
            this.mtAgregarIdioma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtAgregarIdioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtAgregarIdioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtAgregarIdioma.UseSelectable = true;
            this.mtAgregarIdioma.UseTileImage = true;
            this.mtAgregarIdioma.Click += new System.EventHandler(this.mtAgregarIdioma_Click);
            // 
            // mtCambiarIdioma
            // 
            this.mtCambiarIdioma.ActiveControl = null;
            this.mtCambiarIdioma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtCambiarIdioma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.mtCambiarIdioma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtCambiarIdioma.Location = new System.Drawing.Point(23, 31);
            this.mtCambiarIdioma.Name = "mtCambiarIdioma";
            this.mtCambiarIdioma.Size = new System.Drawing.Size(189, 120);
            this.mtCambiarIdioma.Style = MetroFramework.MetroColorStyle.White;
            this.mtCambiarIdioma.TabIndex = 25;
            this.mtCambiarIdioma.Tag = "Cambiar Idioma";
            this.mtCambiarIdioma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCambiarIdioma.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCambiarIdioma.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCambiarIdioma.TileImage")));
            this.mtCambiarIdioma.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.mtCambiarIdioma.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCambiarIdioma.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtCambiarIdioma.UseSelectable = true;
            this.mtCambiarIdioma.UseTileImage = true;
            this.mtCambiarIdioma.Click += new System.EventHandler(this.mtCambiarIdioma_Click);
            // 
            // iuIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 175);
            this.Controls.Add(this.mtAgregarIdioma);
            this.Controls.Add(this.mtCambiarIdioma);
            this.helpProvider1.SetHelpKeyword(this, "Pantalla principal de idioma");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "iuIdioma";
            this.helpProvider1.SetShowHelp(this, true);
            this.Load += new System.EventHandler(this.iuIdioma_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal MetroFramework.Controls.MetroTile mtAgregarIdioma;
        internal MetroFramework.Controls.MetroTile mtCambiarIdioma;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}