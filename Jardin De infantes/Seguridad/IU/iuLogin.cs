using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EEseguridad;
using BLLseguridad.Login;
using BLLseguridad.Idioma;
using System.Globalization;
using System.Collections;
using IU.Properties;

namespace IU
{
    public partial class iuLogin : MetroFramework.Forms.MetroForm
    {
        public iuLogin()
        {
            InitializeComponent();
          
        }

        private void iuLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void iuLogin_Load_1(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace =CHM.Cadena;
            bllIdioma bll = new bllIdioma();
            DataTable dt = new DataTable();
            dt = bll.ListarIdiomas();

            foreach (DataRow item in dt.Rows)
            {
                cbIdioma.Items.Add(item["Idioma"].ToString());
            }
            cbIdioma.SelectedIndex = 0;
            CambiarCultura();
        }
        void cambiarIdioma(Form iu)
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
                foreach (Control controles in iu.Controls)
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
        private void btnAcepta_Click(object sender, EventArgs e)
        {
            EEseguridad.Login.eeUsuario unUsuario = new EEseguridad.Login.eeUsuario(txtUsuario.Text, txtContraseña.Text, "", true);
            bllLogin bll = new bllLogin();

            if (bll.VerificarLogin(unUsuario)==true)
            {
                 iuBienvenidad iu= new iuBienvenidad();
                cambiarIdioma(iu);

                iu.ShowDialog();

            }
            else
            {
                MessageBox.Show(this, "La contraseña o el usuario no es valido", "Ingreso", MessageBoxButtons.OK);
                txtContraseña.Text = "";

            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
        void  CambiarCultura()
        {
            CultureInfo cultura = new CultureInfo(cbIdioma.Text);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;

        }
        void CambiarIdioma()
        {
            bllTraduccion bll = new bllTraduccion();
            EEseguridad.Idioma.eeIdioma idioma = new EEseguridad.Idioma.eeIdioma(cbIdioma.Text);
            EEseguridad.Idioma.SingletonIdioma.intance.CambiarIdioma(idioma.GetIdioma());


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
        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarCultura();
            EEseguridad.Idioma.eeIdioma idioma = new EEseguridad.Idioma.eeIdioma(cbIdioma.Text);
            EEseguridad.Idioma.SingletonIdioma.intance.NuevoIdioma(idioma);
          
            CambiarIdioma();
           
        }
    }
}
