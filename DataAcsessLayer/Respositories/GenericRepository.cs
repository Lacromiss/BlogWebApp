using DataAcsessLayer.Abstract;
using DataAcsessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcsessLayer.Respositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Create(T entity)
        {
            using var _context = new AppDbContext();
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            using var _context = new AppDbContext();
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var _context = new AppDbContext();
            return _context.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            using var _context = new AppDbContext();
            return _context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            using var _context = new AppDbContext();
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
