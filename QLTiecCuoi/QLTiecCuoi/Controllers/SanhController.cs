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
    public class SanhController : Controller
    {
        private QLyTiecCuoiEntities db = new QLyTiecCuoiEntities();

        // GET: Sanh
        public ActionResult Index()
        {
            var sanhs = db.Sanhs.Include(s => s.LoaiSanh);
            return View(sanhs.ToList());
        }

        // GET: Sanh/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanh sanh = db.Sanhs.Find(id);
            if (sanh == null)
            {
                return HttpNotFound();
            }
            return View(sanh);
        }

        // GET: Sanh/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiSanh = new SelectList(db.LoaiSanhs, "MaLoaiSanh", "TenLoaiSanh");
            return View();
        }


        // GET: Sanh/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanh sanh = db.Sanhs.Find(id);
            if (sanh == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiSanh = new SelectList(db.LoaiSanhs, "MaLoaiSanh", "TenLoaiSanh", sanh.MaLoaiSanh);
            return View(sanh);
        }



        // GET: Sanh/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sanh sanh = db.Sanhs.Find(id);
            if (sanh == null)
            {
                return HttpNotFound();
            }
            return View(sanh);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
