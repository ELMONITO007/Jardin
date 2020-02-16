using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;

namespace MPPSeguridad.Login
{
   public class mppUsuario
    {
        public string AltaUSuario(EEseguridad.Login.eeUsuario unUsuario)
        {
            return "insert into Usuario(NombreUsuario,Contraseña,DigitoVerificadorH,Habilitado)values('" + unUsuario.getNombreUSuario() + "','" + unUsuario.getContraseña() + "','"+unUsuario.getDigitoVerificadorH()  +"',1)";
        }
        public string BajaUSuario(EEseguridad.Login.eeUsuario unUsuario)

        {
            return "update Usuario set Habilitado=0 where NombreUsuario='" +unUsuario.getNombreUSuario()+"'";
        }
        public string ModificarUsuario(EEseguridad.Login.eeUsuario unUsuario)
        {
            return "update Usuario set Contraseña='"+unUsuario.getContraseña()+"',DigitoVerificadorH='"+unUsuario.getDigitoVerificadorH()+"' where NombreUsuario='"+unUsuario.getNombreUSuario()+"'";
        }
        public string ObtenerUsuarios()
        {
            return "select NombreUsuario from Usuario where habilitado=1";
        }
        public string ObtenerContraseña(string nombreUsuario)
        {
            return "select Contraseña from Usuario where NombreUsuario='"+nombreUsuario+"'";
        }
        public string BuscarUSuario(string nombreUsuario)
        {
            return "select NombreUsuario from Usuario where NombreUsuario='" + nombreUsuario + "'";
        }
        public string BuscarDVH(string nombreUsuario)
        {
            return "select DigitoVerificadorH from Usuario where NombreUsuario='" + nombreUsuario + "'";
        }
    }
}
