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
    
    public partial class patient_data
    {
        public int id { get; set; }
        public string pay_status { get; set; }
        public Nullable<System.DateTime> daydate { get; set; }
        public Nullable<System.DateTime> deliverdate { get; set; }
        public byte[] doctor_report { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> ray_id { get; set; }
        public Nullable<int> patient_id { get; set; }
        public Nullable<int> assistant_id { get; set; }
        public Nullable<int> doctor_id { get; set; }
        public Nullable<int> dep_id { get; set; }
    
        public virtual assisatant assisatant { get; set; }
        public virtual department department { get; set; }
        public virtual doctor doctor { get; set; }
        public virtual patient_info patient_info { get; set; }
        public virtual ray ray { get; set; }
        public virtual user_ user_ { get; set; }
    }
}
