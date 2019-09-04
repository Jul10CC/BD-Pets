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
    public class  RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        PetsJCEntities contexto;
        public string Agregar(T NuevaEntidad)
        {
            string mensaje = "";
            if (NuevaEntidad == null)
            {
                mensaje = "Error: Datos vacios";
            }
            else
            {
                using (contexto = new PetsJCEntities())
                {
                    var dbset = contexto.Set<T>();
                    dbset.Add(NuevaEntidad);
                    contexto.SaveChanges();
                }
                mensaje = "Se ha grabado un nuevo registro";
            }
            return mensaje;
        }
        public string Editar(T Entidad)
        {
            string mensaje = "";
            if (Entidad == null)
            {
                mensaje = "Error datos vacios";
            }
            else
            {
                using (contexto = new PetsJCEntities())
                {
                    var dbset = contexto.Set<T>();
                    dbset.Attach(Entidad);
                    contexto.Entry(Entidad).State = EntityState.Modified;
                    contexto.SaveChanges();//guardar cambios
                    mensaje = "Datos actualizados";
                }
            }
            return mensaje;
        }//fin de Editar
        public IQueryable<T> ListarTodo()
        {
            IQueryable<T> respuesta;
            using (contexto = new PetsJCEntities())
            {
                respuesta = contexto.Set<T>().ToList().AsQueryable();
            }//fin del using 
            return respuesta;
        }//fin del listar todo

        public IQueryable<T> ListarTodoConFiltro(Expression<Func<T, bool>> filtro) 
        {
            IQueryable<T> respuesta;
            using (contexto = new PetsJCEntities())
            {
                DbQuery<T> consulta = contexto.Set<T>();
                respuesta = consulta.Where(filtro).ToList().AsQueryable();
            }//fin del using
            return respuesta;
        }//fin del listar todo con filtro
    }
}
