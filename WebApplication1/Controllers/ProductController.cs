using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Product; // Ensure this matches your actual namespace

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Apple",
                Description = "Smartphone designed by Apple.",
                Price = 1299
            },

            new Product
            {
                Id = 2,
                Name = "Samsung",
                Description = "Smartphone designed by Samsung.",
                Price = 899
            },


            new Product
            {
                Id = 2,
                Name = "Huawei",
                Description = "Smartphone designed by Huawei.",
                Price = 799
            },



            new Product
            {
                Id = 2,
                Name = "Xiaomi",
                Description = "Smartphone designed by Xiaomi.",
                Price = 699
            }


        };

        public IActionResult Index()
        {
            return View(products); 
        }
    }
}
