﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ValarMorghulis.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VMDBContainer : DbContext
    {
        public VMDBContainer()
            : base("name=VMDBContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Character> Characters { get; set; }
        public virtual DbSet<Culture> Cultures { get; set; }
        public virtual DbSet<House> Houses { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}
