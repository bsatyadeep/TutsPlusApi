using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TutsPlusApi.StatsDemo1.DataAccess.Entities;

namespace TutsPlusApi.StatsDemo1.DataAccess.Repository
{
    public class Repository<T>:IRepository<T> where T:EntityBase
    {
        private readonly StatsDbContext _context;

        public Repository(StatsDbContext context)
        {
            _context = context;
        }
        public List<T> get()
        {
            return _context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            //return _context.Set<T>().FirstOrDefault(arg => arg.Id == id);
            return _context.Set<T>().Find(id);
        }

        public T Update(T obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
            return obj;
        }

        public T Inset(T obj)
        {
            _context.Entry(obj).State = EntityState.Added;
            _context.SaveChanges();
            return obj;
            //_context.Set<T>().Add(obj);
            //_context.SaveChanges();
            //return obj;
        }

        public int Delete(T obj)
        {
            _context.Entry(obj).State = EntityState.Deleted;
            _context.SaveChanges();
            return obj.Id;

            //_context.Set<T>().Remove(obj);
            //_context.SaveChanges();
            //return obj.Id;
        }
    }
}