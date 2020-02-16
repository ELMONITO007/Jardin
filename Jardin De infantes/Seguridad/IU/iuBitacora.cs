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
    public partial class iuBitacora : MetroFramework.Forms.MetroForm
    {
        public iuBitacora()
        {
            InitializeComponent();
        }
        void CambiarCultura()
        {
            CultureInfo cultura = new CultureInfo(EEseguridad.Idioma.SingletonIdioma.intance.getUsuario().idioma);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultura;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultura;

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
        private void iuBitacora_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            BLLseguridad.Bitacora.bllEvento evento = new BLLseguridad.Bitacora.bllEvento();
            DataTable dt = new DataTable();
            dt = evento.obtenerEventosBitacoras();
            txtEvento.DataSource = dt;
            txtEvento.ValueMember = "Evento";
            txtEvento.DisplayMember = "Evento";

            DataTable dtu = new DataTable();
            BLLseguridad.Login.bllUsuario bll = new BLLseguridad.Login.bllUsuario();
            dtu = bll.MostrarUSuarios();
            txtBuscarUSuario.DataSource = dtu;
            txtBuscarUSuario.ValueMember = "NombreUsuario";
            txtBuscarUSuario.DisplayMember = "NombreUsuario";
            cbBuscarUsuarioCambios.DataSource = dtu;
            cbBuscarUsuarioCambios.ValueMember = "NombreUsuario";
            cbBuscarUsuarioCambios.DisplayMember= "NombreUsuario";
            CambiarCultura();
            CambiarIdioma();



        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            BLLseguridad.Bitacora.bllBitacora lasBitacoras = new BLLseguridad.Bitacora.bllBitacora();
            dgvVerTodos.DataSource = "";
            dgvVerTodos.DataSource = lasBitacoras.MostrarBitacora();

        }

        private void txtEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabVerPorEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            BLLseguridad.Bitacora.bllBitacora unaBitacora = new BLLseguridad.Bitacora.bllBitacora();
            dgvPorEvento.DataSource = "";
            dgvPorEvento.DataSource = unaBitacora.BuscarPorEvento(txtEvento.Text);


        }

        private void txtBuscarUSuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BLLseguridad.Bitacora.bllBitacora unaBitacora = new BLLseguridad.Bitacora.bllBitacora();
            dgvPorUsuario.DataSource = "";
            dgvPorUsuario.DataSource = unaBitacora.BuscarPorUSuario(txtBuscarUSuario.Text);
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabVerControlDeCambios_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarControlCambios_Click(object sender, EventArgs e)
        {

            BLLseguridad.Bitacora.bllBitacora unaBitacora = new BLLseguridad.Bitacora.bllBitacora();
            dgvVerControlDeCambios.DataSource = "";
            dgvVerControlDeCambios.DataSource = unaBitacora.BuscarControlDeCambios(txtBuscarUSuario.Text);
        }
    }
}
