using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPSeguridad.Bitacora
{
 public   class mppEventoBitacora
    {
        public string ObtenerBitacora()
        {
            return "select Evento from EventoBitacora";
        }

    }
}
