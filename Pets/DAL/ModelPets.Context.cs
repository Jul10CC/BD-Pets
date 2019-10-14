﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PetsJCEntities : DbContext
    {
        public PetsJCEntities()
            : base("name=PetsJCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<CategoriaProductos> CategoriaProductos { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detalle> Detalle { get; set; }
        public virtual DbSet<DetalleMetodoPago> DetalleMetodoPago { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<EmpleadoCargo> EmpleadoCargo { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<ModoPago> ModoPago { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<sp_Logueo_Result> sp_Logueo(Nullable<int> usuario)
        {
            var usuarioParameter = usuario.HasValue ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_Logueo_Result>("sp_Logueo", usuarioParameter);
        }
    
        public virtual ObjectResult<sp_xml_Result> sp_xml(string xml_estructura)
        {
            var xml_estructuraParameter = xml_estructura != null ?
                new ObjectParameter("xml_estructura", xml_estructura) :
                new ObjectParameter("xml_estructura", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_xml_Result>("sp_xml", xml_estructuraParameter);
        }
    
        public virtual ObjectResult<sp_xml2_Result> sp_xml2(string xml_estructura)
        {
            var xml_estructuraParameter = xml_estructura != null ?
                new ObjectParameter("xml_estructura", xml_estructura) :
                new ObjectParameter("xml_estructura", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_xml2_Result>("sp_xml2", xml_estructuraParameter);
        }
    }
}
