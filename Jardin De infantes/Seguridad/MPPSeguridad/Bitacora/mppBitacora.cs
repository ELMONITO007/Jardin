using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;

namespace MPPSeguridad.Bitacora
{
  public  class mppBitacora
    {
        public string TodasBitacora()
        {
            return "select u.NombreUsuario as Usuario,eb.Evento,b.Fecha,b.Descripcion from Bitacora as b join Usuario as u on b.ID_Usuario=u.ID_Usuario join EventoBitacora as eb on b.ID_Evento=eb.ID_Evento";
        }
        public string BuscarBitacoraUSuario(string bitacora)
        {
            return "select u.NombreUsuario as Usuario,eb.Evento,b.Fecha,b.Descripcion from Bitacora as b join Usuario as u on b.ID_Usuario=u.ID_Usuario join EventoBitacora as eb on b.ID_Evento=eb.ID_Evento where u.NombreUsuario='"+ bitacora+"'";
        }
        public string AltaBitacota(EEseguridad.Bitacora.eeBitacora bitacora)
        {

            string dateFormatted = bitacora.getFecha().ToString("yyyy/dd/MM hh:mm:ss");
            
            return "insert into Bitacora(ID_Evento,ID_Usuario,Fecha,DigitoVerificadorH,Descripcion) values((select ID_Evento from EventoBitacora where evento='"+ bitacora.getEvento() +"'),(select ID_Usuario from Usuario where NombreUsuario='"+ bitacora.getUsuario()+"'),'"+ dateFormatted + "','" +bitacora.getDVH()+"','"+bitacora.getDescripcion()+"')";
        }
        public string BuscarBitacoraEvento(string evento)
        {
            return "select u.NombreUsuario as Usuario,eb.Evento,b.Fecha,b.Descripcion from Bitacora as b join Usuario as u on b.ID_Usuario=u.ID_Usuario join EventoBitacora as eb on b.ID_Evento=eb.ID_Evento where eb.Evento='" + evento + "'";
        }
        public string GestionDeCambios(string usuario)
        {
            return "select b.Fecha,b.Descripcion from Bitacora as b join EventoBitacora as eb on b.ID_Evento=eb.ID_Evento join Usuario as u  on u.ID_Usuario=b.ID_Usuario where (eb.ID_Evento=1 or eb.ID_Evento=11) and u.NombreUsuario='" + usuario + "'";
        }
    }

}
