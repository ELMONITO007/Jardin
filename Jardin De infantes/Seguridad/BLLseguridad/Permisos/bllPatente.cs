using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALseguridad.Permisos;
using MPPSeguridad.Permisos;

namespace BLLseguridad.Permisos
{
   public class bllPatente
    {
        public List<string>ListarPatentes()
        {
            List<string> laListaDePatente = new List<string>();
            DALseguridad.Permisos.dalComposite dal=new DALseguridad.Permisos.dalComposite();
            DataTable dt = new DataTable();
            dt = dal.Leer(MPPSeguridad.Permisos.mppComposite.ListarPatentes());
            laListaDePatente = MPPSeguridad.Permisos.mppComposite.ListafamiliaString(dt);
            return laListaDePatente;

        }


        public void AgregarPatente(string nombre)

        {
            dalComposite dal = new dalComposite();
            dal.Escribir(mppModuloComposite.agregarPatente(nombre));
        }
    }
}
