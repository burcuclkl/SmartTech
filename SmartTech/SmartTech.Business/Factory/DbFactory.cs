using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;

namespace SmartTech.Business.Factory
{
    public class DbFactory : IDisposable, IDbFactory
    {
        SmartTechEntities _dbContext;

        public SmartTechEntities Create()
        {
            return _dbContext ?? (_dbContext = new SmartTechEntities());
           
        }

        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }
    }
}
