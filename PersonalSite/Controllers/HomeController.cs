﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.Title = "Home.cs";
            return View();
        }

        public ViewResult Bio()
        {
            ViewBag.Title = "Bio.txt";
            return View();
        }

    }
}