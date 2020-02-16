using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Idioma
{
  public  class eeTraduccion
    {
        public string traduccion;
        public string referencia;
        public eeIdioma idioma;
        public eePalabra palabra;

      
        public eeTraduccion(string _traduccion,eeIdioma _Idioma,eePalabra _Palabra,string _referencia)
        {
            traduccion = _traduccion;
            idioma = _Idioma;
            palabra = _Palabra;
            referencia = _referencia;
            
        }
        public eeTraduccion(string idiomas) {
            eeIdioma i = new eeIdioma(idiomas);
            idioma = i;
            
        }
        public string GetTaduccion() { return traduccion; }
        public string GetReferencia() { return referencia; }
        public eeIdioma getIdioma() { return idioma; }
        
    }
}
