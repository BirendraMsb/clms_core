using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class SafetyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
