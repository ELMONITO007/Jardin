using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace REGEX
{
   public class REGEXstring
    {
        public static bool VerificarTemañoNumero(string numero,int max,int min)
        {
            return Regex.IsMatch(numero, "^([0-9]){"+max+","+min+"}$");
        }

        public static bool VerificarTemañoTelefono(string telefono)
        {
           return Regex.IsMatch(telefono, "^([0-9]){11,11}$");
        }
        public static bool VerificarNumeros(string numeros)
        {
         return Regex.IsMatch(numeros, "^[0-9]+$");
        }
        public static bool VerificarLetras(string Letras)
        {
            return Regex.IsMatch(Letras, "^([a-zA-Z]+$)");
        }
        public static bool VerificarAlfaNumerico(string Letras)
        {
            return Regex.IsMatch(Letras, "^[A-Za-z0-9 :]+$");
        }
        public static bool VerificarEmail(string Letras)
        {
            return  Regex.IsMatch(Letras,@"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");
        }
        public static bool VerificarFecha(string Letras)
        {
            return Regex.IsMatch(Letras, @"^([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})$");
        }

        public static bool VerificarNumerosIntervalo(string numeros)
        {
            return Regex.IsMatch(numeros, "^([1-9]|1[0])$");
        }
    }
}
