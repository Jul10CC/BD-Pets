using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELS;
namespace DAL
{
    public class ClassTSQL
    {
        PetsJCEntities contexto;
        public IQueryable ProcedimientoTabla(string usuario)
        {
            int idUsuario = Convert.ToInt32(usuario);
            contexto = new PetsJCEntities();
            var listado = (from sp in contexto.sp_Logueo(idUsuario) select sp).ToList();
            return listado.AsQueryable();
        }
    }
}
