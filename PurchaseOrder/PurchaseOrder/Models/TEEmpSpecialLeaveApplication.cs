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
    
    public partial class TEEmpSpecialLeaveApplication
    {
        public int Uniqueid { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> TODate { get; set; }
        public Nullable<decimal> NoOfDays { get; set; }
        public Nullable<int> LeaveType { get; set; }
        public string Status { get; set; }
        public Nullable<int> HRApprover { get; set; }
        public string HRComment { get; set; }
        public Nullable<int> MangerAppover { get; set; }
        public string ManagerComment { get; set; }
        public string HRAction { get; set; }
        public string ManagerAction { get; set; }
        public Nullable<int> TEEmpBasicInfo { get; set; }
        public bool Isdeleted { get; set; }
        public string Reason { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<int> LeaveId { get; set; }
    
        public virtual TEEmpBasicInfo TEEmpBasicInfo1 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo2 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo3 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo4 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo5 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo6 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo7 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo8 { get; set; }
        public virtual TEEmpBasicInfo TEEmpBasicInfo9 { get; set; }
        public virtual TEEmpLeaveApplication TEEmpLeaveApplication { get; set; }
        public virtual TEEmpLeaveApplication TEEmpLeaveApplication1 { get; set; }
        public virtual TEEmpLeaveApplication TEEmpLeaveApplication2 { get; set; }
        public virtual TELeaveType TELeaveType { get; set; }
        public virtual TELeaveType TELeaveType1 { get; set; }
        public virtual TELeaveType TELeaveType2 { get; set; }
    }
}