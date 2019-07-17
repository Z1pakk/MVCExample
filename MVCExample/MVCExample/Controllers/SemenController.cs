using MVCExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class SemenController : Controller
    {
        [HttpGet]
        // GET: Semen
        public ActionResult Index()
        {
            ViewBag.Semen = "Ivan";
            ViewData["Poncho"] = "Ponchik";

            Book book = new Book()
            {
                Author = "Semen",
                Id = 2,
                Name = "Книга про динозаврів",
                PageCount = 1000,
                Title = "Книга про динозаврів"
            };
            return View(book);
            //return Content("About");
            //return Json();

            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home");
            //return Redirect("https://google.com.ua");
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                var tempBook = book;
                return RedirectToAction("Index", "Home");
            }
            return View(book);
        }
    }
}