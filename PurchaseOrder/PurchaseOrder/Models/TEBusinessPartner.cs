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
    
    public partial class TEBusinessPartner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEBusinessPartner()
        {
            this.TEBusinessPartnerBrokerFees = new HashSet<TEBusinessPartnerBrokerFee>();
            this.TEBusinessPartnersRepresentatives = new HashSet<TEBusinessPartnersRepresentative>();
        }
    
        public int BusinessPartnerID { get; set; }
        public Nullable<int> PartnerCompanyContactID { get; set; }
        public string PAN { get; set; }
        public string ServiceRegistrationNo { get; set; }
        public string VAT { get; set; }
        public string PartnerShipLevel { get; set; }
        public string City { get; set; }
        public Nullable<int> PartnerConsultantID { get; set; }
        public Nullable<int> PartnerHeadID { get; set; }
        public Nullable<System.DateTime> AgreementStartDate { get; set; }
        public Nullable<System.DateTime> AgreementEndDate { get; set; }
        public string SAPVendorID { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifiedBy_Id { get; set; }
        public string OldUniqueID { get; set; }
        public string CompanyLogoPath { get; set; }
        public Nullable<int> PartnerType { get; set; }
        public string Status { get; set; }
        public string GSTClassification { get; set; }
        public string GSTIN { get; set; }
        public string ClientCategory { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEBusinessPartnerBrokerFee> TEBusinessPartnerBrokerFees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TEBusinessPartnersRepresentative> TEBusinessPartnersRepresentatives { get; set; }
    }
}