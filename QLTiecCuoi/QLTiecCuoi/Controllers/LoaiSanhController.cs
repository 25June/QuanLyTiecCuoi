﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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
        
        public ActionResult Details(int? id)
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
       
        public ActionResult DetailsAjax(int? id)
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
            return Json(loaiSanh, JsonRequestBehavior.AllowGet);
        }
        // GET: LoaiSanh/Create
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(LoaiSanh loaiSanh)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    //insert
                    return RedirectToAction("index");
                }
                return View(loaiSanh);
            }
            catch
            {
                return View();
            }           
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
