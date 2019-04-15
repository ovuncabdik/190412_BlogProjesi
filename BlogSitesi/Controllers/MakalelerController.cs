using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class MakalelerController : Controller
    {
        // GET: Makaleler
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();

        public ActionResult MakaleListesiIndex()
        {
            return View();
        }

        public ActionResult KategoriListesiIndex()
        {
            return View();
        }

        public ActionResult KategoriListesi()
        {
            return View(db.Kategoriler.ToList());
        }
    }
}