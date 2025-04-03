using Data;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalManagement_BuiManhCuong.Pages.Medicines
{
    [Authorize(Roles = "2")]
    public class CreateModel : PageModel
    {
        private readonly IMedicineRepository _context;
        private readonly IManufacturerRepository  manufacturerRepository;

        public CreateModel(IMedicineRepository context, IManufacturerRepository manufacturerRepository)
        {
            _context = context;
            this.manufacturerRepository = manufacturerRepository;
        }

        public IActionResult OnGet()
        {
        ViewData["ManufacturerId"] = new SelectList(manufacturerRepository.GetAllManufacturers(), "ManufacturerId", "ManufacturerName");
            return Page();
        }

        [BindProperty]
        public MedicineInformation MedicineInformation { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AddMedicine(MedicineInformation);

            return RedirectToPage("./Index");
        }
    }
}
