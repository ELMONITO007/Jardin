using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;


namespace BLLseguridad.Login
{
  public  class bllLogin
    {
       bool verificarContraseña()
        {
           string usuario= EEseguridad.Login.SessionManager.instance.GetUSuario().getNombreUSuario();
            bllUsuario bllUser = new bllUsuario();
            string contraseña = EEseguridad.Login.SessionManager.instance.GetUSuario().getContraseña();
            string contraseñaBD = bllUser.obtenerContraseña(usuario);
            EEseguridad.Encriptado.EncriptarSHA256 encriptar = new EEseguridad.Encriptado.EncriptarSHA256(contraseña);
            string contraseñaEncriptada = encriptar.Hashear();
            if (contraseñaEncriptada == contraseñaBD)
            {
                EEseguridad.Login.SessionManager.instance.GetUSuario().contraseña = contraseñaEncriptada;
               EEseguridad.Login.SessionManager.instance.GetUSuario().digitoVerificadorH = EEseguridad.DigitoVerificador.DigitoVerificadorH.getDigitoEncriptado(EEseguridad.Login.SessionManager.instance.GetUSuario());

                return true;
            }
            else
            {
                return false;
            } 
           
        }
       bool VerificarSiExisteUsuario()
        {
            string usuario = EEseguridad.Login.SessionManager.instance.GetUSuario().getNombreUSuario();
            bllUsuario bllUser = new bllUsuario();
            DataTable dt = new DataTable();
            dt = bllUser.BuscarUSuario(usuario);

            
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }
       bool verificarDigitoVerificadorH()
        {
            BLLseguridad.Login.bllUsuario usuario = new bllUsuario();
            string DVHdb = usuario.BuscarDigitoVerificadorH(EEseguridad.Login.SessionManager.instance.GetUSuario().getNombreUSuario());
          string DVHlogin= EEseguridad.Login.SessionManager.instance.GetUSuario().digitoVerificadorH;
            if (DVHdb==DVHlogin)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
      public bool VerificarLogin(EEseguridad.Login.eeUsuario unUsuario)
        {
            EEseguridad.Login.SessionManager.instance.login(unUsuario);
            bool VC = verificarContraseña();
            bool VDVH = verificarDigitoVerificadorH();
           
            bool VU = VerificarSiExisteUsuario();
            BLLseguridad.DVV.bllDVV dVV = new DVV.bllDVV();
            bool VDVV = dVV.VerificarDVV("Usuario");
           
            if (VC==true && VDVH==true && VU==true && VDVV==true)
            {
                BLLseguridad.Bitacora.bllBitacora bitacora = new Bitacora.bllBitacora();
                bitacora.AltaBitacora("Login", EEseguridad.Login.SessionManager.instance.GetUSuario());
                return true;
            }
            else
            {
                BLLseguridad.Bitacora.bllBitacora bitacora = new Bitacora.bllBitacora();
                bitacora.AltaBitacora("Error Login", EEseguridad.Login.SessionManager.instance.GetUSuario());
                return false;
            }
        }

        
    }
}
