using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Upstairs.Models;

namespace PPCRental.Areas.Admin.Controllers
{
    public class ProductAdminController : Controller
    {
        DemoPPCRentalEntities db = new DemoPPCRentalEntities();
        // GET: Admin/ProductAdmin
        public ActionResult Index()
        {
            var product = db.PROPERTies.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            ViewBag.product_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.ward = db.WARDs.OrderByDescending(x => x.ID ).ToList();
            ViewBag.street = db.STREETs.OrderByDescending(x => x.ID ).ToList();
            ViewBag.district = db.DISTRICTs.OrderByDescending(x => x.ID ).ToList();
            ViewBag.product_status = db.PROJECT_STATUS.OrderByDescending(x => x.ID ).ToList();
            ViewBag.user = db.USERs.OrderByDescending(x => x.ID ).ToList();
            ViewBag.sale = db.USERs.OrderByDescending(x => x.ID ).ToList();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id,PROPERTY p)
        {
            var product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            product.PropertyName = p.PropertyName;
            product.Avatar = p.Avatar;
            product.Images = p.Images;
            product.PropertyType_ID = p.PropertyType_ID;
            product.Content = p.Content;
            product.Street_ID = p.Street_ID;
            product.Ward_ID = p.Ward_ID;
            product.District_ID = p.District_ID;
            product.Price = p.Price;
            product.UnitPrice = p.UnitPrice;
            product.Area = p.Area;
            product.BedRoom = p.BedRoom;
            product.BathRoom = p.BathRoom;
            product.UserID = p.UserID;
            product.PackingPlace = p.PackingPlace;
            product.Created_at = p.Created_at;
            product.Create_post = p.Create_post;
            product.Status_ID = p.Status_ID;
            product.Note = p.Note;
            product.Updated_at = p.Updated_at;
            product.Sale_ID = p.Sale_ID;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.product_type = db.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.ward = db.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.street = db.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.district = db.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            ViewBag.product_status = db.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            ViewBag.user = db.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.sale = db.USERs.OrderByDescending(x => x.ID).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(PROPERTY p)
        {
            var product = new PROPERTY();
            product.PropertyName = p.PropertyName;
            product.Avatar = p.Avatar;
            product.Images = p.Avatar;
            product.PropertyType_ID = p.PropertyType_ID;
            product.Content = p.Content;
            product.Street_ID = p.Street_ID;
            product.Ward_ID = p.Ward_ID;
            product.District_ID = p.District_ID;
            product.Price = p.Price;
            product.UnitPrice = p.UnitPrice;
            product.Area = p.Area;
            product.BedRoom = p.BedRoom;
            product.BathRoom = p.BathRoom;
            product.UserID = p.UserID;
            product.PackingPlace = p.PackingPlace;
            product.Created_at = p.Created_at;
            product.Create_post = p.Create_post;
            product.Status_ID = p.Status_ID;
            product.Note = p.Note;
            product.Updated_at = p.Updated_at;
            product.Status_ID = p.Status_ID;
           
            db.PROPERTies.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            db.PROPERTies.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            var product = db.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}