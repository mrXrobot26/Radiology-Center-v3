//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Radiology_Center.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class super_admin
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string phone_number { get; set; }
        public string gender { get; set; }
        public string nationalID { get; set; }
        public string image { get; set; }
        public Nullable<int> user_id { get; set; }
    
        public virtual user_ user_ { get; set; }
    }
}
