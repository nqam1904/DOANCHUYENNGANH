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
    
    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORDER()
        {
            this.ORDER_INFO = new HashSet<ORDER_INFO>();
        }
    
        public int IDODER { get; set; }
        public Nullable<int> IDAGENCY { get; set; }
        public Nullable<int> IDCUSTOMER { get; set; }
        public string NOTE { get; set; }
        public Nullable<System.DateTime> CREATE_ORDER { get; set; }
        public Nullable<bool> STATUS { get; set; }
    
        public virtual AGENCY AGENCY { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORDER_INFO> ORDER_INFO { get; set; }
    }
}
