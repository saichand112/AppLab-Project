﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALS.Demo.Marketing.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AppLabDbs : DbContext
    {
        public AppLabDbs()
            : base("name=AppLabDbs")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Marketing> Marketings { get; set; }
    
        public virtual int DeleteEmploye(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteEmploye", empidParameter);
        }
    
        public virtual ObjectResult<getemployees_Result> getemployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getemployees_Result>("getemployees");
        }
    
        public virtual ObjectResult<selectemployee_Result> selectemployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selectemployee_Result>("selectemployee");
        }
    }
}