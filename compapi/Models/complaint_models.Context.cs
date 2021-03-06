﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace compapi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class comp_model : DbContext
    {
        public comp_model()
            : base("name=comp_model")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<compdetail> compdetails { get; set; }
        public virtual DbSet<emp> emps { get; set; }
    
        public virtual ObjectResult<get_comp_Result> get_comp(Nullable<int> empid)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<get_comp_Result>("get_comp", empidParameter);
        }
    
        public virtual int insert(Nullable<int> empid, string dept, string problem, string status, Nullable<long> contact, Nullable<System.DateTime> date)
        {
            var empidParameter = empid.HasValue ?
                new ObjectParameter("empid", empid) :
                new ObjectParameter("empid", typeof(int));
    
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            var problemParameter = problem != null ?
                new ObjectParameter("problem", problem) :
                new ObjectParameter("problem", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var contactParameter = contact.HasValue ?
                new ObjectParameter("contact", contact) :
                new ObjectParameter("contact", typeof(long));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insert", empidParameter, deptParameter, problemParameter, statusParameter, contactParameter, dateParameter);
        }
    
        public virtual ObjectResult<PROC_EMP_List_Result> PROC_EMP_List(string eMPNAme)
        {
            var eMPNAmeParameter = eMPNAme != null ?
                new ObjectParameter("EMPNAme", eMPNAme) :
                new ObjectParameter("EMPNAme", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_EMP_List_Result>("PROC_EMP_List", eMPNAmeParameter);
        }
    }
}
