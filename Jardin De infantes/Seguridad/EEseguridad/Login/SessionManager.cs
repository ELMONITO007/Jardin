using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Login
{
 public  sealed class SessionManager
    {
        private SessionManager() { }
        private static SessionManager _intance = null;
        public static  SessionManager instance
                    {
           get
            {
                if (_intance == null)
                {
                    _intance = new SessionManager();
                }

                return _intance;
            }
            
        }

        private eeUsuario usuario;
        public void login(eeUsuario user)
        {
            usuario = user;

        }
        public eeUsuario GetUSuario()
        {
            return usuario;
        }
        public void LogOut()
        {
            usuario = null;
        }
    }
}
