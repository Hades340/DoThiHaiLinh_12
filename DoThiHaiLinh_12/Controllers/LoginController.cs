using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoThiHaiLinh_12.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Index(string userName, string passWord)
        {
            if (userName == "Admin" && passWord == "123456")
            {
                Session["Name"] = "Admin";
                return RedirectToAction("Chosse", "Login");
            }
            return View();
        }
        public ActionResult Chosse()
        {
            if(Session["Name"] != null)
            {
                return View();
            }
            return RedirectToAction("Index", "Login");
        }
    }
}