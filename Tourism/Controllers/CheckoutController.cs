using Microsoft.AspNetCore.Mvc;

namespace Tourism.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
