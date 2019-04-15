using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class EtiketlerController : Controller
    {
        Models.Bloghi304DBEntities db = new Models.Bloghi304DBEntities();
        // GET: AdminPaneli/Etiketler
        public ActionResult EtiketListesiIndex()
        {
            return View(db.Etiketler.ToList());
        }
    }
}