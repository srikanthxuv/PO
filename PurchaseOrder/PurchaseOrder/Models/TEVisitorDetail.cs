//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PurchaseOrder.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TEVisitorDetail
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public int Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Designation { get; set; }
        public string Company { get; set; }
        public string Adress { get; set; }
        public Nullable<long> MinBudget { get; set; }
        public Nullable<long> MaxBudget { get; set; }
        public string DoYoulikeProject { get; set; }
        public System.DateTime DateOfVisit { get; set; }
        public string ProjectName { get; set; }
        public Nullable<long> ProjectID { get; set; }
        public string SourceInfo { get; set; }
        public string AssociatedSalesConsultant { get; set; }
        public Nullable<long> ConsultantID { get; set; }
    }
}