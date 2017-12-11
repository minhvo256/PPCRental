using Models.framwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PPCRental.Controllers
{
    public class DetailController : Controller
    {
        PPCRentalDB db = new PPCRentalDB();
        // GET: Detail
        public ActionResult Detail(int id, string name)
        {
            var p = db.PROPERTies.FirstOrDefault(x => x.ID == id || x.PropertyName == name);
            ViewBag.street = db.STREETs.FirstOrDefault(x => x.ID == id);
            ViewBag.district = db.DISTRICTs.FirstOrDefault(x => x.ID == id);
            ViewBag.ward = db.WARDs.FirstOrDefault(x => x.ID == id);
            return View(p);
  
        }
    }
}