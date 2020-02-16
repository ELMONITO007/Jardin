using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IU
{
 public static   class CadenaConexion
    {
        public static string cadnea = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
    }
}
