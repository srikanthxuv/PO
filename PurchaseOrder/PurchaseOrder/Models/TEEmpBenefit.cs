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
    
    public partial class TEEmpBenefit
    {
        public string PFAccNo { get; set; }
        public string UAN { get; set; }
        public string PAN { get; set; }
        public string Aadhar { get; set; }
        public string ESIIP { get; set; }
        public string ESIHospital { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public string OldUniqueid { get; set; }
        public string Objectid { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public int TEEmpBasicInfo { get; set; }
        public string PANRefNo { get; set; }
        public int Uniqueid { get; set; }
    
        public virtual TEEmpBasicInfo TEEmpBasicInfo1 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo2 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo3 { get; set; }
    }
}
