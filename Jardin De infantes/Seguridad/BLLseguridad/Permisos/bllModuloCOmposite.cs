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
  public  class bllModuloCOmposite
    {
        public DataTable MostarTodo()
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            return dal.Leer(MPPSeguridad.Permisos.mppModuloComposite.ObtenerTodo());
        }
        public DataTable MostarTodoPorPermiso(EEseguridad.Permisos.eeModuloComposite ee)
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            return dal.Leer(MPPSeguridad.Permisos.mppModuloComposite.ObtenerTodoPermiso(ee));
        }
        public void Eliminar (EEseguridad.Permisos.eeModuloComposite ee)
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            dal.Escribir(MPPSeguridad.Permisos.mppModuloComposite.Eliminar(ee));
        }
        public void Alta(EEseguridad.Permisos.eeModuloComposite ee)
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            dal.Escribir(MPPSeguridad.Permisos.mppModuloComposite.Alta(ee));
        }
        public void AgregarFamilia(string nombre)

        {
            dalComposite dal = new dalComposite();
            dal.Escribir(mppModuloComposite.agregarFamilia(nombre));
        }


    }
}
