﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace miguiadigital.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Inicio()
        {
            return View();
        }


        public ActionResult Contacto()
        {
            return View();
        }


    }
}
