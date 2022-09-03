using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartTech.Business.Service;
using SmartTech.DataAccess;
namespace SmartTech.UI.Controllers
{
    public class DefaultController : BaseController
    {
        private IProductService _productService;
        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            ViewBag.MoreDiscountProducts = _productService.GetMoreDiscountProducts(20);
            ViewBag.NewProducts = _productService.GetNewProducts(10);
            return View();
        }


        public ActionResult Error()
        {
            return View();
        }
    }
}