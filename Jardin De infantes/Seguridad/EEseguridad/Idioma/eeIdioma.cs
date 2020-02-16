using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Idioma
{
  public  class eeIdioma
    {
        public string idioma;
        public eeIdioma(string idiom)
        {
            idioma = idiom;
        }
        public void CambiarIdioma(string _idioma)
        {
            idioma = _idioma;
        }
        public string GetIdioma() { return idioma; }


          }
}
