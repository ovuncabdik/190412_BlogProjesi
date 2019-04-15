using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Areas.AdminPaneli.Controllers
{
    public class AdminPaneliAnaSayfaController : Controller
    {
        // GET: AdminPaneli/AdminPaneliAnaSayfa
        public ActionResult AnaSayfaIndex()
        {
            return View();
        }
    }
}