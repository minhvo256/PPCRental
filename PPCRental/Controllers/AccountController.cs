using Model.EF;
using Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
namespace PPCRental.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        // GET: /Account/Register
        [HttpGet]
        public ActionResult Register()
        {
            USER userModel = new USER();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult Register(USER userModel)
        {
            using (PPCRentalDB m = new PPCRentalDB())
            {
                if (m.USERs.Any(x => x.Email == userModel.Email))
                {
                    ViewBag.DuplicateMessage = "Email already exist";
                    return View("Register", userModel);
                }
                userModel.Password = hashPwd(userModel.Password);
                Console.WriteLine(userModel.Password);
                m.USERs.Add(userModel);
                m.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful";
            return View("Register", new USER());
        }

        private string hashPwd(string pwd)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pwd));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();

        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Model.EF.USER model)
        {
            //if (ModelState.IsValid)
            //{
            //    var acc = new UserDB();
            //    var result = acc.Login(model.username, model.password);
            //    if (result)
            //    {
            //        var user = acc.GetByID(model.username);
            //        var userSession = new UserLogin();
            //        userSession.UserName = user.Email;
            //        userSession.UserID = user.ID;
            //        Session.Add(CommonConstraints.USER_SESSION, userSession);
            //        return RedirectToAction("Index", "/HomeAdmin/Index");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "wrong");
            //    }
            //}
            //else
            //{
            //    ModelState.AddModelError("", "wrong");
            //}
            return View("Index");

        }
    }
}