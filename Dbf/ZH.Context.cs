﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZH.Dbf
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZHEntities : DbContext
    {
        public ZHEntities()
            : base("name=ZHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestServe> RequestServes { get; set; }
        public virtual DbSet<Restaurent> Restaurents { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}