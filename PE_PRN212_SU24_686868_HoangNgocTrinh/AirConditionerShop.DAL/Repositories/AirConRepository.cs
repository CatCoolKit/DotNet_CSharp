using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class AirConRepository : BaseRepository<AirConditioner>
    {
        public List<AirConditioner> GetAll()
        {
            return [.. _context.AirConditioners.Include(x => x.Supplier)];
        }
    }
}
