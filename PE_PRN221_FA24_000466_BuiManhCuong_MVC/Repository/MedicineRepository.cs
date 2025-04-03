using Data;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MedicineRepository : IMedicineRepository
    {
        private readonly Sp25PharmaceuticalDbContext _context;

        public MedicineRepository(Sp25PharmaceuticalDbContext context)
        {
            _context = context;
        }

        public void AddMedicine(MedicineInformation medicine)
        {
            _context.MedicineInformations.Add(medicine);
            _context.SaveChanges();
        }

        public void UpdateMedicine(MedicineInformation medicine)
        {
            _context.MedicineInformations.Update(medicine);
            _context.SaveChanges();
        }

        public void DeleteMedicine(MedicineInformation medicine)
        {
            _context.MedicineInformations.Remove(medicine);
            _context.SaveChanges();
        }

        public async Task<MedicineInformation> GetMedicineById(string id)
        {
            return await _context.MedicineInformations
                .Include(m => m.Manufacturer)
                .FirstOrDefaultAsync(m => m.MedicineId == id);
        }

        public async Task<List<MedicineInformation>> GetAllMedicinesAsync()
        {
            return await _context.MedicineInformations
                .Include(m => m.Manufacturer)
                .OrderByDescending(m => m.MedicineId)
                .ToListAsync();
        }

        //public async Task<List<MedicineInformation>> GetAllMedicinesAsync()
        //{
        //    return await _context.MedicineInformations
        //        .Include(m => m.Manufacturer)
        //        .OrderByDescending(m => m.CreatedAt) 
        //        .ToListAsync();
        //}

        public async Task DeleteMedicineByIdAsync(string id)
        {
            var medicineTask = GetMedicineById(id); 
            var medicine = await medicineTask; 

            if (medicine != null)
            {
                await DeleteMedicineAsync(medicine);
            }
        }

        public async Task DeleteMedicineAsync(MedicineInformation medicine)
        {
            try
            {
                _context.MedicineInformations.Remove(medicine);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine($"Error deleting medicine: {ex.Message}");
                throw; 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error deleting medicine: {ex.Message}");
                throw;
            }
        }

        public async Task<List<MedicineInformation>> FindMedicinesAsync(string name)
        {
            return await _context.MedicineInformations.Where(m => m.MedicineName.Contains(name)).ToListAsync();
        }

        public async Task<List<MedicineInformation>> FindMedicinesAsync(MedicineSearchCriteria criteria)
        {
            IQueryable<MedicineInformation> query = _context.MedicineInformations;

            if (!string.IsNullOrEmpty(criteria.ActiveIngredients))
            {
                query = query.Where(m => m.ActiveIngredients.Contains(criteria.ActiveIngredients));
            }

            if (!string.IsNullOrEmpty(criteria.ExpirationDate))
            {
                query = query.Where(m => m.ExpirationDate.Contains(criteria.ExpirationDate));
            }

            if (!string.IsNullOrEmpty(criteria.WarningsAndPrecautions))
            {
                query = query.Where(m => m.WarningsAndPrecautions.Contains(criteria.WarningsAndPrecautions));
            }

            var filteredMedicines = await query.ToListAsync();

            var groupedResults = filteredMedicines
                .GroupBy(m => new { m.ActiveIngredients, m.ExpirationDate, m.WarningsAndPrecautions })
                .SelectMany(g => g)
                .ToList(); 

            return groupedResults;
        }

        public bool MedicineInformationExists(string id)
        {
            return _context.MedicineInformations.Any(e => e.MedicineId == id);
        }

        public async Task<List<MedicineInformation>> GetPagedMedicinesAsync(int pageNumber, int pageSize)
        {
            return await _context.MedicineInformations
                .Include(m => m.Manufacturer) 
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        public async Task<int> GetTotalMedicinesAsync()
        {
            return await _context.MedicineInformations.CountAsync();
        }

    }
}
