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
    public class ClassCliente
    {
        public IEnumerable ListarClientes()
        {
            RepositorioGenerico<Cliente> REP = new RepositorioGenerico<Cliente>();
            return REP.ListarTodo();
        }
        public IEnumerable BuscaClienteNITyNombre(string nit, string nombre)
        {
            RepositorioGenerico<Cliente> REP = new RepositorioGenerico<Cliente>();
            return REP.ListarTodoConFiltro(c => c.NIT == nit || c.Nombre == nombre);
        }//fin de BuscaClienteNITyNombre
        public string NuevoCliente(string nombre,string apellido, string nit, string direccion, string telefono1, string telefono2)
        {
            RepositorioGenerico<Cliente> REP = new RepositorioGenerico<Cliente>();
            Cliente CLI = new Cliente();
            string resultado;
            try
            {
                IEnumerable busca = BuscaClienteNITyNombre(nit, nombre);
                if (busca.Cast<object>().Any())
                    resultado = "Error: ya existe el cliente " + nombre + "Con nit: " + nit;
                else
                {
                    CLI.Nombre = nombre;
                    CLI.Apellido = apellido;
                    CLI.NIT = nit;
                    CLI.Direccion = direccion;
                    CLI.Telefono1 = telefono1;
                    CLI.Telefono2 = telefono2;
                    resultado = REP.Agregar(CLI);
                }
            }
            catch (Exception error)
            {
                resultado = "ERROR " + error.Message;
            }
            return resultado;
        }//fin de NuevoCliente
        public string ActualizarCliente(Cliente Info)
        {
            string resultado = "";
            RepositorioGenerico<Cliente> REP = new RepositorioGenerico<Cliente>();
            try
            {
                resultado = REP.Editar(Info);
            }
            catch (Exception error)
            {

                resultado = "ERRROR " + error.Message;
            }
            return resultado;
        }//fin de ActualizaCliente
    }
}

