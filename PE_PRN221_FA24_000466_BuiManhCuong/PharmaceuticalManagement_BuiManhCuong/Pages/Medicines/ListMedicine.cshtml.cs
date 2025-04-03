using Data;
using DTO;
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
    public class ListMedicineModel : PageModel
    {
        private readonly IMedicineRepository _context;

        public int PageIndex { get; set; } = 1;
        public int TotalPages { get; set; }

        private const int PageSize = 3;

        public ListMedicineModel(IMedicineRepository context)
        {
            _context = context;
        }

        public string SearchString { get; set; } = string.Empty;

        public IList<MedicineInformation> MedicineInformation { get;set; } = default!;

        public async Task OnGetAsync(string searchString, int pageIndex = 1)
        {
            SearchString = searchString;

            PageIndex = pageIndex;

            List<MedicineInformation> query = await _context.GetAllMedicinesAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                string normalizedSearchString = searchString.ToLower();
                query = query.Where(m => m.MedicineName.ToLower().Contains(normalizedSearchString)).ToList();
            }

            int totalRecords = query.Count();
            TotalPages = (int)System.Math.Ceiling(totalRecords / (double)PageSize);

            MedicineInformation = query
                .Skip((PageIndex - 1) * PageSize)
                .Take(PageSize)
                .ToList();
        }
    }
}
