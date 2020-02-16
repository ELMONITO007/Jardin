using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPSeguridad.Idioma
{
  public  class mppIdioma
    {
        public string ListarIDioma()
        {
            return "select Idioma from Idioma where Idioma!=''";
        }
        public string AgregarIdioma(EEseguridad.Idioma.eeIdioma idioma)
        {
            return "insert into Idioma(Idioma) values('"+ idioma.GetIdioma()+"')";
        }
        
    }
}
