using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;
using SmartTech.Business.Factory;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Runtime.InteropServices;

namespace SmartTech.Business.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private IDbFactory _dbFactory;
        public SmartTechEntities _dbContext;
        private IDbSet<T> _dbSet;

        public BaseRepository(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
            _dbContext = _dbFactory.Create();
            _dbSet = _dbContext.Set<T>();
        }



        public T Add(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public bool Delete(int id)
        {
            T entity = this.GetById(id);
            _dbSet.Remove(entity);
            return true;
        }

        public bool Delete(T entity)
        {
            _dbSet.Remove(entity);
            return true;
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public bool Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return true;
        }
    }
}
