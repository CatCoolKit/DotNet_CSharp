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

        public MedicineInformation GetMedicineById(string id)
        {
            return _context.MedicineInformations
                .Include(m => m.Manufacturer)
                .FirstOrDefault(m => m.MedicineId == id);
        }

        public List<MedicineInformation> GetAllMedicines()
        {
            return _context.MedicineInformations.ToList();
        }

        public async Task<List<MedicineInformation>> GetAllMedicinesAsync()
        {
            return await _context.MedicineInformations
                .Include(m => m.Manufacturer)
                .OrderByDescending(m => m.MedicineId)
                .ToListAsync();
        }

        public void DeleteMedicineById(string id)
        {
            var medicine = GetMedicineById(id);
            if (medicine != null)
                DeleteMedicine(medicine);
        }

        public List<MedicineInformation> FindMedicines(string name)
        {
            return _context.MedicineInformations.Where(m => m.MedicineName.Contains(name)).ToList();
        }

        public bool MedicineInformationExists(string id)
        {
            return _context.MedicineInformations.Any(e => e.MedicineId == id);
        }
    }
}
