using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Permisos
{
   public abstract class Composite
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }

        public abstract string Display(int deph);

        public abstract string Mostrar(int deph);


    }
}
