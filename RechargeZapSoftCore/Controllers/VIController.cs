using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RechargeZapSoftCore.Controllers
{
    public class VIController : Controller
    {
      
        public ActionResult VI()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            return View();
        }
        // GET: VI/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VI/Create
        public ActionResult Create()
        {
            return View();
        }

        

        // GET: VI/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        
        // GET: VI/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VI/Delete/5
       
    }
}