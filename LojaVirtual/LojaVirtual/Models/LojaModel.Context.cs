﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaVirtual.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LojaVirtualEntities : DbContext
    {
        public LojaVirtualEntities()
            : base("name=LojaVirtualEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<KitPromocao> KitPromocao { get; set; }
        public virtual DbSet<Produto> Produto { get; set; }
        public virtual DbSet<Promocao> Promocao { get; set; }
    
        public virtual ObjectResult<ObterPromocoes_Result1> ObterPromocoes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObterPromocoes_Result1>("ObterPromocoes");
        }
    }
}
