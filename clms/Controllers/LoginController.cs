using clms.DataAccess;
using clms_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
                _db = db;
        }
        //Get
        public IActionResult Index()
        {
           // List<User> userObj = _db.Users.ToList();
            return View();
        }

       [HttpPost]
        public IActionResult Index(User user)
        {
           
            if (user.Uid == "cc")
            {
               return RedirectToAction("Index", "Contractor");
            }
            else if (user.Uid=="vendor")
            {
                return RedirectToAction("Index", "Vendor");
            }
            else if(user.Uid=="gp")
            {
                return RedirectToAction("Index", "Gatepass");
            }
            else if(user.Uid== "safety")
            {
                return RedirectToAction("Index", "Safety");
            }
            
            return View(user);
               


        }

        public IActionResult Login() 
        {

            return View();
        }
    }
}
