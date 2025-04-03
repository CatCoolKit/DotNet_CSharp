using Data;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ManufacturerRepository : IManufacturerRepository
    {
        private readonly Sp25PharmaceuticalDbContext _context;

        public ManufacturerRepository(Sp25PharmaceuticalDbContext context)
        {
            _context = context;
        }

        public void AddManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Add(manufacturer);
            _context.SaveChanges();
        }

        public void UpdateManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Update(manufacturer);
            _context.SaveChanges();
        }

        public void DeleteManufacturer(Manufacturer manufacturer)
        {
            _context.Manufacturers.Remove(manufacturer);
            _context.SaveChanges();
        }

        public Manufacturer GetManufacturerById(int id)
        {
            return _context.Manufacturers.Find(id);
        }

        public List<Manufacturer> GetAllManufacturers()
        {
            return _context.Manufacturers.ToList();
        }

        public void DeleteManufacturer(int manufacturerId)
        {
            var manufacturer = _context.Manufacturers.Find(manufacturerId);

            if (manufacturer != null)
            {
                _context.Manufacturers.Remove(manufacturer);
                _context.SaveChanges();
            }
        }
    }
}
