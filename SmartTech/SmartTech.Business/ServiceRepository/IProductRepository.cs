using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.Business.Repository;
using SmartTech.DataAccess;

namespace SmartTech.Business.ServiceRepository
{
   public interface IProductRepository : IBaseRepository<Product>
    {
        List<Product> OrderByDiscount(int takeCount);

        
    }
}
