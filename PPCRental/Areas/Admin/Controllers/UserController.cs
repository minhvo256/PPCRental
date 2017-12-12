using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DB;
using PagedList;
using Model.EF;

namespace PPCRental.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index(int page=1, int size=5)
        {
            var acc = new UserDB();
            var model = acc.ListAll(page, size);
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var acc = new UserDB().ViewDetail(id);
            return View(acc);

        }
    }
}