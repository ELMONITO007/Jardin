using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLseguridad;
using BLLseguridad.Idioma;

namespace IU
{
    public partial class iuUsuario : Form
    {
        public iuUsuario()
        {
            InitializeComponent();
        }
        void llenarGrilla()
        {
            BLLseguridad.Login.bllUsuario bll = new BLLseguridad.Login.bllUsuario();
            dgvABMUsuario.DataSource = null;
            dgvABMUsuario.DataSource = bll.MostrarUSuarios();
        }
        private void iuUsuario_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            llenarGrilla();
            CambiarIdioma();
            CambiarCultura();
        }
        void CambiarCultura()
        {
            CultureInfo cultura = new CultureInfo(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;

        }
        private void btnBaja_Click(object sender, EventArgs e)
        {
            BLLseguridad.Login.bllUsuario bll = new BLLseguridad.Login.bllUsuario();

            bll.BajaUSuario(txtUsuario.Text);
            llenarGrilla();
        }

        private void btnModificat_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="")
            {
                MessageBox.Show("Coloque la nueva contraseña");
            }
            else
            {
                BLLseguridad.Login.bllUsuario bll = new BLLseguridad.Login.bllUsuario();
                bll.ModificarCOntraseña(txtUsuario.Text, txtContraseña.Text);
            }
            

        }

        private void dgvABMUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvABMUsuario.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            BLLseguridad.Login.bllUsuario bll = new BLLseguridad.Login.bllUsuario();
            bll.AltaUSuario(txtUsuario.Text, txtContraseña.Text);
            llenarGrilla();
            BLLseguridad.DVV.bllDVV dVV = new BLLseguridad.DVV.bllDVV();
            dVV.altaDVV("Usuario");
        }
        void CambiarIdioma()
        {
            bllTraduccion bll = new bllTraduccion();
            EEseguridad.Idioma.eeIdioma idioma = new EEseguridad.Idioma.eeIdioma(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            EEseguridad.Idioma.SingletonIdioma.intance.NuevoIdioma(idioma);


            EEseguridad.Idioma.SingletonIdioma.intance.CambiarIdioma(idioma.GetIdioma());
            bllTraduccion traduccion = new bllTraduccion();
            Hashtable ht = new Hashtable();
            ht = traduccion.ObtenerTraduccion(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            foreach (DictionaryEntry item in ht)
            {
                foreach (Control controles in this.Controls)
                {
                    if (controles.Tag==null)
                    {

                    }
                    else
                    {
                        if (controles.Tag.Equals(item.Key))
                        {
                            controles.Text = item.Value.ToString();
                        }
                    }
                }
            }
        }
    }
}
