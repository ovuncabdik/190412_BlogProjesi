using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class MakalelerController : Controller
    {
        // GET: AdminPaneli/Makaleler
        public ActionResult Index()
        {
            return View();
        }
    }
}