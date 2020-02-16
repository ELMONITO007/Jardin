using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Login
{
   public class eeUsuario
    {
      public string nombreUsuario { get;set;}
      public string contraseña { get; set; }
      public string digitoVerificadorH { get; set; }
      public bool hablitado { get; set; }
        public eeUsuario (string _nombreUsuario,string _contraseña, string _digitoVerificadorH,bool _hablitado)
        {
            nombreUsuario = _nombreUsuario;
            contraseña = _contraseña;
            digitoVerificadorH = _digitoVerificadorH;
            hablitado = _hablitado;
        }

        public string getNombreUSuario()
        {
            return nombreUsuario;
        }
        public string getContraseña()

        {
            return contraseña;
        }
        public string getDigitoVerificadorH()
        {
            return digitoVerificadorH;
        }
        public bool gethablitado()
        {
            return hablitado;

        }
        public void setDigitoVerificadorH(string _DigitoVerificadorH)
        {
            digitoVerificadorH = _DigitoVerificadorH;
        }
    }
}
