using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;
using SmartTech.Business.Factory;

namespace SmartTech.Business.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

       private IDbFactory _dbFactory;
       private SmartTechEntities _dbContext;

        public UnitOfWork (IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public void Commit()
        {
           _dbContext= _dbFactory.Create();
            _dbContext.SaveChanges();
        }
    }
}
