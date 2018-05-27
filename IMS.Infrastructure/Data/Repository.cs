using IMS.Core.Interfaces;
using IMS.Core.SharedKernel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace IMS.Infrastructure.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IMSContext _context;

        public Repository(IMSContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
            return _context.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> List()
        {
            return _context.Set<T>().ToList();
        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
