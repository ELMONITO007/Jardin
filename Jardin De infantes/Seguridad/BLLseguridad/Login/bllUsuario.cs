using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;
using DALseguridad;
using System.Data;

namespace BLLseguridad.Login
{
    public class bllUsuario
    {
        public  string generarUsuario(string parte1,string parte2)
        {
            string nuevaPArte1;
            string nuevaPArte2;
            if (parte1.Length<6)
            {
                nuevaPArte1 = parte1.Substring(0, parte1.Length);
            }
            else
            {
                nuevaPArte1 = parte1.Substring(0, 5);
            }

            if (parte2.Length<3)
            {
                nuevaPArte2 = parte2.Substring(0, parte2.Length);
            }
            else
            {
                nuevaPArte2 = parte2.Substring(0, 3);
            }
            return nuevaPArte1+nuevaPArte2;
        }
        public void AltaUSuario(string NombreUSuario, string contraseña)


        {
            EEseguridad.Encriptado.EncriptarSHA256 contraselaEncriptada = new EEseguridad.Encriptado.EncriptarSHA256(contraseña);
            contraseña = contraselaEncriptada.Hashear();
            EEseguridad.Login.eeUsuario unUsuario = new EEseguridad.Login.eeUsuario(NombreUSuario, contraseña, "", true);
          

            unUsuario.setDigitoVerificadorH(EEseguridad.DigitoVerificador.DigitoVerificadorH.getDigitoEncriptado(unUsuario));

            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            dal.Escribir(mpp.AltaUSuario(unUsuario));
            BLLseguridad.DVV.bllDVV dvv = new DVV.bllDVV();
            dvv.altaDVV("Usuario");
            BLLseguridad.Bitacora.bllBitacora bitacora = new Bitacora.bllBitacora();
            bitacora.AltaBitacora("Alta usuario", unUsuario);

        }
        public DataTable MostrarUSuarios()
            {
            DataTable dt = new DataTable();
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            dt=dal.Leer(mpp.ObtenerUsuarios());

            return dt;
            }
        public void BajaUSuario(string NombreUSuario)
        {
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            EEseguridad.Login.eeUsuario unUsuario = new EEseguridad.Login.eeUsuario(NombreUSuario, "", "", false);
            dal.Escribir(mpp.BajaUSuario(unUsuario));
            BLLseguridad.Bitacora.bllBitacora bitacora = new Bitacora.bllBitacora();
            bitacora.AltaBitacora("Baja usuario", unUsuario);
        }
        public void ModificarCOntraseña(string NombreUSuario, string contraseña)
        {
            EEseguridad.Encriptado.EncriptarSHA256 contraselaEncriptada = new EEseguridad.Encriptado.EncriptarSHA256(contraseña);
            contraseña = contraselaEncriptada.Hashear();
            EEseguridad.Login.eeUsuario unUsuario = new EEseguridad.Login.eeUsuario(NombreUSuario, contraseña, "", true);
            unUsuario.setDigitoVerificadorH(EEseguridad.DigitoVerificador.DigitoVerificadorH.getDigitoEncriptado(unUsuario));
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            dal.Escribir(mpp.ModificarUsuario(unUsuario));
            BLLseguridad.DVV.bllDVV dvv = new DVV.bllDVV();
            dvv.altaDVV("Usuario");
            BLLseguridad.Bitacora.bllBitacora bitacora = new Bitacora.bllBitacora();
            bitacora.AltaBitacora("Cambiar contraseña", unUsuario);
        }
        public string obtenerContraseña(string NombreUSuario)
        {
           
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            DataTable dt = new DataTable();
           
                dt = dal.Leer(mpp.ObtenerContraseña(NombreUSuario));
                DataRow row = dt.Rows[0];
                string resultado = row["Contraseña"].ToString();
                return resultado;
           
        }
        public DataTable BuscarUSuario(string NombreUsuario)
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            dt = dal.Leer(mpp.BuscarUSuario(NombreUsuario));

            return dt;
        }
        public string BuscarDigitoVerificadorH(string NombreUsuario)
        {
            DataTable dt = new DataTable();
            MPPSeguridad.Login.mppUsuario mpp = new MPPSeguridad.Login.mppUsuario();
            DALseguridad.Login.dalUsuario dal = new DALseguridad.Login.dalUsuario();
            dt = dal.Leer(mpp.BuscarDVH(NombreUsuario));
            DataRow row = dt.Rows[0];
                string resultado= row["DigitoVerificadorH"].ToString();
            return resultado;
        }
    }
}
