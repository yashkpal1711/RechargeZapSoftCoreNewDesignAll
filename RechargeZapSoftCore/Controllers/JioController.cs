using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RechargeZapSoftCore.Controllers
{
    public class JioController : Controller
    {
        // GET: Jio
       

        // GET: Jio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Jio/Create
        public ActionResult Create()
        {
            return View();
        }
        public IActionResult Jio()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png""  />
                        </a>";
            return View();
        }

        // POST: Jio/Create
       

        // GET: Jio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

      

        // GET: Jio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    
    }
}