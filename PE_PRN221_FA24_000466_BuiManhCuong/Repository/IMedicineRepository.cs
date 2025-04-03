using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IMedicineRepository
    {
        void AddMedicine(MedicineInformation medicine);
        void UpdateMedicine(MedicineInformation medicine);
        void DeleteMedicine(MedicineInformation medicine);
        void DeleteMedicineById(string id);
        bool MedicineInformationExists(string id);
        MedicineInformation GetMedicineById(string id);
        List<MedicineInformation> GetAllMedicines();
        Task<List<MedicineInformation>> GetAllMedicinesAsync();
        List<MedicineInformation> FindMedicines(string name);
    }
}
