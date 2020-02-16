using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;
using DALseguridad;
using System.Data;

namespace BLLseguridad.Idioma
{
   public class bllPalabras
    {
       public DataTable ListarPalabras()
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Idioma.mppPalabra mpp = new MPPSeguridad.Idioma.mppPalabra();
            DALseguridad.Idioma.dalPalabra dal = new DALseguridad.Idioma.dalPalabra();
            dt = dal.Leer(mpp.ListarPalabra());
            return dt;
        }
    }
}
