using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radiology_Center.ViewModels
{
    internal class AnalysisVM
    {

        public object RayName { get; set; }
        public decimal Count { get; set; }


        public decimal TotalCost { get; set; }
        public DateTime? FirstDate { get; set; }

    }
}
