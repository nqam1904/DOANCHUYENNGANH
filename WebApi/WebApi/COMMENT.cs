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
    
    public partial class COMMENT
    {
        public int idCOMNENT { get; set; }
        public string DESCRIPTION { get; set; }
        public int IDAGENCY { get; set; }
        public int IDCUSTOMER { get; set; }
        public Nullable<bool> COMMENTSTATUS { get; set; }
    
        public virtual AGENCY AGENCY { get; set; }
        public virtual CUSTOMER CUSTOMER { get; set; }
    }
}