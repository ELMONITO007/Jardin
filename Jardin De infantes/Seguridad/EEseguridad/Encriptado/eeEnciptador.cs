using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Encriptado
{
  public abstract  class eeEnciptador
    {
        protected string valorInicial
        {
            get;
            set;
        }
        protected string valorEncriptado
        {
            get;
            set;
        }
        public abstract string Hashear();
    }
}
