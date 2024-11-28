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

        [HttpGet]
        public IActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Product (Product product)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Product");
            }

            return View(product);
        }
        public IActionResult Index()
        {
            return View(products); 
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Product newProduct)
        {
            if (ModelState.IsValid)
            {
                newProduct.Id = products.Max(p => p.Id) + 1;
                products.Add(newProduct);
                return RedirectToAction("Index");   
            }
            return View(newProduct);
        }
    }
}
