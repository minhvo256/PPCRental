using Models.framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPCRental.Controllers
{
    public class HomePageController : Controller
    {

        PPCRentalDB db = new PPCRentalDB();
        // GET: HomePage
        public ActionResult Index()
        {
            var p = db.PROPERTies.OrderByDescending(x => x.ID).ToList();
            return View(p);
        }
        [HttpPost]
        public ActionResult Search (string text)
        {
            var product = db.PROPERTies.ToList().Where(x => x.PropertyName.ToUpper().Contains(text.ToUpper())
           || x.ID.ToString().ToUpper().Contains(text.ToUpper()) || x.Content.ToUpper().Contains(text.ToUpper()));
            return View(product);
        }
    }
}