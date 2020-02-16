using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;

namespace BLLseguridad.Bitacora
{
  public  class bllBitacora
    {
        public void AltaBitacora(string evento,EEseguridad.Login.eeUsuario unUSuario)
        {
            EEseguridad.Bitacora.eeEventoBitacora unEvento = new EEseguridad.Bitacora.eeEventoBitacora(evento);
            EEseguridad.Bitacora.eeBitacora elEvento = new EEseguridad.Bitacora.eeBitacora(DateTime.Now,unEvento,unUSuario,evento,"");
            elEvento.modificarDVH(EEseguridad.DigitoVerificador.DigitoVerificadorH.getDigitoEncriptado(elEvento));
            MPPSeguridad.Bitacora.mppBitacora mpp = new MPPSeguridad.Bitacora.mppBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dal.Escribir(mpp.AltaBitacota(elEvento));            ;
        }
        public DataTable MostrarBitacora()
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Bitacora.mppBitacora mpp = new MPPSeguridad.Bitacora.mppBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dt=dal.Leer(mpp.TodasBitacora());

            return dt;
        }
        public DataTable BuscarPorUSuario(string nombreUSuario)
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Bitacora.mppBitacora mpp = new MPPSeguridad.Bitacora.mppBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dt = dal.Leer(mpp.BuscarBitacoraUSuario(nombreUSuario));
            return dt;
        }
        public DataTable BuscarPorEvento(string nombreUSuario)
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Bitacora.mppBitacora mpp = new MPPSeguridad.Bitacora.mppBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dt = dal.Leer(mpp.BuscarBitacoraEvento(nombreUSuario));
            return dt;
        }
        public DataTable BuscarControlDeCambios(string nombreUSuario)
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Bitacora.mppBitacora mpp = new MPPSeguridad.Bitacora.mppBitacora();
            DALseguridad.Bitacora.dalBitacora dal = new DALseguridad.Bitacora.dalBitacora();
            dt = dal.Leer(mpp.GestionDeCambios(nombreUSuario));
            return dt;
        }

    }

   
}
