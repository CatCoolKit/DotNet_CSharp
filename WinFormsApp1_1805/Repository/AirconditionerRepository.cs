using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AirconditionerRepository : RepositoryBase<AirConditioner>, IAirconditioner
    {
        public AirConditioner GetById(int id)
        {
            // Sử dụng _dbSet và LINQ để tìm kiếm thực thể
            return _dbSet.FirstOrDefault(a => a.AirConditionerId == id);
        }
    }
}
