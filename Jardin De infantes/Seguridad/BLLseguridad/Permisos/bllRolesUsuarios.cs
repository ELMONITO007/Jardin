using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLseguridad.Permisos
{
  public  class bllRolesUsuarios
    {
        public DataTable ObtenerListaOermisosUsuario(string usuario)
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            return dal.Leer(MPPSeguridad.Permisos.mppComposite.RolesUsuario(usuario));


        }

        public void AsginarPermisosUsuario(string rol,string usuario)
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            dal.Escribir(MPPSeguridad.Permisos.mppComposite.AsginarRolUSuario(usuario, rol));
        }

       public List<string> ListaModulosPorUsuario(string usuario)
        {
            List<string> Lista = new List<string>();
            DataTable dt = new DataTable();
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            MPPSeguridad.Permisos.mppComposite mppComposite = new MPPSeguridad.Permisos.mppComposite();
            dt = ObtenerListaOermisosUsuario(usuario);
            string permiso="";
            foreach (DataRow item in dt.Rows)
            {
                permiso = item[0].ToString();
                break;

            }
            DataTable dtModulos = new DataTable();
            dtModulos =dal.Leer( MPPSeguridad.Permisos.mppComposite.ObtenerListaModulosRol(permiso));
            foreach (DataRow item in dtModulos.Rows)
            {
                Lista.Add(item[0].ToString());
            }

            return Lista;
        }
        public List<string> ListaModulosPorPermiso(string permiso)
        {
            List<string> Lista = new List<string>();
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            DataTable dt = new DataTable();
            dt = dal.Leer(MPPSeguridad.Permisos.mppComposite.ObtenerListaModulosRol(permiso));

            foreach (DataRow item in dt.Rows)
            {
                Lista.Add(item[0].ToString());

            }
            return Lista;

        }


    }
}
