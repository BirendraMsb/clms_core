﻿using clms.Data;
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
            List<User> objUser = _db.Users.ToList();
            return View(objUser);
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
                return RedirectToAction("Index");
            }
           return View(obj);
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
