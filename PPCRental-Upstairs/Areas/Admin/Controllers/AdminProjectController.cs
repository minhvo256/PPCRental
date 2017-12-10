using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PPCRental_Upstairs.Models;

namespace PPCRental_Upstairs.Areas.Admin.Controllers
{
    public class AdminProjectController : Controller
    {
        DemoPPCRentalEntities model = new DemoPPCRentalEntities();
        // GET: Admin/AdminProject
        public ActionResult Index()
        {
            var product = model.PROPERTies.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            ViewBag.product_type = model.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.ward = model.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.street = model.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.district = model.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            ViewBag.product_status = model.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            ViewBag.user = model.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.sale = model.USERs.OrderByDescending(x => x.ID).ToList();
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(int id, PROPERTY p)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
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

            model.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.product_type = model.PROPERTY_TYPE.OrderByDescending(x => x.ID).ToList();
            ViewBag.ward = model.WARDs.OrderByDescending(x => x.ID).ToList();
            ViewBag.street = model.STREETs.OrderByDescending(x => x.ID).ToList();
            ViewBag.district = model.DISTRICTs.OrderByDescending(x => x.ID).ToList();
            ViewBag.product_status = model.PROJECT_STATUS.OrderByDescending(x => x.ID).ToList();
            ViewBag.user = model.USERs.OrderByDescending(x => x.ID).ToList();
            ViewBag.sale = model.USERs.OrderByDescending(x => x.ID).ToList();
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

            model.PROPERTies.Add(product);
            model.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            model.PROPERTies.Remove(product);
            model.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Details(int id)
        {
            var product = model.PROPERTies.FirstOrDefault(x => x.ID == id);
            return View(product);
        }
    }
}