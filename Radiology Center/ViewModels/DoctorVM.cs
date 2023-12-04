using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiology_Center.ViewModels
{
    internal class DoctorVM
    {
        public int Id { get; set; }
        public string DoctorFullName { get; set; }

        public decimal Salary { get; set; }
        public DateTime? BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string depNeme { get; set; }
    }
}
