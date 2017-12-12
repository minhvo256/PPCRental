using PPCRental.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using PPCRental.Areas.Admin.CodeS;
using Model.DB;
using PPCRental.Common;

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
            if (ModelState.IsValid)
            {
                var acc = new UserDB();
                var result = acc.Login(model.username, model.password);
                if (result)
                {
                    var user = acc.GetByID(model.username);
                    var userSession = new UserLogin();
                    userSession.UserName = user.Email;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstraints.USER_SESSION, userSession);
                    return RedirectToAction("Index", "/HomeAdmin/Index");
                }
                else
                {
                    ModelState.AddModelError("", "wrong");
                }
            }
            else
            {
                ModelState.AddModelError("", "wrong");
            }
            return View("Index");
        }
    }
}