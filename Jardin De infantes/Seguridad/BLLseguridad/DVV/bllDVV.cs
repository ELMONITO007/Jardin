using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad.DigitoVerificador;
using EEseguridad.Encriptado;

using MPPSeguridad.DVV;
using DALseguridad.DVV;
using System.Data;

namespace BLLseguridad.DVV
{
  public  class bllDVV
    {

     

       public string ObtenerListaDVV(string tabla)

        {
            mppDVV mpp = new mppDVV();
            dalDVV dal = new dalDVV();
            DataTable dt = new DataTable();
            dt = dal.Leer(mpp.listaDVH(tabla));
            string dvvSinCodificar=null;
            foreach (DataRow item in dt.Rows)
            {
                dvvSinCodificar = dvvSinCodificar + item[0].ToString();
            }

            return dvvSinCodificar;
        }
        public void altaDVV(string tabla)
        {
            mppDVV mpp = new mppDVV();
            dalDVV dal = new dalDVV();
            eeDigitoVerificadorV dvv = new eeDigitoVerificadorV(tabla,"","");
            EncriptarSHA5 encripatar = new EncriptarSHA5(ObtenerListaDVV(tabla));
            dvv.setDVV(encripatar.Hashear());
            dvv.setDVH(DigitoVerificadorH.getDigitoEncriptado(dvv));
            dal.Escribir(mpp.altaDVV(dvv));
        }
        public bool VerificarDVV(string tabla)
        {
            mppDVV mpp = new mppDVV();
            dalDVV dal = new dalDVV();
            DataTable dt = new DataTable();
            dt = dal.Leer(mpp.buscarUltimoDVV(tabla));
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
	        {
                DataRow row = dt.Rows[0];
                string dvvObtenido = row["DigitoVerificadorV"].ToString();
                EncriptarSHA5 encripatar = new EncriptarSHA5(ObtenerListaDVV(tabla));
                string dvv = encripatar.Hashear();
                if (dvv==dvvObtenido)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

            
        }
    }
}
