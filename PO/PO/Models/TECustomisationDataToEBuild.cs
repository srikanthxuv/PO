//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TECustomisationDataToEBuild
    {
        public int UniqueID { get; set; }
        public string CustomerName { get; set; }
        public string SAPCustomerID { get; set; }
        public string ProjectName { get; set; }
        public string SubProductCode { get; set; }
        public string UnitNo { get; set; }
        public string Specification { get; set; }
        public string CustomisationCredit { get; set; }
        public string ArrayOfFreebies { get; set; }
        public string ModeOfCustomisation { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public Nullable<int> LastModifiedBy_Id { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
