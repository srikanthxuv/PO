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
    
    public partial class TESiteVisit
    {
        public int TEId { get; set; }
        public int TEContactid { get; set; }
        public int TELeadid { get; set; }
        public int TEOfferid { get; set; }
        public int TETaskId { get; set; }
        public string SiteVisitType { get; set; }
        public string SiteLocation { get; set; }
        public bool IsPickup { get; set; }
        public string PickupAddress { get; set; }
        public int Durations { get; set; }
        public int FacilitatorID { get; set; }
    }
}