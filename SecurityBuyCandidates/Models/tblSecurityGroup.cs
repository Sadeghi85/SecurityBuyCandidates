//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SecurityBuyCandidates.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblSecurityGroup
    {
        public tblSecurityGroup()
        {
            this.tblSecurity = new HashSet<tblSecurity>();
        }
    
        public int SecurityGroupID { get; set; }
        public string SecurityGroupTitle { get; set; }
    
        public virtual ICollection<tblSecurity> tblSecurity { get; set; }
    }
}
