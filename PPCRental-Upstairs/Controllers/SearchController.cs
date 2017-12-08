using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Upstairs.Models;

namespace PPCRental_Upstairs.Controllers
{
    public class SearchController : Controller
    {
        DemoPPCRentalEntities model = new DemoPPCRentalEntities();
        // GET: Search
        public ActionResult Index(string text)
        {
            var p = model.PROPERTies.ToList().Where(x => x.PropertyName.ToUpper().Contains(text.ToUpper())
               || x.ID.ToString().ToUpper().Contains(text.ToUpper()) || x.Content.ToUpper().Contains(text.ToUpper()));

            return View(p);
        }
    }
}