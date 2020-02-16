using System;

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EEseguridad.DigitoVerificador
{
   public class eeDVGReflection
    {
        public static string GetDVH(object entity)

        {


            string dvh = string.Empty;
            Type t = entity.GetType();

            System.Reflection.PropertyInfo[] properties = t.GetProperties();

            foreach (System.Reflection.PropertyInfo p in properties)
            {

                Console.WriteLine(p);
                if (p.PropertyType.FullName.Equals(typeof(DateTime).FullName))
                {
                    DateTime date = (DateTime)p.GetValue(entity);
                    dvh += date.ToString("ddMMyyyy");
                }
                else
                {



                    dvh += p.GetValue(entity);
                }
            }


            return dvh;
        }
    }
}
