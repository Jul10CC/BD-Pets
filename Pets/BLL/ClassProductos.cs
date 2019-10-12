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
    public class ClassProductos
    {
        public IEnumerable ListarProductos()
        {
            RepositorioGenerico<Productos> REP = new RepositorioGenerico<Productos>();
            return REP.ListarTodo();
        }
    
        public string Nuevoproducto(string nombre, int unidades, string presentacion, string descripcion, int categoria)
        {
            RepositorioGenerico<Productos> REP = new RepositorioGenerico<Productos>();
            Productos pro = new Productos();
            string resultado;
            try
            {
                pro.Nombre = nombre;
                pro.Unidades = unidades;
                pro.Presentacion = presentacion;
                pro.Descripcion = descripcion;
                pro.CategoriaProductosID = categoria;
                resultado = REP.Agregar(pro);
            }
            catch (Exception error)
            {
                resultado = "ERROR " + error.Message;
            }
            return resultado;
        }
        public string Actualizar(Productos info)
        {
            string resultado = "";
            RepositorioGenerico<Productos> REP = new RepositorioGenerico<Productos>();
            try
            {
                resultado = REP.Editar(info);
            }
            catch (Exception Error)
            {
                resultado = "ERROR: " + Error.Message;
            }
            return resultado;
        }
    }
}
