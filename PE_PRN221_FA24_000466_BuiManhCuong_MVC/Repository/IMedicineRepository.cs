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
        Task DeleteMedicineByIdAsync(string id);
        Task<MedicineInformation> GetMedicineById(string id);
        Task<List<MedicineInformation>> FindMedicinesAsync(string name);
        Task<List<MedicineInformation>> FindMedicinesAsync(MedicineSearchCriteria criteria);
        Task<List<MedicineInformation>> GetAllMedicinesAsync();
        bool MedicineInformationExists(string id);
        Task<List<MedicineInformation>> GetPagedMedicinesAsync(int pageNumber, int pageSize);
        Task<int> GetTotalMedicinesAsync();
    }
}
