﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreManagement.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StoreDBEntities : DbContext
    {
        public StoreDBEntities()
            : base("name=StoreDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Document> Documents { get; set; }
        public DbSet<Kala> Kalas { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<DocumentItem> DocumentItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
