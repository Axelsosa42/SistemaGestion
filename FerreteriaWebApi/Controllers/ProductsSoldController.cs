using Microsoft.AspNetCore.Mvc;

namespace FerreteriaWebApi.Controllers
{
    public class ProductsSoldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
