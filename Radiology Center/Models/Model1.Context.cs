﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Radiology_Center.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RadiologyEntities : DbContext
    {
        public RadiologyEntities()
            : base("name=RadiologyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<accountant> accountants { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<assisatant> assisatants { get; set; }
        public virtual DbSet<branch> branches { get; set; }
        public virtual DbSet<department> departments { get; set; }
        public virtual DbSet<doctor> doctors { get; set; }
        public virtual DbSet<patient_data> patient_data { get; set; }
        public virtual DbSet<patient_info> patient_info { get; set; }
        public virtual DbSet<ray> rays { get; set; }
        public virtual DbSet<report> reports { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<super_admin> super_admin { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user_> user_ { get; set; }
    }
}
