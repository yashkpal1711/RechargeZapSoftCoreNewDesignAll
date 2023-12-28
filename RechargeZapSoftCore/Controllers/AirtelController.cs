using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RechargeZapSoftCore.Controllers
{
    public class AirtelController : Controller
    {
      
        public ActionResult Airtel()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            return View();
        }

        // GET: Airtel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Airtel/Create
        public ActionResult Create()
        {
            return View();
        }

        

        // GET: Airtel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        

        // GET: Airtel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

       
    }
}