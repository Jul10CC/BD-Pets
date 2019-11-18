using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Collections;
namespace BLL
{
    public class ClassConsultas
    {
        public IEnumerable Consulta1(string usuario)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.ProcedimientoTabla(usuario);
        }
        public IEnumerable SP_XML(string xml_cadena)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.SP_XML_Prueba(xml_cadena);
        }
        public IEnumerable sp_informe1(string factura)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.Informe1(factura);
        }
        public IEnumerable sp_informe2(string factura)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.Informe2(factura);
        }
        public IEnumerable sp_informe3(string factura)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.Informe3(factura);
        }
        public IEnumerable sp_informe4(string factura)
        {
            ClassTSQL Lg = new ClassTSQL();
            return Lg.Informe4(factura);
        }
    }
}
