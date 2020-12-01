using System.Collections.Generic;
using ContosoWeb.Models.ViewModels;

namespace ContosoWeb.Models.Services.Application
{
    public interface IProductService
    {
        List<ProductViewModel> GetProducts();
    }
}