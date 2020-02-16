using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad.DigitoVerificador;

namespace MPPSeguridad.DVV
{
   public class mppDVV
    {
        public string altaDVV(eeDigitoVerificadorV DVV)
        {
            return "insert into DigitoVerificadorVertical(NombreTabla,DigitoVerificadorV,DigitoVerificadorH)values('" + DVV.getTabla() + "','"+ DVV.getDVV() +"', '"+ DVV.getDVH()+"')";
        }

        public string listaDVH(string tabla)
        {
            return "select DigitoVerificadorH  from "+tabla;
        }
        
        public string buscarUltimoDVV(string tabla)
        {
            return "select top 1 DigitoVerificadorV  from DigitoVerificadorVertical where NombreTabla='"+tabla + "' order by ID_DigitoVerificadorVertical desc";
        }
    }
}
