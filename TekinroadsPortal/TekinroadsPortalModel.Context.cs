﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TekinroadsPortal
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TekinRoadsEntities : DbContext
    {
        public TekinRoadsEntities()
            : base("name=TekinRoadsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPermission> PersonPermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}