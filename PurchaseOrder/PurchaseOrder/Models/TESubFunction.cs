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
    
    public partial class TESubFunction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TESubFunction()
        {
            this.TEEmpAssignmentDetails = new HashSet<TEEmpAssignmentDetail>();
            this.TEEmpWorkSchedules = new HashSet<TEEmpWorkSchedule>();
            this.TEEmpWorkSchedules1 = new HashSet<TEEmpWorkSchedule>();
            this.TEEmpWorkSchedules2 = new HashSet<TEEmpWorkSchedule>();
            this.TEHoliday_TEWorkLocation_Mappings = new HashSet<TEHoliday_TEWorkLocation_Mappings>();
            this.TEMobileEligibilities = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities1 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities2 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities3 = new HashSet<TEMobileEligibility>();
            this.TEMobileEligibilities4 = new HashSet<TEMobileEligibility>();
            this.TESubFunctions1 = new HashSet<TESubFunction>();
            this.TESubFunctions11 = new HashSet<TESubFunction>();
            this.TESubFunctions12 = new HashSet<TESubFunction>();
        }
    
        public System.DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public int Uniqueid { get; set; }
        public string OldUniqueid { get; set; }
        public string Objectid { get; set; }
        public Nullable<int> TEDepartment { get; set; }
        public Nullable<int> TECompany { get; set; }
        public Nullable<int> TELineOfBusiness { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public bool Sunday { get; set; }
        public Nullable<System.TimeSpan> Sun_StartTime { get; set; }
        public Nullable<System.TimeSpan> Sun_EndTime { get; set; }
        public bool Monday { get; set; }
        public Nullable<System.TimeSpan> Mon_StartTime { get; set; }
        public Nullable<System.TimeSpan> Mon_EndTime { get; set; }
        public bool Tuesday { get; set; }
        public Nullable<System.TimeSpan> Tue_StartTime { get; set; }
        public Nullable<System.TimeSpan> Tue_EndTime { get; set; }
        public bool Wednesday { get; set; }
        public Nullable<System.TimeSpan> Wed_StartTime { get; set; }
        public Nullable<System.TimeSpan> Wed_EndTime { get; set; }
        public bool Thursday { get; set; }
        public Nullable<System.TimeSpan> Thu_StartTime { get; set; }
        public Nullable<System.TimeSpan> Thu_EndTime { get; set; }
        public bool Friday { get; set; }
        public Nullable<System.TimeSpan> Fri_StartTime { get; set; }
        public Nullable<System.TimeSpan> Fri_EndTime { get; set; }
        public bool Saturday { get; set; }
        public Nullable<System.TimeSpan> Sat_StartTime { get; set; }
        public Nullable<System.TimeSpan> Sat_EndTime { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public string Status { get; set; }
        public Nullable<int> HeadUser { get; set; }
        public Nullable<int> ParentTESubFunction { get; set; }
        public Nullable<decimal> WorkHoursFullDay { get; set; }
        public Nullable<decimal> WorkHoursHalfDay { get; set; }
        public Nullable<decimal> BreakTime { get; set; }
        public Nullable<System.TimeSpan> CoreInTime { get; set; }
        public Nullable<System.TimeSpan> CoreOutTime { get; set; }
        public Nullable<bool> IsCoreHoursRequired { get; set; }
        public string HROperations { get; set; }
        public string HRManager { get; set; }
    
        public virtual TECompany TECompany1 { get; set; }
        public virtual TECompany TECompany2 { get; set; }
        public virtual TECompany TECompany3 { get; set; }
        public virtual TEDepartment TEDepartment1 { get; set; }
        public virtual TEDepartment TEDepartment2 { get; set; }
        public virtual TEDepartment TEDepartment3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpAssignmentDetail> TEEmpAssignmentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpWorkSchedule> TEEmpWorkSchedules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpWorkSchedule> TEEmpWorkSchedules1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEEmpWorkSchedule> TEEmpWorkSchedules2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEHoliday_TEWorkLocation_Mappings> TEHoliday_TEWorkLocation_Mappings { get; set; }
        public virtual TELineOfBusiness TELineOfBusiness1 { get; set; }
        public virtual TELineOfBusiness TELineOfBusiness2 { get; set; }
        public virtual TELineOfBusiness TELineOfBusiness3 { get; set; }
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESubFunction> TESubFunctions1 { get; set; }
        public virtual TESubFunction TESubFunction1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESubFunction> TESubFunctions11 { get; set; }
        public virtual TESubFunction TESubFunction2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TESubFunction> TESubFunctions12 { get; set; }
        public virtual TESubFunction TESubFunction3 { get; set; }
    }
}
