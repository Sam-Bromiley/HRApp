﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HRAppEntities : DbContext
    {
        public HRAppEntities()
            : base("name=HRAppEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }
        public virtual DbSet<OfficeLocation> OfficeLocations { get; set; }
        public virtual DbSet<Qualification> Qualifications { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SearchType> SearchTypes { get; set; }
        public virtual DbSet<TypeOfEmployee> TypeOfEmployees { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
