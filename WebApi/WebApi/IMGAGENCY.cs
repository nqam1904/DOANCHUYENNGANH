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
    
    public partial class IMGAGENCY
    {
        public int IDIMG { get; set; }
        public string FILENAME { get; set; }
        public int IDAGENCY { get; set; }
    
        public virtual AGENCY AGENCY { get; set; }
    }
}
