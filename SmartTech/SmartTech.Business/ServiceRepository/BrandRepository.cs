using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.Business.Repository;
using SmartTech.DataAccess;
using SmartTech.Business.Factory;

namespace SmartTech.Business.ServiceRepository
{
   public class BrandRepository : BaseRepository<Brand>,IBrandRepository
    {
        

        public BrandRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }


    }
}
