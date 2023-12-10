using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiology_Center.ViewModels
{
    internal class ReportVM
    {
        public string Title { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Note { get; set; }
    }
}
