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
    
    public partial class ORDER_INFO
    {
        public int IDAGENCY { get; set; }
        public int IDODER { get; set; }
        public Nullable<int> COUNT { get; set; }
        public Nullable<double> TOTAL_PRICE { get; set; }
    
        public virtual AGENCY AGENCY { get; set; }
        public virtual ORDER ORDER { get; set; }
    }
}
