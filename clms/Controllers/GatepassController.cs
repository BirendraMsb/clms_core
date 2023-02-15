using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class GatepassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
