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
    
    public partial class TEAttendanceEntry
    {
        public int UniqueId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeUniqueId { get; set; }
        public string RuleType { get; set; }
        public Nullable<System.TimeSpan> FirstInTime { get; set; }
        public Nullable<System.TimeSpan> LastOutTime { get; set; }
        public Nullable<decimal> NetDuration { get; set; }
        public Nullable<int> NoOfPairedSwipes { get; set; }
        public Nullable<int> NoOfDiscardedSwipes { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}