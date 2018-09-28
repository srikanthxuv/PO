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
    
    public partial class TECollection
    {
        public int CollectionsID { get; set; }
        public Nullable<int> ContextID { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> UnitID { get; set; }
        public string SAPCustomerID { get; set; }
        public string PaymentMode { get; set; }
        public string ReceiptID { get; set; }
        public string DraweeBank { get; set; }
        public string SAPBankCode { get; set; }
        public string InstrumentNumber { get; set; }
        public Nullable<System.DateTime> InstrumentDate { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.DateTime> ReceivedOn { get; set; }
        public Nullable<int> ReceivedBy { get; set; }
        public string PayeeBank { get; set; }
        public string PayeeName { get; set; }
        public string PaidBy { get; set; }
        public string ISTDS { get; set; }
        public Nullable<int> ReceiptDocumentID { get; set; }
        public Nullable<int> ClearedBy { get; set; }
        public Nullable<System.DateTime> ClearedOn { get; set; }
        public Nullable<System.DateTime> ReversedOn { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public Nullable<int> LastModifiedBy_Id { get; set; }
        public string OldUniqueID { get; set; }
        public string Status { get; set; }
        public string PANNo { get; set; }
        public string SAPOrderID { get; set; }
        public Nullable<decimal> UnAllocatedAmount { get; set; }
        public string CompanyPAN { get; set; }
        public Nullable<System.DateTime> RecordedOn { get; set; }
        public Nullable<bool> OTCFLAG { get; set; }
        public string OTCSTATUS { get; set; }
        public Nullable<int> OTCOfferId { get; set; }
        public Nullable<int> OTCLead { get; set; }
    }
}