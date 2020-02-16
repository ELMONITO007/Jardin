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
    public partial class iuIndex : MetroFramework.Forms.MetroForm
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


            EEseguridad.Idioma.SingletonIdioma.intance.CambiarIdioma(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
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
        public iuIndex()
        {
            InitializeComponent();
        }

        private void iuIndex_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            CambiarCultura();
            CambiarIdioma();
        }

        private void mtBackup_Click(object sender, EventArgs e)
        {
            BK_Index backup = new BK_Index();
            backup.ShowDialog();
        }

        private void mtServicios_Click(object sender, EventArgs e)
        {
            iuBitacora bitacora = new iuBitacora();
            bitacora.ShowDialog();
        }

        private void mtUsuario_Click(object sender, EventArgs e)
        {
            iuUsuario usuario = new iuUsuario();
            usuario.ShowDialog();
        }

        private void mtIdioma_Click(object sender, EventArgs e)
        {
            iuIdioma iu = new iuIdioma();
            iu.ShowDialog();
            CambiarCultura();
            CambiarIdioma();
        }

        private void mtPermiso_Click(object sender, EventArgs e)
        {
            iuPermisos permisos = new iuPermisos();
            permisos.ShowDialog();
        }
    }
}
