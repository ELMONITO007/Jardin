namespace IU
{
    partial class iuCambiarIdioma
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
            this.txtIdioma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCambiarIdioma = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // txtIdioma
            // 
            this.txtIdioma.FormattingEnabled = true;
            this.txtIdioma.Location = new System.Drawing.Point(118, 96);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(121, 21);
            this.txtIdioma.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Tag = "Idioma";
            this.label1.Text = "Idioma";
            // 
            // btnCambiarIdioma
            // 
            this.btnCambiarIdioma.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCambiarIdioma.Location = new System.Drawing.Point(83, 178);
            this.btnCambiarIdioma.Name = "btnCambiarIdioma";
            this.btnCambiarIdioma.Size = new System.Drawing.Size(75, 23);
            this.btnCambiarIdioma.TabIndex = 2;
            this.btnCambiarIdioma.Tag = "Modificar";
            this.btnCambiarIdioma.Text = "Modificar";
            this.btnCambiarIdioma.UseVisualStyleBackColor = true;
            this.btnCambiarIdioma.Click += new System.EventHandler(this.btnCambiarIdioma_Click);
            // 
            // iuCambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 309);
            this.Controls.Add(this.btnCambiarIdioma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdioma);
            this.helpProvider1.SetHelpKeyword(this, "Cambiar idioma");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "iuCambiarIdioma";
            this.helpProvider1.SetShowHelp(this, true);
            this.Tag = "Cambiar Idioma";
            this.Text = "Cambiar Idioma";
            this.Load += new System.EventHandler(this.iuCambiarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtIdioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarIdioma;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}