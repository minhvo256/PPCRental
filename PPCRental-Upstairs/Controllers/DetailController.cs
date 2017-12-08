using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Upstairs.Models;

namespace PPCRental_Upstairs.Controllers
{
    public class DetailController : Controller
    {
        DemoPPCRentalEntities m = new DemoPPCRentalEntities();
        // GET: Detail
        public ActionResult Detail(int id, string name)
        {
            var p = m.PROPERTies.FirstOrDefault(x => x.ID == id || x.PropertyName == name);
            return View(p);
        }
    }
}