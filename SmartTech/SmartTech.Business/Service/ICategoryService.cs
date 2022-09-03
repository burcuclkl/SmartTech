using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;

namespace SmartTech.Business.Service
{
   public interface ICategoryService
    {
        List<Category> GetCategories();

    }
}
