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
   public class bllModulo
    {
        public DataTable ObtenerTOdo()
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            return dal.Leer(MPPSeguridad.Permisos.mppModulo.mostrarTodo());
        }
        public void AgregarPatente(string nombre, string descripcion)

        {
            dalComposite dal = new dalComposite();
            dal.Escribir(mppComposite.agregarComposite(nombre, descripcion));
        }
    }
}
