//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPCRental_Upstairs.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROPERTY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROPERTY()
        {
            this.PROPERTY_FEATURE = new HashSet<PROPERTY_FEATURE>();
        }
    
        public int ID { get; set; }
        public string PropertyName { get; set; }
        public string Avatar { get; set; }
        public string Images { get; set; }
        public Nullable<int> PropertyType_ID { get; set; }
        public string Content { get; set; }
        public Nullable<int> Street_ID { get; set; }
        public Nullable<int> Ward_ID { get; set; }
        public Nullable<int> District_ID { get; set; }
        public Nullable<int> Price { get; set; }
        public string UnitPrice { get; set; }
        public string Area { get; set; }
        public Nullable<int> BedRoom { get; set; }
        public Nullable<int> BathRoom { get; set; }
        public Nullable<int> PackingPlace { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public Nullable<System.DateTime> Create_post { get; set; }
        public Nullable<int> Status_ID { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
        public Nullable<int> Sale_ID { get; set; }
    
        public virtual DISTRICT DISTRICT { get; set; }
        public virtual PROJECT_STATUS PROJECT_STATUS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPERTY_FEATURE> PROPERTY_FEATURE { get; set; }
        public virtual PROPERTY_TYPE PROPERTY_TYPE { get; set; }
        public virtual STREET STREET { get; set; }
        public virtual USER USER { get; set; }
        public virtual USER USER1 { get; set; }
        public virtual WARD WARD { get; set; }
    }
}
