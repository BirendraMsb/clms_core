using clms.Data;
using clms.Models;
using Microsoft.AspNetCore.Mvc;

namespace clms.Controllers
{
    public class UserController : Controller
    {
       
        private readonly ApplicationDbContext _db;

        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<User> objUser = _db.Users.ToList();
            return View();
        }

        //Get
        public IActionResult Create()
        {
            return View();
        }

        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User obj)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(obj);
                _db.SaveChanges();

            }
            return View();
        }

        //Get
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var userFromDb = _db.Users.Find(id);

            if (userFromDb == null)
            {
                return NotFound();
            }

            return View(userFromDb);

        }

        ////post
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(User obj)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _db.Users.Add(obj);
        //        _db.SaveChanges();

        //    }
        //    return View();
        //}

    }
}
