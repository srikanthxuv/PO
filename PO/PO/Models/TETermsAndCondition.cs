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
    
    public partial class TETermsAndCondition
    {
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string ObjectId { get; set; }
        public string OldUniqueId { get; set; }
        public int UniqueId { get; set; }
        public string ModuleName { get; set; }
        public int SequenceId { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Condition { get; set; }
        public string ContextIdentifier { get; set; }
        public string MasterId { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> POHeaderStructureId { get; set; }
        public Nullable<int> PickListItemId { get; set; }
        public Nullable<int> MasterTandCId { get; set; }
    }
}