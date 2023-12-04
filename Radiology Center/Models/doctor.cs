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
    
    public partial class doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public doctor()
        {
            this.patient_data = new HashSet<patient_data>();
        }
    
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string phone_number { get; set; }
        public string gender { get; set; }
        public Nullable<int> user_id { get; set; }
        public Nullable<int> dep_id { get; set; }
        public string image { get; set; }
    
        public virtual department department { get; set; }
        public virtual user_ user_ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient_data> patient_data { get; set; }
    }
}
