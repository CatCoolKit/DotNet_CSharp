using AirConditionerShop.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditionerShop.DAL.Repositories
{
    public class BaseRepository<T> where T : class
    {
            protected AirConditionerShop2024DbContext _context;
            protected DbSet<T> _dbSet;

            public BaseRepository()
            {
                _context = new AirConditionerShop2024DbContext();
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

            public T GetById(int id)
            {
                return _dbSet.Find(id);
            }
        
    }
}
