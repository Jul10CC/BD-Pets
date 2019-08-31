using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Infrastructure;
using MODELS;
namespace DAL
{
    class  RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        PetsJCEntities contexto;
        public IQueryable<T> ListarTodo()
        {
            IQueryable<T> respuesta;
            using (contexto = new PetsJCEntities())
            {
                respuesta = contexto.Set<T>().ToList().AsQueryable();
            }//Fin del Using
            return respuesta;
        } //Fin de ListarTodo
    }
}
