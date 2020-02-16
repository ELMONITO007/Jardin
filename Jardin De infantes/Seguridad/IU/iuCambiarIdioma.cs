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
using BLLseguridad.Idioma;

namespace IU
{
    public partial class iuCambiarIdioma : MetroFramework.Forms.MetroForm
    {
        void CambiarCultura()
        {
            CultureInfo cultura = new CultureInfo(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;

        }
        void CambiarIdioma()
        {
            bllTraduccion bll = new bllTraduccion();


            
            bllTraduccion traduccion = new bllTraduccion();
            Hashtable ht = new Hashtable();
            ht = traduccion.ObtenerTraduccion(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            foreach (DictionaryEntry item in ht)
            {
                foreach (Control controles in this.Controls)
                {
                    if (controles.Tag == null)
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



        public iuCambiarIdioma()
        {
            InitializeComponent();
        }

        private void iuCambiarIdioma_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            bllIdioma bll = new bllIdioma();
            DataTable dt = new DataTable();
            dt = bll.ListarIdiomas();
            txtIdioma.DataSource = dt;
            txtIdioma.DisplayMember = "Idioma";
            txtIdioma.ValueMember = "Idioma";
            CambiarIdioma();
            CambiarCultura();
        }

        private void btnCambiarIdioma_Click(object sender, EventArgs e)
        {
            EEseguridad.Idioma.SingletonIdioma.intance.CambiarIdioma(txtIdioma.Text);
            CambiarIdioma();
            CambiarCultura();
        }
    }
}
