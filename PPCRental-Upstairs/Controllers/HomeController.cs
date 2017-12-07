using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Upstairs.Models;


namespace PPCRental_Upstairs.Controllers
{
    
    public class HomeController : Controller
    {
        DemoPPCRentalEntities model = new DemoPPCRentalEntities();
        public ActionResult Index()
        {
            var p = model.PROPERTies.ToList();
            return View(p);
        }
      }
}