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
    
    public partial class TEChangeOrder
    {
        public int ChangeOrderID { get; set; }
        public Nullable<int> CurrentOfferId { get; set; }
        public Nullable<int> NewOfferID { get; set; }
        public string Status { get; set; }
        public string DocumentID { get; set; }
        public Nullable<System.DateTime> TermSheetDate { get; set; }
        public Nullable<System.DateTime> ChangeOrderPreparedOn { get; set; }
        public Nullable<int> ChangeOrderPreparedBy { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public Nullable<int> LastModifiedBy_Id { get; set; }
        public string OldUniqueID { get; set; }
        public string SAPCustomerID { get; set; }
    
        public virtual TEOffer TEOffer { get; set; }
    }
}
