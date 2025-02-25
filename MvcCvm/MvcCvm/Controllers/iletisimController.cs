using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCvm.Models.Entity;
using MvcCvm.Repositories;

namespace MvcCvm.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<Tbliletisim> repo=new GenericRepository<Tbliletisim>();
        public ActionResult Index()
        {
            var mesajlar=repo.List();
            return View(mesajlar);
        }
    }
}