using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.DigitoVerificador
{
    public class eeDigitoVerificadorV
    {
        string nombreTabla;
        string DVV;
     
        string DVH;

        public eeDigitoVerificadorV(string _tabla, string _DVV,  string _DVH)
        {
            nombreTabla = _tabla;
            DVV = _DVV;
            
            DVH = _DVH;
        }

        public string getTabla() { return nombreTabla; }
        public string getDVV() { return DVV; }
        public string getDVH() { return DVH; }
       
        public void setDVH(string _dvh) { DVH = _dvh; }
        public void setDVV(string _DVV) { DVV = _DVV; }




    }
}
