using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WeekDayFinder.Models;

namespace WeekDayFinder.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/categories")]
        public ActionResult Categories()
        {
            List<Category> allCategories = Category.GetAll();
            return View(allCategories);
        }

    }
}
