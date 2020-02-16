using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EEseguridad.Bitacora
{
   public class eeBitacora
    {
        public eeBitacora(DateTime _fecha,eeEventoBitacora _evento,Login.eeUsuario _usuario,string _descripcion,string DVH)
        {
            fecha = _fecha;
            evento = _evento;
            usuario = _usuario;
            descripcion = _descripcion;
            digitoVerificadorHorizontal = DVH;
        }
        DateTime fecha
        {
            get;
            set;
        }
        eeEventoBitacora evento
        {
            get;
            set;
        }
        Login.eeUsuario usuario
        {
            get;
            set;
        }

        string descripcion
        {
            get;
            set;
        }
        string digitoVerificadorHorizontal
        {
            get;
            set;
        }

        public void modificarDVH(string undvh)
        {
            digitoVerificadorHorizontal = undvh;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public string getUsuario()
        {
            return usuario.getNombreUSuario();
        }

        public string getEvento()
        {
            return evento.getEventoBitacora();
        }

        public string getDVH()
        {
            return digitoVerificadorHorizontal;
        }
    }
}
