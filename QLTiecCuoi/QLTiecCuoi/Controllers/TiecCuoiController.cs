using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLTiecCuoi.Models;

namespace QLTiecCuoi.Controllers
{
    public class TiecCuoiController : Controller
    {
        private QLyTiecCuoiEntities db = new QLyTiecCuoiEntities();

        // GET: TiecCuois
        public ActionResult Index()
        {
            var tiecCuois = db.TiecCuois.Include(t => t.Sanh);
            return View(tiecCuois.ToList());
        }

        // GET: TiecCuois/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiecCuoi tiecCuoi = db.TiecCuois.Find(id);
            if (tiecCuoi == null)
            {
                return HttpNotFound();
            }
            return View(tiecCuoi);
        }

        // GET: TiecCuois/Create
        public ActionResult Create()
        {
            ViewBag.MaSanh = new SelectList(db.Sanhs, "MaSanh", "TenSanh");
            return View();
        }

        // GET: TiecCuois/Edit/5
        public ActionResult Edit(/*string id*/)
        {
            /*if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiecCuoi tiecCuoi = db.TiecCuois.Find(id);
            if (tiecCuoi == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaSanh = new SelectList(db.Sanhs, "MaSanh", "TenSanh", tiecCuoi.MaSanh);*/
            return View();
        }



        // GET: TiecCuois/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TiecCuoi tiecCuoi = db.TiecCuois.Find(id);
            if (tiecCuoi == null)
            {
                return HttpNotFound();
            }
            return View(tiecCuoi);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        // Partial view
        public PartialViewResult ShowAllMeal()
        {
            
            return PartialView("PartialMealCheckboxs", db.MonAns);
        }
        public PartialViewResult ShowAllDV()
        {
            return PartialView("PartialDVCheckboxs", db.DichVus);
        }
    }
}
