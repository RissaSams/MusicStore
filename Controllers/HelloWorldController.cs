using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MusicStore.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Marissa Dorman";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public IActionResult WhiteRabbit()
        {
            ViewBag.Name = "Marissa Dorman";
            ViewBag.Date = DateTime.Now;
            return View();
        }

        public string Hello()
        {
            return "People...the Techonology has you..";
        }

        public string GoodBye()
        {
            return "See ya, later!";
        }

        public string Exit()
        {
            return "This is the end!";
        }
    }
}