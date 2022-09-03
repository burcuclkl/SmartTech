using SmartTech.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.Business.ServiceRepository;
using SmartTech.Business.Repository;
using SmartTech.Business.UnitOfWork;

namespace SmartTech.Business.Service
{
    public class BrandService : IBrandService
    {
        private IBrandRepository _brandRepository;
        private IUnitOfWork _unitOfWork;

        public BrandService (IBrandRepository brandRepository,IUnitOfWork unitOfWork)
        {
            _brandRepository = brandRepository;
            _unitOfWork = unitOfWork;
        }

        public List<Brand> GetBrands()
        {
            return _brandRepository.GetAll();
        }
    }
}
