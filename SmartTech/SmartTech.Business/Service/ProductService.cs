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
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }
        public List<Product> GetMoreDiscountProducts(int count)
        {
            return _productRepository.OrderByDiscount(count);
        }

        public List<Product> GetNewProducts(int count)
        {
            return _productRepository.GetMany(p => p.IsNew == true).OrderByDescending(p => p.Discount).Take(count).ToList();
        }
    }
}
