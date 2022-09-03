using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;

namespace SmartTech.Business.Factory
{
    public interface IDbFactory
    {
        SmartTechEntities Create();


    }
}
