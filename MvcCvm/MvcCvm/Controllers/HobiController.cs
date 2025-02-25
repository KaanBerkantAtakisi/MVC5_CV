﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvm.Models.Entity;
using MvcCvm.Repositories;

namespace MvcCvm.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TblHobilerim> repo= new GenericRepository<TblHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(TblHobilerim p)
        {
            //TblHobilerim t = new TblHobilerim();
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1=p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }

    }
}