﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAKAKO_ERP_3LAYER
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MMTB_TVC_Entities : DbContext
    {
        public MMTB_TVC_Entities()
            : base("name=MMTB_TVC_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<M0005_ListMMTB> M0005_ListMMTB { get; set; }
        public DbSet<M0005_ListMMTBDoc1> M0005_ListMMTBDoc1 { get; set; }
        public DbSet<M0005_ListMMTBLine> M0005_ListMMTBLine { get; set; }
        public DbSet<M0005_ListMMTBDoc2> M0005_ListMMTBDoc2 { get; set; }
        public DbSet<M0005_ListMMTBDoc3> M0005_ListMMTBDoc3 { get; set; }
    }
}
