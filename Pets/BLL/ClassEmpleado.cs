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
    public class ClassEmpleado
    {
        public IEnumerable ListarEmpleados()
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            return REP.ListarTodo();
        }
        public IEnumerable BuscaEmpleadoNombreyApellido(string nombre, string apellido)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            return REP.ListarTodoConFiltro(c => c.Nombre == nombre || c.Apellido == apellido);
        }//fin de BuscaEmpleadoNombreyApellido
        public string NuevoEmpleado(string nombre, string apellido, string correo, string telefono1, string telefono2)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            Empleado EMP = new Empleado();
            string resultado;
            try
            {
                IEnumerable busca = BuscaEmpleadoNombreyApellido(nombre, apellido);
                if (busca.Cast<object>().Any())
                    resultado = "Error: ya existe el empleado " + nombre + " " + apellido;
                else
                {
                    EMP.Nombre = nombre;
                    EMP.Apellido = apellido;
                    EMP.Correo = correo;
                    EMP.Telefono1 = telefono1;
                    EMP.Telefono2 = telefono2;
                    resultado = REP.Agregar(EMP);
                }
            }
            catch (Exception error)
            {
                resultado = "ERROR " + error.Message;
            }
            return resultado;
        }//fin de NuevoEmpleado
        public string ActualizarEmpleado(Empleado Info)
        {
            string resultado = "";
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            try
            {
                resultado = REP.Editar(Info);
            }
            catch (Exception error)
            {

                resultado = "ERRROR " + error.Message;
            }
            return resultado;
        }//fin de EmpleadoCliente

        public IEnumerable buscarUsuarioYContrasenia(string nombreusuario, string password)
        {
            RepositorioGenerico<Usuario> REP = new RepositorioGenerico<Usuario>();
            var respuesta = REP.ListarTodoConFiltro(b => b.Username== nombreusuario && b.Password == password);
            return respuesta;
        }//fin buscar UsuarioYcontrasenia

        public IEnumerable buscarcargo(int cargoid)
        {
            RepositorioGenerico<EmpleadoCargo> REP = new RepositorioGenerico<EmpleadoCargo>();
            var respuesta = REP.ListarTodoConFiltro(b => b.CargoID == cargoid);
            return respuesta;
        }//fin buscar Cargo

        public string Verificacion(string username, string password)
        {
            RepositorioGenerico<Empleado> REP = new RepositorioGenerico<Empleado>();
            Empleado NUEVO = new Empleado();
            string resultado = "";
            try
            {
                IEnumerable busca = buscarUsuarioYContrasenia(username, password);
                if (busca.Cast<object>().Any())
                    resultado = "Bienvenido";
                else
                {
                    resultado = "ERROR";
                }
            }
            catch (Exception error)
            {
                resultado = "Error " + error.Message;
            }
            return resultado;
        }//fin del NuevoEstado
    }
}
