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
    
    public partial class uspTECEM_GetUnitMileStoneDtlsToConfirm_Result
    {
        public Nullable<int> ProjectID { get; set; }
        public string ProjectColor { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int TowerID { get; set; }
        public string TowerName { get; set; }
        public int SpecificationID { get; set; }
        public string SpecificationName { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string UnitNumber { get; set; }
        public int MileStoneID { get; set; }
        public string MileStoneName { get; set; }
        public Nullable<System.DateTime> ScheduledDate { get; set; }
        public Nullable<System.DateTime> PlannedCompltnDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<decimal> MileStoneRev { get; set; }
        public Nullable<System.DateTime> ModifiedProjectionDate { get; set; }
        public string ModifiedProjectionStatus { get; set; }
        public string MileStoneStatus { get; set; }
        public string ProjectionApproverStatus { get; set; }
        public string MilestoneApproverStatus { get; set; }
        public Nullable<int> SEQNO { get; set; }
        public Nullable<bool> IsMileStoneSplitted { get; set; }
    }
}