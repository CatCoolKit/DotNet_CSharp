using Data;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalManagement_BuiManhCuong.Pages.Medicines
{
    [Authorize(Roles = "2")]
    public class EditModel : PageModel
    {
        private readonly IMedicineRepository _context;
        private readonly IManufacturerRepository manufacturerRepository;

        public EditModel(IMedicineRepository context, IManufacturerRepository manufacturerRepository)
        {
            _context = context;
            this.manufacturerRepository = manufacturerRepository;
        }

        [BindProperty]
        public MedicineInformation MedicineInformation { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineinformation =  _context.GetMedicineById(id);
            if (medicineinformation == null)
            {
                return NotFound();
            }
            MedicineInformation = medicineinformation;
           ViewData["ManufacturerId"] = new SelectList(manufacturerRepository.GetAllManufacturers(), "ManufacturerId", "ManufacturerName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.UpdateMedicine(MedicineInformation);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicineInformationExists(MedicineInformation.MedicineId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MedicineInformationExists(string id)
        {
            return _context.MedicineInformationExists(id);
        }
    }
}
