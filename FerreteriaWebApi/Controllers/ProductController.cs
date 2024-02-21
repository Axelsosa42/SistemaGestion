using Microsoft.AspNetCore.Mvc;

namespace FerreteriaWebApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
