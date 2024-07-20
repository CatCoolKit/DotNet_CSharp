using AirConditionerShop.DAL.Entities;
using AirConditionerShop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.BLL.Services
{
    public class AirConService 
    {
        private readonly AirConRepository _airConRepository = new();

        public void Add(AirConditioner airConditioner)
        {
            _airConRepository.Add(airConditioner);
        }

        public void Update(AirConditioner airConditioner)
        {
            _airConRepository.Update(airConditioner);
        }

        public void Delete(AirConditioner airConditioner)
        {
            _airConRepository.Delete(airConditioner);
        }

        public IEnumerable<AirConditioner> GetAll()
        {
            return _airConRepository.GetAll();
        }

        public AirConditioner GetById(int id)
        {
            return _airConRepository.GetById(id);
        }

    }
}
