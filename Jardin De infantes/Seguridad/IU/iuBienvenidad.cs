using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLseguridad.Idioma;
using IU.Properties;
using Jardin.IU;

namespace IU
{
    public partial class iuBienvenidad : MetroFramework.Forms.MetroForm
    {
      public void VerificarModulo()
        {
            BLLseguridad.Permisos.bllRolesUsuarios bll = new BLLseguridad.Permisos.bllRolesUsuarios();
            List<string> lista = bll.ListaModulosPorUsuario(EEseguridad.Login.SessionManager.instance.GetUSuario().getNombreUSuario());
            foreach (string item in lista)
            {
                foreach (Control controles in this.Controls)
                {
                    if (controles.Tag == null)
                    {

                    }
                    else
                    {
                        if (controles.Tag.Equals(item))
                        {
                            controles.Visible = true;
                        }
                    }
                }
            }

        }
        public iuBienvenidad()
        {
            InitializeComponent();
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
        private void iuBienvenidad_Load(object sender, EventArgs e)
        {
            VerificarModulo();
            helpProvider1.HelpNamespace = CHM.Cadena;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            IU.iuIndex iu = new iuIndex();
            iu.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Jardin.IU.iuIndex iu= new Jardin.IU.iuIndex();
            cambiarIdioma(iu);
            iu.ShowDialog();
        }
    }
}
