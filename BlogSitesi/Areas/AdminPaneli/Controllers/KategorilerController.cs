using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class KategorilerController : Controller
    {
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();
        // GET: AdminPaneli/Kategoriler

        public ActionResult KategoriListesiIndex()
        {
            return View(db.Kategoriler.ToList());
        }

        public ActionResult KategoriEkleIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkleIndex(string kategoriAdi,string aciklama)
        {
            return View();
        }
    }
}