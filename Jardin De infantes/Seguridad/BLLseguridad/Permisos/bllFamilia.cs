using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad.Permisos;

namespace BLLseguridad.Permisos
{
    public class bllFamilia
    {
        public List<string> ListarFamilias(string familia)
        {
            List<string> familias = new List<string>();

            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            DataTable dt = new DataTable();
            dt = dal.Leer(MPPSeguridad.Permisos.mppComposite.ListarFamilias(familia));
            familias = MPPSeguridad.Permisos.mppComposite.ListafamiliaString(dt);
            return familias;

        }

        public List<string> ObtenerPAtenteUnaFamilia(string familia)
        {
            List<string> listaPatente = new List<string>();
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            DataTable dt = new DataTable();
            dt = dal.Leer(MPPSeguridad.Permisos.mppComposite.ObtenerRolesDeUnaFamilia(familia));
            listaPatente = MPPSeguridad.Permisos.mppComposite.ListafamiliaString(dt);
            


            return listaPatente;
        }

        public EEseguridad.Permisos.Familia ObtenerPAtenteUnaFamiliaComposite(string familia)
        {
            
            

            ///Obtengo la lista de patentes y familias de una Familia
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            DataTable dt = new DataTable();
            dt = dal.Leer(MPPSeguridad.Permisos.mppComposite.ObtenerRolesDeUnaFamilia(familia));
            //Creo la Familia 
            EEseguridad.Permisos.Familia familiaComposite = new Familia();
            familiaComposite.nombre = familia;
            //Obtengo la lista de patentes y familia en String
            List<string> familias = new List<string>();
            familias = MPPSeguridad.Permisos.mppComposite.ListafamiliaString(dt);
            //Le agrego solo las patentes
            foreach (string item in familias)
            {
                DALseguridad.Permisos.dalComposite dalPatente = new DALseguridad.Permisos.dalComposite();
                DataTable dtPatentente =new DataTable();
                dtPatentente = dalPatente.Leer(MPPSeguridad.Permisos.mppComposite.VeririfarSiEsUnaPatente(item));
                if (dtPatentente.Rows.Count==0)
                {
                    
                }
                else
                {
                    EEseguridad.Permisos.Patente patente = new Patente();
                    patente.nombre = item;
                    familiaComposite.agregarFamilia(patente);
                }

            }
            //Le agrego solo las familias y genero recursividad con esa familia para obtener las patentes y familias
            foreach (string item in familias)
            {
                DALseguridad.Permisos.dalComposite dalFamilia = new DALseguridad.Permisos.dalComposite();
                DataTable dtFamilia = new DataTable();
                dtFamilia = dalFamilia.Leer(MPPSeguridad.Permisos.mppComposite.VeririfarSiEsUnaFamilia(item));
                if (dtFamilia.Rows.Count==0)
                {

                }
                else
                {
                 EEseguridad.Permisos.Familia unaFamilia = new Familia();
                    unaFamilia = ObtenerPAtenteUnaFamiliaComposite(item);
                    familiaComposite.agregarFamilia(unaFamilia);
                    
                }

            }

            return familiaComposite;
        }

       public string ObtenerListadoDeLaFamilia(string familia)
        {

            EEseguridad.Permisos.Familia familiaComposite = new Familia();
            familiaComposite = ObtenerPAtenteUnaFamiliaComposite(familia);
            

            return familiaComposite.Mostrar(2); 
        }

        public  void AgregarPermiso(string familia,string permiso )
        {
            DALseguridad.Permisos.dalComposite dal = new DALseguridad.Permisos.dalComposite();
            dal.Escribir(MPPSeguridad.Permisos.mppComposite.agregarPAtenteFamilia(familia, permiso));
        }

    }
}
