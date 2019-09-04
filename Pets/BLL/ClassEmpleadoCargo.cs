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
   public  class ClassEmpleadoCargo
    {
        public IEnumerable ListarCargo()
        {
            RepositorioGenerico<EmpleadoCargo> REP = new RepositorioGenerico<EmpleadoCargo>();
            return REP.ListarTodo();

        }

        public string NuevaCargo(string nombre)
        {
            RepositorioGenerico<Cargo> REP = new RepositorioGenerico<Cargo>();
            Cargo Car = new Cargo();
            string resultado;
            try
            {
                Car.Nombre = nombre;
                resultado = REP.Agregar(Car);
            }
            catch (Exception error)
            {
                resultado = "ERROR" + error.Message;

            }
            return resultado;
        }
        public string Actualizar(Cargo info)
        {
            string resultado = "";
            RepositorioGenerico<Cargo> REP = new RepositorioGenerico<Cargo>();
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
