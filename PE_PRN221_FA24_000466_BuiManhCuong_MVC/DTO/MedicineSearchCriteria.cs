using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MedicineSearchCriteria
    {
        public string? ActiveIngredients { get; set; }
        public string? ExpirationDate { get; set; }
        public string? WarningsAndPrecautions { get; set; }
    }
}
