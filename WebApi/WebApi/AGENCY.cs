//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class AGENCY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENCY()
        {
            this.AGENCY_SURVICES = new HashSet<AGENCY_SURVICES>();
            this.COMMENTs = new HashSet<COMMENT>();
            this.ORDER_INFO = new HashSet<ORDER_INFO>();
            this.PEOPLE_AGENCY = new HashSet<PEOPLE_AGENCY>();
            this.AGENCY_SOCIAL = new HashSet<AGENCY_SOCIAL>();
            this.IMGAGENCies = new HashSet<IMGAGENCY>();
            this.CATEGORies = new HashSet<CATEGORY>();
        }
    
        public int IDAGENCY { get; set; }
        public string NAMEAGENCY { get; set; }
        public string PHONEAGENCY { get; set; }
        public string ADDRESSAGENCY { get; set; }
        public string EMAILAGENCY { get; set; }
        public string SUMARYAGENCY { get; set; }
        public string DESCRIPTION { get; set; }
        public Nullable<int> IDSOCIAL { get; set; }
        public Nullable<bool> STATUS { get; set; }
        public int IDUSER { get; set; }
        public int IDCATE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENCY_SURVICES> AGENCY_SURVICES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_INFO> ORDER_INFO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEOPLE_AGENCY> PEOPLE_AGENCY { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENCY_SOCIAL> AGENCY_SOCIAL { get; set; }
        public virtual USER USER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IMGAGENCY> IMGAGENCies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CATEGORY> CATEGORies { get; set; }
    }
}