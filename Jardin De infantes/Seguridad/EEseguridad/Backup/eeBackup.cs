using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.Backup
{
    

  public  class EEbackup
    {
        public EEbackup(string _Path, string _digitoVerificadorH, string _nombreArchivo, DateTime _fecha)
        {

            Path = _Path;
            fecha = _fecha;
            digitoVerificadorH = _digitoVerificadorH;
            nombreArchivo = _nombreArchivo;
        }
        public EEbackup()
        {

        }
        public string Path
        {
            get;
            set;
        }
        public string digitoVerificadorH
        {
            get;
            set;
        }
        public string nombreArchivo
        {
            get;
            set;
        }
        public DateTime fecha
        {
            get;
            set;
        }

      
        public String GetPath()
        {
            return Path;

        }
     
    public   String GetNombre()
        {
            return nombreArchivo;

        }
        public String GetDVH()
        {
            return digitoVerificadorH;

        }
        public DateTime GetFecha()
        {
            return fecha;

        }
        public void SetDVH(string _DVH)

        {
            digitoVerificadorH = _DVH;
        }
    }



}

