using BLLseguridad.Idioma;
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

namespace IU
{
    public partial class iuIdioma : MetroFramework.Forms.MetroForm
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
        public iuIdioma()
        {
            InitializeComponent();
        }

        private void iuIdioma_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;

            CambiarCultura();
            CambiarIdioma();


        }

        private void mtCambiarIdioma_Click(object sender, EventArgs e)
        {
            iuCambiarIdioma iu = new iuCambiarIdioma();
            iu.ShowDialog();
            CambiarCultura();
            CambiarIdioma();
        }

        private void mtAgregarIdioma_Click(object sender, EventArgs e)
        {
            iuCrearIdioma idioma = new iuCrearIdioma();
            idioma.ShowDialog();
        }
    }
}
