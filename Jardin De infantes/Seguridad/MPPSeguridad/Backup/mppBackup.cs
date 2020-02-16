using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EEseguridad;

namespace MPPSeguridad.Backup
{

    public class mppBackup
    {
               
      public static string ObtenerTodoBackup()
        {
            return "select Paths,NombreArchivo,Fecha,DigitoVerificadorH from dbo.BackupS";
        }

      public static string AltaBackup(EEseguridad.Backup.EEbackup unBackup)

        {
      
            string strDate = unBackup.GetFecha().ToString("dd-MM-yyyy HH:mm:ss");


            return "insert into BackupS(Fecha, Paths, NombreArchivo, DigitoVerificadorH)values('" + strDate + "', '" + unBackup.GetPath() + "', '" + unBackup.GetNombre() + "', '"  + unBackup.GetDVH() + "'  )";
        }

      public static string CrearBackup(EEseguridad.Backup.EEbackup unBackup)
        {

            return "backup database JardinInfantes to disk='" + unBackup.GetPath() + @"\" + unBackup.GetNombre() + ".bak'";
        }
        
      public static string RestaurarBackup(EEseguridad.Backup.EEbackup unBackup)
        {
            return "Restore database JardinInfantes from disk='" + unBackup.GetPath() + @"\" + unBackup.GetNombre() + ".bak'";
        }
        public List<EEseguridad.Backup.EEbackup> ConvertirLista(DataTable dt)
        {
            List<EEseguridad.Backup.EEbackup> lista = new List<EEseguridad.Backup.EEbackup>();
            foreach (DataRow item in dt.Rows)
            {
                string dvh = item["DigitoVerificadorH"].ToString();
                string p = item["Paths"].ToString();
                string na = item["NombreArchivo"].ToString();
                DateTime f =DateTime.Parse( item["Fecha"].ToString());
        


                EEseguridad.Backup.EEbackup unBackup = new EEseguridad.Backup.EEbackup(p,dvh,na,f);
                lista.Add(unBackup);
            }

            return lista;
        }
    }
    
     
}
