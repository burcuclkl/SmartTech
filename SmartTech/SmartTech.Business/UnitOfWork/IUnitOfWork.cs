using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTech.Business.UnitOfWork
{
    public interface IUnitOfWork
    {

        void Commit();
    }
}
