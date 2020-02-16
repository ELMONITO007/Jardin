using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPSeguridad.Permisos
{
    public class mppComposite
    {
        public static string ListarFamilias(string familia)
        {
            string resultado = "select distinct Nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite =cf.ID_CompositeFamilia where c.Nombre != '"+familia +"' ";
            return resultado;
        }
        public static string ListarPatentes()
        {
            string resultado = "select distinct Nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite =cf.ID_CompositePatente  where cf.ID_CompositeFamilia==null";
            return resultado;
        }

        public static List<string> ListafamiliaString(DataTable dt)
        {
            List<string> listaString = new List<string>();
            foreach (DataRow item in dt.Rows)
            {
                string dato = item[0].ToString();
                listaString.Add(dato);
            }
            return listaString;
        }

       public static string VeririfarSiEsUnaPatente(string compuesto )
        {
            return "select distinct Nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite =cf.ID_CompositePatente where cf.ID_CompositePatente=(select ID_Composite from Composite where Nombre='" + compuesto +"')";
        }

        public static string VeririfarSiEsUnaFamilia(string compuesto)
        {
            return "select distinct Nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite =cf.ID_CompositeFamilia where cf.ID_CompositeFamilia=(select ID_Composite from Composite where Nombre='"+ compuesto + "')";
        }
        public static string ObtenerRolesDeUnaFamilia(string familia)
        {
            string resultado = "select Nombre from Composite as c join CompositeFamilia as cf on c.ID_Composite=cf.ID_CompositePatente where ID_CompositeFamilia=(select distinct ID_Composite from Composite as c join CompositeFamilia as cf on c.ID_Composite=cf.ID_CompositeFamilia where nombre='" +familia+"')";
            return resultado;
        }

        public static string agregarPAtenteFamilia(string familia, string permiso)
        {
            return "insert into CompositeFamilia (ID_CompositeFamilia,ID_CompositePatente)values((select ID_Composite from Composite where nombre='" + familia + "'),(select ID_Composite from Composite where Nombre='"+ permiso +"'))";
        }
        public static string RolesUsuario(string usuario)
        {
            return "select Nombre from UsuarioFamilia as uf join Composite as c on ID_Permiso=ID_Composite join Usuario as u on u.ID_Usuario=uf.ID_Usuario where NombreUsuario='"+ usuario+"'";
        }
        public static string AsginarRolUSuario(string usuario,string rol)
        {
            return "insert into UsuarioFamilia(ID_Permiso,ID_Usuario)values((select ID_Composite from Composite where nombre='"+rol+"'),(select ID_Usuario from Usuario where NombreUsuario='"+usuario+"') )";
        }

        public static string ObtenerListaModulosRol(string rol)
        {
            return "select m.Nombre from moduloCOmposite as mc join Modulos as m on mc.ID_Modulo=m.ID_Modulo join Composite as c on c.ID_Composite=mc.ID_Composite where c.Nombre='"+rol+"'";
        }

        public static string agregarComposite(string nombre,string descripcion)
        {
            return "insert into Composite (Nombre,Descripcion,Activo)values('"+nombre+"','"+descripcion+"',1)";
        }
       
    }
}
