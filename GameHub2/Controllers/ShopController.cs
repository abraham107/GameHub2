using Microsoft.AspNetCore.Mvc;

namespace GameHub2.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
