using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REGEX
{
   public static class mppMensajes
    {
        public static string TamañoNumero()
        {
            return "El tamaño es incorrecto";
        }
        public static string SoloNumeros(string componente)
        {
            return "El campo: " + componente + " esta vacio o tiene caracteres invalidos,solo acepta numeros sin espacios";
        }
        public static string VerificarSiExiste(string componente)
        {
            return "El registro: " + componente + " ya existe";
        }
        public static string SoloLetras(string componente)
        {
            return "El campo: " + componente + " esta vacio o tiene caracteres invalidos,solo acepta una palabra sin espacios";
        }
        public static string VacioCaracteresInvalidos(string componenete)
        {
            return "El campo: " + componenete + " esta vacio o tiene caracteres invalidos";
        }
        public static string VacioCaracteres(string componenete)
        {
            return "El campo: " + componenete + " esta vacio ";
        }
        public static string FechaPosteriorHoy(string componente)
        {
            return "El campo: " + componente + " debe tener una fecha anterior al dia de hoy";
        }
        public static string FechaPosteriorFin(string componente)
        {
            return "El campo: " + componente + " debe tener una fecha anterior a la fecha inicial";
        }

        public static string Agregar()
        {
            return "Se agrego correctamente";
        }

        public static string Eliminar()
        {
            return "Se elimino correctamente";
        }
        public static string Actualizar()
        {
            return "Se Actualizo correctamente";
        }
        public static string DgvVacio()
        {
            return "No se puede realizar los solicitado, porque no hay elementos";
        }

        public static string IntervaloNumero(string componente)
        {
            return "El campo: " + componente + " esta vacio, tiene caracteres invalidos,o esta fuera de intervalo";
        }
    }
}
