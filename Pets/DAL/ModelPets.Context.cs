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
    
        public virtual ObjectResult<sp_informe1_Result> sp_informe1(Nullable<System.DateTime> fECHA_DESDE, Nullable<System.DateTime> fECHA_HASTA)
        {
            var fECHA_DESDEParameter = fECHA_DESDE.HasValue ?
                new ObjectParameter("FECHA_DESDE", fECHA_DESDE) :
                new ObjectParameter("FECHA_DESDE", typeof(System.DateTime));
    
            var fECHA_HASTAParameter = fECHA_HASTA.HasValue ?
                new ObjectParameter("FECHA_HASTA", fECHA_HASTA) :
                new ObjectParameter("FECHA_HASTA", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_informe1_Result>("sp_informe1", fECHA_DESDEParameter, fECHA_HASTAParameter);
        }
    
        public virtual ObjectResult<sp_informe2_Result> sp_informe2(Nullable<System.DateTime> fECHA_DESDE, Nullable<System.DateTime> fECHA_HASTA)
        {
            var fECHA_DESDEParameter = fECHA_DESDE.HasValue ?
                new ObjectParameter("FECHA_DESDE", fECHA_DESDE) :
                new ObjectParameter("FECHA_DESDE", typeof(System.DateTime));
    
            var fECHA_HASTAParameter = fECHA_HASTA.HasValue ?
                new ObjectParameter("FECHA_HASTA", fECHA_HASTA) :
                new ObjectParameter("FECHA_HASTA", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_informe2_Result>("sp_informe2", fECHA_DESDEParameter, fECHA_HASTAParameter);
        }
    
        public virtual ObjectResult<sp_informe3_Result> sp_informe3(Nullable<System.DateTime> fECHA_DESDE, Nullable<System.DateTime> fECHA_HASTA)
        {
            var fECHA_DESDEParameter = fECHA_DESDE.HasValue ?
                new ObjectParameter("FECHA_DESDE", fECHA_DESDE) :
                new ObjectParameter("FECHA_DESDE", typeof(System.DateTime));
    
            var fECHA_HASTAParameter = fECHA_HASTA.HasValue ?
                new ObjectParameter("FECHA_HASTA", fECHA_HASTA) :
                new ObjectParameter("FECHA_HASTA", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_informe3_Result>("sp_informe3", fECHA_DESDEParameter, fECHA_HASTAParameter);
        }
    
        public virtual ObjectResult<sp_informe4_Result> sp_informe4(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_informe4_Result>("sp_informe4", detalleParameter);
        }
    
        public virtual ObjectResult<sp_informe5_Result> sp_informe5(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_informe5_Result>("sp_informe5", detalleParameter);
        }
    
        public virtual int sp_AnularFactura(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AnularFactura", detalleParameter);
        }
    
        public virtual int sp_anularfacturas(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_anularfacturas", detalleParameter);
        }
    
        public virtual ObjectResult<sp_anularf_Result> sp_anularf(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_anularf_Result>("sp_anularf", detalleParameter);
        }
    
        public virtual ObjectResult<sp_anularfac_Result> sp_anularfac(Nullable<int> detalle)
        {
            var detalleParameter = detalle.HasValue ?
                new ObjectParameter("detalle", detalle) :
                new ObjectParameter("detalle", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_anularfac_Result>("sp_anularfac", detalleParameter);
        }
    }
}
