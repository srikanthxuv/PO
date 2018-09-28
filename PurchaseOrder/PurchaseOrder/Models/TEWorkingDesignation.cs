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
    
    public partial class TEWorkingDesignation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEWorkingDesignation()
        {
            this.TEAssestRequestations = new HashSet<TEAssestRequestation>();
            this.TEAssestRequestations1 = new HashSet<TEAssestRequestation>();
            this.TEAssestRequestations2 = new HashSet<TEAssestRequestation>();
            this.TEEmpAssignmentDetails = new HashSet<TEEmpAssignmentDetail>();
            this.TEEmpAssignmentDetails1 = new HashSet<TEEmpAssignmentDetail>();
            this.TEEmpAssignmentDetails2 = new HashSet<TEEmpAssignmentDetail>();
            this.TEMobileEligibilities = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities1 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities2 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities3 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities4 = new HashSet<TEMobileEligibility>();
        }
    
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int Uniqueid { get; set; }
        public string OldUniqueid { get; set; }
        public string Objectid { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEAssestRequestation> TEAssestRequestations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEAssestRequestation> TEAssestRequestations1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEAssestRequestation> TEAssestRequestations2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpAssignmentDetail> TEEmpAssignmentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpAssignmentDetail> TEEmpAssignmentDetails1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpAssignmentDetail> TEEmpAssignmentDetails2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMobileEligibility> TEMobileEligibilities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMobileEligibility> TEMobileEligibilities1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMobileEligibility> TEMobileEligibilities2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMobileEligibility> TEMobileEligibilities3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEMobileEligibility> TEMobileEligibilities4 { get; set; }
    }
}