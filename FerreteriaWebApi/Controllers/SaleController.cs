using Microsoft.AspNetCore.Mvc;

namespace FerreteriaWebApi.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
