using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using paytm;
using RechargeZapSoftCore.Models;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using System.IO;
using System.Net.Http;
using RestSharp;

namespace RechargeZapSoftCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }


            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Recharge()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult GiftCard()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            gettoken();


            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getGiftCardbrandCarousel1();
            ViewBag.Carousel1 = dt;

            DataTable dt2 = new DataTable();
            dt2 = objoperator.getGiftCardbrandCarousel2();
            ViewBag.Carousel2 = dt2;

            DataTable dt3 = new DataTable();
            dt3 = objoperator.getGiftCardbrandCarousel3();
            ViewBag.Carousel3 = dt3;


            DataTable dt4 = new DataTable();
            dt4 = objoperator.getGiftCardbrandCarousel4();
            ViewBag.Carousel4 = dt4;

            return View();
        }

        public ActionResult GiftCardDetail()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            DataTable dttoken = gettoken();

            if (dttoken.Rows.Count > 0)
            {
                string brandcode = HttpContext.Request.Query["bid"].ToString();
                clsOperator objoperator = new clsOperator();
                //DataSet dsdetail = objoperator.getgiftCardDetail(brandcode, dttoken.Rows[0]["GiftCardToken"].ToString());
                DataTable dsdetail = objoperator.getgiftCardDetailFromDataBase(brandcode);
                if (dsdetail.Rows.Count > 0)
                {
                    ViewBag.str_brandproductcode = dsdetail.Rows[0]["BrandProductCode"].ToString();
                    ViewBag.str_brandtype = dsdetail.Rows[0]["brandtype"].ToString();
                    ViewBag.str_brandname = dsdetail.Rows[0]["BrandName"].ToString();
                    ViewBag.str_brandimage = @"<img src=""" + dsdetail.Rows[0]["BrandImage"].ToString() + @""" alt=""product_image"" style=""width:90%;"" />";
                    ViewBag.str_brandimage2 = dsdetail.Rows[0]["BrandImage"].ToString();
                    ViewBag.str_denomination = dsdetail.Rows[0]["denominationList"].ToString();

                    DataTable dtdenomination = new DataTable();
                    dtdenomination.Columns.Add(new DataColumn("denomid", typeof(string)));
                    dtdenomination.Columns.Add(new DataColumn("denomination", typeof(string)));
                    if (dsdetail.Rows[0]["denominationList"].ToString().Length > 0)
                    {
                        int i = 1;
                        foreach (string str in dsdetail.Rows[0]["denominationList"].ToString().Split(','))
                        {
                            dtdenomination.Rows.Add("spandenom" + str, str);
                            i++;
                        }
                    }
                    ViewBag.DenominationTable = dtdenomination;
                    ViewBag.str_description = dsdetail.Rows[0]["Descriptions"].ToString();
                    ViewBag.str_tnc = dsdetail.Rows[0]["tnc"].ToString();
                    ViewBag.str_importantInstruction = dsdetail.Rows[0]["tnc"].ToString();
                    ViewBag.str_RedeemSteps = dsdetail.Rows[0]["tnc"].ToString();


                    DataTable dtdiscount = new DataTable();
                    dtdiscount = objoperator.getGiftcardDiscount(dsdetail.Rows[0]["BrandProductCode"].ToString());
                    if (dtdiscount.Rows.Count > 0)
                    {
                        ViewBag.str_Discount = dtdiscount.Rows[0]["discount"].ToString();
                    }
                    else
                    {
                        ViewBag.str_Discount = "0";
                    }

                }

            }
            //List<clsCart> data = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");

            return View();
        }
        public ActionResult BrandList()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            DataTable dttoken = gettoken();

            if (dttoken.Rows.Count > 0)
            {
                string categoryid = HttpContext.Request.Query["cid"].ToString();
                ViewBag.CategoryName = HttpContext.Request.Query["cname"].ToString();
                clsOperator objoperator = new clsOperator();
                //DataSet dsdetail = objoperator.getgiftCardDetail(brandcode, dttoken.Rows[0]["GiftCardToken"].ToString());
                DataTable dsdetail = objoperator.getTopGiftCardbrandByCategoryId(categoryid);
                ViewBag.BrandList = dsdetail;

            }
            //List<clsCart> data = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");

            return View();
        }


        //===================== payment gateway hit code==================

        [HttpPost]
        public ActionResult PurchaseGiftCard(clsRecharge objrecharge2)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">

                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>

                </ul>";
            }

            //clsCart objcart = new clsCart();


            List<clsCart> data = new List<clsCart>();

            //for (int i = 1; i < 10; i++)
            //{

            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");


            DataTable dtcart = new DataTable();
            dtcart.Columns.Add(new DataColumn("BrandProductCode", typeof(string)));
            dtcart.Columns.Add(new DataColumn("Denomnation", typeof(string)));
            dtcart.Columns.Add(new DataColumn("Quantity", typeof(string)));

            foreach (clsCart cartsession in cartdata)
            {
                //clsCart obj2 = new clsCart
                //{
                //    Id = cartsession.Id,
                //    BrandProductCode = cartsession.BrandProductCode,
                //    BrandName = cartsession.BrandName,
                //    Denomnation = cartsession.Denomnation,
                //    Quantity = cartsession.Quantity,
                //    Discount = cartsession.Discount,
                //    BrandImage = cartsession.BrandImage,
                //    VoucherType = cartsession.VoucherType
                //};
                //data.Add(obj2);

                dtcart.Rows.Add(cartsession.BrandProductCode, cartsession.Denomnation, cartsession.Quantity);

            }


            HttpContext.Session.SetComplexData("loggerUser", null);

            clsRecharge objrecharge = new clsRecharge();

            if (dtcart.Rows.Count > 0)
            {


                if (str_loginemail != null)
                {
                    objrecharge.LoginEmail = str_loginemail;
                }
                else
                {
                    objrecharge.LoginEmail = "";
                }

                objrecharge.UserMobile = objrecharge2.UserMobile;

                objrecharge.Email = objrecharge2.Email;
                objrecharge.UserName = objrecharge2.UserName;

                if (objrecharge.UserMobile.Length == 10)
                {
                    if (ValidateEmail(objrecharge.Email) == true)
                    {
                        string txnid = Generatetxnid();

                        string orderid = txnid;

                        objrecharge.ReferenceId = orderid;

                        objrecharge.MentionBy = "Online";

                        objrecharge.dtData = dtcart;
                        objrecharge.UsedBalance = Convert.ToDecimal(objrecharge2.UsedBalance);

                        objrecharge.GiftTo = objrecharge2.GiftTo;
                        objrecharge.Message = objrecharge2.Message;
                        objrecharge.OtherName = objrecharge2.OtherName;
                        objrecharge.OtherMobile = objrecharge2.OtherMobile;
                        objrecharge.OtherEmail = objrecharge2.OtherEmail;

                        string Ip = HttpContext.Connection.RemoteIpAddress?.ToString();
                        objrecharge.IPAddress = Ip;
                        DataTable dt = new DataTable();
                        dt = objrecharge.GiftCardInitiate(objrecharge);

                        string resdt = dt.Rows[0][0].ToString();
                        //string resmsg = dt.Rows[0]["msg"].ToString();

                        if (dt.Rows[0][0].ToString() == "t")
                        {

                            decimal dcPaymentGatewayAMount = Convert.ToDecimal(dt.Rows[0]["paymentgatewayfinalamount"].ToString());

                            if (dcPaymentGatewayAMount > 0)
                            {
                                //decimal amount = objrecharge.RechargeAmount;
                                decimal amount = dcPaymentGatewayAMount;

                                // amount = 1.00M;

                                ////======= test url============
                                //var baseURL = "https://test.payu.in/";

                                //============= live url=============
                                var baseURL = "https://secure.payu.in/";
                                var firstName = objrecharge.UserName;
                                //var amount = objrecharge.RechargeAmount;
                                var productInfo = "Online Recharge";
                                var email = objrecharge.Email;
                                var phone = objrecharge.UserMobile;
                                //=========== test details==========
                                //var key = "oZ7oo9";
                                //var salt = "UkojH5TS";
                                //=======live details================
                                var key = "sqyp9U";
                                var salt = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI";




                                Dictionary<String, String> paymentParams = new Dictionary<String, String>();
                                /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */


                                //var myremotepost = new RemotePost { Url = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment" };
                                paymentParams.Add("key", key);
                                paymentParams.Add("txnid", txnid);
                                paymentParams.Add("amount", amount.ToString());
                                paymentParams.Add("productinfo", productInfo);
                                paymentParams.Add("firstname", firstName);
                                paymentParams.Add("phone", phone);
                                paymentParams.Add("email", email);
                                //paymentParams.Add("surl", "https://localhost:44399/Home/PayUMoneySuccessGiftcard");
                                //paymentParams.Add("furl", "https://localhost:44399/Home/PayUMoneyFailedGiftcard");

                                paymentParams.Add("surl", "https://new.rechargezap.in/Home/PayUMoneySuccessGiftcard");
                                paymentParams.Add("furl", "https://new.rechargezap.in/Home/PayUMoneyFailedGiftcard");
                                //paymentParams.Add("furl", "https://new.rechargezap.in/Home/PayUMoneySuccessGiftcard");
                                paymentParams.Add("service_provider", "payu_paisa");

                                //string hashString = key + "|" + Generatetxnid() + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
                                string hashString = key + "|" + txnid + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
                                //string hashString = "3Q5c3q|2590640|3053.00|OnlineBooking|vimallad|ladvimal@gmail.com|||||||||||mE2RxRwx";
                                string hash = Generatehash512(hashString);
                                paymentParams.Add("hash", hash);

                                /* Prepare HTML Form and Submit to Paytm */
                                String outputHtml = "";
                                outputHtml += "<html>";
                                outputHtml += "<head>";
                                //outputHtml += "<title></title>";
                                outputHtml += "</head>";
                                outputHtml += "<body <body onload=\"document.form1.submit()\">";
                                outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
                                outputHtml += "<form method='post' action='" + baseURL + "_payment' name='form1'>";
                                foreach (string key2 in paymentParams.Keys)
                                {
                                    outputHtml += "<input type='hidden' name='" + key2 + "' value='" + paymentParams[key2] + "'>";
                                }
                                outputHtml += "";
                                outputHtml += "</form>";
                                //outputHtml += "<script type='text/javascript'>";
                                //outputHtml += "document.payu_form.submit();";
                                //outputHtml += "</script>";
                                outputHtml += "</body>";
                                outputHtml += "</html>";
                                ViewBag.list = outputHtml;
                                return View("Payment");




                            }
                            else
                            {


                                string str_orderid = orderid;
                                string str_status = "success";

                                try
                                {
                                    DataTable dtvoucherdata = new DataTable();
                                    dtvoucherdata.Columns.Add(new DataColumn("BrandName", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("BrandImage", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("Status", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("Amount", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("Expiry", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("VoucherGCcode", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("VoucherGuid", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("VoucherNo", typeof(string)));
                                    dtvoucherdata.Columns.Add(new DataColumn("Voucherpin", typeof(string)));

                                    const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";


                                    ViewBag.OrderId = str_orderid;


                                    //str_status = "success";

                                    objrecharge.ReferenceId = str_orderid;
                                    objrecharge.Status = str_status;
                                    objrecharge.Message = "PaidFromWallet";
                                    objrecharge.PaymentGatewayResponse = "";

                                    DataTable dtupdate = new DataTable();
                                    dtupdate = objrecharge.UpdateGiftCardInitiate(objrecharge);
                                    ViewBag.PaymentGayewayResponse = "";
                                    ViewBag.PaymentStatus = str_status;
                                    ViewBag.ActionName = "SuccessAction";
                                    ViewBag.OrderTime = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                                    string str_email = "";
                                    string res = "";



                                    string str_token = "";
                                    res = dtupdate.Rows[0][0].ToString();
                                    DataTable dttoken = gettoken();
                                    if (dttoken.Rows.Count > 0)
                                    {
                                        str_token = dttoken.Rows[0]["GiftCardToken"].ToString();
                                    }

                                    //if (str_status == "success")
                                    //{

                                    if (dtupdate.Rows[0][0].ToString() == "t")
                                    {
                                        str_email = dtupdate.Rows[0]["email"].ToString();

                                        foreach (DataRow dr in dtupdate.Rows)
                                        {
                                            //================== test======================
                                            //var client = new RestClient("https://send.bulkgv.net/API/v1/pullvoucher");
                                            //================== Live======================
                                            var client = new RestClient("https://send.bulkgv.com/API/v1/pullvoucher");


                                            //var client = new RestClient("https://send.bulkgv.net/API/v1/pullvoucher");
                                            client.Timeout = -1;
                                            var request = new RestRequest(Method.POST);
                                            request.AddHeader("token", str_token);
                                            request.AddHeader("Content-Type", "application/json");

                                            string str_json = @"{
                 ""BrandProductCode"" : """ + dr["BrandProductCode"].ToString() + @""",
                 ""Denomination"" : """ + dr["Denomnation"].ToString() + @""",
                 ""Quantity"" :" + dr["Quantity"].ToString() + @",
                 ""ExternalOrderId"":""" + "RZAPGift-" + dr["Id"].ToString() + @"""
                }
                            ";
                                            clsOperator objoperator = new clsOperator();

                                            string encryptdata = objoperator.EncryptString("vn3wrtSbd6sB9inNCCl79GG3S5V60JH0", str_json);

                                            var body = @"{""payload"":""" + encryptdata + @"""}";

                                            request.AddParameter("application/json", body, ParameterType.RequestBody);
                                            ServicePointManager.Expect100Continue = true;
                                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                                            IRestResponse response = client.Execute(request);

                                            string str_response2 = response.Content.ToString();

                                            objrecharge.Id = dr["id"].ToString();
                                            objrecharge.Request = "Token : " + str_token + "--- Json : " + str_json + "---Body : " + body;
                                            objrecharge.Response = str_response2;

                                            DataTable dtlog = new DataTable();
                                            dtlog = objrecharge.InsertGiftCardOrderDetailLog(objrecharge);


                                            DataSet ds = objoperator.ConvertJSONToDataSet(response.Content.ToString());
                                            string str_statuscode = ds.Tables[0].Rows[0]["code"].ToString();

                                            string str_status2 = ds.Tables[0].Rows[0]["status"].ToString();
                                            if (str_status2 == "success")
                                            {
                                                if (str_statuscode == "ER048" || str_statuscode == "0000")
                                                {
                                                    str_status2 = "success";
                                                }
                                                else
                                                {
                                                    str_status2 = "pending";
                                                }
                                            }
                                            else if (str_status2 == "error")
                                            {
                                                if (str_statuscode == "ER047" || str_statuscode == "ER1006" || str_statuscode == "ER1057" || str_statuscode == "ER1056" || str_statuscode == "ER1006" || str_statuscode == "EROIP" || str_statuscode == "1048")
                                                {
                                                    str_status2 = "pending";
                                                }
                                            }
                                            else
                                            {
                                                str_status2 = "pending";
                                            }



                                            string str_data = "";
                                            string str_decryptdata = "";
                                            if (str_status2 == "success")
                                            {
                                                //================ test==========================
                                                //string str_key = "6d66fb7debfd15bf716bb14752b9603b";
                                                //================ live ============================
                                                string str_key = "vn3wrtSbd6sB9inNCCl79GG3S5V60JH0";


                                                str_data = ds.Tables[0].Rows[0]["data"].ToString();
                                                str_decryptdata = objoperator.DecryptString(str_key, str_data);
                                                str_decryptdata = str_decryptdata.Substring(0, (str_decryptdata.LastIndexOf("}") + 1));
                                                ViewBag.VoucherResponse += str_decryptdata;

                                                DataSet dsVOucher = objoperator.ConvertJSONToDataSet(str_decryptdata);

                                                string str_voucherstatus = "";
                                                string str_brandname = "";
                                                string str_Amount = "";
                                                string str_Expiry = "";
                                                string str_VoucherGCCode = "";
                                                string str_VoucherGuid = "";
                                                string str_VoucherNo = "";
                                                string str_Voucherpin = "";

                                                if (dsVOucher.Tables.Count > 0)
                                                {
                                                    str_voucherstatus = dsVOucher.Tables[0].Rows[0]["ResultType"].ToString();
                                                    str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();
                                                    if (dsVOucher.Tables.Contains("PullVouchers"))
                                                    {
                                                        str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();

                                                    }

                                                    if (dsVOucher.Tables.Contains("Vouchers"))
                                                    {
                                                        foreach (DataRow drvoucher in dsVOucher.Tables["Vouchers"].Rows)
                                                        {
                                                            str_Amount = drvoucher["Value"].ToString();
                                                            str_Expiry = drvoucher["EndDate"].ToString();
                                                            str_VoucherGCCode = drvoucher["VoucherGCcode"].ToString();
                                                            str_VoucherGuid = drvoucher["VoucherGuid"].ToString();
                                                            str_VoucherNo = drvoucher["VoucherNo"].ToString();
                                                            str_Voucherpin = drvoucher["Voucherpin"].ToString();



                                                            dtvoucherdata.Rows.Add(str_brandname, dr["brandimage"].ToString(), str_voucherstatus, str_Amount, str_Expiry, str_VoucherGCCode, str_VoucherGuid, str_VoucherNo, str_Voucherpin);

                                                        }



                                                    }
                                                }




                                            }
                                            else if (str_status2 == "error")
                                            {
                                                dtvoucherdata.Rows.Add(dr["brandname"].ToString(), dr["brandimage"].ToString(), "FAILED", dr["Denomnation"].ToString(), "", "", "", "", "");

                                            }
                                            else
                                            {
                                                dtvoucherdata.Rows.Add(dr["brandname"].ToString(), dr["brandimage"].ToString(), "PENDING", dr["Denomnation"].ToString(), "", "", "", "", "");

                                            }

                                            objrecharge.Id = dr["id"].ToString();
                                            objrecharge.Status = str_status2;
                                            objrecharge.Request = str_json + "---" + body.ToString();
                                            objrecharge.Response = str_response2;
                                            objrecharge.VoucherData = str_decryptdata;

                                            DataTable dtres = objrecharge.UpdateGiftCardOrderDetail(objrecharge);




                                        }
                                    }
                                    //objrecharge.Status = "Success";
                                    //objrecharge.ReferenceId = "Success";
                                    //objrecharge.Message = "Processed Successfully";
                                    //objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                                    //objrecharge.StatusImage = "success.png";
                                    //}





                                    ViewBag.Email = str_email;
                                    ViewBag.VoucherCount = dtvoucherdata.Rows.Count.ToString();
                                    ViewBag.VoucherData = dtvoucherdata;
                                    Data objdata = new Data();
                                    string str_subject = "";
                                    string str_message = "";


                                    if (str_status == "success")
                                    {

                                        foreach (DataRow drfinal in dtvoucherdata.Rows)
                                        {
                                            if (drfinal["status"].ToString().ToUpper() == "SUCCESS")
                                            {
                                                //ViewBag.VoucherCount += "====Brand :" + drfinal["brandname"].ToString();
                                                //ViewBag.VoucherCount += "====Amount :" + drfinal["Amount"].ToString();
                                                //ViewBag.VoucherCount += "====Expiry: " + drfinal["Expiry"].ToString();
                                                //ViewBag.VoucherCount += "====Voucher No :" + drfinal["VoucherNo"].ToString();




                                                str_subject = "Gift Card Details Recharge Zap";
                                                // str_message = "Brand :" + drfinal["brandname"].ToString() + "<br/>";
                                                //str_message += "Amount :" + drfinal["Amount"].ToString() + "<br/>";
                                                //str_message += "Expiry :" + drfinal["Expiry"].ToString() + "<br/>";
                                                //str_message += "Voucher No :" + drfinal["VoucherNo"].ToString() + "<br/>";
                                                str_message = @" <table  style=""width: 800px;margin:20px auto;padding-bottom:20px;box-shadow: 0 9px 12px 10px rgba(0,0,0,.04);border-radius: 10px;background-color: #fff;"">
    <tbody>
        <tr><td style=""background-image: url('https://cdn-media-ie.pearltrees.com/b8/c3/0a/b8c30aa0669dd2a29428bf760871ddd8-l.jpg'); height: 140px;""></td></tr>
        <tr style=""color: #000B30; text-align: center; font-family: Javanese Text; font-size: 50px; font-style: normal; font-weight: 400; line-height: normal;"">
          <td>Enjoy Your Gift!</td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody>
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody style=""display: flex; align-items: center; justify-content: center;"">
                        <tr>
                          <td style=""width: 200px;""><img src=""" + drfinal["brandimage"].ToString() + @""" alt=""brand logo"" style="" width: 100%; height: 100%;"" /></td>
                          <td>
                            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                              <tbody style=""padding: 10px 0 10px 20px; display: block; flex-direction: column; gap: 10px;border-left: 1px solid black;"">
                                  <tr><td><h4 style=""font-family: Inria Serif; font-size: 20px; font-style: normal; font-weight: 700; line-height: normal; margin-bottom: 0;"">Gift Amount:</h4></td></tr>
                                  <tr><td><h1 style="" font-family: Inria Serif; font-size: 48px; font-style: normal; font-weight: 700; line-height: normal;margin: 0 0 15px 0;"">₹" + drfinal["amount"].ToString() + @"</h1></td></tr>
                                  <tr><td><a href="""" style=""border-radius: 5px 20px 20px 5px; border: 1px solid #000; background: #F69C2A;padding: 6px 12px;text-decoration: none;"">Redeem Now &nbsp; <img src=""https://new.rechargezap.in/new2/img/play.png"" alt=""play button"" style=""width: 20px;height: 20px; position: relative;top: 4px;""/></a></td></tr>
                                  <tr><td><h5 style=""  font-family: Inria Serif; font-size: 18px;font-style: normal;font-weight: 400;line-height: normal; margin-bottom: 0;"">Claim Code:</h5></td></tr>
                                  <tr><td><h2 style="" font-family: Inria Serif; font-size: 24px;font-style: normal;font-weight: 600;line-height: normal;margin: 7px 0;"">" + drfinal["voucherno"].ToString() + @"</h2></td></tr>  
                              </tbody>
                            </table>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody >
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;padding: 10px;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody>
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;padding-bottom: 10px;"">To: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">" + str_email + @"</span></td>
                          <td></td>
                        </tr> 
                        <tr>
                          <td style=""font-family: Inria Serif;font-size: 15px; font-style: normal;font-weight: 400;line-height: normal;padding-bottom: 10px;"">I didn’t know what exactly to get to you so I decided to send you a gift card instead. That way you can get exactly what you want. There must be something you’ve eyeing and you certainly deserve it. </td>
                        </tr> 
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;text-align: right;"">From: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">Recharge Zap</span></td>
                        </tr>                       
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""text-align: center;""><img src=""https://rechargezap.in/new2/img/logo.jpg"" alt=""logo"" style=""width: 100px; height: auto;"" /></td>
        </tr>
    </tbody>
  </table>";
                                                ViewBag.MailMessage += str_message;
                                                objdata.SendMail(str_email, str_subject, str_message);
                                            }
                                        }

                                        return View("GiftCardStatus", objrecharge);

                                    }


                                }
                                catch (Exception ep)
                                {

                                    ViewBag.errortext = ep.Message.ToString();

                                    objrecharge.InsertError("ParsingPaymentGatewaygiftcardwallet", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
                                    return View("GiftCardStatusFailed", objrecharge);
                                }


                                return View("CartDetail");
                            }





                        }

                        else
                        {
                            ViewBag.GiftcardError = "1";
                            ViewBag.GiftcardErrorText = "Technical Error Occurred";
                            return View("CartDetail");
                        }
                    }
                    else
                    {
                        ViewBag.GiftcardError = "1";
                        ViewBag.GiftcardErrorText = "Please Enter Valid Email";

                        return View("CartDetail");
                    }
                }
                else
                {
                    ViewBag.GiftcardError = "1";
                    ViewBag.GiftcardErrorText = "Please Enter Valid User Mobile";

                    return View("CartDetail");
                }
            }
            else
            {
                ViewBag.GiftcardError = "1";
                ViewBag.GiftcardErrorText = "No Items in Cart";

                return View("CartDetail");
            }

            //return View("CartDetail");

            //return Json(data);
        }







        //        [HttpPost]
        //        public ActionResult PurchaseGiftCard(clsRecharge objrecharge2)
        //        {
        //            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
        //                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
        //                        </a>";
        //            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
        //            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
        //            if (str_loginemail != null)
        //            {
        //                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
        //                <a href=""#!"">
        //                <div class=""wallet-img"">
        //                  <img src=""/new2/img/wallet-head.png"" alt="""">
        //                </div>
        //                <div class=""wallet-cont"">
        //                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
        //                  <span>Wallet Balance</span>
        //                </div>
        //              </a>
        //              </div>
        //              <div class=""head-signin h-flex"">
        //                <div class=""sign-img"">
        //                  <img src=""/new2/img/user.png"" alt="""">
        //                </div>
        //                <div class=""sign-cont"">
        //                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
        //                  <div class=""sign-menu"">
        //                    <div class=""sign-menu-inner"">
        //                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
        //                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
        //                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
        //                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
        //                    </div>
        //                  </div>
        //                </div>
        //              </div>";

        //                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">

        //                    <li class=""mobile-item active"">
        //                        <a href=""/Home/Dashboard"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
        //                            </span>
        //                            <span>Dashboard</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/Profile"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                            </span>
        //                            <span>My Profile</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"" class=""mobile-item-dropdown"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
        //                            </span>
        //                            <span>My Services</span>
        //                            <i class=""fa-solid fa-chevron-down""></i>
        //                        </a>
        //                        <div class=""item-dropdown"">
        //                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
        //                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
        //                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
        //                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
        //                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
        //                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
        //                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
        //                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
        //                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
        //                        </div>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/rechargehistory"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
        //                            </span>
        //                            <span>Order History</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""transactionhistory"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
        //                            </span>
        //                            <span>Transaction History</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
        //                            </span>
        //                            <span>Gift Cards</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
        //                            </span>
        //                            <span>Offers & Deals</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/Logout2"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
        //                            </span>
        //                            <span>Logout</span>
        //                        </a>
        //                    </li>
        //                </ul>";

        //            }
        //            else
        //            {
        //                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
        //                                <div class=""sign-img"">
        //                                    <span><i class=""fa-solid fa-circle-user""></i></span>
        //                                </div>
        //                                <div class=""sign-cont sign-in"">
        //                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
        //                                </div>
        //                            </div>";
        //                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
        //                    <li class=""mobile-item"">
        //                        <a onclick=""showModalLoginEmail();"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                            </span>
        //                            <span>Sign In</span>
        //                        </a>
        //                    </li>

        //                </ul>";
        //            }

        //            //clsCart objcart = new clsCart();


        //            List<clsCart> data = new List<clsCart>();

        //            //for (int i = 1; i < 10; i++)
        //            //{

        //            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");


        //            DataTable dtcart = new DataTable();
        //            dtcart.Columns.Add(new DataColumn("BrandProductCode", typeof(string)));
        //            dtcart.Columns.Add(new DataColumn("Denomnation", typeof(string)));
        //            dtcart.Columns.Add(new DataColumn("Quantity", typeof(string)));

        //            string str_token = "";

        //            DataTable dttoken = gettoken();
        //            if (dttoken.Rows.Count > 0)
        //            {
        //                str_token = dttoken.Rows[0]["GiftCardToken"].ToString();
        //            }


        //            foreach (clsCart cartsession in cartdata)
        //            {
        //                //clsCart obj2 = new clsCart
        //                //{
        //                //    Id = cartsession.Id,
        //                //    BrandProductCode = cartsession.BrandProductCode,
        //                //    BrandName = cartsession.BrandName,
        //                //    Denomnation = cartsession.Denomnation,
        //                //    Quantity = cartsession.Quantity,
        //                //    Discount = cartsession.Discount,
        //                //    BrandImage = cartsession.BrandImage,
        //                //    VoucherType = cartsession.VoucherType
        //                //};
        //                //data.Add(obj2);

        //                //dtcart.Rows.Add(cartsession.BrandProductCode, cartsession.Denomnation, cartsession.Quantity);

        //                clsRecharge objrecharge = new clsRecharge();

        //                var client = new RestClient("https://send.bulkgv.net/API/v1/pullvoucher");
        //                client.Timeout = -1;
        //                var request = new RestRequest(Method.POST);
        //                request.AddHeader("token", str_token);
        //                request.AddHeader("Content-Type", "application/json");

        //                string str_json= @"{
        // ""BrandProductCode"" : """+cartsession.BrandProductCode + @""",
        // ""Denomination"" : """+cartsession.Denomnation+@""",
        // ""Quantity"" :"+cartsession.Quantity+@",
        // ""ExternalOrderId"":"""+cartsession.Id+@"""
        //}
        //            ";
        //                clsOperator objoperator = new clsOperator();

        //                string encryptdata = objoperator.EncryptString("6d66fb7debfd15bf716bb14752b9603b", str_json);

        //                var body = @"{""payload"":"""+ encryptdata + @"""}";

        //                request.AddParameter("application/json", body, ParameterType.RequestBody);
        //                ServicePointManager.Expect100Continue = true;
        //                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        //                IRestResponse response = client.Execute(request);

        //                string str_response = response.Content.ToString();

        //                DataSet ds = objoperator.ConvertJSONToDataSet(response.Content.ToString());

        //                string str_status = ds.Tables[0].Rows[0]["status"].ToString();
        //                string str_data = "";
        //                string str_decryptdata = "";
        //                if (str_status == "success")
        //                {

        //                    str_data = ds.Tables[0].Rows[0]["data"].ToString();
        //                    str_decryptdata = objoperator.DecryptString("6d66fb7debfd15bf716bb14752b9603b", str_data);
        //str_decryptdata.Substring(0, (str_decryptdata.LastIndexOf("}]") + 2));

        //                }


        //                objrecharge.Id = "1";
        //                objrecharge.Status = str_status;
        //                objrecharge.Request = body;
        //                objrecharge.Response = str_response;
        //                objrecharge.VoucherData = str_decryptdata;

        //                DataTable dtres = objrecharge.UpdateGiftCardOrderDetail(objrecharge);

        //            }


        //            //HttpContext.Session.SetComplexData("loggerUser", null);


        //            return View("CartDetail");

        //            //return Json(data);
        //        }



        [HttpPost]
        public JsonResult AddToCart(string productCode, string denomination, string qty, string discount, string brandImage, string brandName, string brandType)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            //clsCart objcart = new clsCart();


            List<clsCart> data = new List<clsCart>();

            //for (int i = 1; i < 10; i++)
            //{

            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");


            int str_OldQty = 0;
            int str_NewQty = 0;


            if (cartdata != null)
            {

                clsCart Item = cartdata.Find(c => (c.BrandProductCode == productCode) && (c.Denomnation == denomination));



                if (Item != null)
                {
                    str_OldQty = Convert.ToInt32(Item.Quantity);

                    cartdata.Remove(Item);
                }
                str_NewQty = str_OldQty + 1;



                foreach (clsCart cartsession in cartdata)
                {
                    clsCart obj2 = new clsCart
                    {
                        Id = cartsession.Id,
                        BrandProductCode = cartsession.BrandProductCode,
                        BrandName = cartsession.BrandName,
                        Denomnation = cartsession.Denomnation,
                        Quantity = cartsession.Quantity,
                        Discount = cartsession.Discount,
                        BrandImage = cartsession.BrandImage,
                        VoucherType = cartsession.VoucherType
                    };
                    data.Add(obj2);
                }
            }
            else
            {
                str_NewQty = 1;
            }


            Random rnd = new Random();
            int str_id = rnd.Next(1000, 99999);  // creates a number between 1 and 12

            clsCart obj = new clsCart
            {
                Id = str_id.ToString(),
                BrandProductCode = productCode,
                BrandName = brandName,
                Denomnation = denomination,
                Quantity = str_NewQty.ToString(),
                Discount = discount,
                BrandImage = brandImage,
                VoucherType = brandType
            };
            data.Add(obj);
            //}
            //List<clsCart> _adminuser = HttpContext.Session.GetCustomObjectFromSession<clsCart>("adminUser");


            //HttpContext.Session.SetComplexData("loggerUser", data);
            //HttpContext.Session.SetObjectInSession("adminUser", data);

            //return View();

            HttpContext.Session.SetComplexData("loggerUser", data);



            return Json(data);
        }

        [HttpPost]
        public JsonResult SendOTP(string email)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }


            Random rnd = new Random();
            string str_otp = rnd.Next(10000, 99999).ToString();

            string str_message = @"<div style=""font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2"">
  <div style=""margin:50px auto;width:70%;padding:20px 0"">
    <div style=""border-bottom:1px solid #eee"">
      <a href="""" style=""font-size:1.4em;color: #192e6a;text-decoration:none;font-weight:600"">RechargeZap</a>
    </div>
    <p style=""font-size:1.1em"">Greetings,</p>
    <p><b>" + str_otp + @"</b> is your One-Time Password (OTP) to Recharge Or Bill Payment on RechargeZap account. OTP is valid for 5 minutes.</p>
    
    <p style=""font-size:0.9em;"">Regards,<br />RechargeZap Team</p>
    <hr style=""border:none;border-top:1px solid #eee"" />
    <div style=""float:center;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300"">
      <p>This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
      <p><center>www.rechargezap.in</center></p>
      
    </div>
  </div>
</div>
";

            HttpContext.Session.SetString("RechargeOTP", str_otp);
            HttpContext.Session.SetString("RechargeOTPEmailOTP", email);
            Data objdata = new Data();
            objdata.SendMail(email, "OTP for RechargeZap Recharge", str_message);
            //ViewBag.OTPPopup = "IsOTP";
            //ViewBag.OTPText = str_otp;



            clsRecharge objrecharge = new clsRecharge();
            objrecharge.Status = "1";

            HttpContext.Session.SetComplexData("loggerUser", objrecharge);



            return Json(objrecharge);
        }


        [HttpPost]
        public JsonResult DecreaseCart(string productCode, string denomination, string qty, string discount, string brandImage, string brandName, string brandType)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            //clsCart objcart = new clsCart();


            List<clsCart> data = new List<clsCart>();

            //for (int i = 1; i < 10; i++)
            //{

            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");


            int str_OldQty = 0;
            int str_NewQty = 0;


            if (cartdata != null)
            {

                clsCart Item = cartdata.Find(c => (c.BrandProductCode == productCode) && (c.Denomnation == denomination));



                if (Item != null)
                {
                    str_OldQty = Convert.ToInt32(Item.Quantity);

                    cartdata.Remove(Item);
                }
                str_NewQty = str_OldQty - 1;



                foreach (clsCart cartsession in cartdata)
                {
                    clsCart obj2 = new clsCart
                    {
                        Id = cartsession.Id,
                        BrandProductCode = cartsession.BrandProductCode,
                        BrandName = cartsession.BrandName,
                        Denomnation = cartsession.Denomnation,
                        Quantity = cartsession.Quantity,
                        Discount = cartsession.Discount,
                        BrandImage = cartsession.BrandImage,
                        VoucherType = cartsession.VoucherType
                    };
                    data.Add(obj2);
                }
            }



            if (str_NewQty > 0)
            {
                clsCart obj = new clsCart
                {
                    Id = (data.Count + 1).ToString(),
                    BrandProductCode = productCode,
                    BrandName = brandName,
                    Denomnation = denomination,
                    Quantity = str_NewQty.ToString(),
                    Discount = discount,
                    BrandImage = brandImage,
                    VoucherType = brandType
                };
                data.Add(obj);
            }

            //}
            //List<clsCart> _adminuser = HttpContext.Session.GetCustomObjectFromSession<clsCart>("adminUser");


            //HttpContext.Session.SetComplexData("loggerUser", data);
            //HttpContext.Session.SetObjectInSession("adminUser", data);

            //return View();

            HttpContext.Session.SetComplexData("loggerUser", data);



            return Json(data);
        }


        [HttpPost]
        public JsonResult DeleteCart(string cartId)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            //clsCart objcart = new clsCart();


            List<clsCart> data = new List<clsCart>();

            //for (int i = 1; i < 10; i++)
            //{

            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");

            var itemToRemove = cartdata.Single(r => r.Id == cartId);
            cartdata.Remove(itemToRemove);


            if (cartdata != null)
            {
                foreach (clsCart cartsession in cartdata)
                {
                    clsCart obj2 = new clsCart
                    {
                        Id = cartsession.Id,
                        BrandProductCode = cartsession.BrandProductCode,
                        BrandName = cartsession.BrandName,
                        Denomnation = cartsession.Denomnation,
                        Quantity = cartsession.Quantity,
                        Discount = cartsession.Discount,
                        BrandImage = cartsession.BrandImage,
                        VoucherType = cartsession.VoucherType
                    };
                    data.Add(obj2);
                }
            }



            //}
            //List<clsCart> _adminuser = HttpContext.Session.GetCustomObjectFromSession<clsCart>("adminUser");


            //HttpContext.Session.SetComplexData("loggerUser", data);
            //HttpContext.Session.SetObjectInSession("adminUser", data);

            //return View();

            HttpContext.Session.SetComplexData("loggerUser", data);



            return Json(data);
        }


        [HttpPost]
        public JsonResult GetCart()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            //clsCart objcart = new clsCart();


            List<clsCart> data = new List<clsCart>();

            //for (int i = 1; i < 10; i++)
            //{

            List<clsCart> cartdata = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");
            if (cartdata != null)
            {
                foreach (clsCart cartsession in cartdata)
                {
                    clsCart obj2 = new clsCart
                    {
                        Id = cartsession.Id,
                        BrandProductCode = cartsession.BrandProductCode,
                        BrandName = cartsession.BrandName,
                        Denomnation = cartsession.Denomnation,
                        Quantity = cartsession.Quantity,
                        Discount = cartsession.Discount,
                        BrandImage = cartsession.BrandImage,
                        VoucherType = cartsession.VoucherType
                    };
                    data.Add(obj2);
                }
            }
            return Json(data);
        }
        public IActionResult CartDetail()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            //DataTable dttoken = gettoken();

            //if (dttoken.Rows.Count > 0)
            //{
            //    string brandcode = HttpContext.Request.Query["bid"].ToString();
            //    clsOperator objoperator = new clsOperator();
            //    DataSet dsdetail = objoperator.getgiftCardDetail(brandcode, dttoken.Rows[0]["GiftCardToken"].ToString());
            //    if (dsdetail.Tables.Count > 0)
            //    {
            //        ViewBag.str_brandproductcode = dsdetail.Tables[1].Rows[0]["BrandProductCode"].ToString();
            //        ViewBag.str_brandtype = dsdetail.Tables[1].Rows[0]["brandtype"].ToString();
            //        ViewBag.str_brandname = dsdetail.Tables[1].Rows[0]["BrandName"].ToString();
            //        ViewBag.str_brandimage = @"<img src=""" + dsdetail.Tables[1].Rows[0]["BrandImage"].ToString() + @""" alt=""product_image"" />";
            //        ViewBag.str_brandimage2 = dsdetail.Tables[1].Rows[0]["BrandImage"].ToString();
            //        ViewBag.str_denomination = dsdetail.Tables[1].Rows[0]["denominationList"].ToString();

            //        DataTable dtdenomination = new DataTable();
            //        dtdenomination.Columns.Add(new DataColumn("denomination", typeof(string)));
            //        if (dsdetail.Tables[1].Rows[0]["denominationList"].ToString().Length > 0)
            //        {
            //            foreach (string str in dsdetail.Tables[1].Rows[0]["denominationList"].ToString().Split(','))
            //            {
            //                dtdenomination.Rows.Add(str);
            //            }
            //        }
            //        ViewBag.DenominationTable = dtdenomination;
            //        ViewBag.str_description = dsdetail.Tables[1].Rows[0]["Descriptions"].ToString();
            //        ViewBag.str_tnc = dsdetail.Tables[1].Rows[0]["tnc"].ToString();
            //        ViewBag.str_importantInstruction = dsdetail.Tables[1].Rows[0]["tnc"].ToString();
            //        ViewBag.str_RedeemSteps = dsdetail.Tables[1].Rows[0]["tnc"].ToString();


            //        DataTable dtdiscount = new DataTable();
            //        dtdiscount = objoperator.getGiftcardDiscount(dsdetail.Tables[1].Rows[0]["BrandProductCode"].ToString());
            //        if (dtdiscount.Rows.Count > 0)
            //        {
            //            ViewBag.str_Discount = dtdiscount.Rows[0]["discount"].ToString();
            //        }
            //        else
            //        {
            //            ViewBag.str_Discount = "0";
            //        }

            //    }

            //}
            List<clsCart> data = HttpContext.Session.GetComplexData<List<clsCart>>("loggerUser");

            return View();
        }


        public IActionResult MailTest()
        {
            string str_subject = "";
            string str_message = "";

            str_subject = "Gift Card Details Recharge Zap";
            str_message = @" <table  style=""width: 800px;margin:20px auto;padding-bottom:20px;box-shadow: 0 9px 12px 10px rgba(0,0,0,.04);border-radius: 10px;background-color: #fff;"">
    <tbody>
        <tr><td style=""background-image: url('https://cdn-media-ie.pearltrees.com/b8/c3/0a/b8c30aa0669dd2a29428bf760871ddd8-l.jpg'); height: 140px;""></td></tr>
        <tr style=""color: #000B30; text-align: center; font-family: Javanese Text; font-size: 50px; font-style: normal; font-weight: 400; line-height: normal;"">
          <td>Enjoy Your Gift!</td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody>
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody style=""display: flex; align-items: center; justify-content: center;"">
                        <tr>
                          <td style=""width: 200px;""><img src=""https://cdn.gyftr.com/comm_engine/prod/images/brands/1593584144778_mp92eskc2yurnu.png"" alt=""brand logo"" style="" width: 100%; height: 100%;"" /></td>
                          <td>
                            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                              <tbody style=""padding: 10px 0 10px 20px; display: block; flex-direction: column; gap: 10px;border-left: 1px solid black;"">
                                  <tr><td><h4 style=""font-family: Inria Serif; font-size: 20px; font-style: normal; font-weight: 700; line-height: normal; margin-bottom: 0;"">Gift Amount:</h4></td></tr>
                                  <tr><td><h1 style="" font-family: Inria Serif; font-size: 48px; font-style: normal; font-weight: 700; line-height: normal;margin: 0 0 15px 0;"">₹500</h1></td></tr>
                                  <tr><td><a href="""" style=""border-radius: 5px 20px 20px 5px; border: 1px solid #000; background: #F69C2A;padding: 6px 12px;text-decoration: none;"">Redeem Now &nbsp; <img src=""https://new.rechargezap.in/new2/img/play.png"" alt=""play button"" style=""width: 20px;height: 20px; position: relative;top: 4px;""/></a></td></tr>
                                  <tr><td><h5 style=""  font-family: Inria Serif; font-size: 18px;font-style: normal;font-weight: 400;line-height: normal; margin-bottom: 0;"">Claim Code:</h5></td></tr>
                                  <tr><td><h2 style="" font-family: Inria Serif; font-size: 24px;font-style: normal;font-weight: 600;line-height: normal;margin: 7px 0;"">1234-567890-1234</h2></td></tr>  
                              </tbody>
                            </table>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody >
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;padding: 10px;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody>
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;padding-bottom: 10px;"">To: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">Pragam</span></td>
                          <td></td>
                        </tr> 
                        <tr>
                          <td style=""font-family: Inria Serif;font-size: 15px; font-style: normal;font-weight: 400;line-height: normal;padding-bottom: 10px;"">I didn’t know what exactly to get to you so I decided to send you a gift card instead. That way you can get exactly what you want. There must be something you’ve eyeing and you certainly deserve it. </td>
                        </tr> 
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;text-align: right;"">From: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">Sandeep</span></td>
                        </tr>                       
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""text-align: center;""><img src=""https://rechargezap.in/new2/img/logo.jpg"" alt=""logo"" style=""width: 100px; height: auto;"" /></td>
        </tr>
    </tbody>
  </table>";
            ViewBag.MailMessage += str_message;
            Data objdata = new Data();

            objdata.SendMail("akartheone@gmail.com", str_subject, str_message);


            return View();
        }

        DataTable gettoken()
        {
            DataTable dt = new DataTable();

            try
            {
                clsOperator objoperator = new clsOperator();
                DataTable dttoken = objoperator.getGiftCardToken();
                if (Convert.ToInt32(dttoken.Rows[0]["difference"].ToString()) > 25)
                {
                    dt = objoperator.GetenerateGiftCardToken();
                }
                else
                {
                    dt = dttoken;
                }
            }
            catch
            {
            }
            return dt;
        }

        public IActionResult DTH()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Landline()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Broadband()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Cylinder()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Gas()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Electricity()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Water()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Insurance()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Fastag()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Terms()
        {
            ViewData["Title"] = "Recharge Zap - Payment recharge page";
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult About()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Refund()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            return View();
        }
        public IActionResult APITest()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            return View();
        }
        public IActionResult Payment()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            return View();
        }
        public IActionResult Dashboard()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";

            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (str_loginemail != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }

        }
        public IActionResult RechargeHistory()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (str_loginemail != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }

        }
        public IActionResult TransactionHistory()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (str_loginemail != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }

        }
        public IActionResult Message()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (str_loginemail != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }

        }
        public IActionResult Profile()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (str_loginemail != null)
            {
                return View();
            }
            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }

        }
        //public IActionResult Logout()
        //{
        //    ViewBag.logo1 = @"<a href=""/"" class=""logo"">
        //                    <img src=""../images/logo.png"" style=""max-height: 50px;"" />
        //                </a>";
        //    ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

        //    HttpContext.Session.Clear();
        //    HttpContext.Session.Remove("LoginEmail");
        //    string str_loginemail = HttpContext.Session.GetString("LoginEmail");
        //    if (str_loginemail != null)
        //    {
        //        ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
        //        <a href=""#!"">
        //        <div class=""wallet-img"">
        //          <img src=""/new2/img/wallet-head.png"" alt="""">
        //        </div>
        //        <div class=""wallet-cont"">
        //          <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
        //          <span>Wallet Balance</span>
        //        </div>
        //      </a>
        //      </div>
        //      <div class=""head-signin h-flex"">
        //        <div class=""sign-img"">
        //          <img src=""/new2/img/user.png"" alt="""">
        //        </div>
        //        <div class=""sign-cont"">
        //          <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
        //          <div class=""sign-menu"">
        //            <div class=""sign-menu-inner"">
        //              <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
        //              <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
        //              <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
        //              <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
        //            </div>
        //          </div>
        //        </div>
        //      </div>";

        //        ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">

        //            <li class=""mobile-item active"">
        //                <a href=""/Home/Dashboard"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
        //                    </span>
        //                    <span>Dashboard</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""/Home/Profile"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                    </span>
        //                    <span>My Profile</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""#"" class=""mobile-item-dropdown"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
        //                    </span>
        //                    <span>My Services</span>
        //                    <i class=""fa-solid fa-chevron-down""></i>
        //                </a>
        //                <div class=""item-dropdown"">
        //                    <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
        //                    <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
        //                    <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
        //                    <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
        //                    <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
        //                    <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
        //                    <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
        //                    <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
        //                    <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
        //                </div>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""/Home/rechargehistory"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
        //                    </span>
        //                    <span>Order History</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""transactionhistory"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
        //                    </span>
        //                    <span>Transaction History</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""#"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
        //                    </span>
        //                    <span>Gift Cards</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""#"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
        //                    </span>
        //                    <span>Offers & Deals</span>
        //                </a>
        //            </li>
        //            <li class=""mobile-item"">
        //                <a href=""/Home/Logout2"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
        //                    </span>
        //                    <span>Logout</span>
        //                </a>
        //            </li>
        //        </ul>";

        //    }
        //    else
        //    {
        //        ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
        //                        <div class=""sign-img"">
        //                            <span><i class=""fa-solid fa-circle-user""></i></span>
        //                        </div>
        //                        <div class=""sign-cont sign-in"">
        //                            <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
        //                        </div>
        //                    </div>";
        //        ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
        //            <li class=""mobile-item"">
        //                <a onclick=""showModalLoginEmail();"">
        //                    <span>
        //                        <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                        <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                    </span>
        //                    <span>Sign In</span>
        //                </a>
        //            </li>

        //        </ul>";
        //    }

        //    return new RedirectResult(url: "/", permanent: true,
        //             preserveMethod: true);


        //}

        public IActionResult Logout2()
        {
            //ViewBag.logo1 = @"<a href=""/"" class=""logo"">
            //                <img src=""../images/logo.png"" style=""max-height: 50px;"" />
            //            </a>";
            //ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            HttpContext.Session.Clear();
            HttpContext.Session.Remove("LoginEmail");
            //string str_loginemail = HttpContext.Session.GetString("LoginEmail");

            //    ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
            //                    <div class=""sign-img"">
            //                        <span><i class=""fa-solid fa-circle-user""></i></span>
            //                    </div>
            //                    <div class=""sign-cont sign-in"">
            //                        <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
            //                    </div>
            //                </div>";
            //    ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
            //        <li class=""mobile-item"">
            //            <a onclick=""showModalLoginEmail();"">
            //                <span>
            //                    <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
            //                    <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
            //                </span>
            //                <span>Sign In</span>
            //            </a>
            //        </li>

            //    </ul>";


            //return new RedirectResult(url: "/", permanent: true,
            //         preserveMethod: true);
            return View();


        }

        public IActionResult Test()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("LoginEmail");

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            return View("index");
        }
        private bool ValidateEmail(string str_email)
        {
            bool isemail;
            string email = str_email;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                isemail = true;
            else
                isemail = false;

            return isemail;
        }

        //========================== test credentials====================================
        public ActionResult Transaction(clsRecharge objrecharge)
        {

            if (objrecharge.RechargeAmount > 0)
            {

                string str_loginemail = HttpContext.Session.GetString("LoginEmail");
                if (str_loginemail != null)
                {
                    objrecharge.LoginEmail = str_loginemail;
                }
                else
                {
                    objrecharge.LoginEmail = "";
                }

                if (objrecharge.UserMobile.Length == 10)
                {
                    if (ValidateEmail(objrecharge.Email) == true)
                    {

                        string orderid = "D" + DateTime.Now.Ticks.ToString();

                        objrecharge.ReferenceId = orderid;

                        DataTable dt = new DataTable();
                        dt = objrecharge.RechargeInitiate(objrecharge);
                        if (dt.Rows[0][0].ToString() == "t")
                        {

                            decimal dcPaymentGatewayAMount = Convert.ToDecimal(dt.Rows[0]["paymentgatewayfinalamount"].ToString());

                            if (dcPaymentGatewayAMount > 0)
                            {
                                //decimal amount = objrecharge.RechargeAmount;
                                decimal amount = dcPaymentGatewayAMount;

                                //================================ test detail================================

                                //                Dictionary<String, String> paytmParams = new Dictionary<String, String>();
                                //                /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                //                paytmParams.Add("MID", "VitBiR75509720569947");
                                //                /* Find your WEBSITE in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                //                paytmParams.Add("WEBSITE", "WEBSTAGING");
                                //                /* Find your INDUSTRY_TYPE_ID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                //                paytmParams.Add("INDUSTRY_TYPE_ID", "Retail");
                                //                /* WEB for website and WAP for Mobile-websites or App */
                                //                paytmParams.Add("CHANNEL_ID", "WEB");
                                //                /* Enter your unique order id */
                                //                paytmParams.Add("ORDER_ID", orderid);
                                //                /* unique id that belongs to your customer */
                                //                paytmParams.Add("CUST_ID", objrecharge.Email);
                                //                /* customer's mobile number */
                                //                paytmParams.Add("MOBILE_NO", "");
                                //                /* customer's email */
                                //                paytmParams.Add("EMAIL", "");
                                //                /**
                                //                * Amount in INR that is payble by customer
                                //                * this should be numeric with optionally having two decimal points
                                //*/
                                //                paytmParams.Add("TXN_AMOUNT", amount.ToString());
                                //                /* on completion of transaction, we will send you the response on this URL */
                                //                paytmParams.Add("CALLBACK_URL", "https://rechargezap.com/home/paytmResponse");
                                //                /**
                                //                * Generate checksum for parameters we have
                                //                * You can get Checksum DLL from https://developer.paytm.com/docs/checksum/
                                //                * Find your Merchant Key in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys 
                                //*/
                                //                String checksum = paytm.CheckSum.generateCheckSum("t@SS!cOoARZOd&As", paytmParams);
                                //                /* for Staging */
                                //                String url = "https://securegw-stage.paytm.in/order/process?mid=VitBiR75509720569947&orderId=" + paytmParams.FirstOrDefault(x => x.Key == "ORDER_ID").Value;
                                //                /* for Production */


                                //                //String url = "https://securegw.paytm.in/order/process?mid=VitBiR75509720569947&orderId="+ paytmParams.FirstOrDefault(x => x.Key == "ORDER_ID").Value;

                                //                //For  Production 
                                //                //string  url  =  "https://securegw.paytm.in/theia/api

                                //===================================== Live Details=========================================

                                Dictionary<String, String> paytmParams = new Dictionary<String, String>();
                                /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                paytmParams.Add("MID", "ORIONT01825629762324");
                                /* Find your WEBSITE in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                paytmParams.Add("WEBSITE", "DEFAULT");
                                /* Find your INDUSTRY_TYPE_ID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
                                paytmParams.Add("INDUSTRY_TYPE_ID", "ECommerce");
                                /* WEB for website and WAP for Mobile-websites or App */
                                paytmParams.Add("CHANNEL_ID", "WEB");
                                /* Enter your unique order id */
                                paytmParams.Add("ORDER_ID", orderid);
                                /* unique id that belongs to your customer */
                                paytmParams.Add("CUST_ID", objrecharge.Email);
                                /* customer's mobile number */
                                paytmParams.Add("MOBILE_NO", "");
                                /* customer's email */
                                paytmParams.Add("EMAIL", "");
                                /**
                                * Amount in INR that is payble by customer
                                * this should be numeric with optionally having two decimal points
*/
                                paytmParams.Add("TXN_AMOUNT", amount.ToString());
                                /* on completion of transaction, we will send you the response on this URL */
                                paytmParams.Add("CALLBACK_URL", "https://rechargezap.in/home/paytmResponse");
                                /**
                                * Generate checksum for parameters we have
                                * You can get Checksum DLL from https://developer.paytm.com/docs/checksum/
                                * Find your Merchant Key in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys 
*/
                                String checksum = paytm.CheckSum.generateCheckSum("@nETKCfdug#N6xJe", paytmParams);
                                /* for Staging */
                                //String url = "https://securegw-stage.paytm.in/order/process?mid=VitBiR75509720569947&orderId=" + paytmParams.FirstOrDefault(x => x.Key == "ORDER_ID").Value;
                                /* for Production */


                                String url = "https://securegw.paytm.in/order/process?mid=VitBiR75509720569947&orderId=" + paytmParams.FirstOrDefault(x => x.Key == "ORDER_ID").Value;

                                //For  Production 
                                //string  url  =  "https://securegw.paytm.in/theia/api


                                /* Prepare HTML Form and Submit to Paytm */
                                String outputHtml = "";
                                outputHtml += "<html>";
                                outputHtml += "<head>";
                                outputHtml += "<title>Merchant Checkout Page</title>";
                                outputHtml += "</head>";
                                outputHtml += "<body>";
                                outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
                                outputHtml += "<form method='post' action='" + url + "' name='paytm_form'>";
                                foreach (string key in paytmParams.Keys)
                                {
                                    outputHtml += "<input type='hidden' name='" + key + "' value='" + paytmParams[key] + "'>";
                                }
                                outputHtml += "<input type='hidden' name='CHECKSUMHASH' value='" + checksum + "'>";
                                outputHtml += "</form>";
                                outputHtml += "<script type='text/javascript'>";
                                outputHtml += "document.paytm_form.submit();";
                                outputHtml += "</script>";
                                outputHtml += "</body>";
                                outputHtml += "</html>";
                                ViewBag.list = outputHtml;
                                return View("Payment");
                            }
                            else
                            {

                                string str_operatorname = "";
                                string str_username = "";
                                string str_processingcharge = "";
                                string str_liveid = "";
                                string str_mail = "";

                                str_operatorname = dt.Rows[0]["operator"].ToString();
                                str_username = objrecharge.UserName;
                                str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
                                str_mail = objrecharge.Email;

                                objrecharge.Mobile = objrecharge.UserMobile;
                                objrecharge.PaymentGatewayOrderid = orderid;
                                objrecharge.RechargeType = "Wallet";
                                DataTable dtrecharge = new DataTable();
                                dtrecharge = objrecharge.RechargeNew(objrecharge);
                                if (dtrecharge.Rows.Count > 0)
                                {

                                    objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
                                    objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
                                    objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
                                    objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
                                    objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
                                    objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
                                    objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
                                    objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();

                                    //response.Status = dt.Rows[0]["status"].ToString();
                                    //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
                                    //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
                                    //response.Amount =dt.Rows[0]["Amount"].ToString();
                                    //response.Status = dt.Rows[0]["message"].ToString();



                                }
                                else
                                {
                                    objrecharge.Status = "Failed";
                                    objrecharge.ReferenceId = "Technical Error";
                                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                                    objrecharge.Message = "Technical Error";
                                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
                                    objrecharge.StatusImage = "fail.png";
                                }

                                Data objdata = new Data();
                                string str_subject = "";
                                string str_message = "";

                                try
                                {

                                    if (objrecharge.Status == "Success")
                                    {
                                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
                                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>";
                                        objdata.SendMail(str_mail, str_subject, str_message);
                                    }
                                    else if (objrecharge.Status == "Pending")
                                    {
                                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
                                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>
";
                                        objdata.SendMail(str_mail, str_subject, str_message);
                                    }
                                }
                                catch (Exception ep)
                                {
                                    //clsRecharge objrecharge = new clsRecharge();
                                    ViewBag.errortext = ep.Message.ToString();
                                    objrecharge.InsertError("sendingRechargeEmailwallet", ep.Message.ToString(), "SendingRechargeEmail", "", orderid, "", objrecharge.ReferenceId);
                                }

                                return View("RechargeStatus", objrecharge);
                            }


                        }
                        else
                        {

                            return View();
                        }

                    }
                    else
                    {
                        ViewBag.RechargeError = "1";
                        ViewBag.RechargeErrorText = "Please Enter Valid Email";
                        return View("Recharge");
                    }
                }
                else
                {
                    ViewBag.RechargeError = "1";
                    ViewBag.RechargeErrorText = "Please Enter Valid User Mobile";
                    return View("Recharge");
                }

            }
            else
            {
                ViewBag.RechargeError = "1";
                ViewBag.RechargeErrorText = "Amount Must Be Greater Than Zero";
                return View("Recharge");
            }

        }
        [HttpPost]
        public ActionResult Contact(clsUser objuser)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            if (Regex.IsMatch(objuser.Mobile, "\\A[0-9]{10}\\z"))
            {

                if (objuser.Mobile.Length == 10)
                {
                    if (ValidateEmail(objuser.Email) == true)
                    {



                        Data objdata = new Data();
                        string str_subject = "Contact Request- Recharge Zap";
                        string str_message = @"New Contact Request Recieved <br/>Name : " + objuser.UserName + "<br/>Email : " + objuser.Email + "<br/>Mobile : " + objuser.Mobile + "<br/>Message : " + objuser.Message + "";
                        objdata.SendMail("care@rechargezap.in", str_subject, str_message);

                        ViewBag.ContactFormError = "1";
                        ViewBag.ContactFormText = "Request Submitted Successfuly";


                    }
                    else
                    {
                        ViewBag.ContactFormError = "0";
                        ViewBag.ContactFormText = "Enter Valid Email";
                    }

                }
                else
                {
                    ViewBag.ContactFormError = "0";
                    ViewBag.ContactFormText = "Enter Valid Mobile";
                }
            }
            else
            {
                ViewBag.ContactFormError = "0";
                ViewBag.ContactFormText = "Enter Valid Mobile";
            }

            return View("Contact");
        }
        [HttpPost]
        public ActionResult Profile(clsUser objuser)
        {

            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";

            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            //Data objdata = new Data();
            //string str_subject = "Contact Request- Recharge Zap";
            //string str_message = @"New Contact Request Recieved <br/>Name : " + objuser.UserName + "<br/>Email : " + objuser.Email + "<br/>Mobile : " + objuser.Mobile + "<br/>Message : " + objuser.Message + "";
            //objdata.SendMail("care@rechargezap.in", str_subject, str_message);

            //ViewBag.ContactFormError = "1";
            //ViewBag.ContactFormText = "Request Submitted Successfuly";
            //return View("Contact");
            clsUser objuser2 = new clsUser();
            if (str_loginemail != null)
            {
                objuser2.Email = str_loginemail;
                objuser2.UserName = objuser.UserName;

                string res = objuser.Update_UserProfileByEmail(objuser2);
                ViewBag.ProfileFormError = "1";
                ViewBag.ProfileFormText = "Profile Updated Successfuly";
                return View();
            }

            else
            {
                return new RedirectResult(url: "/", permanent: true,
                         preserveMethod: true);
            }



        }

        public ActionResult LoginEmail(clsRecharge objrecharge)
        {
            if (objrecharge.Email != null)
            {

                ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
                ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
                string str_loginemail = HttpContext.Session.GetString("LoginEmail");
                if (str_loginemail != null)
                {
                    ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                    ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

                }
                else
                {
                    ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                    ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
                }

                Random rnd = new Random();
                string str_otp = rnd.Next(10000, 99999).ToString();

                string str_message = @"<div style=""font-family: Helvetica,Arial,sans-serif;min-width:1000px;overflow:auto;line-height:2"">
  <div style=""margin:50px auto;width:70%;padding:20px 0"">
    <div style=""border-bottom:1px solid #eee"">
      <a href="""" style=""font-size:1.4em;color: #192e6a;text-decoration:none;font-weight:600"">RechargeZap</a>
    </div>
    <p style=""font-size:1.1em"">Greetings,</p>
    <p><b>" + str_otp + @"</b> is your One-Time Password (OTP) to login to your RechargeZap account. OTP is valid for 5 minutes.</p>
    
    <p style=""font-size:0.9em;"">Regards,<br />RechargeZap Team</p>
    <hr style=""border:none;border-top:1px solid #eee"" />
    <div style=""float:center;padding:8px 0;color:#aaa;font-size:0.8em;line-height:1;font-weight:300"">
      <p>This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
      <p><center>www.rechargezap.in</center></p>
      
    </div>
  </div>
</div>
";

                HttpContext.Session.SetString("LoginOTP", str_otp);
                HttpContext.Session.SetString("LoginEmailOTP", objrecharge.Email);
                Data objdata = new Data();
                objdata.SendMail(objrecharge.Email, "OTP for RechargeZap Login", str_message);
                ViewBag.OTPPopup = "IsOTP";
                ViewBag.OTPText = str_otp;
            }
            return View("index");
        }
        public ActionResult LoginOTP(clsRecharge objrecharge)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }

            string str_otp = this.HttpContext.Session.GetString("LoginOTP");
            string str_newotp = objrecharge.OTP1 + objrecharge.OTP2 + objrecharge.OTP3 + objrecharge.OTP4 + objrecharge.OTP5;

            ViewBag.OTPold = str_otp;
            ViewBag.OTPnew = str_newotp;

            if (str_otp == str_newotp.Trim())
            {
                HttpContext.Session.SetString("LoginEmail", HttpContext.Session.GetString("LoginEmailOTP"));
                //return View("Dashboard");
                return new RedirectResult(url: "/Home/Dashboard", permanent: true,
                          preserveMethod: true);
            }
            else
            {
                ViewBag.OTPError = "1";
                return View("index");
            }




        }


        //========================== Live credentials====================================

        //        public ActionResult Transaction(clsRecharge objrecharge)
        //        {


        //            string orderid = "D" + DateTime.Now.Ticks.ToString();

        //            objrecharge.ReferenceId = orderid;

        //            DataTable dt = new DataTable();
        //            dt = objrecharge.RechargeInitiate(objrecharge);
        //            if (dt.Rows[0][0].ToString() == "t")
        //            {

        //                decimal amount = objrecharge.RechargeAmount;

        //                Dictionary<String, String> paytmParams = new Dictionary<String, String>();
        //                /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
        //                paytmParams.Add("MID", "ORIONT01825629762324");
        //                /* Find your WEBSITE in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
        //                paytmParams.Add("WEBSITE", "DEFAULT");
        //                /* Find your INDUSTRY_TYPE_ID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */
        //                paytmParams.Add("INDUSTRY_TYPE_ID", "ECommerce");
        //                /* WEB for website and WAP for Mobile-websites or App */
        //                paytmParams.Add("CHANNEL_ID", "WEB");
        //                /* Enter your unique order id */
        //                paytmParams.Add("ORDER_ID", orderid);
        //                /* unique id that belongs to your customer */
        //                paytmParams.Add("CUST_ID", "455451");
        //                /* customer's mobile number */
        //                paytmParams.Add("MOBILE_NO", "");
        //                /* customer's email */
        //                paytmParams.Add("EMAIL", "");
        //                /**
        //                * Amount in INR that is payble by customer
        //                * this should be numeric with optionally having two decimal points
        //*/
        //                paytmParams.Add("TXN_AMOUNT", amount.ToString());
        //                /* on completion of transaction, we will send you the response on this URL */
        //                paytmParams.Add("CALLBACK_URL", "http://rechargezap.com/home/paytmResponse");
        //                /**
        //                * Generate checksum for parameters we have
        //                * You can get Checksum DLL from https://developer.paytm.com/docs/checksum/
        //                * Find your Merchant Key in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys 
        //*/
        //                String checksum = paytm.CheckSum.generateCheckSum("@nETKCfdug#N6xJe", paytmParams);
        //                /* for Staging */
        //                //String url = "https://securegw-stage.paytm.in/order/process";
        //                /* for Production */
        //                //String url = "https://securegw.paytm.in/order/process";
        //                String url = "https://securegw-stage.paytm.in/theia/processTransaction?orderid=" + paytmParams.FirstOrDefault(x => x.Key == "ORDER_ID").Value;
        //                /* Prepare HTML Form and Submit to Paytm */
        //                String outputHtml = "";
        //                outputHtml += "<html>";
        //                outputHtml += "<head>";
        //                outputHtml += "<title>Merchant Checkout Page</title>";
        //                outputHtml += "</head>";
        //                outputHtml += "<body>";
        //                outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
        //                outputHtml += "<form method='post' action='" + url + "' name='paytm_form'>";
        //                foreach (string key in paytmParams.Keys)
        //                {
        //                    outputHtml += "<input type='hidden' name='" + key + "' value='" + paytmParams[key] + "'>";
        //                }
        //                outputHtml += "<input type='hidden' name='CHECKSUMHASH' value='" + checksum + "'>";
        //                outputHtml += "</form>";
        //                outputHtml += "<script type='text/javascript'>";
        //                outputHtml += "document.paytm_form.submit();";
        //                outputHtml += "</script>";
        //                outputHtml += "</body>";
        //                outputHtml += "</html>";
        //                ViewBag.list = outputHtml;
        //                return View("Payment");
        //            }
        //            else {

        //            return View();
        //            }
        //        }

        public ActionResult paytmResponse()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult paytmResponse(PaytmResponse response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            try
            {
                String paytmChecksum = "";

                /* Create a Dictionary from the parameters received in POST */
                Dictionary<String, String> paytmParams = new Dictionary<String, String>();
                foreach (string key in Request.Form.Keys)
                {
                    if (key.Equals("CHECKSUMHASH"))
                    {
                        paytmChecksum = Request.Form[key];
                    }
                    else
                    {
                        paytmParams.Add(key.Trim(), Request.Form[key].ToString().Trim());
                    }
                }

                /**
                * Verify checksum
                * Find your Merchant Key in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys 
*/
                //===================== test Details===================
                // bool isValidChecksum = CheckSum.verifyCheckSum("t@SS!cOoARZOd&As", paytmParams, paytmChecksum);

                //========================== Live Details=============================
                bool isValidChecksum = CheckSum.verifyCheckSum("@nETKCfdug#N6xJe", paytmParams, paytmChecksum);
                string str_status = "";
                string str_paymentgatewayid = "";

                if (isValidChecksum)
                {
                    str_orderid = Request.Form["ORDERID"].ToString().Trim();
                    if (Request.Form["STATUS"].ToString().Trim() == "TXN_SUCCESS")
                    {
                        str_status = "success";
                        str_paymentgatewayid = Request.Form["TXNID"].ToString().Trim();

                    }
                    else
                    {
                        str_status = "failed";
                    }

                }
                else
                {

                    str_status = "failed";
                }


                //str_orderid = "D637807143501105607";
                //str_status = "success";

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.ReferenceId = str_orderid;
                objrecharge.Status = str_status;
                string str_operatorname = "";
                string str_username = "";
                string str_processingcharge = "";
                string str_liveid = "";
                string str_mail = "";
                DataTable dt = new DataTable();
                dt = objrecharge.UpdateRechargeInitiate(objrecharge);
                string res = "";
                if (dt.Rows.Count > 0)
                {
                    str_operatorname = dt.Rows[0]["operator"].ToString();
                    str_username = dt.Rows[0]["username"].ToString();
                    str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
                    str_mail = dt.Rows[0]["email"].ToString();

                    res = dt.Rows[0][0].ToString();
                    if (str_status == "success")
                    {
                        objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                        objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                        objrecharge.OperatorCode = dt.Rows[0]["operatorid"].ToString();
                        objrecharge.UserMobile = dt.Rows[0]["usermobile"].ToString();
                        objrecharge.Email = dt.Rows[0]["email"].ToString();
                        objrecharge.Mobile = dt.Rows[0]["usermobile"].ToString();
                        objrecharge.UserName = dt.Rows[0]["username"].ToString();
                        objrecharge.PaymentGatewayOrderid = dt.Rows[0]["referenceid"].ToString();
                        objrecharge.RechargeType = "PaymentGateway";
                        DataTable dtrecharge = new DataTable();
                        dtrecharge = objrecharge.RechargeNew(objrecharge);
                        if (dtrecharge.Rows.Count > 0)
                        {

                            objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
                            objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
                            objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
                            objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
                            objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
                            objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
                            objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
                            objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();

                            //response.Status = dt.Rows[0]["status"].ToString();
                            //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
                            //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
                            //response.Amount =dt.Rows[0]["Amount"].ToString();
                            //response.Status = dt.Rows[0]["message"].ToString();



                        }
                        else
                        {
                            objrecharge.Status = "Failed";
                            objrecharge.ReferenceId = "Technical Error";
                            objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                            objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                            objrecharge.Message = "Technical Error";
                            objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
                            objrecharge.StatusImage = "fail.png";
                        }
                    }
                    else
                    {
                        objrecharge.Status = "Failed";
                        objrecharge.ReferenceId = "Payment Failed";
                        objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                        objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                        objrecharge.Message = "Payment Failed";
                        objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
                        objrecharge.StatusImage = "fail.png";
                    }
                }
                else
                {
                    objrecharge.Status = "Failed";
                    objrecharge.ReferenceId = "Technical Error";
                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    objrecharge.Message = "Technical Error On Updating Request";
                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
                    objrecharge.StatusImage = "fail.png";

                    res = "-1";
                }
                Data objdata = new Data();
                string str_subject = "";
                string str_message = "";

                try
                {

                    if (objrecharge.Status == "Success")
                    {
                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>";
                        objdata.SendMail(str_mail, str_subject, str_message);
                    }
                    else if (objrecharge.Status == "Pending")
                    {
                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>
";
                        objdata.SendMail(str_mail, str_subject, str_message);
                    }
                }
                catch (Exception ep)
                {
                    //clsRecharge objrecharge = new clsRecharge();
                    ViewBag.errortext = ep.Message.ToString();
                    objrecharge.InsertError("sendingRechargeEmail", ep.Message.ToString(), "SendingRechargeEmail", "", str_paymentgatewayid, "", objrecharge.ReferenceId);
                }
                return View("RechargeStatus", objrecharge);

            }
            catch (Exception ep)
            {
                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertError("ParsingPaymentGateway", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
            }


            return View("paytmResponse", response);
        }

        public ActionResult GiftCardStatus()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult GiftCardStatus(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }
        public ActionResult GiftCardStatusFailed()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult GiftCardStatusFailed(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }
        public ActionResult GiftCardStatusPending()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult GiftCardStatusPending(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }

        public ActionResult RechargeStatus()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult RechargeStatus(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }
        public ActionResult RechargeStatusRefund()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult RechargeStatusRefund(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }

        public ActionResult RechargeStatusFailed()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult RechargeStatusFailed(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }
        public ActionResult RechargeStatusPending()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult RechargeStatusPending(clsRecharge response)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View("RechargeStatus", response);
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //public ActionResult PayUMoneyPayment()
        //{
        //    ViewBag.logo1 = @"<a href=""/"" class=""logo"">
        //                    <img src=""../images/logo.png"" style=""max-height: 50px;"" />
        //                </a>";
        //    ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
        //    return View();
        //}
        //        [HttpPost]
        //        public ActionResult PayUMoneyPayment(clsRecharge objrecharge)
        //        {
        //            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
        //                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
        //                        </a>";
        //            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
        //            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
        //            if (str_loginemail != null)
        //            {
        //                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
        //                <a href=""#!"">
        //                <div class=""wallet-img"">
        //                  <img src=""/new2/img/wallet-head.png"" alt="""">
        //                </div>
        //                <div class=""wallet-cont"">
        //                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
        //                  <span>Wallet Balance</span>
        //                </div>
        //              </a>
        //              </div>
        //              <div class=""head-signin h-flex"">
        //                <div class=""sign-img"">
        //                  <img src=""/new2/img/user.png"" alt="""">
        //                </div>
        //                <div class=""sign-cont"">
        //                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
        //                  <div class=""sign-menu"">
        //                    <div class=""sign-menu-inner"">
        //                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
        //                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
        //                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
        //                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
        //                    </div>
        //                  </div>
        //                </div>
        //              </div>";

        //                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">

        //                    <li class=""mobile-item active"">
        //                        <a href=""/Home/Dashboard"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
        //                            </span>
        //                            <span>Dashboard</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/Profile"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                            </span>
        //                            <span>My Profile</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"" class=""mobile-item-dropdown"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
        //                            </span>
        //                            <span>My Services</span>
        //                            <i class=""fa-solid fa-chevron-down""></i>
        //                        </a>
        //                        <div class=""item-dropdown"">
        //                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
        //                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
        //                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
        //                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
        //                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
        //                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
        //                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
        //                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
        //                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
        //                        </div>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/rechargehistory"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
        //                            </span>
        //                            <span>Order History</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""transactionhistory"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
        //                            </span>
        //                            <span>Transaction History</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
        //                            </span>
        //                            <span>Gift Cards</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""#"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
        //                            </span>
        //                            <span>Offers & Deals</span>
        //                        </a>
        //                    </li>
        //                    <li class=""mobile-item"">
        //                        <a href=""/Home/Logout2"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
        //                            </span>
        //                            <span>Logout</span>
        //                        </a>
        //                    </li>
        //                </ul>";

        //            }
        //            else
        //            {
        //                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
        //                                <div class=""sign-img"">
        //                                    <span><i class=""fa-solid fa-circle-user""></i></span>
        //                                </div>
        //                                <div class=""sign-cont sign-in"">
        //                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
        //                                </div>
        //                            </div>";
        //                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
        //                    <li class=""mobile-item"">
        //                        <a onclick=""showModalLoginEmail();"">
        //                            <span>
        //                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
        //                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
        //                            </span>
        //                            <span>Sign In</span>
        //                        </a>
        //                    </li>

        //                </ul>";
        //            }

        //            if (objrecharge.RechargeAmount > 0)
        //            {


        //                if (str_loginemail != null)
        //                {
        //                    objrecharge.LoginEmail = str_loginemail;
        //                }
        //                else
        //                {
        //                    objrecharge.LoginEmail = "";
        //                }
        //                if (objrecharge.UserMobile.Length == 10)
        //                {
        //                    if (ValidateEmail(objrecharge.Email) == true)
        //                    {
        //                        string txnid = Generatetxnid();

        //                        string orderid = txnid;

        //                        objrecharge.ReferenceId = orderid;
        //                       string Ip = HttpContext.Connection.RemoteIpAddress?.ToString();
        //                        objrecharge.IPAddress = Ip;
        //                        DataTable dt = new DataTable();
        //                        dt = objrecharge.RechargeInitiate(objrecharge);

        //                        string resdt = dt.Rows[0][0].ToString();

        //                        if (dt.Rows[0][0].ToString() == "t")
        //                        {

        //                            decimal dcPaymentGatewayAMount = Convert.ToDecimal(dt.Rows[0]["paymentgatewayfinalamount"].ToString());

        //                            if (dcPaymentGatewayAMount > 0)
        //                            {
        //                                //decimal amount = objrecharge.RechargeAmount;
        //                                decimal amount = dcPaymentGatewayAMount;


        //                                //======= test url============
        //                                //var baseURL = "https://test.payu.in/";

        //                                //============= live url=============
        //                                var baseURL = "https://secure.payu.in/";
        //                                var firstName = objrecharge.UserName;
        //                                //var amount = objrecharge.RechargeAmount;
        //                                var productInfo = "Online Recharge";
        //                                var email = objrecharge.Email;
        //                                var phone = objrecharge.UserMobile;
        //                                //=========== test details==========
        //                                //var key = "oZ7oo9";
        //                                //var salt = "UkojH5TS";
        //                                //=======live details================
        //                                var key = "sqyp9U";
        //                                var salt = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI";




        //                                Dictionary<String, String> paymentParams = new Dictionary<String, String>();
        //                                /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */


        //                                //var myremotepost = new RemotePost { Url = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment" };
        //                                paymentParams.Add("key", key);
        //                                paymentParams.Add("txnid", txnid);
        //                                paymentParams.Add("amount", amount.ToString());
        //                                paymentParams.Add("productinfo", productInfo);
        //                                paymentParams.Add("firstname", firstName);
        //                                paymentParams.Add("phone", phone);
        //                                paymentParams.Add("email", email);
        //                                //paymentParams.Add("surl", "https://localhost:44399/Home/PayUMoneySuccess");
        //                                //paymentParams.Add("furl", "https://localhost:44399/Home/PayUMoneyFailed");

        //                                paymentParams.Add("surl", "https://rechargezap.in/Home/PayUMoneySuccess");
        //                                paymentParams.Add("furl", "https://rechargezap.in/Home/PayUMoneyFailed");
        //                                paymentParams.Add("service_provider", "payu_paisa");

        //                                //string hashString = key + "|" + Generatetxnid() + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
        //                                string hashString = key + "|" + txnid + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
        //                                //string hashString = "3Q5c3q|2590640|3053.00|OnlineBooking|vimallad|ladvimal@gmail.com|||||||||||mE2RxRwx";
        //                                string hash = Generatehash512(hashString);
        //                                paymentParams.Add("hash", hash);

        //                                /* Prepare HTML Form and Submit to Paytm */
        //                                String outputHtml = "";
        //                                outputHtml += "<html>";
        //                                outputHtml += "<head>";
        //                                //outputHtml += "<title></title>";
        //                                outputHtml += "</head>";
        //                                outputHtml += "<body <body onload=\"document.form1.submit()\">";
        //                                outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
        //                                outputHtml += "<form method='post' action='" + baseURL + "_payment' name='form1'>";
        //                                foreach (string key2 in paymentParams.Keys)
        //                                {
        //                                    outputHtml += "<input type='hidden' name='" + key2 + "' value='" + paymentParams[key2] + "'>";
        //                                }
        //                                outputHtml += "";
        //                                outputHtml += "</form>";
        //                                //outputHtml += "<script type='text/javascript'>";
        //                                //outputHtml += "document.payu_form.submit();";
        //                                //outputHtml += "</script>";
        //                                outputHtml += "</body>";
        //                                outputHtml += "</html>";
        //                                ViewBag.list = outputHtml;
        //                                return View("Payment");
        //                            }
        //                            else
        //                            {

        //                                string str_operatorname = "";
        //                                string str_username = "";
        //                                string str_processingcharge = "";
        //                                string str_liveid = "";
        //                                string str_mail = "";

        //                                str_operatorname = dt.Rows[0]["operator"].ToString();
        //                                str_username = objrecharge.UserName;
        //                                str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
        //                                str_mail = objrecharge.Email;

        //                                objrecharge.Mobile = objrecharge.UserMobile;
        //                                objrecharge.PaymentGatewayOrderid = orderid;
        //                                objrecharge.RechargeType = "Wallet";
        //                                DataTable dtrecharge = new DataTable();
        //                                dtrecharge = objrecharge.RechargeNew(objrecharge);
        //                                if (dtrecharge.Rows.Count > 0)
        //                                {

        //                                    objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
        //                                    objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
        //                                    objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
        //                                    objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
        //                                    objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
        //                                    objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
        //                                    objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
        //                                    objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();

        //                                    //response.Status = dt.Rows[0]["status"].ToString();
        //                                    //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
        //                                    //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
        //                                    //response.Amount =dt.Rows[0]["Amount"].ToString();
        //                                    //response.Status = dt.Rows[0]["message"].ToString();



        //                                }
        //                                else
        //                                {
        //                                    objrecharge.Status = "Failed";
        //                                    objrecharge.ReferenceId = "Technical Error";
        //                                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
        //                                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
        //                                    objrecharge.Message = "Technical Error";
        //                                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
        //                                    objrecharge.StatusImage = "fail.png";
        //                                }

        //                                Data objdata = new Data();
        //                                string str_subject = "";
        //                                string str_message = "";

        //                                try
        //                                {

        //                                    if (objrecharge.Status == "Success")
        //                                    {
        //                                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
        //                                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
        //                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
        //<tbody><tr>
        //<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
        //                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
        //<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
        //<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
        //<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
        //<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
        //</tr></thead>
        //<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
        //</tr>
        //  <tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
        //</tr>
        //  <tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
        //</tr>
        //</tbody>
        //</table>
        //</div>
        //</div>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
        //<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
        //<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
        //<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
        //<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //                                </td>
        //                            </tr></tbody></table>
        //</td>
        //                </tr></tbody></table>
        //</td>
        //    </tr></tbody></table>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
        //RechargeZap Team</p><br>
        // <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
        //This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

        //  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
        //©RechargeZap 2022. All Rights Reserved.</p>


        //                                    </td>
        //                                </tr>
        //</tbody></table>
        //</td>";
        //                                        objdata.SendMail(str_mail, str_subject, str_message);
        //                                    }
        //                                    else if (objrecharge.Status == "Pending")
        //                                    {
        //                                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
        //                                        str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
        //                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
        //<tbody><tr>
        //<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
        //                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
        //<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
        //<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
        //<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
        //<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
        //</tr></thead>
        //<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
        //</tr>
        //  <tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
        //</tr>
        //<tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
        //</tr>

        //  <tr>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
        //<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
        //</tr>
        //</tbody>
        //</table>
        //</div>
        //</div>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
        //<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
        //<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
        //<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
        //<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
        //                                </td>
        //                            </tr></tbody></table>
        //</td>
        //                </tr></tbody></table>
        //</td>
        //    </tr></tbody></table>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

        //  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
        //<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
        //RechargeZap Team</p><br>
        // <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
        //This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

        //  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
        //©RechargeZap 2022. All Rights Reserved.</p>


        //                                    </td>
        //                                </tr>
        //</tbody></table>
        //</td>
        //";
        //                                        objdata.SendMail(str_mail, str_subject, str_message);
        //                                    }
        //                                    else if (objrecharge.Status == "Failed")
        //                                    {
        //                                        str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Failed";
        //                                        str_message = @"<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; background-color: #ffffff; margin: 0 auto; padding: 0; width: 570px;"" width=""570"" cellspacing=""0"" cellpadding=""0"" align=""center"">
        //<tbody>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; padding: 35px;"">
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Dear " + str_username + @",</p>
        //<br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">&nbsp;</p>
        //<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
        //<div style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
        //<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; background-color: #edf4fb; padding: 13px; margin-bottom: 5px!important; margin: 30px auto; width: 100%;"">
        //<thead style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
        //<tr>
        //<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
        //<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
        //</tr>
        //</thead>
        //<tbody style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Name</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_username + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_operatorname + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator Number</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.RechargeMobile + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Order ID</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.ReferenceId + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Payment Type</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Online</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Date &amp; Time</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Amount</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + objrecharge.RechargeAmount + @"</td>
        //</tr>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Status</td>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Failed</td>
        //</tr>
        //</tbody>
        //</table>
        //</div>
        //</div>
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: center;"">**Payment Is Inclusive of GST **</p>
        //<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; margin: 30px auto; padding: 0; text-align: center; width: 100%;"" width=""100%"" cellspacing=""0"" cellpadding=""0"" align=""center"">
        //<tbody>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
        //<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" width=""100%"" cellspacing=""0"" cellpadding=""0"">
        //<tbody>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
        //<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" cellspacing=""0"" cellpadding=""0"">
        //<tbody>
        //<tr>
        //<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">&nbsp;</td>
        //</tr>
        //</tbody>
        //</table>
        //</td>
        //</tr>
        //</tbody>
        //</table>
        //</td>
        //</tr>
        //</tbody>
        //</table>
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, your amount will be refunded back to your wallet.</p>
        //<br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.com</a></p>
        //<br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Here to help :)</p>
        //<br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thanks &amp; Regards<br />RechargeZap Team</p>
        //<br /><br /><br /><br /><br /><br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 10px; line-height: 1.5em; margin-top: 0; text-align: center;"">This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
        //<br /><br />
        //<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393838; font-size: 11px; line-height: 1.5em; margin-top: 0; text-align: center;"">&copy;RechargeZap 2022. All Rights Reserved.</p>
        //</td>
        //</tr>
        //</tbody>
        //</table>

        //";
        //                                        objdata.SendMail(str_mail, str_subject, str_message);
        //                                    }



        //                                }
        //                                catch (Exception ep)
        //                                {
        //                                    //clsRecharge objrecharge = new clsRecharge();
        //                                    ViewBag.errortext = ep.Message.ToString();
        //                                    objrecharge.InsertError("sendingRechargeEmailwallet", ep.Message.ToString(), "SendingRechargeEmail", "", orderid, "", objrecharge.ReferenceId);
        //                                }

        //                                if (objrecharge.Status == "Success")
        //                                {
        //                                    return View("RechargeStatus", objrecharge);

        //                                }
        //                                else if (objrecharge.Status == "Pending")
        //                                {
        //                                    return View("RechargeStatusPending", objrecharge);

        //                                }
        //                                else
        //                                {
        //                                    return View("RechargeStatusRefund", objrecharge);

        //                                }
        //                                //return View("RechargeStatus", objrecharge);
        //                            }





        //                        }

        //                        else
        //                        {
        //                            ViewBag.RechargeError = "1";
        //                            ViewBag.RechargeErrorText = "Techncal Error Occurred";
        //                            return View("Recharge");
        //                        }
        //                    }
        //                    else
        //                    {
        //                        ViewBag.RechargeError = "1";
        //                        ViewBag.RechargeErrorText = "Please Enter Valid Email";
        //                        return View("Recharge");
        //                    }
        //                }
        //                else
        //                {
        //                    ViewBag.RechargeError = "1";
        //                    ViewBag.RechargeErrorText = "Please Enter Valid User Mobile";
        //                    return View("Recharge");
        //                }
        //            }
        //            else
        //            {
        //                ViewBag.RechargeError = "1";
        //                ViewBag.RechargeErrorText = "Amount Must Be Greater Than Zero";
        //                return View("Recharge");
        //            }
        //        }


        [HttpPost]
        public ActionResult PayUMoneyPayment(clsRecharge objrecharge)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";




            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }


            string str_rechargeotp= HttpContext.Session.GetString("RechargeOTP");
            string str_rechargeotpemail = HttpContext.Session.GetString("RechargeOTPEmailOTP");

            string str_otp = objrecharge.RechargeOTP;

            int otpflag = 0;

            if (objrecharge.RechargeAmount <= 10000M)
            {
                otpflag = 1;
            }
            else if (str_otp == str_rechargeotp)
            {
                otpflag = 1;
            }
            if (otpflag == 1)
            {
            
            decimal dcmaxamount = 1000000M;
            if (objrecharge.RechargeAmount > 0)
            {


                if (str_loginemail != null)
                {
                    objrecharge.LoginEmail = str_loginemail;
                }
                else
                {
                    objrecharge.LoginEmail = "";
                }
                if (objrecharge.UserMobile.Length == 10)
                {
                    if (ValidateEmail(objrecharge.Email) == true)
                    {
                        DataTable dtoptype = new DataTable();
                        dtoptype = objrecharge.getOperatorCodeType(objrecharge);
                        if (dtoptype.Rows.Count > 0)
                        {

                            string str_operatortype = "";
                            str_operatortype = dtoptype.Rows[0]["type"].ToString();
                            if (str_operatortype == "1")
                            {
                                dcmaxamount = 10000M;
                            }
                            else if (str_operatortype == "2")
                            {
                                dcmaxamount = 10000M;
                            }
                            else if (str_operatortype == "6")
                            {
                                dcmaxamount = 10000M;
                            }
                            else if (str_operatortype == "12")
                            {
                                dcmaxamount = 30000M;
                            }
                            if (objrecharge.RechargeAmount <= dcmaxamount)
                            {


                                string txnid = Generatetxnid();

                                string orderid = txnid;

                                objrecharge.ReferenceId = orderid;
                                string Ip = HttpContext.Connection.RemoteIpAddress?.ToString();
                                objrecharge.IPAddress = Ip;
                                DataTable dt = new DataTable();
                                dt = objrecharge.RechargeInitiate(objrecharge);

                                string resdt = dt.Rows[0][0].ToString();
                                //string resmsg = dt.Rows[0]["msg"].ToString();

                                if (dt.Rows[0][0].ToString() == "t")
                                {

                                    decimal dcPaymentGatewayAMount = Convert.ToDecimal(dt.Rows[0]["paymentgatewayfinalamount"].ToString());

                                    if (dcPaymentGatewayAMount > 0)
                                    {
                                        //decimal amount = objrecharge.RechargeAmount;
                                        decimal amount = dcPaymentGatewayAMount;


                                        ////======= test url============
                                        ////var baseURL = "https://test.payu.in/";

                                        //============= live url=============
                                        var baseURL = "https://secure.payu.in/";
                                        var firstName = objrecharge.UserName;
                                        //var amount = objrecharge.RechargeAmount;
                                        var productInfo = "Online Recharge";
                                        var email = objrecharge.Email;
                                        var phone = objrecharge.UserMobile;
                                        //=========== test details==========
                                        //var key = "oZ7oo9";
                                        //var salt = "UkojH5TS";
                                        //=======live details================
                                        var key = "sqyp9U";
                                        var salt = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI";




                                        Dictionary<String, String> paymentParams = new Dictionary<String, String>();
                                        /* Find your MID in your Paytm Dashboard at https://dashboard.paytm.com/next/apikeys */


                                        //var myremotepost = new RemotePost { Url = ConfigurationManager.AppSettings["PAYU_BASE_URL"] + "/_payment" };
                                        paymentParams.Add("key", key);
                                        paymentParams.Add("txnid", txnid);
                                        paymentParams.Add("amount", amount.ToString());
                                        paymentParams.Add("productinfo", productInfo);
                                        paymentParams.Add("firstname", firstName);
                                        paymentParams.Add("phone", phone);
                                        paymentParams.Add("email", email);
                                        //paymentParams.Add("surl", "https://localhost:44399/Home/PayUMoneySuccess");
                                        //paymentParams.Add("furl", "https://localhost:44399/Home/PayUMoneyFailed");

                                        paymentParams.Add("surl", "https://rechargezap.in/Home/PayUMoneySuccess");
                                        paymentParams.Add("furl", "https://rechargezap.in/Home/PayUMoneyFailed");
                                        paymentParams.Add("service_provider", "payu_paisa");

                                        //string hashString = key + "|" + Generatetxnid() + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
                                        string hashString = key + "|" + txnid + "|" + amount + "|" + productInfo + "|" + firstName + "|" + email + "|||||||||||" + salt;
                                        //string hashString = "3Q5c3q|2590640|3053.00|OnlineBooking|vimallad|ladvimal@gmail.com|||||||||||mE2RxRwx";
                                        string hash = Generatehash512(hashString);
                                        paymentParams.Add("hash", hash);

                                        /* Prepare HTML Form and Submit to Paytm */
                                        String outputHtml = "";
                                        outputHtml += "<html>";
                                        outputHtml += "<head>";
                                        //outputHtml += "<title></title>";
                                        outputHtml += "</head>";
                                        outputHtml += "<body <body onload=\"document.form1.submit()\">";
                                        outputHtml += "<center><h1>Please do not refresh this page...</h1></center>";
                                        outputHtml += "<form method='post' action='" + baseURL + "_payment' name='form1'>";
                                        foreach (string key2 in paymentParams.Keys)
                                        {
                                            outputHtml += "<input type='hidden' name='" + key2 + "' value='" + paymentParams[key2] + "'>";
                                        }
                                        outputHtml += "";
                                        outputHtml += "</form>";
                                        //outputHtml += "<script type='text/javascript'>";
                                        //outputHtml += "document.payu_form.submit();";
                                        //outputHtml += "</script>";
                                        outputHtml += "</body>";
                                        outputHtml += "</html>";
                                        ViewBag.list = outputHtml;
                                        return View("Payment");




                                    }
                                    else
                                    {

                                        string str_operatorname = "";
                                        string str_username = "";
                                        string str_processingcharge = "";
                                        string str_liveid = "";
                                        string str_mail = "";

                                        str_operatorname = dt.Rows[0]["operator"].ToString();
                                        str_username = objrecharge.UserName;
                                        str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
                                        str_mail = objrecharge.Email;

                                        objrecharge.Mobile = objrecharge.UserMobile;
                                        objrecharge.PaymentGatewayOrderid = orderid;
                                        objrecharge.RechargeType = "Wallet";
                                        DataTable dtrecharge = new DataTable();
                                        dtrecharge = objrecharge.RechargeNew(objrecharge);
                                        if (dtrecharge.Rows.Count > 0)
                                        {

                                            objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
                                            objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
                                            objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
                                            objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
                                            objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
                                            objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
                                            objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
                                            objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();

                                            //response.Status = dt.Rows[0]["status"].ToString();
                                            //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
                                            //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
                                            //response.Amount =dt.Rows[0]["Amount"].ToString();
                                            //response.Status = dt.Rows[0]["message"].ToString();



                                        }
                                        else
                                        {
                                            objrecharge.Status = "Failed";
                                            objrecharge.ReferenceId = "Technical Error";
                                            objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                                            objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                                            objrecharge.Message = "Technical Error";
                                            objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy");
                                            objrecharge.StatusImage = "fail.png";
                                        }

                                        Data objdata = new Data();
                                        string str_subject = "";
                                        string str_message = "";

                                        try
                                        {

                                            if (objrecharge.Status == "Success")
                                            {
                                                str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
                                                str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>";
                                                objdata.SendMail(str_mail, str_subject, str_message);
                                            }
                                            else if (objrecharge.Status == "Pending")
                                            {
                                                str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
                                                str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>

  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>
";
                                                objdata.SendMail(str_mail, str_subject, str_message);
                                            }
                                            else if (objrecharge.Status == "Failed")
                                            {
                                                str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Failed";
                                                str_message = @"<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; background-color: #ffffff; margin: 0 auto; padding: 0; width: 570px;"" width=""570"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; padding: 35px;"">
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Dear " + str_username + @",</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">&nbsp;</p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<div style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; background-color: #edf4fb; padding: 13px; margin-bottom: 5px!important; margin: 30px auto; width: 100%;"">
<thead style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
</tr>
</thead>
<tbody style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Name</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_username + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_operatorname + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator Number</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.RechargeMobile + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Order ID</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Payment Type</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Online</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Date &amp; Time</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Amount</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + objrecharge.RechargeAmount + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Status</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Failed</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: center;"">**Payment Is Inclusive of GST **</p>
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; margin: 30px auto; padding: 0; text-align: center; width: 100%;"" width=""100%"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" width=""100%"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, your amount will be refunded back to your wallet.</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.com</a></p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Here to help :)</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thanks &amp; Regards<br />RechargeZap Team</p>
<br /><br /><br /><br /><br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 10px; line-height: 1.5em; margin-top: 0; text-align: center;"">This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
<br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393838; font-size: 11px; line-height: 1.5em; margin-top: 0; text-align: center;"">&copy;RechargeZap 2022. All Rights Reserved.</p>
</td>
</tr>
</tbody>
</table>

";
                                                objdata.SendMail(str_mail, str_subject, str_message);
                                            }



                                        }
                                        catch (Exception ep)
                                        {
                                            //clsRecharge objrecharge = new clsRecharge();
                                            ViewBag.errortext = ep.Message.ToString();
                                            objrecharge.InsertError("sendingRechargeEmailwallet", ep.Message.ToString(), "SendingRechargeEmail", "", orderid, "", objrecharge.ReferenceId);
                                        }

                                        if (objrecharge.Status == "Success")
                                        {
                                            return View("RechargeStatus", objrecharge);

                                        }
                                        else if (objrecharge.Status == "Pending")
                                        {
                                            return View("RechargeStatusPending", objrecharge);

                                        }
                                        else
                                        {
                                            return View("RechargeStatusRefund", objrecharge);

                                        }
                                        //return View("RechargeStatus", objrecharge);
                                    }





                                }

                                else
                                {
                                    ViewBag.RechargeError = "1";
                                    ViewBag.RechargeErrorText = "Techncal Error Occurred";
                                    return View("Recharge");
                                }
                            }
                            else
                            {
                                ViewBag.RechargeError = "1";
                                ViewBag.RechargeErrorText = "Amount Must Be Less Than Or Equal To " + dcmaxamount.ToString();
                                return View("Recharge");
                            }
                        }
                        else
                        {
                            ViewBag.RechargeError = "1";
                            ViewBag.RechargeErrorText = "Invalid Operator";
                            return View("Recharge");
                        }
                    }
                    else
                    {
                        ViewBag.RechargeError = "1";
                        ViewBag.RechargeErrorText = "Please Enter Valid Email";
                        return View("Recharge");
                    }
                }
                else
                {
                    ViewBag.RechargeError = "1";
                    ViewBag.RechargeErrorText = "Please Enter Valid User Mobile";
                    return View("Recharge");
                }
            }
            else
            {
                ViewBag.RechargeError = "1";
                ViewBag.RechargeErrorText = "Amount Must Be Greater Than Zero";
                return View("Recharge");
            }
        }
            else
            {
                ViewBag.RechargeError = "1";
                ViewBag.RechargeErrorText = "Invalid OTP";
                return View("Recharge");
            }
        }
        public Boolean VerifyPayment(string txnid, string mihpayid)
        {

            //===test mode 
            //var baseURL = "https://test.payu.in/merchant/postservice.php?form=2";
            //===Live Mode
            var baseURL = "https://info.payu.in/merchant/postservice.php?form=2";

            //var amount = objrecharge.RechargeAmount;

            //=========== test details==========
            //var key = "oZ7oo9";
            //var salt = "UkojH5TS";
            //=======live details================
            var key = "sqyp9U";
            var salt = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI";


            string command = "verify_payment";
            string hashstr = key + "|" + command + "|" + txnid + "|" + salt;

            string hash = Generatehash512(hashstr);

            ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol = (SecurityProtocolType)768 | (SecurityProtocolType)3072;

            var request = (HttpWebRequest)WebRequest.Create(baseURL);

            var postData = "key=" + Uri.EscapeDataString(key);
            postData += "&hash=" + Uri.EscapeDataString(hash);
            postData += "&var1=" + Uri.EscapeDataString(txnid);
            postData += "&command=" + Uri.EscapeDataString(command);
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            if (responseString.Contains("\"mihpayid\":\"" + mihpayid + "\"") && responseString.Contains("\"status\":\"success\""))
                return true;
            else
                return false;
            /*
            Here is json response example -

            {"status":1,
            "msg":"1 out of 1 Transactions Fetched Successfully",
            "transaction_details":</strong>
            {	
                "Txn72738624":
                {
                    "mihpayid":"403993715519726325",
                    "request_id":"",
                    "bank_ref_num":"670272",
                    "amt":"6.17",
                    "transaction_amount":"6.00",
                    "txnid":"Txn72738624",
                    "additional_charges":"0.17",
                    "productinfo":"P01 P02",
                    "firstname":"Viatechs",
                    "bankcode":"CC",
                    "udf1":null,
                    "udf3":null,
                    "udf4":null,
                    "udf5":"PayUBiz_PHP7_Kit",
                    "field2":"179782",
                    "field9":" Verification of Secure Hash Failed: E700 -- Approved -- Transaction Successful -- Unable to be determined--E000",
                    "error_code":"E000",
                    "addedon":"2019-08-09 14:07:25",
                    "payment_source":"payu",
                    "card_type":"MAST",
                    "error_Message":"NO ERROR",
                    "net_amount_debit":6.17,
                    "disc":"0.00",
                    "mode":"CC",
                    "PG_TYPE":"AXISPG",
                    "card_no":"512345XXXXXX2346",
                    "name_on_card":"Test Owenr",
                    "udf2":null,
                    "status":"success",
                    "unmappedstatus":"captured",
                    "Merchant_UTR":null,
                    "Settled_At":"0000-00-00 00:00:00"
                }
            }
            }

            Decode the Json response and retrieve "transaction_details" 
            Then retrieve {txnid} part. This is dynamic as per txnid sent in var1.
            Then check for mihpayid and status.

            */
        }

        public ActionResult PayUMoneySuccess()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult PayUMoneySuccess(PayUMoneyResponse form)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            string str_message2 = "";
            string str_rechargestatus = "";


            try
            {
                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                str_status = Request.Form["status"].ToString().Trim();
                str_orderid = Request.Form["txnid"].ToString().Trim();
                foreach (string key in Request.Form.Keys)
                {

                    str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
                }
                if (str_status == "success")
                {

                    var mercHashVarsSeq = hashSeq.Split('|');
                    Array.Reverse(mercHashVarsSeq);
                    var mercHashString = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI" + "|" + Request.Form["status"].ToString().Trim();

                    foreach (var mercHashVar in mercHashVarsSeq)
                    {
                        mercHashString += "|";
                        mercHashString = mercHashString + Request.Form[mercHashVar].ToString();

                    }
                    var mercHash = Generatehash512(mercHashString).ToLower();

                    if (mercHash != Request.Form["hash"].ToString())
                    {
                        str_message2 = "Hash value did not matched";
                        str_status = "failure";

                    }
                    else
                    {
                        str_message2 = "Hash value matched";
                        str_status = Request.Form["status"].ToString();
                        //if (VerifyPayment(str_orderid, Request.Form["mihpayid"].ToString()))
                        //{
                        //    str_message2 = "Payment Verification Success";
                        //    str_status = "success";
                        //}
                        //else
                        //{
                        //    str_message2 = "Payment Verification Failed";
                        //    str_status = "failed";
                        //}


                    }
                }
                else
                {
                    str_message2 = "payment failed";
                    str_status = Request.Form["status"].ToString();
                }
                //ViewBag.response1 = formValues;
                if (str_status.ToLower() == "failure")
                {
                    str_status = "failed";
                }

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.ReferenceId = str_orderid;
                objrecharge.Status = str_status;
                objrecharge.Message = str_message2;
                objrecharge.PaymentGatewayResponse = str_response;
                string str_operatorname = "";
                string str_username = "";
                string str_processingcharge = "";
                string str_liveid = "";
                string str_mail = "";
                DataTable dt = new DataTable();
                dt = objrecharge.UpdateRechargeInitiate(objrecharge);
                string res = "";
                if (dt.Rows.Count > 0)
                {
                    objrecharge.PaymentGatewayAmount = Convert.ToDecimal(dt.Rows[0]["PaymentGatewayAmount"].ToString());
                    objrecharge.ProcessingCharge = Convert.ToDecimal(dt.Rows[0]["ProcessingCharge"].ToString());
                    objrecharge.PaymentGatewayOrderid = str_orderid;
                    objrecharge.OperatorName = dt.Rows[0]["operator"].ToString();
                    str_operatorname = dt.Rows[0]["operator"].ToString();
                    str_username = dt.Rows[0]["username"].ToString();
                    str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
                    str_mail = dt.Rows[0]["email"].ToString();
                    ViewBag.PaymentGatewayAmount = dt.Rows[0]["PaymentGatewayAmount"].ToString();
                    ViewBag.PaymentGatewayOrderid = dt.Rows[0]["referenceid"].ToString();
                    res = dt.Rows[0][0].ToString();
                    if (str_status == "success")
                    {
                        objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                        objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                        objrecharge.PaymentGatewayAmount = Convert.ToDecimal(dt.Rows[0]["PaymentGatewayAmount"].ToString());
                        objrecharge.OperatorCode = dt.Rows[0]["operatorid"].ToString();
                        objrecharge.UserMobile = dt.Rows[0]["usermobile"].ToString();
                        objrecharge.Email = dt.Rows[0]["email"].ToString();
                        objrecharge.Mobile = dt.Rows[0]["usermobile"].ToString();
                        objrecharge.UserName = dt.Rows[0]["username"].ToString();
                        objrecharge.PaymentGatewayOrderid = dt.Rows[0]["referenceid"].ToString();
                        objrecharge.RechargeType = "PaymentGateway";
                        DataTable dtrecharge = new DataTable();
                        dtrecharge = objrecharge.RechargeNew(objrecharge);
                        if (dtrecharge.Rows.Count > 0)
                        {

                            objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
                            objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
                            objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
                            objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
                            objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
                            objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
                            objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
                            objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();
                            objrecharge.Email = str_mail;
                            //response.Status = dt.Rows[0]["status"].ToString();
                            //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
                            //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
                            //response.Amount =dt.Rows[0]["Amount"].ToString();
                            //response.Status = dt.Rows[0]["message"].ToString();



                        }
                        else
                        {
                            objrecharge.Email = str_mail;
                            objrecharge.Status = "Failed";
                            objrecharge.ReferenceId = "Technical Error";
                            objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                            objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                            objrecharge.Message = "Technical Error";
                            objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                            objrecharge.StatusImage = "fail.png";
                        }
                    }
                    else
                    {
                        objrecharge.Status = "Failed";
                        objrecharge.ReferenceId = "Payment Failed";
                        objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                        objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                        objrecharge.Message = "Payment Failed";
                        objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                        objrecharge.StatusImage = "fail.png";
                    }
                }
                else
                {
                    objrecharge.Status = "Failed";
                    objrecharge.ReferenceId = "Technical Error";
                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    objrecharge.Message = "Technical Error On Updating Request";
                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    objrecharge.StatusImage = "fail.png";

                    res = "-1";
                }
                Data objdata = new Data();
                string str_subject = "";
                string str_message = "";

                if (res == "t")
                {

                    try
                    {

                        if (objrecharge.Status == "Success")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
                            str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                        else if (objrecharge.Status == "Pending")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
                            str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>
";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                        else if (objrecharge.Status == "Failed")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Failed";
                            str_message = @"<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; background-color: #ffffff; margin: 0 auto; padding: 0; width: 570px;"" width=""570"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; padding: 35px;"">
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Dear " + str_username + @",</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">&nbsp;</p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<div style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; background-color: #edf4fb; padding: 13px; margin-bottom: 5px!important; margin: 30px auto; width: 100%;"">
<thead style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
</tr>
</thead>
<tbody style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Name</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_username + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_operatorname + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator Number</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.RechargeMobile + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Order ID</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Payment Type</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Online</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Date &amp; Time</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Amount</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Amount Paid</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Status</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Failed</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: center;"">**Payment Is Inclusive of GST **</p>
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; margin: 30px auto; padding: 0; text-align: center; width: 100%;"" width=""100%"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" width=""100%"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Your recharge has failed due to some technical issue at the operator's end. Your amount has been refunded back to your wallet in the form of eCash, you can use your wallet balance to make a new recharge.</p>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Login to your <a href=""https://rechargezap.in"">RechargeZap</a> account to view transaction history, check avilable eCash balance and much more.</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Here to help :)</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thanks &amp; Regards<br />RechargeZap Team</p>
<br /><br /><br /><br /><br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 10px; line-height: 1.5em; margin-top: 0; text-align: center;"">This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
<br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393838; font-size: 11px; line-height: 1.5em; margin-top: 0; text-align: center;"">&copy;RechargeZap 2022. All Rights Reserved.</p>
</td>
</tr>
</tbody>
</table>

";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                    }
                    catch (Exception ep)
                    {
                        //clsRecharge objrecharge = new clsRecharge();
                        ViewBag.errortext = ep.Message.ToString();
                        objrecharge.InsertError("sendingRechargeEmail", ep.Message.ToString(), "SendingRechargeEmail", "", str_orderid, "", objrecharge.ReferenceId);
                    }
                }

                if (objrecharge.Status == "Success")
                {
                    return View("RechargeStatus", objrecharge);

                }
                else if (objrecharge.Status == "Pending")
                {
                    return View("RechargeStatusPending", objrecharge);

                }
                else
                {
                    return View("RechargeStatusRefund", objrecharge);

                }

            }
            catch (Exception ep)
            {
                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertError("ParsingPaymentGateway", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
            }


            //ViewBag.response1 = formValues;


            //PaytmResponse response = new PaytmResponse();

            return View("PayUMoneySuccess", form);
        }


        public ActionResult PayUMoneySuccessGiftCard()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";

                //DataTable dtvoucherdata = new DataTable();
                //dtvoucherdata.Columns.Add(new DataColumn("BrandName", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("BrandImage", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("Status", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("Amount", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("Expiry", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("VoucherGCcode", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("VoucherGuid", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("VoucherNo", typeof(string)));
                //dtvoucherdata.Columns.Add(new DataColumn("Voucherpin", typeof(string)));


                //clsOperator objoperator = new clsOperator();


                //string str_response2 = @"{""status"":""success"",""data"":""fxb+9MG/BscVzhSk5Yi6JQ0+rd4R0y1KA0Kjw1QJFuLtb40n/E5yvorqP5GTjldGNq15EtyU8J6RhrK54JFUXqv05/wksirR8SQIPYN7LjkA+pLCkeRwu1mndy38vn04P3CqTSuIH42IeePEvK6cTFxlrDuFM+SCb0PRH1M1xRHHC91HMGYjb66ceXDQoMn3HR+lzuq93VAWfEomV7vmaqAZauvrkLmh2psqsC7pTubMZmjTPhVdn73uNJXifrTHMe/gzpj3FU2nn46NDtBXoiBtaRpyGaVZvHVB++xuWLj34Vh2FUBA/czU/cvfq0B/EU62R4612Dh5XHud0+hQu9blXtRta6wCqwaRqD51ck6hHY8EEr02iA6qHC1iqfHT47g/kEQsKF/AisLIEKt0h3Tad7rjhdM1rz8dvtXOTUMV0Y7euAMv2z+kCg2TBXUyQCjByCz9W5tesPc0FrZWGSB4QzCtss6hC1MsENlrPWVyXeatkX1Kh38Ep9Kilhy9sc/4KP2HbQk9X+y/wMt3XcZSQoooKmYljZtyMXd0kQ5ldE0JHvg+Mq3doGyHFjclMzlMekiO0WRxCLHJyfG17n9eiG3JtPfBe4/1h1djzkTDJz6WZpz9r3jxE+GbP3GNs2YQ2VlA7E9dIr20akVqTQe/NvwHPhmNmIjz/JLk3MpqO5yjmehcjZVALzUJ8H58"",""desc"":""Process successfully completed"",""code"":""0000""}";

                //DataSet ds = objoperator.ConvertJSONToDataSet(str_response2);

                //string str_status2 = ds.Tables[0].Rows[0]["status"].ToString();
                //string str_data = "";
                //string str_decryptdata = "";
                //if (str_status2 == "success")
                //{

                //    str_data = ds.Tables[0].Rows[0]["data"].ToString();
                //    str_decryptdata = objoperator.DecryptString("6d66fb7debfd15bf716bb14752b9603b", str_data);
                //str_decryptdata.Substring(0, (str_decryptdata.LastIndexOf("}]") + 2));
                //    DataSet dsVOucher = objoperator.ConvertJSONToDataSet(str_decryptdata);

                //    string str_voucherstatus = "";
                //    string str_brandname = "";
                //    string str_Amount = "";
                //    string str_Expiry = "";
                //    string str_VoucherGCCode = "";
                //    string str_VoucherGuid = "";
                //    string str_VoucherNo = "";
                //    string str_Voucherpin = "";

                //    if (dsVOucher.Tables.Count > 0)
                //    {
                //        str_voucherstatus = dsVOucher.Tables[0].Rows[0]["ResultType"].ToString();
                //        str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();
                //        if (dsVOucher.Tables.Contains("PullVouchers"))
                //        {
                //            str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();

                //        }

                //        if (dsVOucher.Tables.Contains("Vouchers"))
                //        {
                //            foreach (DataRow drvoucher in dsVOucher.Tables["Vouchers"].Rows)
                //            {
                //                str_Amount = drvoucher["Value"].ToString();
                //                str_Expiry = drvoucher["EndDate"].ToString();
                //                str_VoucherGCCode = drvoucher["VoucherGCcode"].ToString();
                //                str_VoucherGuid = drvoucher["VoucherGuid"].ToString();
                //                str_VoucherNo = drvoucher["VoucherNo"].ToString();
                //                str_Voucherpin = drvoucher["Voucherpin"].ToString();



                //                dtvoucherdata.Rows.Add(str_brandname, "dfjdffdj", str_voucherstatus, str_Amount, str_Expiry, str_VoucherGCCode, str_VoucherGuid, str_VoucherNo, str_Voucherpin);






                //                }
                //        }




                //    }



                //}

                //Data objdata = new Data();

                //foreach (DataRow drfinal in dtvoucherdata.Rows)
                //{
                //    string str_subject = "GiFrard Details Recharge Zap";
                //    string str_message = "Brand :"+drfinal["brandname"].ToString()+"<br/>";
                //     str_message += "Amount :"+drfinal["Amount"].ToString() + "<br/>";
                //     str_message += "Expiry :"+drfinal["Expiry"].ToString() + "<br/>";
                //     str_message += "Voucher No :" + drfinal["VoucherNo"].ToString() + "<br/>";
                //    objdata.SendMail("akartheone@gmail.com", str_subject, str_message);

                //}



            }
            return View();
        }
        [HttpPost]
        public ActionResult PayUMoneySuccessGiftCard(PayUMoneyResponse form)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            string str_message2 = "";
            string str_rechargestatus = "";


            try
            {
                DataTable dtvoucherdata = new DataTable();
                dtvoucherdata.Columns.Add(new DataColumn("BrandName", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("BrandImage", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("Status", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("Amount", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("Expiry", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("VoucherGCcode", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("VoucherGuid", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("VoucherNo", typeof(string)));
                dtvoucherdata.Columns.Add(new DataColumn("Voucherpin", typeof(string)));

                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                str_status = Request.Form["status"].ToString().Trim();
                str_orderid = Request.Form["txnid"].ToString().Trim();
                foreach (string key in Request.Form.Keys)
                {

                    str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
                }

                ViewBag.OrderId = str_orderid;

                if (str_status == "success")
                {

                    var mercHashVarsSeq = hashSeq.Split('|');
                    Array.Reverse(mercHashVarsSeq);
                    var mercHashString = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI" + "|" + Request.Form["status"].ToString().Trim();

                    foreach (var mercHashVar in mercHashVarsSeq)
                    {
                        mercHashString += "|";
                        mercHashString = mercHashString + Request.Form[mercHashVar].ToString();

                    }
                    var mercHash = Generatehash512(mercHashString).ToLower();

                    if (mercHash != Request.Form["hash"].ToString())
                    {
                        str_message2 = "Hash value did not matched";
                        str_status = "failure";

                    }
                    else
                    {
                        str_message2 = "Hash value matched";
                        str_status = Request.Form["status"].ToString();
                        //if (VerifyPayment(str_orderid, Request.Form["mihpayid"].ToString()))
                        //{
                        //    str_message2 = "Payment Verification Success";
                        //    str_status = "success";
                        //}
                        //else
                        //{
                        //    str_message2 = "Payment Verification Failed";
                        //    str_status = "failed";
                        //}


                    }
                }
                else
                {
                    str_message2 = "payment failed";
                    str_status = Request.Form["status"].ToString();
                }
                //ViewBag.response1 = formValues;
                if (str_status.ToLower() == "failure")
                {
                    str_status = "failed";
                }
                //str_status = "success";

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.ReferenceId = str_orderid;
                objrecharge.Status = str_status;
                objrecharge.Message = str_message2;
                objrecharge.PaymentGatewayResponse = str_response;
                string str_operatorname = "";
                string str_username = "";
                string str_processingcharge = "";
                string str_liveid = "";
                string str_mail = "";
                DataTable dt = new DataTable();
                dt = objrecharge.UpdateGiftCardInitiate(objrecharge);
                ViewBag.PaymentGayewayResponse = str_response;
                ViewBag.PaymentStatus = str_status;
                ViewBag.ActionName = "SuccessAction";
                ViewBag.OrderTime = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                string str_email = "";
                string res = "";
                if (dt.Rows.Count > 0)
                {


                    string str_token = "";
                    res = dt.Rows[0][0].ToString();
                    DataTable dttoken = gettoken();
                    if (dttoken.Rows.Count > 0)
                    {
                        str_token = dttoken.Rows[0]["GiftCardToken"].ToString();
                    }

                    //if (str_status == "success")
                    //{

                    if (dt.Rows[0][0].ToString() == "t")
                    {
                        str_email = dt.Rows[0]["email"].ToString();

                        foreach (DataRow dr in dt.Rows)
                        {


                            //================== test======================
                            //var client = new RestClient("https://send.bulkgv.net/API/v1/pullvoucher");
                            //================== Live======================
                            var client = new RestClient("https://send.bulkgv.com/API/v1/pullvoucher");

                            client.Timeout = -1;
                            var request = new RestRequest(Method.POST);
                            request.AddHeader("token", str_token);
                            request.AddHeader("Content-Type", "application/json");

                            string str_json = @"{
                 ""BrandProductCode"" : """ + dr["BrandProductCode"].ToString() + @""",
                 ""Denomination"" : """ + dr["Denomnation"].ToString() + @""",
                 ""Quantity"" :" + dr["Quantity"].ToString() + @",
                 ""ExternalOrderId"":""" + "RZAPGift-" + dr["Id"].ToString() + @"""
                }
                            ";
                            clsOperator objoperator = new clsOperator();

                            string encryptdata = objoperator.EncryptString("vn3wrtSbd6sB9inNCCl79GG3S5V60JH0", str_json);

                            var body = @"{""payload"":""" + encryptdata + @"""}";

                            request.AddParameter("application/json", body, ParameterType.RequestBody);
                            ServicePointManager.Expect100Continue = true;
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                            IRestResponse response = client.Execute(request);

                            string str_response2 = response.Content.ToString();


                            objrecharge.Id = dr["id"].ToString();

                            objrecharge.Request = body;
                            objrecharge.Response = str_response2;

                            DataTable dtlog = new DataTable();
                            dtlog = objrecharge.InsertGiftCardOrderDetailLog(objrecharge);

                            DataSet ds = objoperator.ConvertJSONToDataSet(response.Content.ToString());

                            string str_statuscode = ds.Tables[0].Rows[0]["code"].ToString();

                            string str_status2 = ds.Tables[0].Rows[0]["status"].ToString();
                            if (str_status2 == "success")
                            {
                                if (str_statuscode == "ER048" || str_statuscode == "0000")
                                {
                                    str_status2 = "success";
                                }
                                else
                                {
                                    str_status2 = "pending";
                                }
                            }
                            else if (str_status2 == "error")
                            {
                                if (str_statuscode == "ER047" || str_statuscode == "ER1006" || str_statuscode == "ER1057" || str_statuscode == "ER1056" || str_statuscode == "ER1006" || str_statuscode == "EROIP" || str_statuscode == "1048")
                                {
                                    str_status2 = "pending";
                                }
                            }
                            else
                            {
                                str_status2 = "pending";
                            }

                            string str_data = "";
                            string str_decryptdata = "";
                            if (str_status2 == "success")
                            {

                                //================ test==========================
                                //string str_key = "6d66fb7debfd15bf716bb14752b9603b";
                                //================ live ============================
                                string str_key = "vn3wrtSbd6sB9inNCCl79GG3S5V60JH0";

                                str_data = ds.Tables[0].Rows[0]["data"].ToString();
                                str_decryptdata = objoperator.DecryptString(str_key, str_data);
                                str_decryptdata = str_decryptdata.Substring(0, (str_decryptdata.LastIndexOf("}") + 1));
                                ViewBag.VoucherResponse += str_decryptdata;

                                DataSet dsVOucher = objoperator.ConvertJSONToDataSet(str_decryptdata);

                                string str_voucherstatus = "";
                                string str_brandname = "";
                                string str_Amount = "";
                                string str_Expiry = "";
                                string str_VoucherGCCode = "";
                                string str_VoucherGuid = "";
                                string str_VoucherNo = "";
                                string str_Voucherpin = "";

                                if (dsVOucher.Tables.Count > 0)
                                {
                                    str_voucherstatus = dsVOucher.Tables[0].Rows[0]["ResultType"].ToString();
                                    str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();
                                    if (dsVOucher.Tables.Contains("PullVouchers"))
                                    {
                                        str_brandname = dsVOucher.Tables["PullVouchers"].Rows[0]["ProductName"].ToString();

                                    }

                                    if (dsVOucher.Tables.Contains("Vouchers"))
                                    {
                                        foreach (DataRow drvoucher in dsVOucher.Tables["Vouchers"].Rows)
                                        {
                                            str_Amount = drvoucher["Value"].ToString();
                                            str_Expiry = drvoucher["EndDate"].ToString();
                                            str_VoucherGCCode = drvoucher["VoucherGCcode"].ToString();
                                            str_VoucherGuid = drvoucher["VoucherGuid"].ToString();
                                            str_VoucherNo = drvoucher["VoucherNo"].ToString();
                                            str_Voucherpin = drvoucher["Voucherpin"].ToString();



                                            dtvoucherdata.Rows.Add(str_brandname, dr["brandimage"].ToString(), str_voucherstatus, str_Amount, str_Expiry, str_VoucherGCCode, str_VoucherGuid, str_VoucherNo, str_Voucherpin);

                                        }



                                    }
                                }




                            }
                            else if (str_status2 == "error")
                            {
                                dtvoucherdata.Rows.Add(dr["brandname"].ToString(), dr["brandimage"].ToString(), "FAILED", dr["Denomnation"].ToString(), "", "", "", "", "");

                            }
                            else
                            {
                                dtvoucherdata.Rows.Add(dr["brandname"].ToString(), dr["brandimage"].ToString(), "PENDING", dr["Denomnation"].ToString(), "", "", "", "", "");

                            }


                            objrecharge.Id = dr["id"].ToString();
                            objrecharge.Status = str_status2;
                            objrecharge.Request = str_json + "---" + body.ToString();
                            objrecharge.Response = str_response2;
                            objrecharge.VoucherData = str_decryptdata;

                            DataTable dtres = objrecharge.UpdateGiftCardOrderDetail(objrecharge);




                        }
                    }
                    //objrecharge.Status = "Success";
                    //objrecharge.ReferenceId = "Success";
                    //objrecharge.Message = "Processed Successfully";
                    //objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    //objrecharge.StatusImage = "success.png";
                    //}



                }
                else
                {
                    str_status = "failed";
                }

                ViewBag.Email = str_email;
                ViewBag.VoucherCount = dtvoucherdata.Rows.Count.ToString();
                ViewBag.VoucherData = dtvoucherdata;
                Data objdata = new Data();
                string str_subject = "";
                string str_message = "";


                if (str_status == "success")
                {

                    foreach (DataRow drfinal in dtvoucherdata.Rows)
                    {
                        if (drfinal["status"].ToString().ToUpper() == "SUCCESS")
                        {
                            //ViewBag.VoucherCount += "====Brand :" + drfinal["brandname"].ToString();
                            //ViewBag.VoucherCount += "====Amount :" + drfinal["Amount"].ToString();
                            //ViewBag.VoucherCount += "====Expiry: " + drfinal["Expiry"].ToString();
                            //ViewBag.VoucherCount += "====Voucher No :" + drfinal["VoucherNo"].ToString();




                            str_subject = "Gift Card Details Recharge Zap";
                            // str_message = "Brand :" + drfinal["brandname"].ToString() + "<br/>";
                            //str_message += "Amount :" + drfinal["Amount"].ToString() + "<br/>";
                            //str_message += "Expiry :" + drfinal["Expiry"].ToString() + "<br/>";
                            //str_message += "Voucher No :" + drfinal["VoucherNo"].ToString() + "<br/>";
                            str_message = @" <table  style=""width: 800px;margin:20px auto;padding-bottom:20px;box-shadow: 0 9px 12px 10px rgba(0,0,0,.04);border-radius: 10px;background-color: #fff;"">
    <tbody>
        <tr><td style=""background-image: url('https://cdn-media-ie.pearltrees.com/b8/c3/0a/b8c30aa0669dd2a29428bf760871ddd8-l.jpg'); height: 140px;""></td></tr>
        <tr style=""color: #000B30; text-align: center; font-family: Javanese Text; font-size: 50px; font-style: normal; font-weight: 400; line-height: normal;"">
          <td>Enjoy Your Gift!</td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody>
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody style=""display: flex; align-items: center; justify-content: center;"">
                        <tr>
                          <td style=""width: 200px;""><img src=""" + drfinal["brandimage"].ToString() + @""" alt=""brand logo"" style="" width: 100%; height: 100%;"" /></td>
                          <td>
                            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                              <tbody style=""padding: 10px 0 10px 20px; display: block; flex-direction: column; gap: 10px;border-left: 1px solid black;"">
                                  <tr><td><h4 style=""font-family: Inria Serif; font-size: 20px; font-style: normal; font-weight: 700; line-height: normal; margin-bottom: 0;"">Gift Amount:</h4></td></tr>
                                  <tr><td><h1 style="" font-family: Inria Serif; font-size: 48px; font-style: normal; font-weight: 700; line-height: normal;margin: 0 0 15px 0;"">₹" + drfinal["amount"].ToString() + @"</h1></td></tr>
                                  <tr><td><a href="""" style=""border-radius: 5px 20px 20px 5px; border: 1px solid #000; background: #F69C2A;padding: 6px 12px;text-decoration: none;"">Redeem Now &nbsp; <img src=""https://new.rechargezap.in/new2/img/play.png"" alt=""play button"" style=""width: 20px;height: 20px; position: relative;top: 4px;""/></a></td></tr>
                                  <tr><td><h5 style=""  font-family: Inria Serif; font-size: 18px;font-style: normal;font-weight: 400;line-height: normal; margin-bottom: 0;"">Claim Code:</h5></td></tr>
                                  <tr><td><h2 style="" font-family: Inria Serif; font-size: 24px;font-style: normal;font-weight: 600;line-height: normal;margin: 7px 0;"">" + drfinal["voucherno"].ToString() + @"</h2></td></tr>  
                              </tbody>
                            </table>
                          </td>
                        </tr>
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""padding: 32px;  margin: 41px;"">
            <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
              <tbody >
                <tr>
                  <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;padding: 10px;"">
                    <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                      <tbody>
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;padding-bottom: 10px;"">To: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">" + str_email + @"</span></td>
                          <td></td>
                        </tr> 
                        <tr>
                          <td style=""font-family: Inria Serif;font-size: 15px; font-style: normal;font-weight: 400;line-height: normal;padding-bottom: 10px;"">I didn’t know what exactly to get to you so I decided to send you a gift card instead. That way you can get exactly what you want. There must be something you’ve eyeing and you certainly deserve it. </td>
                        </tr> 
                        <tr>
                          <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;text-align: right;"">From: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">Recharge Zap</span></td>
                        </tr>                       
                      </tbody>
                    </table>
                  </td>
                </tr>
              </tbody>
            </table>
          </td>
        </tr>
        <tr>
          <td style=""text-align: center;""><img src=""https://rechargezap.in/new2/img/logo.jpg"" alt=""logo"" style=""width: 100px; height: auto;"" /></td>
        </tr>
    </tbody>
  </table>";
                            ViewBag.MailMessage += str_message;
                            objdata.SendMail(str_email, str_subject, str_message);
                        }
                    }


                    return View("GiftCardStatus", objrecharge);

                }
                else if (str_status == "pending")
                {
                    return View("GiftCardStatusPending", objrecharge);

                }
                else
                {
                    //                  foreach (DataRow drfinal in dtvoucherdata.Rows)
                    //                  {
                    //                      //ViewBag.VoucherCount += "====Brand :" + drfinal["brandname"].ToString();
                    //                      //ViewBag.VoucherCount += "====Amount :" + drfinal["Amount"].ToString();
                    //                      //ViewBag.VoucherCount += "====Expiry: " + drfinal["Expiry"].ToString();
                    //                      //ViewBag.VoucherCount += "====Voucher No :" + drfinal["VoucherNo"].ToString();




                    //                      str_subject = "Gift Card Details Recharge Zap";
                    //                      // str_message = "Brand :" + drfinal["brandname"].ToString() + "<br/>";
                    //                      //str_message += "Amount :" + drfinal["Amount"].ToString() + "<br/>";
                    //                      //str_message += "Expiry :" + drfinal["Expiry"].ToString() + "<br/>";
                    //                      //str_message += "Voucher No :" + drfinal["VoucherNo"].ToString() + "<br/>";
                    //                      str_message = @" <table  style=""width: 800px; margin: 20px auto; background-color: #fff; padding-bottom: 20px;"">
                    //  <tbody>
                    //      <tr><td style=""background-image: url('https://cdn-media-ie.pearltrees.com/b8/c3/0a/b8c30aa0669dd2a29428bf760871ddd8-l.jpg'); height: 140px;""></td></tr>
                    //      <tr style=""color: #000B30; text-align: center; font-family: Javanese Text; font-size: 50px; font-style: normal; font-weight: 400; line-height: normal;"">
                    //        <td>Enjoy Your Gift!</td>
                    //      </tr>
                    //      <tr>
                    //        <td style=""padding: 32px;  margin: 41px;"">
                    //          <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                    //            <tbody >
                    //              <tr>
                    //                <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;"">
                    //                  <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                    //                    <tbody  style=""display: flex; align-items: center; justify-content: center;"">
                    //                      <tr>
                    //                        <td style=""width: 200px; height: 200px;""><img src=""" + drfinal["brandimage"].ToString() + @""" alt=""brand logo"" style="" width: 100%; height: 100%;"" /></td>
                    //                      </tr>
                    //                      <tr style=""padding: 10px 0 10px 20px; display: flex; flex-direction: column; gap: 10px;border-left: 1px solid black;"">
                    //                          <td><h4 style=""font-family: Inria Serif; font-size: 20px; font-style: normal; font-weight: 700; line-height: normal; margin-bottom: 0;"">Gift Amount:</h4></td>
                    //                          <td><h1 style="" font-family: Inria Serif; font-size: 48px; font-style: normal; font-weight: 700; line-height: normal;margin: 0 0 15px 0;"">₹" + drfinal["amount"].ToString() + @"</h1></td>
                    //                          <td><a href="""" style=""border-radius: 5px 20px 20px 5px; border: 1px solid #000; background: #F69C2A;padding: 6px 12px;text-decoration: none;"">Redeem Now &nbsp; <i class=""fa fa-play-circle"" aria-hidden=""true""></i></a></td>
                    //                          <td><h5 style=""  font-family: Inria Serif; font-size: 18px;font-style: normal;font-weight: 400;line-height: normal; margin-bottom: 0;"">Claim Code: </h5></td>
                    //                          <td><h2 style="" font-family: Inria Serif; font-size: 24px;font-style: normal;font-weight: 600;line-height: normal;margin: 7px 0;"">" + drfinal["voucherno"].ToString() + @"</h2></td>  
                    //                      </tr>
                    //                    </tbody>
                    //                  </table>
                    //                </td>
                    //              </tr>
                    //            </tbody>
                    //          </table>
                    //        </td>
                    //      </tr>
                    //      <tr>
                    //        <td style=""padding: 32px;  margin: 41px;"">
                    //          <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                    //            <tbody >
                    //              <tr>
                    //                <td style=""border-radius: 10px; border:1px solid black;  margin: 35px 50px; overflow: hidden;padding: 10px;"">
                    //                  <table cellpadding=""0"" cellspacing=""0"" style=""width:100%"" width=""100%"">
                    //                    <tbody>
                    //                      <tr>
                    //                        <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;padding-bottom: 10px;"">To: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">" + str_email + @"</span></td>
                    //                        <td></td>
                    //                      </tr> 
                    //                      <tr>
                    //                        <td style=""font-family: Inria Serif;font-size: 15px; font-style: normal;font-weight: 400;line-height: normal;padding-bottom: 10px;"">I didn’t know what exactly to get to you so I decided to send you a gift card instead. That way you can get exactly what you want. There must be something you’ve eyeing and you certainly deserve it. </td>
                    //                      </tr> 
                    //                      <tr>
                    //                        <td style=""font-size: 14px; font-style: normal; font-weight: 400; line-height: normal;text-align: right;"">From: <span style=""color: #E37F00; font-family: Inria Serif;font-weight: 700;text-transform: capitalize;"">Recharge Zap</span></td>
                    //                      </tr>                       
                    //                    </tbody>
                    //                  </table>
                    //                </td>
                    //              </tr>
                    //            </tbody>
                    //          </table>
                    //        </td>
                    //      </tr>
                    //      <tr>
                    //        <td style=""text-align: center;""><img src=""https://new.rechargezap.in/new2/img/logo.jpg"" alt=""logo"" style=""width: 100px; height: auto;"" /></td>
                    //      </tr>
                    //  </tbody>
                    //</table>";
                    //                      ViewBag.MailMessage += str_message;
                    //                      objdata.SendMail(str_email, str_subject, str_message);

                    //                  }
                    //return View("GiftCardStatus", objrecharge);
                    return View("GiftCardStatusFailed", objrecharge);

                }

            }
            catch (Exception ep)
            {

                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertError("ParsingPaymentGatewaygiftcard", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
                return View("GiftCardStatusFailed", objrecharge);
            }


            //ViewBag.response1 = formValues;


            //PaytmResponse response = new PaytmResponse();

            //return View("PayUMoneySuccessGiftCard", form);
        }

        public ActionResult PayUMoneyFailedGiftCard()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult PayUMoneyFailedGiftCard(PayUMoneyResponse form)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            string str_message2 = "";
            string str_rechargestatus = "";


            try
            {
                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                str_status = Request.Form["status"].ToString().Trim();
                str_orderid = Request.Form["txnid"].ToString().Trim();
                foreach (string key in Request.Form.Keys)
                {

                    str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
                }
                if (str_status == "success")
                {

                    var mercHashVarsSeq = hashSeq.Split('|');
                    Array.Reverse(mercHashVarsSeq);
                    var mercHashString = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI" + "|" + Request.Form["status"].ToString().Trim();

                    foreach (var mercHashVar in mercHashVarsSeq)
                    {
                        mercHashString += "|";
                        mercHashString = mercHashString + Request.Form[mercHashVar].ToString();

                    }
                    var mercHash = Generatehash512(mercHashString).ToLower();

                    if (mercHash != Request.Form["hash"].ToString())
                    {
                        str_message2 = "Hash value did not matched";
                        str_status = "failure";

                    }
                    else
                    {
                        str_message2 = "Hash value matched";
                        str_status = Request.Form["status"].ToString();
                        //if (VerifyPayment(str_orderid, Request.Form["mihpayid"].ToString()))
                        //{
                        //    str_message2 = "Payment Verification Success";
                        //    str_status = "success";
                        //}
                        //else
                        //{
                        //    str_message2 = "Payment Verification Failed";
                        //    str_status = "failed";
                        //}


                    }
                }
                else
                {
                    str_message2 = "payment failed";
                    str_status = Request.Form["status"].ToString();
                }
                //ViewBag.response1 = formValues;
                if (str_status.ToLower() == "failure")
                {
                    str_status = "failed";
                }

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.ReferenceId = str_orderid;
                objrecharge.Status = str_status;
                objrecharge.Message = str_message2;
                objrecharge.PaymentGatewayResponse = str_response;
                string str_operatorname = "";
                string str_username = "";
                string str_processingcharge = "";
                string str_liveid = "";
                string str_mail = "";
                DataTable dt = new DataTable();
                dt = objrecharge.UpdateGiftCardInitiate(objrecharge);
                string str_token = "";

                ViewBag.PaymentGayewayResponse = str_response;
                ViewBag.PaymentStatus = str_status;
                ViewBag.ActionName = "FailedAction";
                objrecharge.Status = "Failed";
                objrecharge.ReferenceId = "Technical Error";
                objrecharge.Message = "Technical Error On Updating Request";
                objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                objrecharge.StatusImage = "fail.png";




                Data objdata = new Data();
                string str_subject = "";
                string str_message = "";



                if (str_status == "Success")
                {
                    return View("GiftCardStatus", objrecharge);

                }
                else if (str_status == "Pending")
                {
                    return View("GiftCardStatusPending", objrecharge);

                }
                else
                {
                    return View("GiftCardStatusFailed", objrecharge);

                }

            }
            catch (Exception ep)
            {
                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertError("ParsingPaymentGateway", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
            }


            //ViewBag.response1 = formValues;


            //PaytmResponse response = new PaytmResponse();

            return View("PayUMoneySuccess", form);
        }


        public ActionResult PayUMoneyWebhook()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult PayUMoneyWebhook(PayUMoneyResponse form)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            string str_message2 = "";


            try
            {
                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                str_status = Request.Form["status"].ToString().Trim();
                str_orderid = Request.Form["txnid"].ToString().Trim();
                foreach (string key in Request.Form.Keys)
                {

                    str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
                }


                //Stream req = Request.InputStream;
                //req.Seek(0, System.IO.SeekOrigin.Begin);
                //string json = new StreamReader(req).ReadToEnd();


                //HttpResponseMessage response = new HttpResponseMessage();
                //response.Content = new StringContent("Your message to me was: " + value);

                //str_response += response.Content;

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertPayuWebhooklog(str_response, "Online");
                this.HttpContext.Response.StatusCode = 200;
                //return View("PayUMoneyWebhook");
                return View();
                //return (Microsoft.AspNetCore.Http.StatusCodes.Status200OK);
            }
            catch (Exception ep)
            {
                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                // objrecharge.InsertError("ParsingPayuMoneyWebhook", ep.Message.ToString(), "ParsingPayuMoneyWebhook", "", "", str_orderid, "");
            }


            //ViewBag.response1 = formValues;


            //PaytmResponse response = new PaytmResponse();

            //return View("PayUMoneyWebhook", form);
            return View();
        }

        public ActionResult PayUMoneyFailed()
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            return View();
        }
        [HttpPost]
        public ActionResult PayUMoneyFailed(PayUMoneyResponse form)
        {
            ViewBag.logo1 = @"<a href=""/"" class=""logo"">
                            <img src=""../images/logo.png"" style=""max-height: 50px;"" />
                        </a>";
            ViewBag.MyAccount = @"<a onclick=""showModalLoginEmail();""  id=""spanuserlogin""   style=""color: #000 !important; margin:auto""><i class=""ti-user mr-2""></i> Login</a>";
            string str_loginemail = HttpContext.Session.GetString("LoginEmail");
            if (str_loginemail != null)
            {
                ViewBag.loginlink = @"   <div class=""head-wallet h-flex"">
                <a href=""#!"">
                <div class=""wallet-img"">
                  <img src=""/new2/img/wallet-head.png"" alt="""">
                </div>
                <div class=""wallet-cont"">
                  <p><i class=""fa-solid fa-indian-rupee-sign""></i><span id=""userbalancetop"">0</span></p>
                  <span>Wallet Balance</span>
                </div>
              </a>
              </div>
              <div class=""head-signin h-flex"">
                <div class=""sign-img"">
                  <img src=""/new2/img/user.png"" alt="""">
                </div>
                <div class=""sign-cont"">
                  <p>My Account <i class=""fa-solid fa-chevron-down""></i></p>
                  <div class=""sign-menu"">
                    <div class=""sign-menu-inner"">
                      <a href=""/Home/Profile""><i class=""fa-solid fa-chevron-right""></i> My Profile</a>
                      <a href=""/home/RechargeHistory""><i class=""fa-solid fa-chevron-right""></i> Order History</a>
                      <a href=""/Home/TransactionHistory""><i class=""fa-solid fa-chevron-right""></i> Transaction History</a>
                      <a href=""/Home/Test""><i class=""fa-solid fa-chevron-right""></i> Log Out</a>
                    </div>
                  </div>
                </div>
              </div>";

                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                   
                    <li class=""mobile-item active"">
                        <a href=""/Home/Dashboard"">
                            <span>
                                <img src=""/new2/img/dashboard/home.png"" alt=""Home"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/home.png"" alt=""Home"" class=""dash-active"">
                            </span>
                            <span>Dashboard</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Profile"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>My Profile</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"" class=""mobile-item-dropdown"">
                            <span>
                                <img src=""/new2/img/dashboard/services.png"" alt=""Services"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/services.png"" alt=""Services"" class=""dash-active"">
                            </span>
                            <span>My Services</span>
                            <i class=""fa-solid fa-chevron-down""></i>
                        </a>
                        <div class=""item-dropdown"">
                            <a href=""/Home/recharge""><img src=""/new2/img/icon/mobile-phone.png"" alt=""Recharge"" /> <span>Recharge</span></a>
                            <a href=""/Home/dth""><img src=""/new2/img/icon/television.png"" alt=""DTH"" /> <span>DTH</span></a>
                            <a href=""/Home/landline""><img src=""/new2/img/icon/landlinee.png"" alt=""Landline"" /> <span>landline</span></a>
                            <a href=""/Home/broadband""><img src=""/new2/img/icon/internet.png"" alt=""Broadband"" /> <span>Broadband</span></a>
                            <a href=""/Home/cylinder""><img src=""/new2/img/icon/gas-tank.png"" alt=""Cylinder"" /> <span>Cylinder</span></a>
                            <a href=""/Home/gas""><img src=""/new2/img/icon/stove.png"" alt=""Piped Gas"" /> <span>Piped Gas</span></a>
                            <a href=""/Home/electricity""><img src=""/new2/img/icon/light-bulb.png"" alt=""Electricity"" /> <span>Electricity</span></a>
                            <a href=""/Home/water""><img src=""/new2/img/icon/water-tap.png"" alt=""Water"" /> <span>Water</span></a>
                            <a href=""/Home/fastag""><img src=""/new2/img/icon/toll.png"" alt=""Fastag"" /> <span>FASTag</span></a>
                        </div>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/rechargehistory"">
                            <span>
                                <img src=""/new2/img/dashboard/order.png"" alt=""Order"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/order.png"" alt=""Order"" class=""dash-active"">
                            </span>
                            <span>Order History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""transactionhistory"">
                            <span>
                                <img src=""/new2/img/dashboard/transaction.png"" alt=""Transaction"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/transaction.png"" alt=""Transaction"" class=""dash-active"">
                            </span>
                            <span>Transaction History</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/gift-card.png"" alt=""Gift"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/gift-card.png"" alt=""Gift"" class=""dash-active"">
                            </span>
                            <span>Gift Cards</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""#"">
                            <span>
                                <img src=""/new2/img/dashboard/offers.png"" alt=""Offers"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/offers.png"" alt=""Offers"" class=""dash-active"">
                            </span>
                            <span>Offers & Deals</span>
                        </a>
                    </li>
                    <li class=""mobile-item"">
                        <a href=""/Home/Logout2"">
                            <span>
                                <img src=""/new2/img/dashboard/logout.png"" alt=""Logout"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/logout.png"" alt=""Logout"" class=""dash-active"">
                            </span>
                            <span>Logout</span>
                        </a>
                    </li>
                </ul>";

            }
            else
            {
                ViewBag.loginlink = @"<div class=""head-signin h-flex sign-in-main"" onclick=""showModalLoginEmail();"">
                                <div class=""sign-img"">
                                    <span><i class=""fa-solid fa-circle-user""></i></span>
                                </div>
                                <div class=""sign-cont sign-in"">
                                    <p>Sign In <i class=""fa-solid fa-chevron-down""></i></p>
                                </div>
                            </div>";
                ViewBag.loginlinkmobile = @"<ul class=""mobile-link"">
                    <li class=""mobile-item"">
                        <a onclick=""showModalLoginEmail();"">
                            <span>
                                <img src=""/new2/img/dashboard/profile.png"" alt=""Profile"" class=""dash-inactive"">
                                <img src=""/new2/img/dashboard/active/profile.png"" alt=""Profile"" class=""dash-active"">
                            </span>
                            <span>Sign In</span>
                        </a>
                    </li>
                    
                </ul>";
            }
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            string str_message2 = "";


            try
            {
                const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

                str_status = Request.Form["status"].ToString().Trim();
                str_orderid = Request.Form["txnid"].ToString().Trim();
                foreach (string key in Request.Form.Keys)
                {

                    str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
                }
                if (str_status == "success")
                {

                    var mercHashVarsSeq = hashSeq.Split('|');
                    Array.Reverse(mercHashVarsSeq);
                    var mercHashString = "B4IomR0EQvrJKdqMc7qGhVklsz9OFBqI" + "|" + Request.Form["status"].ToString().Trim();

                    foreach (var mercHashVar in mercHashVarsSeq)
                    {
                        mercHashString += "|";
                        mercHashString = mercHashString + Request.Form[mercHashVar].ToString();

                    }
                    var mercHash = Generatehash512(mercHashString).ToLower();

                    if (mercHash != Request.Form["hash"].ToString())
                    {
                        str_message2 = "Hash value did not matched";
                        str_status = "failure";

                    }
                    else
                    {
                        str_message2 = "Hash value  matched";
                        str_status = Request.Form["status"].ToString();
                    }
                }
                else
                {
                    str_message2 = "payment failed";
                    str_status = Request.Form["status"].ToString();
                }
                //ViewBag.response1 = formValues;
                if (str_status.ToLower() == "failure")
                {
                    str_status = "failed";
                }

                clsRecharge objrecharge = new clsRecharge();
                objrecharge.ReferenceId = str_orderid;
                objrecharge.Status = str_status;
                objrecharge.Message = str_message2;
                objrecharge.PaymentGatewayResponse = str_response;
                string str_operatorname = "";
                string str_username = "";
                string str_processingcharge = "";
                string str_liveid = "";
                string str_mail = "";
                DataTable dt = new DataTable();
                dt = objrecharge.UpdateRechargeInitiate(objrecharge);
                string res = "";
                if (dt.Rows.Count > 0)
                {
                    objrecharge.PaymentGatewayAmount = Convert.ToDecimal(dt.Rows[0]["PaymentGatewayAmount"].ToString());
                    objrecharge.ProcessingCharge = Convert.ToDecimal(dt.Rows[0]["ProcessingCharge"].ToString());
                    objrecharge.PaymentGatewayOrderid = str_orderid;
                    objrecharge.OperatorName = dt.Rows[0]["operator"].ToString();
                    str_operatorname = dt.Rows[0]["operator"].ToString();
                    str_username = dt.Rows[0]["username"].ToString();
                    str_processingcharge = dt.Rows[0]["ProcessingCharge"].ToString();
                    str_mail = dt.Rows[0]["email"].ToString();
                    ViewBag.PaymentGatewayAmount = dt.Rows[0]["PaymentGatewayAmount"].ToString();
                    ViewBag.PaymentGatewayOrderid = dt.Rows[0]["referenceid"].ToString();
                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    res = dt.Rows[0][0].ToString();
                    //if (str_status == "success")
                    //{

                    //    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    //    objrecharge.PaymentGatewayAmount = Convert.ToDecimal(dt.Rows[0]["PaymentGatewayAmount"].ToString());
                    //    objrecharge.OperatorCode = dt.Rows[0]["operatorid"].ToString();
                    //    objrecharge.UserMobile = dt.Rows[0]["usermobile"].ToString();
                    //    objrecharge.Email = dt.Rows[0]["email"].ToString();
                    //    objrecharge.Mobile = dt.Rows[0]["usermobile"].ToString();
                    //    objrecharge.UserName = dt.Rows[0]["username"].ToString();
                    //    objrecharge.PaymentGatewayOrderid = dt.Rows[0]["referenceid"].ToString();
                    //    objrecharge.RechargeType = "PaymentGateway";



                    //    DataTable dtrecharge = new DataTable();
                    //    dtrecharge = objrecharge.RechargeNew(objrecharge);
                    //    if (dtrecharge.Rows.Count > 0)
                    //    {

                    //        objrecharge.Status = dtrecharge.Rows[0]["status"].ToString();
                    //        objrecharge.ReferenceId = dtrecharge.Rows[0]["ReferenceId"].ToString();
                    //        objrecharge.RechargeMobile = dtrecharge.Rows[0]["RechargeMobile"].ToString();
                    //        objrecharge.RechargeAmount = Convert.ToDecimal(dtrecharge.Rows[0]["Amount"].ToString());
                    //        objrecharge.Message = dtrecharge.Rows[0]["message"].ToString();
                    //        objrecharge.RechargeDate = dtrecharge.Rows[0]["RechargeDate"].ToString();
                    //        objrecharge.StatusImage = dtrecharge.Rows[0]["image"].ToString();
                    //        objrecharge.LiveId = dtrecharge.Rows[0]["LiveId"].ToString();

                    //        //response.Status = dt.Rows[0]["status"].ToString();
                    //        //response.ReferenceId = dt.Rows[0]["referenceid"].ToString();
                    //        //response.Mobile = dt.Rows[0]["RechargeMobile"].ToString();
                    //        //response.Amount =dt.Rows[0]["Amount"].ToString();
                    //        //response.Status = dt.Rows[0]["message"].ToString();



                    //    }
                    //    else
                    //    {
                    //        objrecharge.Status = "Failed";
                    //        objrecharge.ReferenceId = "Technical Error";
                    //        objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    //        objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    //        objrecharge.Message = "Technical Error";
                    //        objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    //        objrecharge.StatusImage = "fail.png";
                    //    }
                    //}
                    //else
                    //{
                    objrecharge.Status = "Failed";
                    objrecharge.ReferenceId = "Payment Failed";
                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    objrecharge.Message = "Payment Failed";
                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    objrecharge.StatusImage = "fail.png";
                    objrecharge.Email = str_mail;
                    //}
                }
                else
                {
                    objrecharge.Email = str_mail;
                    objrecharge.Status = "Failed";
                    objrecharge.ReferenceId = "Technical Error";
                    objrecharge.RechargeMobile = dt.Rows[0]["rechargemobile"].ToString();
                    objrecharge.RechargeAmount = Convert.ToDecimal(dt.Rows[0]["rechargeamount"].ToString());
                    objrecharge.Message = "Technical Error On Updating Request";
                    objrecharge.RechargeDate = System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    objrecharge.StatusImage = "fail.png";

                    res = "-1";
                }
                Data objdata = new Data();
                string str_subject = "";
                string str_message = "";

                try
                {

                    if (str_status == "success")
                    {
                        if (objrecharge.Status == "Success")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Successful";
                            str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.LiveId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Success</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any queries or support you can recah out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                        else if (objrecharge.Status == "Pending")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Pending";
                            str_message = @"<td width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;border-bottom:1px solid #edeff2;border-top:1px solid #edeff2;margin:0;padding:0;width:100%"">
                            <table align=""center"" width=""570"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;background-color:#ffffff;margin:0 auto;padding:0;width:570px"">
<tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;padding:35px"">
                                        <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Dear " + str_username + @",</p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left""></p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<div style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<table style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;background-color:#edf4fb;padding:13px;margin-bottom:5px!important;margin:30px auto;width:100%"">
<thead style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tr>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
<th align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;border-bottom:1px solid #edeff2;padding-bottom:8px;margin:0;display:none""></th>
</tr></thead>
<tbody style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Name</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_username + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_operatorname + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Number</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.RechargeMobile + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Order ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Operator Ref. ID</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + str_liveid + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Payment Type</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Online</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Date & Time</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Amount</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Amount Paid</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
  <tr>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Recharge Status</td>
<td align=""left"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:15px;line-height:18px;padding:10px 0;margin:0"">Pending</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:16px;line-height:1.5em;margin-top:0;text-align:center"">**Payment Is Inclusive of GST **</p>
<table align=""center"" width=""100%"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;margin:30px auto;padding:0;text-align:center;width:100%""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
            <table width=""100%"" border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td align=""center"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                        <table border=""0"" cellpadding=""0"" cellspacing=""0"" style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box""><tbody><tr>
<td style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box"">
                                </td>
                            </tr></tbody></table>
</td>
                </tr></tbody></table>
</td>
    </tr></tbody></table>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:justify""> Your recharge is pending due to some technical issue at the operator's end. If you do not receive your recharge in the next 30 minutes, please contact our customer support helpdesk at <a>care@rechargezap.in</a></p><br>

  <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p><br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Here to help :)</p> <br>
<p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393737;font-size:16px;line-height:1.5em;margin-top:0;text-align:left"">Thanks & Regards<br>
RechargeZap Team</p><br>
 <br><br><br><br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#74787e;font-size:10px;line-height:1.5em;margin-top:0;text-align:center"">
This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>

  <br><br> <p style=""font-family:Avenir,Helvetica,sans-serif;box-sizing:border-box;color:#393838;font-size:11px;line-height:1.5em;margin-top:0;text-align:center"">
©RechargeZap 2022. All Rights Reserved.</p>

 
                                    </td>
                                </tr>
</tbody></table>
</td>
";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                        else if (objrecharge.Status == "Failed")
                        {
                            str_subject = "Recharge of " + str_operatorname + " " + objrecharge.RechargeMobile + " for Rs." + objrecharge.RechargeAmount + " is Failed";
                            str_message = @"<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; background-color: #ffffff; margin: 0 auto; padding: 0; width: 570px;"" width=""570"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; padding: 35px;"">
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Dear " + str_username + @",</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thank you for using RechargeZap.in. Please find your transaction details below.</p>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">&nbsp;</p>
<div class=""m_1308194265162116072mail-table-ctn"" style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<div style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; background-color: #edf4fb; padding: 13px; margin-bottom: 5px!important; margin: 30px auto; width: 100%;"">
<thead style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
<th style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; border-bottom: 1px solid #edeff2; padding-bottom: 8px; margin: 0; display: none;"" align=""left"">&nbsp;</th>
</tr>
</thead>
<tbody style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Name</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_username + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + str_operatorname + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Operator Number</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.RechargeMobile + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Order ID</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + objrecharge.ReferenceId + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Payment Type</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Online</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Date &amp; Time</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">" + System.DateTime.Now.ToString("dd/MM/yyyy hh:mm tt") + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Amount</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + objrecharge.RechargeAmount.ToString() + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Amount Paid</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Rs." + (objrecharge.RechargeAmount + Convert.ToDecimal(str_processingcharge)).ToString() + @"</td>
</tr>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Recharge Status</td>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 15px; line-height: 18px; padding: 10px 0; margin: 0;"" align=""left"">Failed</td>
</tr>
</tbody>
</table>
</div>
</div>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: center;"">**Payment Is Inclusive of GST **</p>
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; margin: 30px auto; padding: 0; text-align: center; width: 100%;"" width=""100%"" cellspacing=""0"" cellpadding=""0"" align=""center"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" width=""100%"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" align=""center"">
<table style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"" border=""0"" cellspacing=""0"" cellpadding=""0"">
<tbody>
<tr>
<td style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box;"">&nbsp;</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Your recharge has failed due to some technical issue at the operator's end. Your amount has been refunded back to your wallet in the form of eCash, you can use your wallet balance to make a new recharge.</p>
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: justify;"">Login to your <a href=""https://rechargezap.in"">RechargeZap</a> account to view transaction history, check avilable eCash balance and much more.</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">For any other queries or support you can reach out to our customer care at <a>care@rechargezap.in</a></p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Here to help :)</p>
<br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393737; font-size: 16px; line-height: 1.5em; margin-top: 0; text-align: left;"">Thanks &amp; Regards<br />RechargeZap Team</p>
<br /><br /><br /><br /><br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #74787e; font-size: 10px; line-height: 1.5em; margin-top: 0; text-align: center;"">This is a system generated mail. Please do not reply to this email address. If you have a query or need any support, please reach out to our customer support team at care@rechargezap.in.</p>
<br /><br />
<p style=""font-family: Avenir,Helvetica,sans-serif; box-sizing: border-box; color: #393838; font-size: 11px; line-height: 1.5em; margin-top: 0; text-align: center;"">&copy;RechargeZap 2022. All Rights Reserved.</p>
</td>
</tr>
</tbody>
</table>

";
                            objdata.SendMail(str_mail, str_subject, str_message);
                        }
                    }
                }
                catch (Exception ep)
                {
                    //clsRecharge objrecharge = new clsRecharge();
                    ViewBag.errortext = ep.Message.ToString();
                    objrecharge.InsertError("sendingRechargeEmail", ep.Message.ToString(), "SendingRechargeEmail", "", str_orderid, "", objrecharge.ReferenceId);
                }
                return View("RechargeStatusFailed", objrecharge);

            }
            catch (Exception ep)
            {
                ViewBag.errortext = ep.Message.ToString();
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.InsertError("ParsingPaymentGateway", ep.Message.ToString(), "ParsingPaymentGateway", "", "", str_orderid, "");
            }


            //ViewBag.response1 = formValues;


            //PaytmResponse response = new PaytmResponse();

            return View("PayUMoneyFailed", form);
        }


        public string Generatehash512(string text)
        {
            var message = Encoding.UTF8.GetBytes(text);
            var hashString = new SHA512Managed();
            var hashValue = hashString.ComputeHash(message);
            return hashValue.Aggregate("", (current, x) => current + $"{x:x2}");
        }


        public string Generatetxnid()
        {
            var rnd = new Random();

            DateTime dt = DateTime.Now;

            //getting Milliseconds only from the currenttime
            int ms = dt.Millisecond;
            int card = rnd.Next(52);
            var strHash = Generatehash512(rnd.ToString() + DateTime.Now + dt.Millisecond.ToString() + card.ToString());
            var txnid1 = strHash.Substring(0, 20);
            return txnid1;
        }
    }



}
public class RemotePost
{
    private System.Collections.Specialized.NameValueCollection Inputs = new System.Collections.Specialized.NameValueCollection();

    private readonly IHttpContextAccessor _httpContextAccessor;


    public RemotePost(IHttpContextAccessor httpContextAccessor)
    {

        _httpContextAccessor = httpContextAccessor;
    }

    public string Url = "";
    public string Method = "post";
    public string FormName = "form1";

    public void Add(string name, string value)
    {
        Inputs.Add(name, value);
    }



    public void Post()
    {
        var context = _httpContextAccessor.HttpContext;



        context.Response.Clear();

        context.Response.WriteAsync("<html><head>");

        context.Response.WriteAsync(string.Format("</head><body onload=\"document.{0}.submit()\">", FormName));
        context.Response.WriteAsync(string.Format("<form name=\"{0}\" method=\"{1}\" action=\"{2}\" >", FormName, Method, Url));
        for (int i = 0; i < Inputs.Keys.Count; i++)
        {
            context.Response.WriteAsync(string.Format("<input name=\"{0}\" type=\"hidden\" value=\"{1}\">", Inputs.Keys[i], Inputs[Inputs.Keys[i]]));
        }
        context.Response.WriteAsync("</form>");
        context.Response.WriteAsync("</body></html>");

        //context.Response.end();
    }
}