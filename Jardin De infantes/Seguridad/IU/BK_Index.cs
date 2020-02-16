using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLseguridad;
using REGEX;

using EEseguridad;


namespace IU
{
    public partial class BK_Index : MetroFramework.Forms.MetroForm
    {
        public BK_Index()
        {
            
            InitializeComponent();

        }

        private void BK_Index_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            iuBitacora ii = new iuBitacora();
            ii.Show();
            llenarLista();
                            

        }
        void llenarLista()
        {

            BLLseguridad.Backup.bllBackup unBLL = new BLLseguridad.Backup.bllBackup();
            dgvBackup.DataSource = null;
            dgvBackup.DataSource = unBLL.ListarBackup();

        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCrearBackup_Click(object sender, EventArgs e)
        {
          
            if (REGEX.REGEXstring.VerificarAlfaNumerico(txtnombreArchivo.Text))
            {
                BLLseguridad.Backup.bllBackup unBLL = new BLLseguridad.Backup.bllBackup();
                unBLL.CrearBackup(DateTime.Now, @"c:\temp", txtnombreArchivo.Text);
               
            }
            else
            {
                MessageBox.Show("Coloco un Caractér especial", "Error de escritura");
            }
            llenarLista();
            
        }
    }
           
}
