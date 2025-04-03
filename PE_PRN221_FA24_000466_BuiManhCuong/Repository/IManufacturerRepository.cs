using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IManufacturerRepository
    {
        void AddManufacturer(Manufacturer manufacturer);
        void UpdateManufacturer(Manufacturer manufacturer);
        void DeleteManufacturer(int manufacturerId);
        Manufacturer GetManufacturerById(int manufacturerId);
        List<Manufacturer> GetAllManufacturers();
    }
}
