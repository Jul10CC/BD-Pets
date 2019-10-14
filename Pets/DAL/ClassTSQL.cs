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
        public IQueryable SP_XML_Prueba(string xml_cadena)
        {
            contexto = new PetsJCEntities();
            var info = (from spXML2 in contexto.sp_xml2(xml_cadena) select spXML2).ToList();
            return info.AsQueryable();
        }
    }
}
