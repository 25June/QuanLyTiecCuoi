using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using QLTiecCuoi.Models;

namespace QLTiecCuoi.Controllers
{
    public class LoaiSanhController : Controller
    {
        private QLyTiecCuoiEntities db = new QLyTiecCuoiEntities();

        // GET: LoaiSanh
        public ActionResult Index()
        {
            
            return View(db.LoaiSanhs.ToList());
        }

        // GET: LoaiSanh/Details/5
        
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanh loaiSanh = db.LoaiSanhs.Find(id);
            if (loaiSanh == null)
            {
                return HttpNotFound();
            }
            
            return View(loaiSanh);
        }
        [HttpGet]
        public ActionResult DetailsTest(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanh loaiSanh = (LoaiSanh)db.LoaiSanhs.Find(id);
            if (loaiSanh == null)
            {
                return HttpNotFound();
            }
           // var kq = Newtonsoft.Json.JsonConvert.SerializeObject(new Test(1,"minh"));
            //var kq = Newtonsoft.Json.JsonConvert.SerializeObject(loaiSanh);
            //var kq = Json(loaiSanh, JsonRequestBehavior.AllowGet);
            return Json(loaiSanh, JsonRequestBehavior.AllowGet);
        }
        // GET: LoaiSanh/Create
        public ActionResult Create()
        {
            return View();
        }

      

        // GET: LoaiSanh/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanh loaiSanh = db.LoaiSanhs.Find(id);
            if (loaiSanh == null)
            {
                return HttpNotFound();
            }
            return View(loaiSanh);
        }

        

        // GET: LoaiSanh/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiSanh loaiSanh = db.LoaiSanhs.Find(id);
            if (loaiSanh == null)
            {
                return HttpNotFound();
            }
            return View(loaiSanh);
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
