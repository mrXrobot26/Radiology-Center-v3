using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiology_Center.ViewModels
{
    internal class PatientVM
    {
        public int Id { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }


    }
}
