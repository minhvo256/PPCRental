using PPCRental.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using PPCRental.Areas.Admin.CodeS;

namespace PPCRental.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new UserModel().Login(model.username, model.password);

            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { username = model.username });
                return RedirectToAction("Index", "HomeAdmin");
            }
            else
            {
                ModelState.AddModelError("", "wrong email or password");
            }
            return View(model);
        }
    }
}