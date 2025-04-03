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
    [Authorize(Roles = "1,2,3")]

    public class IndexModel : PageModel
    {
        private readonly IMedicineRepository _context;

        public IndexModel(IMedicineRepository context)
        {
            _context = context;
        }

        public IList<MedicineInformation> MedicineInformation { get;set; } = default!;
        public string SearchString { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;

        public int PageIndex { get; set; } = 1;
        public int TotalPages { get; set; }

        private const int PageSize = 3;

        public async Task OnGetAsync(string searchString, int pageIndex = 1)
        {
            SearchString = searchString;

            PageIndex = pageIndex;

            List<MedicineInformation> query = await _context.GetAllMedicinesAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                if (User.IsInRole("2") || User.IsInRole("3"))
                {
                    string normalizedSearchString = searchString.ToLower();
                    query = query.Where(m => m.MedicineName.ToLower().Contains(normalizedSearchString)).ToList();
                }
                else
                {
                    ErrorMessage = "You do not have permission to do this function!";
                }
            }

            int totalRecords = query.Count();
            TotalPages = (int)System.Math.Ceiling(totalRecords / (double)PageSize);

            MedicineInformation = query
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }

        public IActionResult OnPostCheckPermission()
        {
            if (!User.IsInRole("2"))
            {
                return Forbid();
            }

            return Page();
        }
    }
}
