using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RechargeZapSoftCore.Controllers
{
    public class DTHController : Controller
    {
        public IActionResult DTH()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png""  />
                        </a>";
            return View();
        }
    }
}