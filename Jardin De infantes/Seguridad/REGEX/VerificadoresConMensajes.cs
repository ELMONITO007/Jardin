using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;


namespace REGEX
{
   
      
 public static class VerificadoresConMensajes

    {
        public static bool VerificarIntervalo(string numero, string componente, MetroFramework.Forms.MetroForm form)
        {
            if (REGEXstring.VerificarNumerosIntervalo(numero))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.IntervaloNumero(componente));
                return false;
            }
        }


        public static bool VerificarSoloNumero(string numero,string componente, MetroFramework.Forms.MetroForm form)
        {
            if (REGEXstring.VerificarNumeros(numero))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.SoloNumeros(componente));
                return false;
            }
        }
        public static bool  VerificarTamañoNumeros(int tmin,int tmax, string valor,MetroFramework.Forms.MetroForm form)
        {
            if (REGEXstring.VerificarTemañoNumero(valor, tmin, tmax)) { return true; }
            else {
                MetroMessageBox.Show(form, mppMensajes.TamañoNumero());
                return false;

            }
        }

        public static void VerificarSiExiste(string componente, MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, mppMensajes.VerificarSiExiste(componente));
        }


        public static bool MensajeSoloLetras(string componente, string valor, MetroFramework.Forms.MetroForm form)
        {
            if (REGEXstring.VerificarLetras(valor))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.VacioCaracteresInvalidos(componente));
                return false;
            }
        }


        public static bool MensajeAlfanumerico(string componente,string valor,MetroFramework.Forms.MetroForm form)
        {
            if (REGEXstring.VerificarAlfaNumerico(valor))
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.VacioCaracteresInvalidos(componente));
                return false;
            }
        }
        public static bool MensajeVacio(string componente, string valor, MetroFramework.Forms.MetroForm form)
        {
            if (valor!="")
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.VacioCaracteres(componente));
                return false;
            }
        }

        public static bool FechaPosteriorHoy(string componente, string valor, MetroFramework.Forms.MetroForm form)
        {
            long resul = DateTime.Compare(DateTime.Now, DateTime.Parse(valor));

            if (resul!=-1)
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.FechaPosteriorHoy(componente));
                return false;
            }
        }
        public static bool FechaPosteriorAlFin(string componente, string valorInicial,string valorFinal, MetroFramework.Forms.MetroForm form)
        {
            long resul = DateTime.Compare(DateTime.Parse( valorInicial),DateTime.Parse( valorFinal));

            if (resul == -1)
            {
                return true;
            }
            else
            {
                MetroMessageBox.Show(form, mppMensajes.FechaPosteriorFin(componente));
                return false;
            }
        }

        public static void Actualizar(MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, mppMensajes.Actualizar());
        }

        public static void Eliminar(MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, mppMensajes.Eliminar());
        }

        public static void Agregar(MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, mppMensajes.Agregar());
        }


        public static void DgvVacio(MetroFramework.Forms.MetroForm form)
        {
            MetroMessageBox.Show(form, mppMensajes.DgvVacio());
        }

    }
}
