using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartTech.UI.Models;
using SmartTech.Business.Service;
using SmartTech.DataAccess;
using SmartTech.UI.Models.Category;
using SmartTech.UI.Models.Brand;

namespace SmartTech.UI.Controllers
{
    public class AjaxController : BaseController
    {
        private ICategoryService _categoryService;
        private IBrandService _brandService;
        public AjaxController(ICategoryService categoryService, IBrandService brandService)
        {
            _categoryService = categoryService;
            _brandService = brandService;
        }

        [HttpPost]
        public JsonResult CategoryList()
        {
            List<Category> allCategories = _categoryService.GetCategories();
            List<CategoryListResponse> allResponse = new List<CategoryListResponse>();
            foreach (Category category in allCategories)
            {
                CategoryListResponse response = new CategoryListResponse();
                response.Id = category.Id;
                response.Name = category.Name;
                allResponse.Add(response);
            }

            return Json(allResponse);
        }

        [HttpPost]
        public JsonResult BrandList()
        {
            List<Brand> allBrands = _brandService.GetBrands();
            List<BrandListResponse> allResponse = new List<BrandListResponse>();
            foreach (Brand brand in allBrands)
            {
                BrandListResponse response = new BrandListResponse();
                response.Id = brand.Id;
                response.Name = brand.Name;
                allResponse.Add(response);
            }
            return Json(allResponse);
        }
    }
}