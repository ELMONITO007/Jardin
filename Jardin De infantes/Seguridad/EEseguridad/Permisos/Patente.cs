using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Permisos
{
  public  class Patente : Composite
    {
        public override string Display(int depth)
        {
            return nombre;
        }
        public override string Mostrar(int depth)
        {
            return nombre;
        }
    }
}
