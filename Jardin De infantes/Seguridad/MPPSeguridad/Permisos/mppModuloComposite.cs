using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPPSeguridad.Permisos
{
  public  class mppModuloComposite
    {

        public static string   Alta(EEseguridad.Permisos.eeModuloComposite moduloComposite)
        {
            return "insert into ModuloComposite(ID_Composite,ID_Modulo)values ((select ID_Composite from Composite where Nombre='"+moduloComposite.unComposite.nombre+"'),(select * from Modulos where Nombre='"+moduloComposite.unComposite.nombre+"'))";
        }

        public static string ObtenerTodo()
        {
            return "select m.Nombre as Modulo,c.Nombre as Permiso from ModuloComposite as mp join Modulos as m on m.ID_Modulo=mp.ID_Modulo join Composite as c on c.ID_Composite=mp.ID_Composite";
        }
        public static string ObtenerTodoPermiso(EEseguridad.Permisos.eeModuloComposite moduloComposite)
        {
            return "select m.Nombre as Modulo,c.Nombre as Permiso from ModuloComposite as mp join Modulos as m on m.ID_Modulo=mp.ID_Modulo join Composite as c on c.ID_Composite=mp.ID_Composite where c.Nombre='"+moduloComposite.unComposite.nombre+"'";
        }
        public static string Eliminar(EEseguridad.Permisos.eeModuloComposite moduloComposit)
        {
            return "delete  from ModuloComposite where ID_Composite=(select ID_Composite from Composite where nombre='"+moduloComposit.unComposite.nombre+"')and ID_Modulo=(select ID_Modulo from Modulos where Nombre='"+moduloComposit.unComposite.nombre+"')";
        }
        public static string agregarFamilia(string nombre)
        {
            return "insert into CompositeFamilia(ID_CompositeFamilia)values((select ID_Composite from Composite where Nombre='"+nombre+"'))";
        }

        public static string agregarPatente(string nombre)
        {
            return "insert into CompositeFamilia(ID_CompositePatente)values((select ID_Composite from Composite where Nombre='"+nombre+"'))";
        }


    }
}
