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
    
    public partial class TEPOHSNTaxCodeMapping
    {
        public int UniqueID { get; set; }
        public string ApplicableTo { get; set; }
        public string DestinationCountry { get; set; }
        public string VendorRegionCode { get; set; }
        public string VendorRegionDescription { get; set; }
        public string DeliveryPlantRegionCode { get; set; }
        public string DeliveryPlantRegionDescription { get; set; }
        public Nullable<int> GSTVendorClassification { get; set; }
        public string HSNCode { get; set; }
        public Nullable<int> MaterialGSTApplicability { get; set; }
        public Nullable<int> VendorGSTApplicability { get; set; }
        public Nullable<System.DateTime> ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public string TaxType { get; set; }
        public string TaxCode { get; set; }
        public Nullable<decimal> TaxRate { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedOn { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
    }
}
