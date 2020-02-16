using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;
using MPPSeguridad;
using DALseguridad;
using System.Data.SqlClient;
using System.Data;

namespace BLLseguridad
{
    public class bllSeguridad
    {
       public List<EEseguridad.Backup.EEbackup> ListarBackup()
        {
            List<EEseguridad.Backup.EEbackup> lista = new List<EEseguridad.Backup.EEbackup>();
            DALseguridad.Backup.dalBackup unaDAL = new DALseguridad.Backup.dalBackup();
            DataTable dt=new DataTable();
           dt= unaDAL.Leer(MPPSeguridad.Backup.mppBackup.ObtenerTodoBackup());
            MPPSeguridad.Backup.mppBackup unMPP = new MPPSeguridad.Backup.mppBackup();
            lista = unMPP.ConvertirLista(dt);

            return lista;
        }

        public void CrearBackup(DateTime _fecha,string _path,string _nombreArchivo)
        {
            DALseguridad.Backup.dalBackup unaDAL = new DALseguridad.Backup.dalBackup();
            DALseguridad.Backup.dalBackup unaDAL1 = new DALseguridad.Backup.dalBackup();
            EEseguridad.Backup.EEbackup unBackup = new EEseguridad.Backup.EEbackup(_path, "", _nombreArchivo, _fecha);
            unaDAL.Escribir(MPPSeguridad.Backup.mppBackup.AltaBackup(unBackup));
            unaDAL1.Escribir(MPPSeguridad.Backup.mppBackup.CrearBackup(unBackup));

        }

        public void RecuperarBackup(DateTime _fecha, string _path, string _nombreArchivo)
        {
            DALseguridad.Backup.dalBackup unaDAL = new DALseguridad.Backup.dalBackup();
            EEseguridad.Backup.EEbackup unBackup = new EEseguridad.Backup.EEbackup(_path, "", _nombreArchivo, _fecha);
            unaDAL.Escribir(MPPSeguridad.Backup.mppBackup.RestaurarBackup(unBackup));

        }
    }
}
