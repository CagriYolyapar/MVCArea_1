﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCArea_1.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}