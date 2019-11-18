using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MODELS;
using System.Collections;

namespace BLL
{
    public class ClassFactura
    {
        public IEnumerable ListarFactura()
        {
            RepositorioGenerico<Factura> REP = new RepositorioGenerico<Factura>();
            return REP.ListarTodo();
        }
    }
}
