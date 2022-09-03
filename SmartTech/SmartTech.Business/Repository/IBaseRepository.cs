using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;
using System.Linq.Expressions;    

namespace SmartTech.Business.Repository
{
    public interface IBaseRepository<T> where T : class
    {


        T Add(T entity);

        bool Update(T entity);

        bool Delete(int id);

        bool Delete(T entity);

        T GetById(int id);

        List<T> GetAll();

        List<T> GetMany(Expression<Func<T,bool>>where);
        

    }
}
