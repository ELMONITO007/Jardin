using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLseguridad.Permisos;

using REGEX;

namespace IU
{
    public partial class iuPermisos : MetroFramework.Forms.MetroForm
    {
        public iuPermisos()
        {
            InitializeComponent();
        }

        void actualizarLista()
        {
            lblFamiliaAgregar.Text = lbFamiliaAgregar.Text;
            BLLseguridad.Permisos.bllFamilia bll = new BLLseguridad.Permisos.bllFamilia();
            string resultado= bll.ObtenerListadoDeLaFamilia(lbFamilia.Text);
            lbFamiliaPAtente.Text = resultado;
            BLLseguridad.Permisos.bllFamilia bll2 = new BLLseguridad.Permisos.bllFamilia();
            string r = bll2.ObtenerListadoDeLaFamilia(lbFamiliaAgregar.Text);
            txtRoles.Text = r;

        }
        void llenarGrilla()
        {
            List<string> listaFamilia = new List<string>();
            BLLseguridad.Permisos.bllFamilia bll = new BLLseguridad.Permisos.bllFamilia();
            listaFamilia = bll.ListarFamilias("");
            lbFamilia.DataSource = listaFamilia;
            lbUsuariosListaFamilia.DataSource = listaFamilia;



            List<string> listaFamilia2 = new List<string>();
            BLLseguridad.Permisos.bllFamilia bll2 = new BLLseguridad.Permisos.bllFamilia();
            listaFamilia = bll.ListarFamilias(lblFamiliaAgregar.Text);
            lbFamilia.DisplayMember = "Familia";
            lbFamiliaAgregar.DataSource = listaFamilia;
            lbListaRoles.DataSource = listaFamilia2;

            /* PAtente  */
            List<string> listaPatente = new List<string>();
            BLLseguridad.Permisos.bllPatente bllp = new BLLseguridad.Permisos.bllPatente();
            listaPatente = bllp.ListarPatentes();
            lbPatente.DataSource = listaPatente;
            lbPatente.DisplayMember = "Nombre";

            /* usuarios*/
            BLLseguridad.Login.bllUsuario bllUsuario = new BLLseguridad.Login.bllUsuario();
            cbMostrarUsuario.DataSource = bllUsuario.MostrarUSuarios();
            cbMostrarUsuario.DisplayMember = "NombreUsuario";
            cbMostrarUsuario.ValueMember = "NombreUsuario";
        }
        private void iuPermisos_Load(object sender, EventArgs e)
        {
            helpProvider1.HelpNamespace = CHM.Cadena;
            llenarGrilla();

        }

        private void lbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void lbFamilia_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void tabVerControlDeCambios_Click(object sender, EventArgs e)
        {

        }

        private void lbFamiliaAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFamiliaAgregar.Text = lbFamiliaAgregar.Text;
            BLLseguridad.Permisos.bllFamilia bll = new BLLseguridad.Permisos.bllFamilia();
            txtRoles.Text = bll.ObtenerListadoDeLaFamilia(lbFamilia.Text);
            List<string> listaFamilia = new List<string>();
            BLLseguridad.Permisos.bllFamilia bll2 = new BLLseguridad.Permisos.bllFamilia();
            listaFamilia = bll2.ListarFamilias(lbFamiliaAgregar.Text);
            lbListaRoles.DataSource = listaFamilia;
            actualizarLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLLseguridad.Permisos.bllFamilia bll = new BLLseguridad.Permisos.bllFamilia();
            bll.AgregarPermiso(lbFamiliaAgregar.Text, lbListaRoles.Text);
            actualizarLista();
        }

        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            BLLseguridad.Permisos.bllFamilia bll = new BLLseguridad.Permisos.bllFamilia();
            bll.AgregarPermiso(lbFamiliaAgregar.Text, lbPatente.Text);
            actualizarLista();
        }

        private void tabVerPorUsuario_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            
        }

        public void actualizarRolesUsuario()
        {
            BLLseguridad.Permisos.bllRolesUsuarios bllRoles = new BLLseguridad.Permisos.bllRolesUsuarios();
            lbRolesDelUsuario.DataSource = bllRoles.ObtenerListaOermisosUsuario(cbMostrarUsuario.Text);
            lbRolesDelUsuario.DisplayMember = "Nombre";
            lbRolesDelUsuario.ValueMember = "Nombre";
            BLLseguridad.Permisos.bllRolesUsuarios bll = new BLLseguridad.Permisos.bllRolesUsuarios();
            lbModulos.DataSource = bll.ListaModulosPorUsuario(cbMostrarUsuario.Text);

        }
        private void cbMostrarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLseguridad.Permisos.bllRolesUsuarios bllRoles = new BLLseguridad.Permisos.bllRolesUsuarios();
            lbRolesDelUsuario.DataSource = bllRoles.ObtenerListaOermisosUsuario(cbMostrarUsuario.Text);
            lbRolesDelUsuario.DisplayMember = "Nombre";
            lbRolesDelUsuario.ValueMember = "Nombre";
            BLLseguridad.Permisos.bllRolesUsuarios bll = new BLLseguridad.Permisos.bllRolesUsuarios();
            lbModulos.DataSource = bll.ListaModulosPorUsuario(cbMostrarUsuario.Text);

        }

        private void btnAgregarRolUsuario_Click(object sender, EventArgs e)
        {

            BLLseguridad.Permisos.bllRolesUsuarios bllRoles = new BLLseguridad.Permisos.bllRolesUsuarios();
            bllRoles.AsginarPermisosUsuario(lbUsuariosListaFamilia.Text, cbMostrarUsuario.Text);
            actualizarRolesUsuario();

            

        }
        bool vericarAgregar()
        {
            bool r = true;
            if (!VerificadoresConMensajes.MensajeVacio("Nombre",txtnombre.Text,this))
            {
                r = false;
            }
            if (!VerificadoresConMensajes.MensajeVacio("Descripcion", txtDescripcion.Text, this))
            {
                r = false;
            }

            if (!VerificadoresConMensajes.MensajeVacio("Roles", txtTipo.Text, this))
            {
                r = false;
            }


            return r;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (vericarAgregar())
            {
                bllModulo modulo = new bllModulo();
                if (txtTipo.Text=="Permiso")
                {
                    modulo.AgregarPatente(txtnombre.Text, txtDescripcion.Text);
                    bllPatente patente = new bllPatente();
                    patente.AgregarPatente(txtnombre.Text);
                    VerificadoresConMensajes.Agregar(this);
                }
                else if (txtTipo.Text == "Rol")
                {
                    modulo.AgregarPatente(txtnombre.Text, txtDescripcion.Text);
                    bllModuloCOmposite cOmposite = new bllModuloCOmposite();
                    cOmposite.AgregarFamilia(txtnombre.Text);
                }
                llenarGrilla();

            }
        }
    }
}
