using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class DeptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
