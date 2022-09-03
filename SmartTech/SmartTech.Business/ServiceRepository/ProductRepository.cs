using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.Business.Factory;
using SmartTech.Business.Repository;
using SmartTech.DataAccess;

namespace SmartTech.Business.ServiceRepository
{
   public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public List<Product> OrderByDiscount(int takeCount)
        {
            return _dbContext.Product.OrderByDescending(p => p.Discount).Take(takeCount).ToList();
        }
    }
}
