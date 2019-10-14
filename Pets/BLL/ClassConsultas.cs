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
    }
}
