using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryBase<T> where T : class
    {
        protected AirConditionerShop2023DBContext _context;
        protected DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new AirConditionerShop2023DBContext();   
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            var TrackEntity = _dbSet.Attach(entity);
            TrackEntity.State = EntityState.Modified;
            _context.SaveChanges();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        public void DeleteAll()
        {
            _dbSet.RemoveRange(_dbSet);
            _context.SaveChanges();
        }

    }
}
