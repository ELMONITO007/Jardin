using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.DigitoVerificador
{
   public class DigitoVerificadorH
    {
         
        public DigitoVerificadorH()

        {
           
        }



        public static string getDigitoEncriptado(object unObjeto)
        {
            string digitoAEncriptar = EEseguridad.DigitoVerificador.eeDVGReflection.GetDVH(unObjeto);
            EEseguridad.Encriptado.EncriptarSHA5 e = new Encriptado.EncriptarSHA5(digitoAEncriptar);
            string digitoEncriptado = e.Hashear();
            return digitoEncriptado;
        }
    }
}
