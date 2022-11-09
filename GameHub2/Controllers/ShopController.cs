using GameHub2.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameHub2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Category(string Name)
        {
            // ensure some category name was passed to
            if (Name == null)
            {
                return RedirectToAction("Index");
            }

            // get the name param from url and store in view data object so we can display it
            ViewData["Category"] = Name;

            // use product model to create a list of products in memory for display
            var products = new List<Product>();

            // use a loop to make a list of products
            for (var i =1; i<6; i++)
            {
                products.Add(new Product {  ProductId = i, Name = "Product" + i.ToString(), Price = 10 + i });
            }

            return View();
        }
    }
}
