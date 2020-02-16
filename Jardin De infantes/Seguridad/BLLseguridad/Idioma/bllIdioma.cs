using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;
using DALseguridad;

namespace BLLseguridad.Idioma
{
   public class bllIdioma
    {
        public DataTable ListarIdiomas()
        {
            DataTable dt = new DataTable();
            DALseguridad.Idioma.dalIdioma dal = new DALseguridad.Idioma.dalIdioma();
            MPPSeguridad.Idioma.mppIdioma mpp = new MPPSeguridad.Idioma.mppIdioma();
            dt = dal.Leer(mpp.ListarIDioma());
            return dt;
        }

        public void crearIdioma(string idioma)
        {
            EEseguridad.Idioma.eeIdioma unIdioma = new EEseguridad.Idioma.eeIdioma(idioma);
            unIdioma.CambiarIdioma(idioma);
            DALseguridad.Idioma.dalIdioma dal = new DALseguridad.Idioma.dalIdioma();
            MPPSeguridad.Idioma.mppIdioma mpp = new MPPSeguridad.Idioma.mppIdioma();
            dal.Escribir(mpp.AgregarIdioma(unIdioma));
        }
    }
}
