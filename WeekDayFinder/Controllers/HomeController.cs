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

        [HttpPost("/dayofweek")]
        public ActionResult DayOfWeek()
        {
          FindDay newDate = new FindDay((int.Parse(Request.Form["year"])), (int.Parse(Request.Form["month"])), (int.Parse(Request.Form["day"])));
          string dayFound = newDate.DateTime();
          return View("DayOfWeek", dayFound);
        }
    }
}
