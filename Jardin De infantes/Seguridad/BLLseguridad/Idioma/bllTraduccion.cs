using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad.Idioma;
using DALseguridad.Idioma;
using MPPSeguridad.Idioma;
using System.Collections;

namespace BLLseguridad.Idioma
{
   public class bllTraduccion
    {
        public Hashtable ObtenerTraduccion(string idioma)
        {
            DataTable dt = new DataTable();

            eeTraduccion traduccion = new eeTraduccion(idioma);
            mppTraduccion mpp = new mppTraduccion();
            dalTraduccion dal = new dalTraduccion();
            dt = dal.Leer(mpp.ObtenerTraduccion(traduccion));
            Hashtable ht = new Hashtable();
            ht = mpp.ObtenerTraduccionHT(dt);
            return ht;

        }
        public void CrearTraduccion(List <eeTraduccion> lista)
        {
            //try
            //{
                foreach (eeTraduccion item in lista)
                {
                  
                        dalTraduccion dal = new dalTraduccion();
                        mppTraduccion mpp = new mppTraduccion();
                        dal.Escribir(mpp.CrearTraduccion(item));
                   
                }
            //}
            //catch (Exception)
            //{
                
               
            //}
            
        }
    }
}
