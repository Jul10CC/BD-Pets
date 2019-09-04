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
    public class ClassCategoriaProducto
    {
        public IEnumerable ListarCategoria()
        {
            RepositorioGenerico<CategoriaProductos> REP = new RepositorioGenerico<CategoriaProductos>();
            return REP.ListarTodo();

        }

        public string NuevaCategoria(string nombre)
        {
            RepositorioGenerico<CategoriaProductos> REP = new RepositorioGenerico<CategoriaProductos>();
            CategoriaProductos Cat = new CategoriaProductos();
            string resultado;
            try
            {
                Cat.Nombre = nombre;
                resultado = REP.Agregar(Cat);
            }
            catch (Exception error)
            {
                resultado = "ERROR" + error.Message;

            }
            return resultado;
        }
        public string Actualizar(CategoriaProductos info)
        {
            string resultado = "";
            RepositorioGenerico<CategoriaProductos> REP = new RepositorioGenerico<CategoriaProductos>();
            try
            {
                resultado = REP.Editar(info);
            }
            catch (Exception Error)
            {

                resultado = "Error: " + Error.Message;
            }
            return resultado;
        }
    }
}
