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
    public class ClassUsuario
    {
        public IEnumerable ListarUsuario()
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            return REP.ListarTodo();
        }

        public string NuevoUsuario(string username, string password, int empleado)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            Usuario us = new Usuario();
            string resultado;
            try
            {
                us.Username = username;
                us.Password = password;
                us.EmpleadoID = empleado;
                resultado = REP.Agregar(us);
            }
            catch (Exception error)
            {
                resultado = "ERROR " + error.Message;
            }
            return resultado;
        }
        public string Actualizar(Usuario info)
        {
            string resultado = "";
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
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
