using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository.Models
{
    public class NewListOut
    {
        public int AirConditionerId { get; set; }
        public string AirConditionerName { get; set; }
        public string Warranty { get; set; }
        public string SoundPressureLevel { get; set; }
        public string FeatureFunction { get; set; }
        public int? Quantity { get; set; }
        public double? DollarPrice { get; set; }
        public string SupplierId { get; set; }

        public string SupplierName { get; set; }

    }
}
