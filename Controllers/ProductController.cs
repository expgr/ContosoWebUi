using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ContosoWeb.Models.ViewModels;
using ContosoWeb.Models.Services.Application;

namespace ContosoWeb
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            List<ProductViewModel> products = productService.GetProducts();
            return View(products);
        }
    }
}