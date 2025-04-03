using Data;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using PharmaceuticalManagement_BuiManhCuong.Hubs;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmaceuticalManagement_BuiManhCuong.Pages.Medicines
{
    [Authorize(Roles = "2")]
    public class DeleteModel : PageModel
    {
        private readonly IMedicineRepository _context;
        private readonly IHubContext<MedicineHub> _hubContext;

        public DeleteModel(IMedicineRepository context, IHubContext<MedicineHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medicineinformation = _context.GetMedicineById(id);
            if (medicineinformation != null)
            {
                MedicineInformation = medicineinformation;
                _context.DeleteMedicine(MedicineInformation);
            }

            await _hubContext.Clients.All.SendAsync("ReceiveMedicineDelete");

            return RedirectToPage("./Index");
        }
    }
}
