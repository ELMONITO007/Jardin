using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Idioma
{
    public sealed class SingletonIdioma
    {
        private SingletonIdioma()
        {
        }

        private static SingletonIdioma _intance = null;
        public static SingletonIdioma intance
        {
            get
            {
                if (_intance == null)
                    _intance = new SingletonIdioma();
                return _intance;
            }
        }

        private eeIdioma unIdioma
        {
            get;
            set;
        }

        public void NuevoIdioma(eeIdioma lenguaje)
        {
            unIdioma = lenguaje;
        }
    
        public eeIdioma getUsuario()
        {
            return unIdioma;
        }

        public void CambiarIdioma(string NuevoIdioma)
        {
            unIdioma.CambiarIdioma(NuevoIdioma);
        }

        public void BorrarIdioma()
        {
            unIdioma = null;
        }
    }
}
