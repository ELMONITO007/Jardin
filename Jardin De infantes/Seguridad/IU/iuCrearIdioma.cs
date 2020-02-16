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

namespace IU
{
    public partial class iuCrearIdioma : MetroFramework.Forms.MetroForm
    {
        public iuCrearIdioma()
        {
            InitializeComponent();
        }

        private void iuCrearIdioma_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
        }

        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            if (txtIdioma.Text=="")
            {
                MessageBox.Show(this,"No coloco nada en el campo idioma","error",MessageBoxButtons.OK);
            }
            else
            {
                BLLseguridad.Idioma.bllPalabras palabras = new BLLseguridad.Idioma.bllPalabras();
                dgvTraduccion.DataSource = null;
                dgvTraduccion.DataSource = palabras.ListarPalabras();



            }
         


        }

        private void btnAgregarTraduccion_Click(object sender, EventArgs e)
        {
            if (txtIdioma.Text == "")
            {
                MessageBox.Show(this, "No coloco nada en el campo idioma", "error", MessageBoxButtons.OK);
            }
            else
            {
                BLLseguridad.Idioma.bllIdioma idioma = new BLLseguridad.Idioma.bllIdioma();
                EEseguridad.Idioma.eeIdioma eeIdioma = new EEseguridad.Idioma.eeIdioma(txtIdioma.Text);
                BLLseguridad.Idioma.bllTraduccion bllTraduccion = new BLLseguridad.Idioma.bllTraduccion();
                idioma.crearIdioma(txtIdioma.Text);
                List<EEseguridad.Idioma.eeTraduccion> traduccion = new List<EEseguridad.Idioma.eeTraduccion>();
                foreach (DataGridViewRow item in dgvTraduccion.Rows)
                {
                    if (item.Cells[0].Value == null)
                    {

                    }
                    else
                    {
                        string traducido = item.Cells[0].Value.ToString();
                        string laPalabra = item.Cells[1].Value.ToString();
                        EEseguridad.Idioma.eePalabra palabra = new EEseguridad.Idioma.eePalabra(laPalabra);
                        EEseguridad.Idioma.eeTraduccion traducir = new EEseguridad.Idioma.eeTraduccion(traducido, eeIdioma, palabra, "");
                        traduccion.Add(traducir);
                    }
                   
                }

                bllTraduccion.CrearTraduccion(traduccion);

            }

        }
    }
}
