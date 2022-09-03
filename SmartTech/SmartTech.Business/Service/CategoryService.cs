using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTech.DataAccess;
using SmartTech.Business.ServiceRepository;
using SmartTech.Business.UnitOfWork;

namespace SmartTech.Business.Service
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryRepository,IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }


        public List<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }
    }
}
