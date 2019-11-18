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
        public IQueryable Informe1(string factura)
        {
            DateTime fecha1 = Convert.ToDateTime(factura);
            DateTime fecha2 = Convert.ToDateTime(factura);
            contexto = new PetsJCEntities();
            var listado1 = (from sp1 in contexto.sp_informe1(fecha1,fecha2) select sp1).ToList();
            return listado1.AsQueryable();
        }
        public IQueryable Informe2(string factura)
        {
            DateTime fecha1 = Convert.ToDateTime(factura);
            DateTime fecha2 = Convert.ToDateTime(factura);
            contexto = new PetsJCEntities();
            var listado2 = (from sp2 in contexto.sp_informe2(fecha1, fecha2) select sp2).ToList();
            return listado2.AsQueryable();
        }
        public IQueryable Informe3(string factura)
        {
            DateTime fecha1 = Convert.ToDateTime(factura);
            DateTime fecha2 = Convert.ToDateTime(factura);
            contexto = new PetsJCEntities();
            var listado3 = (from sp3 in contexto.sp_informe3(fecha1, fecha2) select sp3).ToList();
            return listado3.AsQueryable();
        }
        public IQueryable Informe4(string factura)
        {
            int idFac = Convert.ToInt32(factura);
            contexto = new PetsJCEntities();
            var listado4 = (from sp4 in contexto.sp_informe4(idFac) select sp4).ToList();
            return listado4.AsQueryable();
        }
    }
}
