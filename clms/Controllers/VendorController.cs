using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class VendorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
