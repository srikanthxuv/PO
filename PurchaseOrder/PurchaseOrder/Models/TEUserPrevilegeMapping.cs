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
    
    public partial class TEUserPrevilegeMapping
    {
        public int TRID { get; set; }
        public Nullable<int> WebRoleId { get; set; }
        public Nullable<int> ModuleId { get; set; }
        public Nullable<int> PrivilegeId { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string OldUniqueID { get; set; }
    
        public virtual TEUserPrevilege TEUserPrevilege { get; set; }
    }
}
