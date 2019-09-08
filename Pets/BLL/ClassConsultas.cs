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
    }
}
