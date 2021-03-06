﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStandardValidation.Models;

namespace MvcStandardValidation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(HomeDataModel model)
        {
            if (ModelState.IsValid)
            {
                
                return this.RedirectToAction("Index");
            }

            return View("Index", model);
        }

        public ActionResult Test()
        {
            return View();
        }



    }
}
