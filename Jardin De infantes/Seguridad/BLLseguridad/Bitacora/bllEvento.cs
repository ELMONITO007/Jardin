using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using DALseguridad;
using MPPSeguridad;
using System.Data;

namespace BLLseguridad.Bitacora
{
  public  class bllEvento
    {
       public DataTable obtenerEventosBitacoras()
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Bitacora.mppEventoBitacora mpp = new MPPSeguridad.Bitacora.mppEventoBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dt = dal.Leer(mpp.ObtenerBitacora());

            return dt;
        }
    }
}
