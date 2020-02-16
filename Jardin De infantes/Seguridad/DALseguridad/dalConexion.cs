using System.Configuration;

namespace DALseguridad
{
   public static class dalConexion
    {

        public static string Cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        public static string CadenaNegocio = ConfigurationManager.ConnectionStrings["CadenaNegocio"].ConnectionString;
    }
}


