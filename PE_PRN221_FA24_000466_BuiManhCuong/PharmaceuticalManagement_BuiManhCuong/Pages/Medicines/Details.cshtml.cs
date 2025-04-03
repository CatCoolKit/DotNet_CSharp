using Data;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalManagement_BuiManhCuong.Pages.Medicines
{
    [Authorize(Roles = "2")]
    public class DetailsModel : PageModel
    {
        private readonly IMedicineRepository _context;

        public DetailsModel(IMedicineRepository context)
        {
            _context = context;
        }

        public MedicineInformation MedicineInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineinformation = _context.GetMedicineById(id);
            if (medicineinformation == null)
            {
                return NotFound();
            }
            else
            {
                MedicineInformation = medicineinformation;
            }
            return Page();
        }
    }
}
