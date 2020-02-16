using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad.Idioma;

namespace MPPSeguridad.Idioma
{
  public  class mppTraduccion
    {
        public string ObtenerTraduccion(eeTraduccion traduccion)
        {
            return "select p.Palabra,t.Palabra as Traduccion  from Traduccion as t join Idioma as i on t.ID_Idioma=i.ID_Idioma join Palabra as p on p.ID_Palabra=t.ID_Palabra  where i.Idioma='" + traduccion.getIdioma().idioma + "'";
        }

        public Hashtable ObtenerTraduccionHT(DataTable dt)
        {
            Hashtable ht = new Hashtable();

            foreach (DataRow item in dt.Rows)
            {
                string tag = item["Palabra"].ToString();
                string traduccion = item["traduccion"].ToString();
                ht.Add(tag, traduccion);


            }
            return ht;
        }
        public string CrearTraduccion(eeTraduccion traduccion )
        {

            string resultado = "insert into Traduccion(ID_Idioma,ID_Palabra,Palabra)values((select ID_Idioma from Idioma where Idioma='" + traduccion.idioma.idioma + "'),(select ID_Palabra from Palabra where Palabra='" + traduccion.palabra.palabara + "'),'"+ traduccion.traduccion +"' )";

            return resultado;
        }
    }

   
}
