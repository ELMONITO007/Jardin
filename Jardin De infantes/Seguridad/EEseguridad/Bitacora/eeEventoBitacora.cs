using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Bitacora
{
  public  class eeEventoBitacora
    {
        public eeEventoBitacora(string _evento)
        {
            eventoBitacora = _evento;
        }
        private string eventoBitacora
        {
            get;
            set;
        }

        public string getEventoBitacora()
        {
            return eventoBitacora;
        }
    }
}
